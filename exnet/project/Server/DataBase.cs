using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Finisar.SQLite;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace Server
{
	[Serializable]
	public class DataBase
	{
		private static SQLiteConnection _conn;
		private StreamWriter sw = new StreamWriter("log.txt");
		
		public DataBase()
		{
			//new DataBaseCheck();
			this.Init();
			sw.Write("init");
			sw.Flush();
			
		}
		
		private void Init()
		{
			this.ConnectDatabase();
			this.CreateDatabase();				
		}
		
		private void ConnectDatabase()
		{			
			try
			{
				DataBase._conn = new SQLiteConnection();
				DataBase._conn.ConnectionString = "Data Source=expert.db;Version=3;New=False;Compress=True";
				DataBase._conn.Open();
			}catch(Exception e)
			{
				sw.Write(e.Message);
				sw.Flush();
			}
		}
		
		public DataTable Delete()
		{
			return null;
		}
		
		public DataTable Update(string queryString)
		{
			return null;
		}
		
		public DataTable Select(string queryString)
		{			
			sw.Write("test"+queryString);
			try
			{
				lock(DataBase._conn)
				{
				SQLiteCommand Cmd = new SQLiteCommand();						
				SQLiteDataAdapter da = new SQLiteDataAdapter(queryString, DataBase._conn);				
				DataTable dt = new DataTable();            	
				if(da != null)
				{
					da.Fill(dt);
					return dt; 
				}else{
					return null;
				}
				}
            	
			}catch(Exception e){
				Debug.WriteLine("DataBase Select Problem: "+ e.Message);
				return null;
			}
		}				
			
		public DataTable Insert(string queryString)
		{
			try
			{
				lock(DataBase._conn)
				{
				SQLiteCommand Cmd = new SQLiteCommand();
				Cmd = DataBase._conn.CreateCommand(); 			
				Cmd.CommandText = queryString;
				Cmd.CommandType=CommandType.Text ;
				Cmd.ExecuteNonQuery();
				
				}
				return null;
			}catch(Exception e){
				Debug.WriteLine("DataBase Insert Problem: "+ e.Message);
				return null;
			}
		}
		
		private void CreateDatabase()
		{							
			try
			{
				//this._db.Execute("create table player(playerName,coordinates,planetName)");
			}
			catch
			{
				
			}
		}
		
	}
}
