/*
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
					System.IO.StreamReader sreader = new System.IO.StreamReader(@laruta.Text, System.Text.Encoding.Default);
					
					String txto;
					while ((txto = sreader.ReadLine()) != null) {
						string[] tokens = txto.Split(new char[]{' ','\t'});
						foreach(string palabra in tokens){
<<<<<<< HEAD
							txtbox.AppendText(palabra+"\n");
			
=======
							
							if(palabra!=""){
							if(palabra[0]==';'){
							   txtbox.AppendText("COMENTARIOOO\n");
							   }else{
							   	txtbox.AppendText(palabra+"\n");
								}
							}
>>>>>>> 42af67f61b2e7b1b767d1f94ca5e4cb4830b5864
						}
					}
					sreader.Close();
					
				}
			//ABRIR FIN
			
		}
		
		void BotonClick(object sender, EventArgs e)
		{
			//Close();
			FormLst lst = new FormLst();
			lst.Show();

		}
		}
	}

