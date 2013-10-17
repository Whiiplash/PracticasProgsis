/*
 * Created by SharpDevelop.
 * User: RafaelRCA
 * Date: 10/10/2013
 * Time: 11:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgSist
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.btabrir = new System.Windows.Forms.Button();
			this.laruta = new System.Windows.Forms.Label();
			this.txtbox = new System.Windows.Forms.TextBox();
			this.boton = new System.Windows.Forms.Button();
			this.btlimpiar = new System.Windows.Forms.Button();
			this.openfile = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(13, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ruta:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btabrir
			// 
			this.btabrir.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btabrir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btabrir.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btabrir.Location = new System.Drawing.Point(12, 20);
			this.btabrir.Name = "btabrir";
			this.btabrir.Size = new System.Drawing.Size(112, 32);
			this.btabrir.TabIndex = 1;
			this.btabrir.Text = "Abrir";
			this.btabrir.UseVisualStyleBackColor = false;
			this.btabrir.Click += new System.EventHandler(this.BtabrirClick);
			// 
			// laruta
			// 
			this.laruta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laruta.ForeColor = System.Drawing.SystemColors.GrayText;
			this.laruta.Location = new System.Drawing.Point(60, 66);
			this.laruta.Name = "laruta";
			this.laruta.Size = new System.Drawing.Size(352, 23);
			this.laruta.TabIndex = 4;
			this.laruta.Text = " ";
			this.laruta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtbox
			// 
			this.txtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbox.Location = new System.Drawing.Point(12, 110);
			this.txtbox.Multiline = true;
			this.txtbox.Name = "txtbox";
			this.txtbox.Size = new System.Drawing.Size(400, 305);
			this.txtbox.TabIndex = 5;
			// 
			// boton
			// 
			this.boton.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.boton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boton.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.boton.Location = new System.Drawing.Point(300, 20);
			this.boton.Name = "boton";
			this.boton.Size = new System.Drawing.Size(112, 32);
			this.boton.TabIndex = 6;
			this.boton.Text = "Cerrar";
			this.boton.UseVisualStyleBackColor = false;
			this.boton.Click += new System.EventHandler(this.BotonClick);
			// 
			// btlimpiar
			// 
			this.btlimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btlimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btlimpiar.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btlimpiar.Location = new System.Drawing.Point(156, 20);
			this.btlimpiar.Name = "btlimpiar";
			this.btlimpiar.Size = new System.Drawing.Size(112, 32);
			this.btlimpiar.TabIndex = 7;
			this.btlimpiar.Text = "Limpiar";
			this.btlimpiar.UseVisualStyleBackColor = false;
			this.btlimpiar.Click += new System.EventHandler(this.BtlimpiarClick);
			// 
			// openfile
			// 
			this.openfile.FileName = "Abrir Archivo";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 427);
			this.Controls.Add(this.btlimpiar);
			this.Controls.Add(this.boton);
			this.Controls.Add(this.txtbox);
			this.Controls.Add(this.laruta);
			this.Controls.Add(this.btabrir);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Taller de Programacion de Sistemas";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btabrir;
		private System.Windows.Forms.OpenFileDialog openfile;
		private System.Windows.Forms.Button btlimpiar;
		private System.Windows.Forms.Button boton;
		private System.Windows.Forms.TextBox txtbox;
		private System.Windows.Forms.Label laruta;
		private System.Windows.Forms.Label label1;
	}
}
