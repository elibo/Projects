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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        static Fichero f = new Fichero();
        static int ini=0;
        static int fin=10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//abrir fichero
            openFileDialog1.ShowDialog();
            f.Ruta = openFileDialog1.FileName;
            textBox1.Text = f.Ruta;
        }

        private void button2_Click(object sender, EventArgs e)
        {//mostrar fichero
           List<string> l= f.lineaLinea(f.Ruta);
            /*  foreach (string s in l)
              {
                  textBox2.Text +=s+Environment.NewLine;
              }*/
            for (int i = ini; i <fin; i++)
            {
                textBox2.Text += l[i]+Environment.NewLine;   
            }
            ini += 10;
            fin += 10;

        }

        private void button3_Click(object sender, EventArgs e)
        {//buscar autor
            string autor = textBox3.Text;
            List<string>au=f.buscAutor(autor);
            textBox2.Clear();
            foreach (string i in au)
            {
                textBox2.Text += i+Environment.NewLine;
            }       
            

        

        }

        private void button4_Click(object sender, EventArgs e)
        {//añadir linea

            string autor = textBox4.Text;
            string frase = textBox5.Text;
            textBox4.Clear();
            textBox5.Clear();
            string linea = frase + " - " +autor+ Environment.NewLine;
            f.añadeLinea(f.Ruta, linea);
            textBox2.Text += linea;

        }

        private void button5_Click(object sender, EventArgs e)
        {//mostrar 10
            textBox2.Clear();
            List<string> l = f.lineaLinea(f.Ruta);
            for (int i = ini; i < fin; i++)
            {
                textBox2.Text += l[i] + Environment.NewLine;
            }
            ini =20;
            fin = l.Count();
        }
    }
}
