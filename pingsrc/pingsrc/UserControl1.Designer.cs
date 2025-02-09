/*
 * Created by SharpDevelop.
 * User: MoloM
 * Date: 6/3/2018
 * Time: 1:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
namespace pingsrc
{
	partial class UserControl1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		frmu frm=new frmu("لطفا آی پی آدرس مقصد را وارد کنید");
		frmu frm2=new frmu("لطفا نام دلخواه مقصد را وارد کنید");
		//System.Windows.Forms.Form frm=new System.Windows.Forms.Form();
		//System.Windows.Forms.Form frm2=new System.Windows.Forms.Form();
		class frmu:Form
		{
			Label lbl=new Label();
			TextBox txt=new TextBox();
			Button btn=new Button();
			public frmu(string message)
			{
				btn.Click+= new System.EventHandler(this.btnClick);
				this.Width=400;
				this.Height=240;
				this.FormBorderStyle=FormBorderStyle.None;
				lbl.Width=400;
				lbl.Height=100;
				lbl.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
				txt.Width=370;
				txt.Height=40;
				this.Controls.Add(lbl);
				lbl.Top=12;
				lbl.Text=message;
				this.Controls.Add(txt);
				txt.Top=128;
				txt.Left=14;
				btn.Width=133;
				btn.Height=37;
				btn.Text="ثبت";
				this.Controls.Add(btn);
				btn.Top=190;
				btn.Left=133;
			}
			void btnClick(object sender,EventArgs e ){this.Close();}
//			public string gimmeThatFuckinValue()
//			{
//				return txt.Text.ToString();
//			}
			public string gimmeValue()
			{
				this.ShowDialog();
				return txt.Text.ToString();
			}
//			public override string ShowDialoge(string nothing)
//			{
//				return txt.Text;
//				
//			} 
			
			
		}
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Silver;
			this.pictureBox1.Location = new System.Drawing.Point(7, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(21, 20);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "4.2.2.4";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(133, 37);
			this.Load += new System.EventHandler(this.UserControl1Load);
			this.Click += new System.EventHandler(this.UserControl1Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
