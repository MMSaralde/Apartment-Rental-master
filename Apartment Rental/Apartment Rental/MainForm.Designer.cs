﻿/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 17/02/2020
 * Time: 12:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Apartment_Rental
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button A2;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button C2;
		private System.Windows.Forms.Button A3;
		private System.Windows.Forms.Button A1;
		private System.Windows.Forms.Button B1;
		private System.Windows.Forms.Button C1;
		private System.Windows.Forms.Button back;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.A2 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.C2 = new System.Windows.Forms.Button();
			this.A1 = new System.Windows.Forms.Button();
			this.B1 = new System.Windows.Forms.Button();
			this.C1 = new System.Windows.Forms.Button();
			this.A3 = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// A2
			// 
			this.A2.Location = new System.Drawing.Point(52, 133);
			this.A2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(122, 48);
			this.A2.TabIndex = 0;
			this.A2.Text = "2A";
			this.A2.UseVisualStyleBackColor = true;
			this.A2.Click += new System.EventHandler(this.A2Click);
			// 
			// B2
			// 
			this.B2.Location = new System.Drawing.Point(199, 133);
			this.B2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(122, 48);
			this.B2.TabIndex = 1;
			this.B2.Text = "2B";
			this.B2.UseVisualStyleBackColor = true;
			this.B2.Click += new System.EventHandler(this.B2Click);
			// 
			// C2
			// 
			this.C2.Location = new System.Drawing.Point(340, 133);
			this.C2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(122, 48);
			this.C2.TabIndex = 2;
			this.C2.Text = "2C";
			this.C2.UseVisualStyleBackColor = true;
			this.C2.Click += new System.EventHandler(this.C2Click);
			// 
			// A1
			// 
			this.A1.Location = new System.Drawing.Point(52, 204);
			this.A1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(122, 48);
			this.A1.TabIndex = 4;
			this.A1.Text = "1A";
			this.A1.UseVisualStyleBackColor = true;
			this.A1.Click += new System.EventHandler(this.A1Click);
			// 
			// B1
			// 
			this.B1.Location = new System.Drawing.Point(199, 204);
			this.B1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(122, 48);
			this.B1.TabIndex = 5;
			this.B1.Text = "1B";
			this.B1.UseVisualStyleBackColor = true;
			this.B1.Click += new System.EventHandler(this.B1Click);
			// 
			// C1
			// 
			this.C1.Location = new System.Drawing.Point(340, 204);
			this.C1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(122, 48);
			this.C1.TabIndex = 6;
			this.C1.Text = "1C";
			this.C1.UseVisualStyleBackColor = true;
			this.C1.Click += new System.EventHandler(this.C1Click);
			// 
			// A3
			// 
			this.A3.Location = new System.Drawing.Point(199, 62);
			this.A3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(122, 48);
			this.A3.TabIndex = 7;
			this.A3.Text = "3A";
			this.A3.UseVisualStyleBackColor = true;
			this.A3.Click += new System.EventHandler(this.A3Click);
			// 
			// back
			// 
			this.back.Location = new System.Drawing.Point(340, 334);
			this.back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(122, 48);
			this.back.TabIndex = 8;
			this.back.Text = "RETURN";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.BackClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(207)))), ((int)(((byte)(188)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(491, 396);
			this.Controls.Add(this.back);
			this.Controls.Add(this.A3);
			this.Controls.Add(this.C1);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.A1);
			this.Controls.Add(this.C2);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.A2);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "APARTMENT RENTAL";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
