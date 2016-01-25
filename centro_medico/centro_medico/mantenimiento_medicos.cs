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
    public partial class mantenimiento_medicos : Form
    {
        public mantenimiento_medicos()
        {
            InitializeComponent();
        }

        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centroMedicoDataSet);

        }

        private void mantenimiento_medicos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centroMedicoDataSet.Medicos' table. You can move, or remove it, as needed.
            this.medicosTableAdapter.Fill(this.centroMedicoDataSet.Medicos);

        }
    }
}
