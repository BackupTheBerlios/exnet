using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;
using System.IO;

using Interfaces;

namespace Client
{
	public delegate void UserLoginDelegate(IUser user);
	public delegate void UserSearchDelegate(List<SearchItem> hits);
	public delegate void UserMessagesDelegate(List<Message> messages);
	public delegate void UserInterestsDelegate(List<Interest> interests);
	public delegate void UserWriteMessageDelegate();
	public delegate void UserWriteInterestDelegate();
	public delegate void UserDeleteInterestsDelegate();
	public delegate void UserDeleteMessagesDelegate();
	//public delegate void UserSaveFileDelegate(FileStatus fs, string FileName, object lvsi);
	public delegate void UpdatesDelegate();	
	
	public class Client
	{
		public event UpdatesDelegate UpdatesAvailable;
		private string _clientStoragePath = @"client\storage\";
		TcpChannel _chan = new TcpChannel();
		IServer _ro;		
		
		public Client()
		{
			this.Start();		
		}
				
		public void Start()
		{			
			try{
				
			BinaryClientFormatterSinkProvider clientProvider = new BinaryClientFormatterSinkProvider();
			BinaryServerFormatterSinkProvider serverProvider = new BinaryServerFormatterSinkProvider();
			serverProvider.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
			
			IDictionary props = new Hashtable();
			props["port"] = 0;
			string s = System.Guid.NewGuid().ToString();
			Debug.WriteLine(s);
			props["name"] = s;
			props["typeFilterLevel"] = TypeFilterLevel.Full;
			_chan = new TcpChannel(
				props,clientProvider,serverProvider);

			ChannelServices.RegisterChannel(_chan,true);
								
			}catch{}
			this.Connect();
		}
				
		public void Connect()
		{
			_ro = (IServer)
			Activator.GetObject(typeof(IServer),
			"tcp://127.0.0.1:9999/FirstRemote");
			
			EventWrapper ew = new EventWrapper();
			ew.ParachuteEvent += Temping;
			
			_ro.AddEvent(ew);
		}
		
		public void Temping()
		{
			if(UpdatesAvailable != null)
				UpdatesAvailable();
		}
		
		public void Super(IAsyncResult ar)
		{
			LongRuningProcess d = (LongRuningProcess)((AsyncResult)ar).AsyncDelegate;
			
			if(UserLogin != null)
			{
				UserLogin(d.EndInvoke(ar));
			}
		}
		
		public void SuperSearch(IAsyncResult ar)
		{
			LongRuningSearch d = (LongRuningSearch)((AsyncResult)ar).AsyncDelegate;
			
			if(UserSearch != null)
			{
				UserSearch(d.EndInvoke(ar));
			}
		}
		
		public void SuperMessages(IAsyncResult ar)
		{
			LongRuningGetMessages d = (LongRuningGetMessages)((AsyncResult)ar).AsyncDelegate;
			
			if(UserMessages != null)
			{
				UserMessages(d.EndInvoke(ar));
			}
		}
		
		public void SuperInterests(IAsyncResult ar)
		{
			LongRuningGetInterests d = (LongRuningGetInterests)((AsyncResult)ar).AsyncDelegate;
			
			if(UserInterests != null)
			{
				UserInterests(d.EndInvoke(ar));
			}
		}
		
		public void SuperWriteMessage(IAsyncResult ar)
		{
			LongRuningWriteMessage d = (LongRuningWriteMessage)((AsyncResult)ar).AsyncDelegate;
			
			if(UserWriteMessage != null)
			{
				UserWriteMessage();
			}
		}
		
		public void SuperWriteInterest(IAsyncResult ar)
		{
			LongRuningWriteInterest d = (LongRuningWriteInterest)((AsyncResult)ar).AsyncDelegate;
			
			if(UserWriteInterest != null)
			{
				UserWriteInterest();
				
			}
		}
	
		public void SuperDeleteInterests(IAsyncResult ar)
		{
			LongRuningDeleteInterests d = (LongRuningDeleteInterests)((AsyncResult)ar).AsyncDelegate;
			
			if(UserDeleteInterests != null)
			{
				//UserDeleteInterests();
			}
		}
		
		public void SuperDeleteMessages(IAsyncResult ar)
		{
			LongRuningDeleteMessages d = (LongRuningDeleteMessages)((AsyncResult)ar).AsyncDelegate;
			
			if(UserDeleteMessages != null)
			{
				//UserDeleteMessages();
			}
		}
		
