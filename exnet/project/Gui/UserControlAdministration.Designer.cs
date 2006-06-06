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
	partial class UserControlAdministration : System.Windows.Forms.UserControl
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
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.textBox47 = new System.Windows.Forms.TextBox();
			this.textBox48 = new System.Windows.Forms.TextBox();
			this.label88 = new System.Windows.Forms.Label();
			this.label90 = new System.Windows.Forms.Label();
			this.label93 = new System.Windows.Forms.Label();
			this.tabPage12 = new System.Windows.Forms.TabPage();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.textBox44 = new System.Windows.Forms.TextBox();
			this.textBox35 = new System.Windows.Forms.TextBox();
			this.textBox43 = new System.Windows.Forms.TextBox();
			this.textBox36 = new System.Windows.Forms.TextBox();
			this.textBox42 = new System.Windows.Forms.TextBox();
			this.textBox41 = new System.Windows.Forms.TextBox();
			this.textBox39 = new System.Windows.Forms.TextBox();
			this.textBox40 = new System.Windows.Forms.TextBox();
			this.textBox38 = new System.Windows.Forms.TextBox();
			this.label87 = new System.Windows.Forms.Label();
			this.textBox37 = new System.Windows.Forms.TextBox();
			this.label86 = new System.Windows.Forms.Label();
			this.label76 = new System.Windows.Forms.Label();
			this.label85 = new System.Windows.Forms.Label();
			this.label77 = new System.Windows.Forms.Label();
			this.label84 = new System.Windows.Forms.Label();
			this.label82 = new System.Windows.Forms.Label();
			this.label83 = new System.Windows.Forms.Label();
			this.label79 = new System.Windows.Forms.Label();
			this.label78 = new System.Windows.Forms.Label();
			this.label80 = new System.Windows.Forms.Label();
			this.label81 = new System.Windows.Forms.Label();
			this.tabPage13 = new System.Windows.Forms.TabPage();
			this.textBox49 = new System.Windows.Forms.TextBox();
			this.label91 = new System.Windows.Forms.Label();
			this.textBox46 = new System.Windows.Forms.TextBox();
			this.label89 = new System.Windows.Forms.Label();
			this.textBox45 = new System.Windows.Forms.TextBox();
			this.label92 = new System.Windows.Forms.Label();
			this.tabPage14 = new System.Windows.Forms.TabPage();
			this.tabControl3.SuspendLayout();
			this.tabPage11.SuspendLayout();
			this.tabPage12.SuspendLayout();
			this.tabPage13.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl3
			// 
			this.tabControl3.Controls.Add(this.tabPage11);
			this.tabControl3.Controls.Add(this.tabPage12);
			this.tabControl3.Controls.Add(this.tabPage13);
			this.tabControl3.Controls.Add(this.tabPage14);
			this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl3.Location = new System.Drawing.Point(0, 0);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(582, 546);
			this.tabControl3.TabIndex = 1;
			// 
			// tabPage11
			// 
			this.tabPage11.Controls.Add(this.textBox47);
			this.tabPage11.Controls.Add(this.textBox48);
			this.tabPage11.Controls.Add(this.label88);
			this.tabPage11.Controls.Add(this.label90);
			this.tabPage11.Controls.Add(this.label93);
			this.tabPage11.Location = new System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage11.Size = new System.Drawing.Size(574, 520);
			this.tabPage11.TabIndex = 0;
			this.tabPage11.Text = "System";
			this.tabPage11.UseVisualStyleBackColor = true;
			// 
			// textBox47
			// 
			this.textBox47.Location = new System.Drawing.Point(95, 40);
			this.textBox47.Name = "textBox47";
			this.textBox47.Size = new System.Drawing.Size(100, 21);
			this.textBox47.TabIndex = 106;
			// 
			// textBox48
			// 
			this.textBox48.Location = new System.Drawing.Point(95, 64);
			this.textBox48.Name = "textBox48";
			this.textBox48.Size = new System.Drawing.Size(100, 21);
			this.textBox48.TabIndex = 107;
			// 
			// label88
			// 
			this.label88.Location = new System.Drawing.Point(20, 43);
			this.label88.Name = "label88";
			this.label88.Size = new System.Drawing.Size(100, 25);
			this.label88.TabIndex = 98;
			this.label88.Text = "Port";
			// 
			// label90
			// 
			this.label90.Location = new System.Drawing.Point(20, 66);
			this.label90.Name = "label90";
			this.label90.Size = new System.Drawing.Size(100, 25);
			this.label90.TabIndex = 100;
			this.label90.Text = "Ip";
			// 
			// label93
			// 
			this.label93.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label93.Location = new System.Drawing.Point(20, 18);
			this.label93.Name = "label93";
			this.label93.Size = new System.Drawing.Size(175, 25);
			this.label93.TabIndex = 102;
			this.label93.Text = "Server - Einstellungen";
			// 
			// tabPage12
			// 
			this.tabPage12.Controls.Add(this.comboBox3);
			this.tabPage12.Controls.Add(this.comboBox4);
			this.tabPage12.Controls.Add(this.textBox44);
			this.tabPage12.Controls.Add(this.textBox35);
			this.tabPage12.Controls.Add(this.textBox43);
			this.tabPage12.Controls.Add(this.textBox36);
			this.tabPage12.Controls.Add(this.textBox42);
			this.tabPage12.Controls.Add(this.textBox41);
			this.tabPage12.Controls.Add(this.textBox39);
			this.tabPage12.Controls.Add(this.textBox40);
			this.tabPage12.Controls.Add(this.textBox38);
			this.tabPage12.Controls.Add(this.label87);
			this.tabPage12.Controls.Add(this.textBox37);
			this.tabPage12.Controls.Add(this.label86);
			this.tabPage12.Controls.Add(this.label76);
			this.tabPage12.Controls.Add(this.label85);
			this.tabPage12.Controls.Add(this.label77);
			this.tabPage12.Controls.Add(this.label84);
			this.tabPage12.Controls.Add(this.label82);
			this.tabPage12.Controls.Add(this.label83);
			this.tabPage12.Controls.Add(this.label79);
			this.tabPage12.Controls.Add(this.label78);
			this.tabPage12.Controls.Add(this.label80);
			this.tabPage12.Controls.Add(this.label81);
			this.tabPage12.Location = new System.Drawing.Point(4, 22);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage12.Size = new System.Drawing.Size(794, 426);
			this.tabPage12.TabIndex = 1;
			this.tabPage12.Text = "Gruppen";
			this.tabPage12.UseVisualStyleBackColor = true;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(462, 23);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(101, 21);
			this.comboBox3.TabIndex = 97;
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(108, 20);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(101, 21);
			this.comboBox4.TabIndex = 97;
			// 
			// textBox44
			// 
			this.textBox44.Location = new System.Drawing.Point(462, 151);
			this.textBox44.Name = "textBox44";
			this.textBox44.Size = new System.Drawing.Size(100, 21);
			this.textBox44.TabIndex = 95;
			// 
			// textBox35
			// 
			this.textBox35.Location = new System.Drawing.Point(108, 148);
			this.textBox35.Name = "textBox35";
			this.textBox35.Size = new System.Drawing.Size(100, 21);
			this.textBox35.TabIndex = 95;
			// 
			// textBox43
			// 
			this.textBox43.Location = new System.Drawing.Point(462, 125);
			this.textBox43.Name = "textBox43";
			this.textBox43.Size = new System.Drawing.Size(100, 21);
			this.textBox43.TabIndex = 94;
			// 
			// textBox36
			// 
			this.textBox36.Location = new System.Drawing.Point(108, 122);
			this.textBox36.Name = "textBox36";
			this.textBox36.Size = new System.Drawing.Size(100, 21);
			this.textBox36.TabIndex = 94;
			// 
			// textBox42
			// 
			this.textBox42.Location = new System.Drawing.Point(462, 48);
			this.textBox42.Name = "textBox42";
			this.textBox42.Size = new System.Drawing.Size(100, 21);
			this.textBox42.TabIndex = 96;
			// 
			// textBox41
			// 
			this.textBox41.Location = new System.Drawing.Point(462, 72);
			this.textBox41.Name = "textBox41";
			this.textBox41.Size = new System.Drawing.Size(100, 21);
			this.textBox41.TabIndex = 96;
			// 
			// textBox39
			// 
			this.textBox39.Location = new System.Drawing.Point(108, 45);
			this.textBox39.Name = "textBox39";
			this.textBox39.Size = new System.Drawing.Size(100, 21);
			this.textBox39.TabIndex = 96;
			// 
			// textBox40
			// 
			this.textBox40.Location = new System.Drawing.Point(462, 97);
			this.textBox40.Name = "textBox40";
			this.textBox40.Size = new System.Drawing.Size(100, 21);
			this.textBox40.TabIndex = 96;
			// 
			// textBox38
			// 
			this.textBox38.Location = new System.Drawing.Point(108, 69);
			this.textBox38.Name = "textBox38";
			this.textBox38.Size = new System.Drawing.Size(100, 21);
			this.textBox38.TabIndex = 96;
			// 
			// label87
			// 
			this.label87.Location = new System.Drawing.Point(387, 51);
			this.label87.Name = "label87";
			this.label87.Size = new System.Drawing.Size(100, 25);
			this.label87.TabIndex = 89;
			this.label87.Text = "Firmenname";
			// 
			// textBox37
			// 
			this.textBox37.Location = new System.Drawing.Point(108, 94);
			this.textBox37.Name = "textBox37";
			this.textBox37.Size = new System.Drawing.Size(100, 21);
			this.textBox37.TabIndex = 96;
			// 
			// label86
			// 
			this.label86.Location = new System.Drawing.Point(387, 150);
			this.label86.Name = "label86";
			this.label86.Size = new System.Drawing.Size(100, 25);
			this.label86.TabIndex = 91;
			this.label86.Text = "Straße";
			// 
			// label76
			// 
			this.label76.Location = new System.Drawing.Point(33, 48);
			this.label76.Name = "label76";
			this.label76.Size = new System.Drawing.Size(100, 25);
			this.label76.TabIndex = 89;
			this.label76.Text = "Firmenname";
			// 
			// label85
			// 
			this.label85.Location = new System.Drawing.Point(387, 74);
			this.label85.Name = "label85";
			this.label85.Size = new System.Drawing.Size(100, 25);
			this.label85.TabIndex = 90;
			this.label85.Text = "Land";
			// 
			// label77
			// 
			this.label77.Location = new System.Drawing.Point(33, 147);
			this.label77.Name = "label77";
			this.label77.Size = new System.Drawing.Size(100, 25);
			this.label77.TabIndex = 91;
			this.label77.Text = "Straße";
			// 
			// label84
			// 
			this.label84.Location = new System.Drawing.Point(387, 99);
			this.label84.Name = "label84";
			this.label84.Size = new System.Drawing.Size(100, 25);
			this.label84.TabIndex = 90;
			this.label84.Text = "Plz";
			// 
			// label82
			// 
			this.label82.Location = new System.Drawing.Point(33, 71);
			this.label82.Name = "label82";
			this.label82.Size = new System.Drawing.Size(100, 25);
			this.label82.TabIndex = 90;
			this.label82.Text = "Land";
			// 
			// label83
			// 
			this.label83.Location = new System.Drawing.Point(387, 125);
			this.label83.Name = "label83";
			this.label83.Size = new System.Drawing.Size(100, 25);
			this.label83.TabIndex = 93;
			this.label83.Text = "Ort";
			// 
			// label79
			// 
			this.label79.Location = new System.Drawing.Point(33, 96);
			this.label79.Name = "label79";
			this.label79.Size = new System.Drawing.Size(100, 25);
			this.label79.TabIndex = 90;
			this.label79.Text = "Plz";
			// 
			// label78
			// 
			this.label78.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label78.Location = new System.Drawing.Point(387, 26);
			this.label78.Name = "label78";
			this.label78.Size = new System.Drawing.Size(116, 25);
			this.label78.TabIndex = 92;
			this.label78.Text = "Abteilung";
			// 
			// label80
			// 
			this.label80.Location = new System.Drawing.Point(33, 122);
			this.label80.Name = "label80";
			this.label80.Size = new System.Drawing.Size(100, 25);
			this.label80.TabIndex = 93;
			this.label80.Text = "Ort";
			// 
			// label81
			// 
			this.label81.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label81.Location = new System.Drawing.Point(33, 23);
			this.label81.Name = "label81";
			this.label81.Size = new System.Drawing.Size(116, 25);
			this.label81.TabIndex = 92;
			this.label81.Text = "Firma";
			// 
			// tabPage13
			// 
			this.tabPage13.Controls.Add(this.textBox49);
			this.tabPage13.Controls.Add(this.label91);
			this.tabPage13.Controls.Add(this.textBox46);
			this.tabPage13.Controls.Add(this.label89);
			this.tabPage13.Controls.Add(this.textBox45);
			this.tabPage13.Controls.Add(this.label92);
			this.tabPage13.Location = new System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage13.Size = new System.Drawing.Size(794, 426);
			this.tabPage13.TabIndex = 2;
			this.tabPage13.Text = "Log";
			this.tabPage13.UseVisualStyleBackColor = true;
			// 
			// textBox49
			// 
			this.textBox49.Location = new System.Drawing.Point(227, 36);
			this.textBox49.Multiline = true;
			this.textBox49.Name = "textBox49";
			this.textBox49.Size = new System.Drawing.Size(194, 312);
			this.textBox49.TabIndex = 115;
			// 
			// label91
			// 
			this.label91.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label91.Location = new System.Drawing.Point(227, 19);
			this.label91.Name = "label91";
			this.label91.Size = new System.Drawing.Size(175, 25);
			this.label91.TabIndex = 114;
			this.label91.Text = "Debug";
			// 
			// textBox46
			// 
			this.textBox46.Location = new System.Drawing.Point(464, 36);
			this.textBox46.Multiline = true;
			this.textBox46.Name = "textBox46";
			this.textBox46.Size = new System.Drawing.Size(194, 312);
			this.textBox46.TabIndex = 113;
			// 
			// label89
			// 
			this.label89.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label89.Location = new System.Drawing.Point(464, 19);
			this.label89.Name = "label89";
			this.label89.Size = new System.Drawing.Size(175, 25);
			this.label89.TabIndex = 112;
			this.label89.Text = "Sicherheit";
			// 
			// textBox45
			// 
			this.textBox45.Location = new System.Drawing.Point(19, 36);
			this.textBox45.Multiline = true;
			this.textBox45.Name = "textBox45";
			this.textBox45.Size = new System.Drawing.Size(175, 312);
			this.textBox45.TabIndex = 111;
			// 
			// label92
			// 
			this.label92.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label92.Location = new System.Drawing.Point(19, 19);
			this.label92.Name = "label92";
			this.label92.Size = new System.Drawing.Size(175, 25);
			this.label92.TabIndex = 110;
			this.label92.Text = "Benutzer";
			// 
			// tabPage14
			// 
			this.tabPage14.Location = new System.Drawing.Point(4, 22);
			this.tabPage14.Name = "tabPage14";
			this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage14.Size = new System.Drawing.Size(794, 426);
			this.tabPage14.TabIndex = 3;
			this.tabPage14.Text = "Benutzer";
			this.tabPage14.UseVisualStyleBackColor = true;
			// 
			// UserControlAdministration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl3);
			this.Name = "UserControlAdministration";
			this.Size = new System.Drawing.Size(582, 546);
			this.tabControl3.ResumeLayout(false);
			this.tabPage11.ResumeLayout(false);
			this.tabPage11.PerformLayout();
			this.tabPage12.ResumeLayout(false);
			this.tabPage12.PerformLayout();
			this.tabPage13.ResumeLayout(false);
			this.tabPage13.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TabPage tabPage14;
		private System.Windows.Forms.Label label92;
		private System.Windows.Forms.TextBox textBox45;
		private System.Windows.Forms.Label label89;
		private System.Windows.Forms.TextBox textBox46;
		private System.Windows.Forms.Label label91;
		private System.Windows.Forms.TextBox textBox49;
		private System.Windows.Forms.TabPage tabPage13;
		private System.Windows.Forms.Label label81;
		private System.Windows.Forms.Label label80;
		private System.Windows.Forms.Label label78;
		private System.Windows.Forms.Label label79;
		private System.Windows.Forms.Label label83;
		private System.Windows.Forms.Label label82;
		private System.Windows.Forms.Label label84;
		private System.Windows.Forms.Label label77;
		private System.Windows.Forms.Label label85;
		private System.Windows.Forms.Label label76;
		private System.Windows.Forms.Label label86;
		private System.Windows.Forms.TextBox textBox37;
		private System.Windows.Forms.Label label87;
		private System.Windows.Forms.TextBox textBox38;
		private System.Windows.Forms.TextBox textBox40;
		private System.Windows.Forms.TextBox textBox39;
		private System.Windows.Forms.TextBox textBox41;
		private System.Windows.Forms.TextBox textBox42;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.TextBox textBox43;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.TextBox textBox44;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.TabPage tabPage12;
		private System.Windows.Forms.Label label93;
		private System.Windows.Forms.Label label90;
		private System.Windows.Forms.Label label88;
		private System.Windows.Forms.TextBox textBox48;
		private System.Windows.Forms.TextBox textBox47;
		private System.Windows.Forms.TabPage tabPage11;
		private System.Windows.Forms.TabControl tabControl3;
	}
}
