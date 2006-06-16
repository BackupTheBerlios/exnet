using System;
using System.Windows.Forms;

using Gui;
using Server;

namespace Start
{
	public class Start
	{
		[STAThread]
		public static void Main(string[] args)
		{		
			#region Server - separated in later version
			Server.Server _s = new Server.Server();
			_s.Start();		
			#endregion		
			
			#region Client - separated in later version			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			Application.Run(new Gui.Login());
			#endregion
		}	
	}
}
