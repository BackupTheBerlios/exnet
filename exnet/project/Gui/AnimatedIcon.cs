/*
 * Created by SharpDevelop.
 * User: super
 * Date: 18.4.2006
 * Time: 15:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace Gui
{
	/// <summary>
	/// Description of AnimatedIcon.
	/// </summary>
	public partial class AnimatedIcon
	{
		public AnimatedIcon()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			points[0] = new Point(7,0);
			points[1] = new Point(11,2);
			points[2] = new Point(13,6);
			points[3] = new Point(11,10);
			points[4] = new Point(7,12);
			points[5] = new Point(3,10);
			points[6] = new Point(1,6);						
			points[7] = new Point(3,2);
	
	
		}
		
		void AnimatedIconPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;		
			DrawPoints(g);
		}
		
		Point[] points =  new Point[8];
		Brush b = new SolidBrush(Color.FromArgb(178,178,178));
		
		Brush b1 = new SolidBrush(Color.FromArgb(101,143,203));
		Brush b2 = new SolidBrush(Color.FromArgb(136,167,212));		
		Brush b3 = new SolidBrush(Color.FromArgb(171,191,220));
		
		int color1 = 0;
		int color2 = 7;
		int color3 = 6;		
				
		void DrawPoints(Graphics g)
		{			
			for(int i = 0;i<points.Length;i++)
			{
				Point p = points[i];			
				DrawPoint(g,b,p);			
			}
			
			if(this.timer1.Enabled)
			{
			DrawPoint(g,b1,points[color1]);
			DrawPoint(g,b2,points[color2]);
			DrawPoint(g,b3,points[color3]);			
			}
		}
		
		void DrawPoint(Graphics g, Brush b, Point p)
		{
			Rectangle r = new Rectangle(p.X+1,p.Y,2,4);
			g.FillRectangle(b,r);
			r = new Rectangle(p.X,p.Y+1,4,2);
			g.FillRectangle(b,r);
		}
		
		void Timer1Tick(object sender, System.EventArgs e)
		{
			if(color1 < points.Length-1 ){
				color1++;
			}else{
				color1 = 0;}
			
			if(color2 < points.Length-1 ){
				color2++;
			}else{
				color2 = 0;}
			
			if(color3 < points.Length-1 ){
				color3++;
			}else{
				color3 = 0;}
			
			Invalidate();
		}
		
		public void Start()
		{
			this.timer1.Enabled = true;
		}
		
		public void Stop()
		{
			this.timer1.Enabled = false;
			this.Invalidate();
		}		
	}
}
