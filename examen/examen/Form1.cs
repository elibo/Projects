using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        XML xml = new XML();
        List<Modulo> lm = new List<Modulo>();
        List<Alumno> a = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//cargar modulos
            lm=xml.cargartxt();
            dataGridView1.DataSource = lm;


        }

        private void button2_Click(object sender, EventArgs e)
        {//informe faltas(cargar xml)
            a=xml.cargar();
            dataGridView2.DataSource = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {//guarda xml
            Alumno al = new Alumno();
            al.Nombre = "Elena";
            al.Modulo = "Mates";
            al.Horasfaltadas = 55;
            al.Porcentaje = 4.5;
            a.Add(al);
            al= new Alumno();
            al.Nombre = "Yo";
            al.Modulo = "Fisica";
            al.Horasfaltadas = 5;
            al.Porcentaje = 0.5;
            a.Add(al);
            xml.crearxml(a,"alumnos.xml");
        }
    }
}
