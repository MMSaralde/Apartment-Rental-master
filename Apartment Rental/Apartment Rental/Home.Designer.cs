/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 21/02/2020
 * Time: 12:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Apartment_Rental
{
	partial class Home
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(171, 144);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(240, 88);
			this.button1.TabIndex = 1;
			this.button1.Text = "SIGN IN";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(171, 255);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(240, 88);
			this.button2.TabIndex = 2;
			this.button2.Text = "NEW TENANT";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(171, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "A. VELARDE RENTALS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(207)))), ((int)(((byte)(188)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(584, 397);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HOME";
			this.ResumeLayout(false);

		}
	}
}
