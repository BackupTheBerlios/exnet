/*
 * Created by SharpDevelop.
 * User: super
 * Date: 20.3.2006
 * Time: 08:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.ComponentModel.Design;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Gui
{
	/// <summary>
	/// Description of UserControlContainer.
	/// </summary>
	/// 
		
	[Designer(typeof(UserControlContainer .MyControlDesigner))]
	public partial class UserControlContainer
	{
		public UserControlContainer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
				/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
	//	public System.ComponentModel.IContainer components = null;
				
		internal class MyControlDesigner : System.Windows.Forms.Design.ParentControlDesigner 
        {
			
            public override System.Windows.Forms.Design.SelectionRules SelectionRules
            {
                get
                {
                //	this.EnableDragDrop(true);
                    return System.Windows.Forms.Design.SelectionRules.AllSizeable |
                        System.Windows.Forms.Design.SelectionRules.Visible |
                        System.Windows.Forms.Design.SelectionRules.Moveable;
                }
            }
          
        }
				
		private UserControlDiscussion ucd = new UserControlDiscussion();
		private UserControlAdministration uca = new UserControlAdministration();
		private UserControlMessages ucm = new UserControlMessages();
		private UserControlProfile ucp = new UserControlProfile();
		private UserControlSearch ucs = new UserControlSearch();
		
		public void ShowDiscussion()
		{
			
			ucd.Dock = DockStyle.Fill;
			this.Controls.Clear();
			this.Controls.Add(ucd);
		}
		
		public void ShowAdministration()
		{
			uca.Dock = DockStyle.Fill;
			this.Controls.Clear();
			this.Controls.Add(uca);
		}
		
		public void ShowMessages()
		{
			ucm.Dock = DockStyle.Fill;
			this.Controls.Clear();
			this.Controls.Add(ucm);
		}
		
		public void ShowProfile()
		{
			ucp.Dock = DockStyle.Fill;
			this.Controls.Clear();
			this.Controls.Add(ucp);
		}
		
		public void ShowSearch()
		{
			ucs.Dock = DockStyle.Fill;
			this.Controls.Clear();
		//	this.Controls.Add(ucs);
		}
		
		void UserControlContainerPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			
			Rectangle r = new Rectangle(0,0,this.Width,this.Height);
			Color c2 = Color.FromArgb(90,95,99);
			Color c1 = Color.FromArgb(159,169,179);
			//Color c2 = Color.FromArgb(101,143,203);
			//Color c1 = Color.FromArgb(191,219,255);
			
			LinearGradientBrush b = 
				new LinearGradientBrush(r,c1,c2,LinearGradientMode.Vertical);
			
			g.FillRectangle(b,r);
		}
	}
	
}
