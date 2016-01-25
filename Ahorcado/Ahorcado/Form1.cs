using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
       private Fichero f = new Fichero();
       private int intentos = 5;
       



        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {//jugar
            textBox2.Text = intentos.ToString();
            f.Palabra= f.cargaPalabra();
            f.OcultarPalabra();
            pictureBox1.Image = Image.FromFile(@"C:\Users\elibo\Downloads\" + intentos + ".png");
            textBox3.Text = f.Oculta;

            
            
          

        }

        private void button2_Click(object sender, EventArgs e)
        {//configurar
            string palabra=ShowDialog("Nueva palabra", "Configuración");
            f.Palabra = palabra;
            f.guardaPalabra();



        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };

            Button confirmation = new Button() { Text = "Aceptar", Left = 150, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void button3_Click(object sender, EventArgs e)
        {//validar
            string mostrada = "";
            char c = Convert.ToChar(textBox1.Text);
            textBox1.Clear();
            for (int i = 0; i < f.Palabra.Length; i++) {
                if (f.Palabra[i]== c)
                {
                    mostrada += c;
                }
                else {
                    mostrada +=f.Oculta[i];
                    
                }

            }
            if (f.Oculta.Trim().Equals(mostrada.Trim())) {
                intentos--;
            }
            f.Oculta = mostrada;
            textBox3.Text = mostrada;
            textBox2.Text = intentos.ToString();
            pictureBox1.Image = Image.FromFile(@"C:\Users\elibo\Downloads\" + intentos + ".png");
            if (intentos <= 0)
            {
                button3.Enabled = false;
                label3.Text = "Que pena. Te has quedado sin intentos!";
                label3.Visible = true;

            }
            if (mostrada.Equals(f.Palabra))
            {
                button3.Enabled = false;
                label3.Text ="Felicidades! Has acertado la palabra";
                label3.Visible = true;
            }

        }
    }
}
