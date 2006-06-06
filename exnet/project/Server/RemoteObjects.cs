using System;
using System.IO;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

using Interfaces;

namespace Server
{	
	[Serializable]
	public class RemoteObjects :  MarshalByRefObject, IServer
	{
		#region unkown crap
		private DataBase _db = new DataBase();
		//private IUser _user;
		private event ChangedDelegate Changed; 
		private string _serverStoragePath = @"server\storage\";
			
		public IUser Login(IUser user)
		{			
		//	System.Threading.Thread.Sleep(2000);	
			
			try
			{
			DataTable dt = _db.Select("Select id,user From user WHERE user ='"+user.Name+"' AND pass='"+user.Pass+"'");
			
			//user seems to be on the database
			if(dt.Rows.Count == 1){
				user.Error = ErrorStatus.None;				
				user.ID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
				user.Name = dt.Rows[0].ItemArray[1].ToString();
				
				if(user.ID == 0)
					throw(new Exception("User ID Problem"));
	
				user.Session = CreateHash();
				_db.Insert("UPDATE user SET session = '"+user.Session+"' " +
				           "WHERE user ='"+user.Name+"' AND pass='"+user.Pass+"'");
				
	
			//more then on user? cannot be, give up
			}else if(dt.Rows.Count > 1){
				user.Error = ErrorStatus.UserNotUnique;
			//whatever was the input, not results!
			}else if(dt.Rows.Count == 0){
				user.Error = ErrorStatus.PassWrong;
			}
			}catch
			{
				user.Error = ErrorStatus.Undefined;
			}
			
			return user;
		}
			
		public string CreateHash()
		{
			Random r = new Random();
			byte[] rand = new byte[32];
		  	r.NextBytes(rand);		  	
		    byte[] result = MD5.Create().ComputeHash(rand);		

		    StringBuilder sb = new StringBuilder();
		    for (int i=0;i<result.Length;i++)
		    {
		        sb.Append(result[i].ToString("X2"));
		    }
		   return Convert.ToBase64String(result);
		}
			
		public void AddEvent(ChangedDelegate cd)
		{
			Changed += cd;
		}
		
		public void AddEvent(EventWrapper ew)
		{
			ParachuteEvent = new ParachuteDelegate(ew.ParachuteEventHandler);
		}
		
		ParachuteDelegate ParachuteEvent =null;
			
		public void Logout(string guid)
		{
			return;
		}
	
		private bool CheckUserIntegrity(IUser user)
		{
			return true;
		}
		#endregion
		
		#region files		
		
		public DBFile SaveFile(FileStream fs, string clientFileHash, IUser user)
		{			
		//if not allready done create neccessary dirs
		CreatePath();
		
		DBFile dbf = new DBFile();
				
		//skip the file if its larger than 5 mbyte
		if(fs.Length > 1024*1024*5){
			dbf.FileStatus = FileStatus.FileTooBig;
			return dbf;}
		
		//check wether the file exists or not
		if(File.Exists(_serverStoragePath+clientFileHash)){
			dbf.FileStatus = FileStatus.FileAllreadyExists;
			return dbf;}
		
		//try to upload the file and write it locally		
		try{
			FileStream lfs = File.Open(_serverStoragePath+clientFileHash, FileMode.CreateNew);
			BinaryReader br = new BinaryReader(fs);
			BinaryWriter bw = new BinaryWriter(lfs);
					
			while(br.BaseStream.Length != br.BaseStream.Position){
				bw.Write(br.ReadBytes(1024*1024*5));}			
			
			bw.Close();	
			br.Close();
			lfs.Close();
			fs.Close();
		}catch(Exception e){
			Debug.WriteLine("Server: "+e.Message);
			dbf.FileStatus = FileStatus.FileUploadFailed;
			return dbf;			
		}		
		
		//check crc		
		MD5Class md5 = new MD5Class(_serverStoragePath+clientFileHash);	
		string hash = md5.GetHash();
		if(!clientFileHash.Equals(hash))
		{
			try{
			File.Delete(_serverStoragePath+clientFileHash);
			}catch{}
			dbf.FileStatus = FileStatus.FileCRCFailed;
			return dbf;
		}
		
		//if everthing went just fine write it in the db
		try{
			FileInfo fi = new FileInfo(fs.Name);	
			FileInfo local = new FileInfo(_serverStoragePath+hash);
			
			_db.Insert("INSERT INTO files (md5,filename,user,size) " +
				       "VALUES ('"+hash+"','"+fi.Name+"','"+user.ID+"','"+local.Length+"')");	
			
			dbf.FileStatus = FileStatus.FileUploaded;
			dbf.FileName = fi.Name;
			dbf.User = user.ID;
			
			DataTable dt = _db.Select("SELECT id FROM files " +
			                          "WHERE md5 = '"+hash+"'");
			
			if(dt != null && dt.Rows.Count == 1 && dt.Rows[0].ItemArray.Length == 1)
				dbf.ID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
			else
				throw new Exception("File inserted, but hash not found?");
			
			return dbf;
		}catch(Exception e){
			Debug.WriteLine("Server: "+e.Message);
			dbf.FileStatus = FileStatus.DatabaseProblem;
			return dbf;}				
		}
				
