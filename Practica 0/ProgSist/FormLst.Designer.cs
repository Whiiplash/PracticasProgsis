/*
 * Created by SharpDevelop.
 * User: RafaelRCA
 * Date: 16/10/2013
 * Time: 06:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgSist
{
	partial class FormLst
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.txtlst = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btguardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtlst
			// 
			this.txtlst.AcceptsReturn = true;
			this.txtlst.Location = new System.Drawing.Point(12, 69);
			this.txtlst.Multiline = true;
			this.txtlst.Name = "txtlst";
			this.txtlst.Size = new System.Drawing.Size(400, 346);
			this.txtlst.TabIndex = 9;
			this.txtlst.TextChanged += new System.EventHandler(this.TxtlstTextChanged);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.button2.Location = new System.Drawing.Point(300, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 32);
			this.button2.TabIndex = 8;
			this.button2.Text = "  ";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.button1.Location = new System.Drawing.Point(157, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "  ";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btguardar
			// 
			this.btguardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btguardar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btguardar.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btguardar.Location = new System.Drawing.Point(12, 12);
			this.btguardar.Name = "btguardar";
			this.btguardar.Size = new System.Drawing.Size(112, 32);
			this.btguardar.TabIndex = 6;
			this.btguardar.Text = "Guardar";
			this.btguardar.UseVisualStyleBackColor = false;
			// 
			// FormLst
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 427);
			this.Controls.Add(this.txtlst);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btguardar);
			this.Name = "FormLst";
			this.Text = "Archivo LST";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btguardar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtlst;
	}
}
