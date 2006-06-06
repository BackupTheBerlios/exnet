/*
 * Created by SharpDevelop.
 * User: ${USER}
 * Date: ${DATE}
 * Time: ${TIME}
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gui
{
	partial class UserControlMessages : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Eingang");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ausgang");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Versendet");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Papierkorb");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Beobachtet");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Langzeitsuche");
			this.linkLabel15 = new System.Windows.Forms.LinkLabel();
			this.linkLabel14 = new System.Windows.Forms.LinkLabel();
			this.label62 = new System.Windows.Forms.Label();
			this.label61 = new System.Windows.Forms.Label();
			this.textBox34 = new System.Windows.Forms.TextBox();
			this.treeView5 = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// linkLabel15
			// 
			this.linkLabel15.Location = new System.Drawing.Point(602, 11);
			this.linkLabel15.Name = "linkLabel15";
			this.linkLabel15.Size = new System.Drawing.Size(74, 18);
			this.linkLabel15.TabIndex = 8;
			this.linkLabel15.TabStop = true;
			this.linkLabel15.Text = "Senden";
			// 
			// linkLabel14
			// 
			this.linkLabel14.Location = new System.Drawing.Point(522, 11);
			this.linkLabel14.Name = "linkLabel14";
			this.linkLabel14.Size = new System.Drawing.Size(74, 18);
			this.linkLabel14.TabIndex = 9;
			this.linkLabel14.TabStop = true;
			this.linkLabel14.Text = "Empfangen";
			// 
			// label62
			// 
			this.label62.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label62.Location = new System.Drawing.Point(189, 34);
			this.label62.Name = "label62";
			this.label62.Size = new System.Drawing.Size(74, 20);
			this.label62.TabIndex = 7;
			this.label62.Text = "Eingang";
			// 
			// label61
			// 
			this.label61.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label61.Location = new System.Drawing.Point(14, 34);
			this.label61.Name = "label61";
			this.label61.Size = new System.Drawing.Size(74, 20);
			this.label61.TabIndex = 6;
			this.label61.Text = "Ordner";
			// 
			// textBox34
			// 
			this.textBox34.Location = new System.Drawing.Point(189, 57);
			this.textBox34.Multiline = true;
			this.textBox34.Name = "textBox34";
			this.textBox34.Size = new System.Drawing.Size(487, 320);
			this.textBox34.TabIndex = 5;
			// 
			// treeView5
			// 
			this.treeView5.Location = new System.Drawing.Point(14, 57);
			this.treeView5.Name = "treeView5";
			treeNode1.Name = "Knoten0";
			treeNode1.Text = "Eingang";
			treeNode2.Name = "Knoten1";
			treeNode2.Text = "Ausgang";
			treeNode3.Name = "Knoten6";
			treeNode3.Text = "Versendet";
			treeNode4.Name = "Knoten7";
			treeNode4.Text = "Papierkorb";
			treeNode5.Name = "Knoten2";
			treeNode5.Text = "Beobachtet";
			treeNode6.Name = "Knoten3";
			treeNode6.Text = "Langzeitsuche";
			this.treeView5.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
									treeNode1,
									treeNode2,
									treeNode3,
									treeNode4,
									treeNode5,
									treeNode6});
			this.treeView5.Size = new System.Drawing.Size(169, 320);
			this.treeView5.TabIndex = 4;
			// 
			// UserControlMessages
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.linkLabel15);
			this.Controls.Add(this.linkLabel14);
			this.Controls.Add(this.label62);
			this.Controls.Add(this.label61);
			this.Controls.Add(this.textBox34);
			this.Controls.Add(this.treeView5);
			this.Name = "UserControlMessages";
			this.Size = new System.Drawing.Size(708, 418);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TreeView treeView5;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.Label label61;
		private System.Windows.Forms.Label label62;
		private System.Windows.Forms.LinkLabel linkLabel14;
		private System.Windows.Forms.LinkLabel linkLabel15;
	}
}