		public DBFile DeleteFile(IUser user, DBFile dbfile)
		{						
			
			Debug.WriteLine("Server: Try to delete. "+dbfile.ID);
			try{
				DataTable dt = _db.Select("SELECT md5 FROM files " +
				                          "WHERE id = '"+dbfile.ID+"'");	
				
				if(dt.Rows.Count <= 0){
					dbfile.FileStatus = FileStatus.FileNotInDatabase;
					return dbfile;
				}else if(dt.Rows.Count > 1){
					dbfile.FileStatus = FileStatus.FileIDNotUnique;
					return dbfile;
				}else if(dt.Rows.Count == 1){
					
					string hash = dt.Rows[0].ItemArray[0].ToString();
					if(File.Exists(_serverStoragePath+hash))
						File.Delete(_serverStoragePath+hash);	
					else
						Debug.WriteLine("Server: Try to delete. Not in Filesystem");
										
					string temp = "DELETE FROM files " +
				           		  "WHERE id = '"+dbfile.ID+"'";
				
					_db.Insert(temp);					
					dbfile.FileStatus = FileStatus.FileSuccessfullyDeleted;
					return dbfile;
				}				
				
			}catch(Exception e){
				Debug.WriteLine("Server: "+e.Message);}
			
			dbfile.FileStatus = FileStatus.Undefined;
			return dbfile;
		}
		
		private void CreatePath()
		{
			try{
				if(!Directory.Exists(_serverStoragePath))
					Directory.CreateDirectory(_serverStoragePath);
			}catch{
				Debug.WriteLine("Server: Create directory failed: "+_serverStoragePath);
			}
		}
		
		public List<DBFile> GetFileInfos(IUser user)
		{
			List<DBFile> list = new List<DBFile>();
			
			try{
				DataTable dt = _db.Select("SELECT id,filename,user " +
				                          "FROM files");
				foreach(DataRow r in dt.Rows)
				{
					DBFile file = new DBFile();
					file.ID = int.Parse(r.ItemArray[0].ToString());
					file.FileName = r.ItemArray[1].ToString();					
					file.User = int.Parse(r.ItemArray[2].ToString());	
					list.Add(file);
				}
			}catch(Exception e){
				Debug.WriteLine("Server: "+e.Message);
			}

			return list;						
		}
		
		public DBFile GetFile(IUser user, DBFile dbfile)
		{			
			try{				
			DataTable dt = _db.Select("SELECT md5 FROM files " +
			                          "WHERE id = '"+dbfile.ID+"'");
			
			if(dt.Rows.Count <= 0){
				dbfile.FileStatus = FileStatus.FileNotInDatabase;
			}else if(dt.Rows.Count > 1){
				dbfile.FileStatus = FileStatus.FileIDNotUnique;
			}else{
			
				string hash = dt.Rows[0].ItemArray[0].ToString();
				if(!File.Exists(_serverStoragePath+hash)){
					dbfile.FileStatus = FileStatus.FileNotInFilesystem;
				}else{
				
				FileStream fs = File.Open(_serverStoragePath+hash, FileMode.Open,FileAccess.Read,FileShare.Read);
				dbfile.FileStream = fs;
				}				
			}
			}catch(Exception e){
				Debug.WriteLine("Server: "+e.Message);}
			return dbfile;
		}
		
		#endregion
		
		#region messages
		
		public List<Message> GetMessages(IUser user)
		{
			List<Message> list = new List<Message>();
			
			try{				
				DataTable dt = _db.Select("SELECT content,title,id " +
				                          "FROM messages " +
				                          "WHERE receiver = '"+user.ID+"'");
				
				foreach(DataRow r in dt.Rows)
				{
					Message m = new Message();
					m.Content = r.ItemArray[0].ToString();
					m.Title = r.ItemArray[1].ToString();
					m.ID = int.Parse(r.ItemArray[2].ToString());
					list.Add(m);
				}
				
			}catch{}
			return list;
		}
		
