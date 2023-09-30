/*
 * Criado por SharpDevelop.
 * Usuário: Usuario
 * Data: 19/09/2023
 * Hora: 11:41
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Temperatura
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
		void Button1Click(object sender, EventArgs e)
		{
			float temperatura;
			temperatura = float.Parse(textBox1.Text);
			
		if (temperatura < 0)				    
        {
            label4.Text = "Está um Frio congelante! Agasalhe-se Bem!";
            pictureBox2.Load("congelante.png");
        }
        else if (temperatura >= 0 && temperatura <= 10)
        {
            label4.Text = "Está Muito Frio! Use roupas quentinhas!";
            pictureBox2.Load("muito_frio.jpg");
        }
        else if (temperatura > 10 && temperatura <= 18)
        {
            label4.Text = "Frio! Não esqueça o casaco!";
            pictureBox2.Load("frio.jpg");
        }
        else if (temperatura > 18 && temperatura <= 24)
        {
            label4.Text = "Agradável! Hoje está um bom dia para caminhar!";
            pictureBox2.Load("agradavel.jpg");
        }
        else if (temperatura > 24 && temperatura <= 32)
        {
            label4.Text = "Calor!   Que tal uma praia?";
            pictureBox2.Load("calor.jpg");
        }
        else if (temperatura > 32 && temperatura <= 38)
        {
            label4.Text = "Está Muito Quente! Beba muita água!";
            pictureBox2.Load("muito_quente.jpg");
        }
        else
        {
            label4.Text = "Calor Escaldante! Evite o sol do 12:00hr!";
            pictureBox2.Load("escaldante.jpg");
        }
			
  
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}
	}
}
