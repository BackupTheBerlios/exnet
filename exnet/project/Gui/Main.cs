/*
 * Created by SharpDevelop.
 * User: super
 * Date: 20.3.2006
 * Time: 02:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Client;
using Resources;
using Interfaces;

namespace Gui
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Main
	{

		
		public Main()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//this.panel1.BackColor = Color.FromArgb(159,169,179);			
		}
		
		void LToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			
		}
		
		public delegate void Logoff(bool test);
		public event Logoff logi;
		
		void LogoffToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			if(logi != null)
			{			
				logi(false);
				this.Close();
			}
						
		}		
		

	
		
		void MenuPanel3UserClicked(object sender, System.EventArgs e)
		{
			this.userControlContainer1.ShowDiscussion();
		}
				
		
		void MenuPanel1Click(object sender, System.EventArgs e)
		{
			this.userControlContainer1.ShowSearch();
		}
		
		void MenuPanel2Click(object sender, System.EventArgs e)
		{
			this.userControlContainer1.ShowProfile();
		}
				
		void MenuPanel4Click(object sender, System.EventArgs e)
		{
			this.userControlContainer1.ShowMessages();
		}
		
		void MenuPanel5Click(object sender, System.EventArgs e)
		{
			this.userControlContainer1.ShowAdministration();
		}
		
		void MainFormResize(object sender, System.EventArgs e)
		{
			if (FormWindowState.Minimized == WindowState)
     			Hide();
		}
		
		void NotifyIcon1DoubleClick(object sender, System.EventArgs e)
		{
			Show();
    		WindowState = FormWindowState.Normal;

		}
	}
}
