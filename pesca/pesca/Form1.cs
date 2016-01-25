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

namespace pesca
{
    public partial class Form1 : Form

    {
        Pesca p = new Pesca();
        XmlDocument d = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            d.Load("Pesca.xml");
            XmlNodeList li = d.GetElementsByTagName("Especie");
           // XmlNodeList li = d.SelectNodes("Pesca/Especies/*[1]");-- first child por xpath
           // xpath buscar /pesca/especies/especie[@nome='robaliza']--busca a los que sean robaliza
           
            
              foreach (XmlNode nodo in li)
               {
                textBox1.Text += "Nombre: " + nodo.Attributes["nome"].Value + Environment.NewLine;
               
                   // textBox1.Text += " Valor: " + nodo["Especie"].GetAttribute("valor");
                textBox1.Text += nodo["Habitat"].InnerText + Environment.NewLine;
                textBox1.Text += nodo["NomeCientifico"].InnerText + Environment.NewLine;
                if(nodo["OutrosNomes"]!=null)
                textBox1.Text += nodo["OutrosNomes"].InnerText + Environment.NewLine;
                textBox1.Text += nodo["CapturaMinima"].InnerText + Environment.NewLine;
                if (nodo["Nota"] != null)
               
                        textBox1.Text += nodo["Nota"].InnerText + Environment.NewLine;
                    
                
                    
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.Load("Pesca.xml");
            // xpath buscar /pesca/especies/especie[@nome='robaliza']--busca a los que sean robaliza
            XmlNodeList l = d.SelectNodes("Pesca/Especies/Especie/Nota");
            foreach (XmlNode nodo in l) {

                textBox1.Text += nodo.InnerText + Environment.NewLine;

            }
        }





    }
}