		public void WriteMessage (Message m, IUser user)
		{
			if(!CheckUserIntegrity(user))
				return;
						
			try{		
				foreach(int receiver in m.Receiver)
				{
				_db.Insert("INSERT INTO messages (receiver,content,title) " +
				           "VALUES ('"+receiver+"','"+m.Content+"','"+m.Title+"')");
				}
				
				ParachuteEvent();
			}catch{
				
			}
		}
		
		public void DeleteMessages(List<Message> list, IUser user)
		{
			if(!CheckUserIntegrity(user))
				return;
			
			foreach(Message m in list)
			{				
				string temp = "DELETE FROM messages " +
				           "WHERE id = '"+m.ID+"' " +
				           "AND receiver = '"+user.ID+"'";
				
				_db.Insert(temp);
			}
		}
	
		#endregion
			
		#region search
		
		
		//not a really good search engine
		public List<SearchItem> Search(string searchString, IUser user)
		{
			#region new filesearch
			try{	
							
			DataTable dt = _db.Select("SELECT filename,md5 " +
			                          "FROM files");
			
			FileSearcher fs = new FileSearcher();
				
			foreach(DataRow dr in dt.Rows)
			{
				DBFile dbfile = new DBFile();
				dbfile.FileName = dr.ItemArray[0].ToString();
				dbfile.MD5 = dr.ItemArray[1].ToString();
				fs.Search(dbfile, searchString);				
			}
			
			}catch(Exception e)
			{
				Debug.WriteLine("Server: New Search. "+e.Message);
			}
			#endregion
						
			#region thestandard be replaced soon
			if(!CheckUserIntegrity(user))
				return null;
			
			if(searchString.Length < 3 || searchString.Length > 50)
				return null;
			
			// search algo gone easy: one hit gets 100%			
			
			List<SearchItem> si = new List<SearchItem>();
			
			try{	
							
			DataTable dt = _db.Select("SELECT user " +
			                          "FROM interests " +
			                          "WHERE content = '"+searchString+"'");
				
			foreach(DataRow dr in dt.Rows)
			{ 
				SearchItem s = new SearchItem();
				s.PercentageHit = 100;
				s.User = int.Parse(dr.ItemArray[0].ToString());
				s.UserLastSeen = DateTime.Now.Ticks;
				si.Add(s);
			}
			
			}catch(Exception e)
			{
				Console.Write(e);
			}
			
			return si;
			#endregion
			
		}
		
		#endregion
		
		#region interests
		public List<Interest> GetInterests (IUser user)
		{
			List<Interest> list = new List<Interest>();
			
			try{				
				DataTable dt = _db.Select("SELECT id,user,content,updated,inserted " +
				                          "FROM interests " +
				                          "WHERE user = '"+user.ID+"'");
				
				foreach(DataRow r in dt.Rows)
				{
					Interest i = new Interest();
					i.ID = int.Parse(r.ItemArray[0].ToString());
					i.User = int.Parse(r.ItemArray[1].ToString());
					i.Content = r.ItemArray[2].ToString();
					i.Updated = long.Parse(r.ItemArray[3].ToString());
					i.Inserted = long.Parse(r.ItemArray[4].ToString());										
					list.Add(i);
				}				
			}catch{}
			
			return list;
		}
		
		public void DeleteInterests (List <Interest> interests, IUser user)
		{
			if(!CheckUserIntegrity(user))
				return;
			
			foreach(Interest i in interests)
			{
				
				string temp = "DELETE FROM interests " +
				           "WHERE content = '"+i.Content+"' " +
				           "AND user = '"+user.ID+"'";
				
				_db.Insert(temp);
			}		
		}
						
		public void WriteInterest (Interest i, IUser user)
		{
			if(!CheckUserIntegrity(user))
				return;
			
			
			try{
							
				
					
					DataTable dt = _db.Select("SELECT id " +
					                          "FROM interests " +
					                          "WHERE user = '"+user.ID+"' " +
					                          "AND content = '"+i.Content+"'");
					if(dt.Rows.Count == 0)
					{
					_db.Insert("INSERT INTO interests (user,content,updated,inserted) " +
					           "VALUES ('"+user.ID+"','"+i.Content+"','"+i.Updated+"','"+i.Inserted+"')");
					}else{							
					_db.Insert("UPDATE interests SET updated = '"+i.Updated+"' " + 
						       "WHERE user ='"+user.ID+"' AND content='"+i.Content+"'");
					}
					
				
			}catch{}
		}		
		#endregion
		
		
		
	}
}