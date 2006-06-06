/*
 * Created by SharpDevelop.
 * User: super
 * Date: 20.3.2006
 * Time: 01:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gui
{
	partial class Login : System.Windows.Forms.Form
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.profilImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.neuerBenutzerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.passwortVergessenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proxyEinstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.deutschToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.englischToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.türkischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.webseiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.testing1 = new Gui.Testing();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.animatedIcon1 = new Gui.AnimatedIcon();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.testToolStripMenuItem,
									this.testToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.testToolStripMenuItem.Text = "Bearbeiten";
			// 
			// testToolStripMenuItem1
			// 
			this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
			this.testToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
			this.testToolStripMenuItem1.Text = "Hinzufügen";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Benutzer";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kennwort";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(90, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(170, 21);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "peter";
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(90, 71);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(170, 21);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "peter";
			this.textBox2.UseSystemPasswordChar = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.dateiToolStripMenuItem,
									this.bearbeitenToolStripMenuItem,
									this.languageToolStripMenuItem1,
									this.hilfeToolStripMenuItem,
									this.testing1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.menuStrip1.Size = new System.Drawing.Size(272, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// dateiToolStripMenuItem
			// 
			this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.profilImportierenToolStripMenuItem,
									this.toolStripSeparator1,
									this.neuerBenutzerToolStripMenuItem1,
									this.passwortVergessenToolStripMenuItem1,
									this.toolStripSeparator2,
									this.beendenToolStripMenuItem});
			this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
			this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.dateiToolStripMenuItem.Text = "Datei";
			// 
			// profilImportierenToolStripMenuItem
			// 
			this.profilImportierenToolStripMenuItem.Name = "profilImportierenToolStripMenuItem";
			this.profilImportierenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.profilImportierenToolStripMenuItem.Text = "Profil Importieren";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
			// 
			// neuerBenutzerToolStripMenuItem1
			// 
			this.neuerBenutzerToolStripMenuItem1.Name = "neuerBenutzerToolStripMenuItem1";
			this.neuerBenutzerToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
			this.neuerBenutzerToolStripMenuItem1.Text = "Neuer Benutzer";
			// 
			// passwortVergessenToolStripMenuItem1
			// 
			this.passwortVergessenToolStripMenuItem1.Name = "passwortVergessenToolStripMenuItem1";
			this.passwortVergessenToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
			this.passwortVergessenToolStripMenuItem1.Text = "Passwort vergessen?";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.beendenToolStripMenuItem.Text = "Beenden";
			// 
			// bearbeitenToolStripMenuItem
			// 
			this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.proxyEinstellenToolStripMenuItem});
			this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
			this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
			// 
			// proxyEinstellenToolStripMenuItem
			// 
			this.proxyEinstellenToolStripMenuItem.Name = "proxyEinstellenToolStripMenuItem";
			this.proxyEinstellenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.proxyEinstellenToolStripMenuItem.Text = "Optionen";
			this.proxyEinstellenToolStripMenuItem.Click += new System.EventHandler(this.ProxyEinstellenToolStripMenuItemClick);
			// 
			// languageToolStripMenuItem1
			// 
			this.languageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.deutschToolStripMenuItem1,
									this.englischToolStripMenuItem1,
									this.türkischToolStripMenuItem});
			this.languageToolStripMenuItem1.Name = "languageToolStripMenuItem1";
			this.languageToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
			this.languageToolStripMenuItem1.Text = "Language";
			// 
			// deutschToolStripMenuItem1
			// 
			this.deutschToolStripMenuItem1.Name = "deutschToolStripMenuItem1";
			this.deutschToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.deutschToolStripMenuItem1.Text = "Deutsch";
			// 
			// englischToolStripMenuItem1
			// 
			this.englischToolStripMenuItem1.Name = "englischToolStripMenuItem1";
			this.englischToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.englischToolStripMenuItem1.Text = "Englisch";
			// 
			// türkischToolStripMenuItem
			// 
			this.türkischToolStripMenuItem.Name = "türkischToolStripMenuItem";
			this.türkischToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.türkischToolStripMenuItem.Text = "Türkisch";
			// 
			// hilfeToolStripMenuItem
			// 
			this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.webseiteToolStripMenuItem,
									this.überToolStripMenuItem});
			this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
			this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.hilfeToolStripMenuItem.Text = "Hilfe";
			// 
			// webseiteToolStripMenuItem
			// 
			this.webseiteToolStripMenuItem.Name = "webseiteToolStripMenuItem";
			this.webseiteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.webseiteToolStripMenuItem.Text = "Webseite";
			// 
			// überToolStripMenuItem
			// 
			this.überToolStripMenuItem.Name = "überToolStripMenuItem";
			this.überToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.überToolStripMenuItem.Text = "Über";
			// 
			// testing1
			// 
			this.testing1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.testing1.Name = "testing1";
			this.testing1.Size = new System.Drawing.Size(20, 20);
			this.testing1.Text = "0";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 169);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(272, 22);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
			this.toolStripStatusLabel1.Text = "Bitte Anmelden";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(170, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Anmelden";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox1.Location = new System.Drawing.Point(91, 99);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(169, 23);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "Automatischer Login";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// animatedIcon1
			// 
			this.animatedIcon1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animatedIcon1.BackColor = System.Drawing.Color.Transparent;
			this.animatedIcon1.Location = new System.Drawing.Point(231, 6);
			this.animatedIcon1.Name = "animatedIcon1";
			this.animatedIcon1.Size = new System.Drawing.Size(18, 30);
			this.animatedIcon1.TabIndex = 15;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 191);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Login";
			this.Text = "Expert Finding";
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Gui.Testing testing1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private Gui.AnimatedIcon animatedIcon1;
		private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem webseiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem türkischToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem proxyEinstellenToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem profilImportierenToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem passwortVergessenToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem neuerBenutzerToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		
		void MenuStrip1ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
		{
			
		}
		
		void ToolStripMenuItem1Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
