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
    public partial class mantenimiento_especialidades : Form
    {
        public mantenimiento_especialidades()
        {
            InitializeComponent();
        }

        private void especialidadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.especialidadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centroMedicoDataSet);

        }

        private void mantenimiento_especialidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centroMedicoDataSet.Especialidades' table. You can move, or remove it, as needed.
            this.especialidadesTableAdapter.Fill(this.centroMedicoDataSet.Especialidades);

        }
    }
}
