namespace centro_medico
{
    partial class mantenimiento_serviciosm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mantenimiento_serviciosm));
            this.centroMedicoDataSet = new centro_medico.CentroMedicoDataSet();
            this.servicioMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioMedicoTableAdapter = new centro_medico.CentroMedicoDataSetTableAdapters.ServicioMedicoTableAdapter();
            this.tableAdapterManager = new centro_medico.CentroMedicoDataSetTableAdapters.TableAdapterManager();
            this.servicioMedicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.servicioMedicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.servicioMedicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.centroMedicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioMedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioMedicoBindingNavigator)).BeginInit();
            this.servicioMedicoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicioMedicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // centroMedicoDataSet
            // 
            this.centroMedicoDataSet.DataSetName = "CentroMedicoDataSet";
            this.centroMedicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioMedicoBindingSource
            // 
            this.servicioMedicoBindingSource.DataMember = "ServicioMedico";
            this.servicioMedicoBindingSource.DataSource = this.centroMedicoDataSet;
            // 
            // servicioMedicoTableAdapter
            // 
            this.servicioMedicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitasTableAdapter = null;
            this.tableAdapterManager.EspecialidadesTableAdapter = null;
            this.tableAdapterManager.HistorialesTableAdapter = null;
            this.tableAdapterManager.HorariosTableAdapter = null;
            this.tableAdapterManager.MedicosTableAdapter = null;
            this.tableAdapterManager.ServicioMedicoTableAdapter = this.servicioMedicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = centro_medico.CentroMedicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // servicioMedicoBindingNavigator
            // 
            this.servicioMedicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servicioMedicoBindingNavigator.BindingSource = this.servicioMedicoBindingSource;
            this.servicioMedicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicioMedicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servicioMedicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.servicioMedicoBindingNavigatorSaveItem});
            this.servicioMedicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicioMedicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicioMedicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicioMedicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicioMedicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicioMedicoBindingNavigator.Name = "servicioMedicoBindingNavigator";
            this.servicioMedicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicioMedicoBindingNavigator.Size = new System.Drawing.Size(388, 25);
            this.servicioMedicoBindingNavigator.TabIndex = 0;
            this.servicioMedicoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // servicioMedicoBindingNavigatorSaveItem
            // 
            this.servicioMedicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicioMedicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicioMedicoBindingNavigatorSaveItem.Image")));
            this.servicioMedicoBindingNavigatorSaveItem.Name = "servicioMedicoBindingNavigatorSaveItem";
            this.servicioMedicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.servicioMedicoBindingNavigatorSaveItem.Text = "Save Data";
            this.servicioMedicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicioMedicoBindingNavigatorSaveItem_Click);
            // 
            // servicioMedicoDataGridView
            // 
            this.servicioMedicoDataGridView.AutoGenerateColumns = false;
            this.servicioMedicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicioMedicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.servicioMedicoDataGridView.DataSource = this.servicioMedicoBindingSource;
            this.servicioMedicoDataGridView.Location = new System.Drawing.Point(12, 43);
            this.servicioMedicoDataGridView.Name = "servicioMedicoDataGridView";
            this.servicioMedicoDataGridView.Size = new System.Drawing.Size(346, 292);
            this.servicioMedicoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idServicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "idServicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // mantenimiento_serviciosm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 366);
            this.Controls.Add(this.servicioMedicoDataGridView);
            this.Controls.Add(this.servicioMedicoBindingNavigator);
            this.Name = "mantenimiento_serviciosm";
            this.Text = "Servicios Médicos";
            this.Load += new System.EventHandler(this.mantenimiento_serviciosm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centroMedicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioMedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioMedicoBindingNavigator)).EndInit();
            this.servicioMedicoBindingNavigator.ResumeLayout(false);
            this.servicioMedicoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicioMedicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CentroMedicoDataSet centroMedicoDataSet;
        private System.Windows.Forms.BindingSource servicioMedicoBindingSource;
        private CentroMedicoDataSetTableAdapters.ServicioMedicoTableAdapter servicioMedicoTableAdapter;
        private CentroMedicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicioMedicoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton servicioMedicoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView servicioMedicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}