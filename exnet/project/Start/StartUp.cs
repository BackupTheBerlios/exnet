using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Gui;
using Server;

using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;

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
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Gui.Login());
			#endregion
		}	
	}
}
