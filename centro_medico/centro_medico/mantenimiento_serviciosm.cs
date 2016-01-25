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
    public partial class mantenimiento_serviciosm : Form
    {
        public mantenimiento_serviciosm()
        {
            InitializeComponent();
        }

        private void servicioMedicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicioMedicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centroMedicoDataSet);

        }

        private void mantenimiento_serviciosm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centroMedicoDataSet.ServicioMedico' table. You can move, or remove it, as needed.
            this.servicioMedicoTableAdapter.Fill(this.centroMedicoDataSet.ServicioMedico);

        }
    }
}
