using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
	
	public partial class MainForm : Form
	{
		private string usuario="hector";
		private string contraseña="123";
		
		
		
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text == usuario && textBox2.Text == contraseña) 
			{
				MessageBox.Show("Bienvenido al sistema");
			}
			else
			{
				
				MessageBox.Show("Usuario o contraseña incorrectos");
			}
			
			}
			
		}
	}


