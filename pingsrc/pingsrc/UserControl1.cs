/*
 * Created by SharpDevelop.
 * User: MoloM
 * Date: 6/3/2018
 * Time: 1:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace pingsrc
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class UserControl1 : UserControl
	{//every n seconds
	 //default ip="4.2.2.4"
		string ipaddress="4.2.2.4";
		public int interval=1000;
		//Timer time=new Timer();
		System.Timers.Timer tm=new System.Timers.Timer();
		public UserControl1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//time.Interval=5000;
			//time.Tick+=new EventHandler(timerTick);
			tm.Elapsed+=new System.Timers.ElapsedEventHandler(tmElapse);
			tm.Interval=5000;
			tm.Enabled=true;
			//time.Start();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void timerTick(object sender,EventArgs e)
		{}
		void tmElapse(object sender,EventArgs e)
		{
			ping();
		}
		void Label1Click(object sender, EventArgs e)
		{
			ipaddress = frm.gimmeValue();
			label1.Text=frm2.gimmeValue();
			//MessageBox.Show(this.Name,"nope");
			System.IO.File.WriteAllText(this.Name,ipaddress+"\n"+label1.Text);
			//frm.ShowDialog();
			
			
			//frm2.ShowDialog();
			
		}
		void UserControl1Click(object sender, EventArgs e)
		{}
//		void btnClick(object sender,EventArgs e)
//		{
//			
//			MessageBox.Show("");
//		}
//		void btn2Click(object sender,EventArgs e)
//		{
//			MessageBox.Show("");
//		}
		void ping()//object sender,EventArgs e
		{
			if(ipaddress.Length>=7){
			System.Net.NetworkInformation.Ping p1 = new System.Net.NetworkInformation.Ping();
			//System.Net.NetworkInformation.PingReply PR = p1.Send(ipaddress);
			// check when the ping is not success
			int x=0;
			if (p1.Send(ipaddress,interval).Status.ToString().Equals("Success"))
			{
				x++;
			}
			if (p1.Send(ipaddress,interval).Status.ToString().Equals("Success"))
			{
				x++;
			}
			if (p1.Send(ipaddress,interval).Status.ToString().Equals("Success"))
			{
				x++;
			}
			if (p1.Send(ipaddress,interval).Status.ToString().Equals("Success"))
			{
				x++;
			}
			switch(x)
			{
				case 4:
					pictureBox1.BackColor=Color.Green;
					break;
				case 3:
					pictureBox1.BackColor=Color.Yellow;
					break;
				case 2:
					pictureBox1.BackColor=Color.Orange;
					break;
				default:
					pictureBox1.BackColor=Color.Red;
					break;
			}
			
			}
		}
		void UserControl1Load(object sender, EventArgs e)
		{
			if(System.IO.File.Exists(this.Name)){
			   ipaddress=System.IO.File.ReadAllLines(this.Name)[0];
			   label1.Text=System.IO.File.ReadAllLines(this.Name)[1];}
		}
	}
}