using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Interfaces
{
	public delegate void ChangedDelegate();
	
	public interface IServer
	{
		/*
		Special Events
		not sure what they do .. forgot :)
		*/		
		void AddEvent(EventWrapper ew);
		//event ChangedDelegate Changed;
		
		#region user
		IUser UserLogin (IUser user);
		#endregion
		
		#region search
		List<SearchItem> Search(string searchString, IUser user);
		#endregion
		
		#region messages		
		List<Message> GetMessages (IUser user);	
		void WriteMessage (Message m,IUser user);	
		void DeleteMessages (List <Message> messages, IUser user);			
		#endregion
		
		#region interests
		List<Interest> GetInterests (IUser user);	
		void WriteInterest (Interest i, IUser user);	
		void DeleteInterests(List <Interest> i, IUser user);
		#endregion
		
		#region file
		DBFile SaveFile(IUser user, FileStream fs, string clientFileHash, DBDirectory dir);
		DBFile DeleteFile(IUser user, DBFile dbfile);
		DBFile GetFile(IUser user, DBFile dbfile);
		DBFile RenameFile(IUser user, DBFile file, string newName);
		List<DBFile> GetFiles(IUser user, DBDirectory dir);		
		#endregion
		
		#region items
		List<DBItem> GetItems(IUser user, DBDirectory dir);		
		DBItem RenameItem(IUser user, DBItem item, string newName);
		#endregion
		
		#region directory
		List<DBDirectory> GetDirectoryInfos(IUser user, DBDirectory dir);		
		DBDirectory DeleteDirectory(IUser user, DBDirectory dir);		
		DBDirectory CreateDirectory(IUser user, DBDirectory dir);				
		DBDirectory RenameDirectory(IUser user, DBDirectory dir, string newName);
		#endregion		
	}	
}
