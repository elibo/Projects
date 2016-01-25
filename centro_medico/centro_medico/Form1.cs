using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace centro_medico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//mantenimiento usuarios
            mantenimiento_usuarios mu = new mantenimiento_usuarios();
            mu.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {//mantenimiento medicos
            mantenimiento_medicos mm = new mantenimiento_medicos();
            mm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {//mantenimiento especialidades
            mantenimiento_especialidades me = new mantenimiento_especialidades();
            me.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {// mantenimiento servicios medicos
            mantenimiento_serviciosm ms = new mantenimiento_serviciosm();
            ms.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {// gestion de historiales
            historiales h = new historiales();
            h.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {// gestion de citas
            citas c = new citas();
            c.ShowDialog();
        }
    }
}
