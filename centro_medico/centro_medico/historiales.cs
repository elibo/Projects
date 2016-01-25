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
    public partial class historiales : Form
    {
        Gestora g = new Gestora();

        public historiales()
        {
            InitializeComponent();
        }

        private void historialesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historialesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centroMedicoDataSet);

        }

        private void historiales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centroMedicoDataSet.Historiales' table. You can move, or remove it, as needed.
            this.historialesTableAdapter.Fill(this.centroMedicoDataSet.Historiales);
            

        }

        private void historialesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {// mostrar historial
            string usuario = textBox1.Text;
            usuario = usuario.Trim();
           historialesDataGridView.DataSource = g.HistorialxNombre(usuario);
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
