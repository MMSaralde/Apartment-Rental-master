/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 21/02/2020
 * Time: 1:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Apartment_Rental
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
			this.label2.Location = new System.Drawing.Point(12, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contact No. :";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(118, 69);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(272, 20);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(118, 103);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(272, 20);
			this.textBox2.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(159, 187);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(247, 29);
			this.button1.TabIndex = 7;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(243, 222);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 28);
			this.button2.TabIndex = 8;
			this.button2.Text = "Return";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
			this.label3.Location = new System.Drawing.Point(12, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 9;
			this.label3.Text = "Room:";
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(118, 142);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(272, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(255, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "DATE:";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Location = new System.Drawing.Point(312, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
			this.dateTimePicker1.TabIndex = 12;
			this.dateTimePicker1.Value = new System.DateTime(2020, 2, 26, 19, 45, 31, 0);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(207)))), ((int)(((byte)(188)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(548, 304);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NEW TENANT";
			this.Load += new System.EventHandler(this.Form1Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