		/*
		 Calling backs
		 */
		
		public delegate IUser LongRuningProcess(IUser user);
		public delegate List<SearchItem> LongRuningSearch(string searchString, IUser user);
		public delegate List<Message> LongRuningGetMessages(IUser user);
		public delegate List<Interest> LongRuningGetInterests(IUser user);
		public delegate void LongRuningWriteMessage(Message m, IUser user);
		public delegate void LongRuningWriteInterest(Interest i, IUser user);
		public delegate void LongRuningDeleteInterests(List <Interest> interests, IUser user);
		public delegate void LongRuningDeleteMessages(List <Message> messages, IUser user);		
		
		public event UserLoginDelegate UserLogin;
		public event UserSearchDelegate UserSearch;
		public event UserMessagesDelegate UserMessages;
		public event UserWriteMessageDelegate UserWriteMessage;
		public event UserInterestsDelegate UserInterests;
		public event UserWriteInterestDelegate UserWriteInterest;
		public event UserDeleteInterestsDelegate UserDeleteInterests;
		public event UserDeleteMessagesDelegate UserDeleteMessages;
		
#region getfile
		//server sided interface/delegate
		private delegate DBFile GettingFile(IUser user, DBFile dbfile);
		
		//filled from gui
		public delegate void GotFileDelegate(DBFile dbfile);
		public event GotFileDelegate GotFile;
		
		//gui starts getting the filestream -> async 
		public void GetFile(IUser user, DBFile dbfile)
		{
			AsyncCallback call = new AsyncCallback( ServerGotFile );			
			GettingFile process = _ro.GetFile;
			IAsyncResult ar = process.BeginInvoke(user, dbfile, call, null);			
		}
		
		//asynccallback after finishing the long running progress
		private void ServerGotFile(IAsyncResult ar)
		{
			GettingFile d = (GettingFile)((AsyncResult)ar).AsyncDelegate;			
			
			if(GotFile != null)
				GotFile(d.EndInvoke(ar));
		}
#endregion
		
#region filedelete
		//server sided interface/delegate
		private delegate DBFile DeletingFile(IUser user, DBFile dbfile);
		
		//filled from gui
		public delegate void DeletedFileDelegate(DBFile dbfile);
		public event DeletedFileDelegate FileDeleted;
		
		//gui starts saving the file -> async 
		public void DeleteFile(IUser user, DBFile dbfile)
		{
			AsyncCallback call = new AsyncCallback( ServerFileDeleted );			
			DeletingFile process = _ro.DeleteFile;
			IAsyncResult ar = process.BeginInvoke(user, dbfile, call, null);			
		}
		
		//asynccallback after finishing the long running progress
		private void ServerFileDeleted(IAsyncResult ar)
		{
			DeletingFile d = (DeletingFile)((AsyncResult)ar).AsyncDelegate;			
			
			if(FileDeleted != null)
				FileDeleted(d.EndInvoke(ar));
		}
#endregion
		
#region filesave
		//server sided interface/delegate
		private delegate DBFile SavingFile(FileStream fs, string clientFileHash, IUser user);
		
		//filled from gui
		public delegate void SavedFileDelegate(DBFile fs);
		public event SavedFileDelegate FileSaved;
		
		//gui starts saving the file -> async 
		public void SaveFile(FileStream fs, string clientFileHash, IUser user)
		{
			AsyncCallback call = new AsyncCallback( ServerFileSaved );			
			SavingFile process = _ro.SaveFile;
			IAsyncResult ar = process.BeginInvoke(fs, clientFileHash, user, call, null);			
		}
		
		//asynccallback after finishing the long running progress
		private void ServerFileSaved(IAsyncResult ar)
		{
			SavingFile d = (SavingFile)((AsyncResult)ar).AsyncDelegate;			
			
			if(FileSaved != null)
				FileSaved(d.EndInvoke(ar));
		}
#endregion
		
#region getfileinfos
		//server sided interface/delegate
		private delegate List<DBFile> GettingDBFiles(IUser user);
		
		//filled from gui
		public delegate void GotDBFilesDelegate(List<DBFile> dbfiles);
		public event GotDBFilesDelegate GotDBFiles;
		
		//gui starts saving the file -> async 
		public void GetDBFiles(IUser user)
		{
			AsyncCallback call = new AsyncCallback( ServerGotDBFiles );			
			GettingDBFiles process = _ro.GetFileInfos;
			IAsyncResult ar = process.BeginInvoke(user, call, null);			
		}
		
