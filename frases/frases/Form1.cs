using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace frases
{
    public partial class Form1 : Form
    {

        static Fichero f;
        string ruta;
        static List<Fichero> lista = new List<Fichero>();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text= openFileDialog1.FileName;
            ruta= openFileDialog1.FileName;


        }

        private void button2_Click(object sender, EventArgs e)
        {//ver lista
            List<Fichero> fichero = new List<Fichero>();
            XmlDocument d = new XmlDocument();
            d.Load(textBox1.Text);
            XmlNodeList li = d.SelectNodes("Frases/Frase");
            foreach (XmlNode n in li)
            {
                f = new Fichero();
                f.Autor = n["Autor"].InnerText;
                f.Frase = n["Cita"].InnerText;
                fichero.Add(f);

            }

            dataGridView1.DataSource = fichero;
        }

        private void button4_Click(object sender, EventArgs e)
        {//añadir a lista
         
        }

        private void button5_Click(object sender, EventArgs e)
        {//guardar xml
            f.guardarxml(lista, "xml.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {//buscar autor
           
            
        }
    }
}
