/*
 * Created by SharpDevelop.
 * User: super
 * Date: 20.3.2006
 * Time: 02:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gui
{
	partial class Main : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuPanel5 = new Gui.MenuPanel();
			this.menuPanel4 = new Gui.MenuPanel();
			this.menuPanel3 = new Gui.MenuPanel();
			this.menuPanel2 = new Gui.MenuPanel();
			this.menuPanel1 = new Gui.MenuPanel();
			this.userControlContainer1 = new Gui.UserControlContainer();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.wiederherstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.dateiToolStripMenuItem,
									this.lToolStripMenuItem,
									this.extrasToolStripMenuItem,
									this.hilfeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(810, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dateiToolStripMenuItem
			// 
			this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.logoffToolStripMenuItem});
			this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
			this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.dateiToolStripMenuItem.Text = "Datei";
			// 
			// logoffToolStripMenuItem
			// 
			this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
			this.logoffToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.logoffToolStripMenuItem.Text = "Logoff";
			this.logoffToolStripMenuItem.Click += new System.EventHandler(this.LogoffToolStripMenuItemClick);
			// 
			// lToolStripMenuItem
			// 
			this.lToolStripMenuItem.Name = "lToolStripMenuItem";
			this.lToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.lToolStripMenuItem.Text = "Bearbeiten";
			this.lToolStripMenuItem.Click += new System.EventHandler(this.LToolStripMenuItemClick);
			// 
			// extrasToolStripMenuItem
			// 
			this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
			this.extrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.extrasToolStripMenuItem.Text = "Extras";
			// 
			// hilfeToolStripMenuItem
			// 
			this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
			this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.hilfeToolStripMenuItem.Text = "Hilfe";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 573);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(810, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.menuPanel5);
			this.panel1.Controls.Add(this.menuPanel4);
			this.panel1.Controls.Add(this.menuPanel3);
			this.panel1.Controls.Add(this.menuPanel2);
			this.panel1.Controls.Add(this.menuPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(810, 65);
			this.panel1.TabIndex = 3;
			// 
			// menuPanel5
			// 
			this.menuPanel5.BackColor = System.Drawing.Color.Transparent;
			this.menuPanel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuPanel5.Location = new System.Drawing.Point(715, 0);
			this.menuPanel5.Name = "menuPanel5";
			this.menuPanel5.Size = new System.Drawing.Size(95, 65);
			this.menuPanel5.TabIndex = 11;
			this.menuPanel5.UserImage = ((System.Drawing.Image)(resources.GetObject("menuPanel5.UserImage")));
			this.menuPanel5.UserText = "Administration";
			this.menuPanel5.UserClicked += new System.EventHandler(this.MenuPanel5Click);
			// 
			// menuPanel4
			// 
			this.menuPanel4.BackColor = System.Drawing.Color.Transparent;
			this.menuPanel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuPanel4.Location = new System.Drawing.Point(285, 0);
			this.menuPanel4.Name = "menuPanel4";
			this.menuPanel4.Size = new System.Drawing.Size(95, 65);
			this.menuPanel4.TabIndex = 10;
			this.menuPanel4.UserImage = ((System.Drawing.Image)(resources.GetObject("menuPanel4.UserImage")));
			this.menuPanel4.UserText = "Nachrichten";
			this.menuPanel4.UserClicked += new System.EventHandler(this.MenuPanel4Click);
			// 
			// menuPanel3
			// 
			this.menuPanel3.BackColor = System.Drawing.Color.Transparent;
			this.menuPanel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuPanel3.Location = new System.Drawing.Point(190, 0);
			this.menuPanel3.Name = "menuPanel3";
			this.menuPanel3.Size = new System.Drawing.Size(95, 65);
			this.menuPanel3.TabIndex = 9;
			this.menuPanel3.UserImage = ((System.Drawing.Image)(resources.GetObject("menuPanel3.UserImage")));
			this.menuPanel3.UserText = "Diskussion";
			this.menuPanel3.UserClicked += new System.EventHandler(this.MenuPanel3UserClicked);
			// 
			// menuPanel2
			// 
			this.menuPanel2.BackColor = System.Drawing.Color.Transparent;
			this.menuPanel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuPanel2.Location = new System.Drawing.Point(95, 0);
			this.menuPanel2.Name = "menuPanel2";
			this.menuPanel2.Size = new System.Drawing.Size(95, 65);
			this.menuPanel2.TabIndex = 8;
			this.menuPanel2.UserImage = ((System.Drawing.Image)(resources.GetObject("menuPanel2.UserImage")));
			this.menuPanel2.UserText = "Profil";
			this.menuPanel2.UserClicked += new System.EventHandler(this.MenuPanel2Click);
			// 
			// menuPanel1
			// 
			this.menuPanel1.BackColor = System.Drawing.Color.Transparent;
			this.menuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuPanel1.Location = new System.Drawing.Point(0, 0);
			this.menuPanel1.Name = "menuPanel1";
			this.menuPanel1.Size = new System.Drawing.Size(95, 65);
			this.menuPanel1.TabIndex = 7;
			this.menuPanel1.UserImage = ((System.Drawing.Image)(resources.GetObject("menuPanel1.UserImage")));
			this.menuPanel1.UserText = "Suchen";
			this.menuPanel1.UserClicked += new System.EventHandler(this.MenuPanel1Click);
			// 
			// userControlContainer1
			// 
			this.userControlContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlContainer1.Location = new System.Drawing.Point(0, 89);
			this.userControlContainer1.Name = "userControlContainer1";
			this.userControlContainer1.Size = new System.Drawing.Size(810, 484);
			this.userControlContainer1.TabIndex = 4;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.wiederherstellenToolStripMenuItem,
									this.beendenToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(167, 48);
			// 
			// wiederherstellenToolStripMenuItem
			// 
			this.wiederherstellenToolStripMenuItem.Name = "wiederherstellenToolStripMenuItem";
			this.wiederherstellenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.wiederherstellenToolStripMenuItem.Text = "Wiederherstellen";
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.beendenToolStripMenuItem.Text = "Beenden";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 595);
			this.Controls.Add(this.userControlContainer1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Expert Finding - Suchen";
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wiederherstellenToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private Gui.UserControlContainer userControlContainer1;
		private Gui.MenuPanel menuPanel2;
		private Gui.MenuPanel menuPanel3;
		private Gui.MenuPanel menuPanel4;
		private Gui.MenuPanel menuPanel5;
		private Gui.MenuPanel menuPanel1;
		private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
