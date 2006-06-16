using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Client;
using Resources;
using Interfaces;

namespace Gui
{
	public partial class Login
	{
		
		#region variables
		private delegate void BackCall (User user);
		private BackCall bc = null;
		private ClientSettings _cs = ClientSettings.Fetch();		
		private Client.Client _c = new Client.Client();
		private Resources.Function _r = new Resources.Function();
		private Gui.NewForm mf;	
		private bool CloseVar = true;
		#endregion
		
		public Login()
		{
			InitializeComponent();
			bc += Check;
			_c.UserLogin += ServerCall;			
			
			#region setSettings
			this.textBox1.Text = _cs.LoginSettings.Name;
			this.textBox2.Text = _cs.LoginSettings.Pass;
			this.checkBox1.Checked = _cs.LoginSettings.AutoLogin;
			#endregion
						
			if(_cs.LoginSettings.AutoLogin)
				Button1Click(null,null);
		}

		public void ServerCall(User user)
		{
			//_user = user;
			
			if(this.InvokeRequired)
			{
				Invoke(bc,new object [] {user});
			}
		}
		
		private void Check(User user)
		{
			this.testing1.Stop();
			this.button1.Enabled = true;
			if(user.Error == ErrorStatus.None)
			{			
				this.toolStripStatusLabel1.Text = ErrorStatus.None.ToString();
								
				this.Hide();
				mf = new NewForm(_c,user,_cs);
				mf.Show();
				
				this.mf.Closed += delegate(object senderd, EventArgs ed) { 
					if(this.CloseVar == true)
					{				
						this.Close();						
					}else{
						this.Show();
						this.CloseVar = true;
					}
				};
				
				this.mf.logi += ChangeClose;
						
			}else if(user.Error == ErrorStatus.PassWrong){
				foreach(ErrorStatus es in user.GetErrors())
				{
				this.toolStripStatusLabel1.Text = es.ToString();
				}	
			}	
		}
		
		private void Button1Click(object sender, System.EventArgs e)
		{			
			User user = new User();			
			user.Name = this.textBox1.Text;
			user.Pass = this.textBox2.Text;
			_c.Login(user);		
			//this.testing1.Start();
			this.button1.Enabled = false;
			
			#region saveLogin
			_cs.LoginSettings.Name = user.Name;
			_cs.LoginSettings.Pass = user.Pass;
			_cs.LoginSettings.AutoLogin = this.checkBox1.Checked;
			_cs.Save();
			#endregion			
		}
				
		private void ChangeClose(bool cl){
			this.CloseVar = cl;
		}
				
		private void ProxyEinstellenToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			Options op = new Options(this._cs);
			op.ShowDialog();
		}
	}
}
