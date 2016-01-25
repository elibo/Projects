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
    public partial class citas : Form
    {

        Gestora g = new Gestora();
        public citas()
        {
            InitializeComponent();
        }

        private void citasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.citasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centroMedicoDataSet);

        }

        private void citas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centroMedicoDataSet.Citas' table. You can move, or remove it, as needed.
            this.citasTableAdapter.Fill(this.centroMedicoDataSet.Citas);

        }

        private void button1_Click(object sender, EventArgs e)
        {//citas por fecha
            string fecha = textBox1.Text;
            fecha = fecha.Trim();
            citasDataGridView.DataSource = g.CitaxFecha(fecha);
        }

        private void button2_Click(object sender, EventArgs e)
        {//citas por usuario
            string usuario = textBox1.Text;
            usuario = usuario.Trim();
            citasDataGridView.DataSource = g.CitaxNombre(usuario);
        }

        private void button3_Click(object sender, EventArgs e)
        {//citas por medico
            string medico = textBox1.Text;
            medico = medico.Trim();
            citasDataGridView.DataSource = g.CitaxMedico(medico);
        }
    }
}
