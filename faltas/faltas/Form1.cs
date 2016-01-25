using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faltas
{
    public partial class Form1 : Form
    {


        XML xml = new XML();
        List<Modulo> listmod = new List<Modulo>();
        List<Alumno> listalumnos = new List<Alumno>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {//xml
            if (listalumnos.Count() > 0)
                xml.crearXml(listalumnos, listmod[comboBox1.SelectedIndex].Nombre + ".xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {//faltas
            listalumnos = xml.consultaNotas(comboBox1.SelectedIndex + 1, listmod[comboBox1.SelectedIndex].Nombre, listmod[comboBox1.SelectedIndex].Horast);
            dataGridView2.DataSource = listalumnos;
        }

        private void button1_Click(object sender, EventArgs e)
        {//modulos
            listmod = xml.cargaModulos();
            dataGridView1.DataSource = listmod;
            comboBox1.DataSource = listmod;
            comboBox1.DisplayMember = "Nombre";
        }
    }
}
