using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peajes
{
    public partial class Form1 : Form
    {

       static Evento e = new Evento(); //{ Fecha = "25/06/2006 ", Matricula = "RA3728 ", Puerta = "P4", Precio = 3 };
       /// Evento e1 = new Evento { Fecha = "25/06/2006 ", Matricula = "TR7865  ", Puerta = "P1" ,Precio = 4 };
      //  Evento e2 = new Evento { Fecha = "25/06/2006 ", Matricula = "HK7827  ", Puerta = "P1", Precio = 4 };
       // Evento e3 = new Evento { Fecha = "26/06/2006 ", Matricula = "RA3728 ", Puerta = "P5", Precio = 2 };
       //  Evento e4 =   new Evento { Fecha = "26/06/2006 ", Matricula = "HK7827  ", Puerta ="P2", Precio=5 };

        static List<Evento> trafico = new List<Evento>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cargarDatos();
            foreach (Evento i in trafico)
            {
                textBox2.Text = trafico.ToString();
            }
           // textBox2.Text = string.Join(Environment.NewLine, trafico);

        }

        public void cargarDatos()
        {
            e.Fecha = "25/06/2006";
            e.Matricula = "HK7827";
            e.Puerta = "P5";
            e.Precio = 3;
            trafico.Add(e);
            //trafico.Add(e1);
           // trafico.Add(e2);
          //  trafico.Add(e3);
          //  trafico.Add(e4);


        }



        public void facturacion(string matricula)
        {


        }
    }



      


    

    
}
