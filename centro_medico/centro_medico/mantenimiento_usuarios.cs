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
    public partial class mantenimiento_usuarios : Form
    {
        public mantenimiento_usuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centroMedicoDataSet);

        }

        private void mantenimiento_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centroMedicoDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.centroMedicoDataSet.Usuarios);

        }
    }
}
