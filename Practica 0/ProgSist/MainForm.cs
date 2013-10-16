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
/// Jala Chido
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
			openfile.Filter = "Archivos ASM|*.asm|Archivos TXT|*.txt|Archivos TODOS|*.*";
			if (openfile.ShowDialog() == DialogResult.OK) 
				{
<<<<<<< HEAD
					this.laruta.Text = openfile.FileName; 
					
			System.IO.StreamReader sreader = new System.IO.StreamReader(@laruta.Text, System.Text.Encoding.Default);
			String txto;
            txto = sreader.ReadToEnd();
            txtbox.Text = txto;
			sreader.Close();
			
				}
		
			else if (openfile.ShowDialog() == DialogResult.Cancel){}
=======
					this.laruta.Text= openfile.FileName; 
					System.IO.StreamReader sreader = new System.IO.StreamReader(@laruta.Text, System.Text.Encoding.Default);
					
					String txto;
					while ((txto = sreader.ReadLine()) != null) {
						string[] tokens = txto.Split(new char[]{' ','\t'});
						foreach(string palabra in tokens){
							txtbox.AppendText(palabra+"\n");
						}
					}
					sreader.Close();
					
				}
>>>>>>> c6bc58a216efab6e3fabf0ded5efcb9de3b93811
			//ABRIR FIN
		}
		
		void BotonClick(object sender, EventArgs e)
		{	
			/*string [] lines = this.txtbox.Text.Split('\n');
			MessageBox.Show(lines.Length.ToString());*/
			//Close();
		}
	}
}