		//asynccallback after finishing the long running progress
		private void ServerGotDBFiles(IAsyncResult ar)
		{
			GettingDBFiles d = (GettingDBFiles)((AsyncResult)ar).AsyncDelegate;			
			
			if(GotDBFiles != null)
				GotDBFiles(d.EndInvoke(ar));
		}
#endregion

		public void StartProcess(DBFile dbfile)
		{
			try{
				Process p = new Process();
				p.StartInfo.FileName = _clientStoragePath+dbfile.ID+"_"+dbfile.FileName;
				p.Start();
			}catch(Exception e){
				Debug.WriteLine("Client: Problem starting process." + e.Message);}
		}
				
		public void WriteMessage(Message m, User user)
		{
			AsyncCallback call = new AsyncCallback( SuperWriteMessage );
			LongRuningWriteMessage longProcess = new LongRuningWriteMessage(_ro.WriteMessage);
			IAsyncResult ar = longProcess.BeginInvoke(m, user, call, null);
		}
		
		public void WriteInterest(Interest i, User user)
		{
			AsyncCallback call = new AsyncCallback( SuperWriteInterest );
			LongRuningWriteInterest longProcess = new LongRuningWriteInterest(_ro.WriteInterest);
			IAsyncResult ar = longProcess.BeginInvoke(i, user, call, null);
		}
		
		public void Login(User user)
		{
			AsyncCallback call = new AsyncCallback( Super );
			LongRuningProcess longProcess = new LongRuningProcess(_ro.Login);
			IAsyncResult ar = longProcess.BeginInvoke(user, call, null);			
		}
		
		public void GetMessages(User user)
		{
			AsyncCallback call = new AsyncCallback( SuperMessages );
			LongRuningGetMessages longProcess = new LongRuningGetMessages(_ro.GetMessages);
			IAsyncResult ar = longProcess.BeginInvoke(user, call, null);			
		}
		
		public void GetInterests(User user)
		{
			AsyncCallback call = new AsyncCallback( SuperInterests );
			LongRuningGetInterests longProcess = new LongRuningGetInterests(_ro.GetInterests);
			IAsyncResult ar = longProcess.BeginInvoke(user, call, null);			
		}
		
		public void DeleteInterest(List <Interest> interests, User user)
		{
			AsyncCallback call = new AsyncCallback( SuperDeleteInterests );
			LongRuningDeleteInterests longProcess = new LongRuningDeleteInterests(_ro.DeleteInterests);
			IAsyncResult ar = longProcess.BeginInvoke(interests, user, call, null);	
		}
		
		public void DeleteMessages(List <Message> messages, User user)
		{
			AsyncCallback call = new AsyncCallback( SuperDeleteMessages );
			LongRuningDeleteMessages longProcess = new LongRuningDeleteMessages(_ro.DeleteMessages);
			IAsyncResult ar = longProcess.BeginInvoke(messages, user, call, null);			
		}
		
		public void GetSearch(string searchString, IUser user)
		{
			AsyncCallback call = new AsyncCallback( SuperSearch );
			LongRuningSearch longProcess = new LongRuningSearch(_ro.Search);
			IAsyncResult ar = longProcess.BeginInvoke(searchString, user, call, null);			
		}
		
		
		
	}
	
	[Serializable]	
	public class User : IUser
	{
		string _user;		
		string _pass;		
		string _session;
		int _id;
		ErrorStatus _Err;
		
		public string Name{ 
			get{ return _user;}
			set{ _user = value;}
		}	
		
		public int ID{ 
			get{ return _id;}
			set{ _id = value;}
		}
		
		public string Pass{
			get{ return _pass;}
			set{ _pass = value;}
		}
		
		public string Session { 
			get{ return _session;}
			set{ _session = value;}
		}
		
		public ErrorStatus Error { 
			get{ return _Err;}
			set{ _Err = value; }
		}		
		
		public IEnumerable <ErrorStatus> GetErrors()
		{
			int i = (int)_Err;
			while(i>0)
			{				
				int temp = (int)Math.Pow(2,(int)Math.Log(i,2));
				yield return (ErrorStatus)temp;
				i -= temp;
			}
		}
		
		public bool HasError(ErrorStatus error)
		{
			foreach(ErrorStatus es in GetErrors())
			{
				if(es == error)
				{
					return true;
				}
			}
			return false;
		}		
	}	
}
