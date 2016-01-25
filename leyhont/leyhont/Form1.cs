using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leyhont
{
    public partial class Form1 : Form
    {

        static Partido p = new Partido();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] co = new int[3,5];
            int v1= Int32.Parse(textBox1.Text);
            int v2 = Int32.Parse(textBox2.Text);
            int v3 = Int32.Parse(textBox3.Text);
            for (int i = 0; i < 5; i++) 
            {
                co[0, i] = v1 / (i+1);
                co[1, i] = v2 / (i + 1);
                co[2, i] = v3 / (i + 1);
            }

        
           

            Partido p1 = new Partido();
            p1.Nombre = "Partido A";
            p1.Votos = Int32.Parse(textBox1.Text);
            p1.Escaños = 0;



            Partido p2 = new Partido();
            p1.Nombre = "Partido B";
            p1.Votos = Int32.Parse(textBox2.Text);
            p1.Escaños = 0;



            Partido p3 = new Partido();
            p1.Nombre = "Partido C";
            p1.Votos = Int32.Parse(textBox3.Text);
            p1.Escaños = 0;
            


           



        }




    }
}
