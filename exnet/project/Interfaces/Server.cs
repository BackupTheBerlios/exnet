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
		IUser Login (IUser user);
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
		DBFile SaveFile(FileStream fs, string clientFileHash, IUser user);
		DBFile DeleteFile(IUser user, DBFile dbfile);
		DBFile GetFile(IUser user, DBFile dbfile);
		List<DBFile> GetFileInfos(IUser user);		
		#endregion
		
	}	
}
