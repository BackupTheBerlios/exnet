using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
	/// <summary>
	/// Description of MenuPanel.
	/// </summary>
	public partial class MenuPanel
	{
		public MenuPanel()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}

			
		
		public string UserText
		{
			get
			{
				return this.label1.Text;
			}
			
			set
			{
				this.label1.Text = value;
			}
		}
		
		public Image UserImage
		{
			get
			{
				return this.pictureBox1.Image;
			}
			
			set
			{
				this.pictureBox1.Image = value;
			}
		}
		
	
	}
}
