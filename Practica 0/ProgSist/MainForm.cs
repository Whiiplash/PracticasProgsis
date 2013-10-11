﻿/*
 * Created by SharpDevelop.
 * User: RafaelRCA
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ProgSist
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtlimpiarClick(object sender, EventArgs e)
		{
			this.laruta.Text="";		
			this.txtbox.Text="";
		}
		
		void BtabrirClick(object sender, EventArgs e)
		{
			//ABRIR INICIO
			OpenFileDialog openfile = new OpenFileDialog();
			openfile.Title = "Seleccione un archivo";
			if (openfile.ShowDialog() == DialogResult.OK) 
				{
					this.laruta.Text= openfile.FileName; 
				}
			
			System.IO.StreamReader sreader = new System.IO.StreamReader(@laruta.Text, System.Text.Encoding.Default);
			String txto;
			txto = sreader.ReadToEnd();
			sreader.Close();
			txtbox.Text = txto;
 
			//ABRIR FIN
		}
		
		void BotonClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}