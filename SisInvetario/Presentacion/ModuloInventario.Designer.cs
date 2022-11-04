namespace SisInvetario.Presentacion
{
    partial class ModuloInventario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.vwInventariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwInventariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdSistemVDataSet = new SisInvetario.bdSistemVDataSet();
            this.vwInventariosTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.vwInventariosTableAdapter();
            this.tableAdapterManager = new SisInvetario.bdSistemVDataSetTableAdapters.TableAdapterManager();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwInventariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInventariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.vwInventariosDataGridView);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1108, 649);
            this.panelFondo.TabIndex = 1;
            // 
            // vwInventariosDataGridView
            // 
            this.vwInventariosDataGridView.AllowUserToAddRows = false;
            this.vwInventariosDataGridView.AllowUserToDeleteRows = false;
            this.vwInventariosDataGridView.AutoGenerateColumns = false;
            this.vwInventariosDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vwInventariosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vwInventariosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwInventariosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vwInventariosDataGridView.ColumnHeadersHeight = 43;
            this.vwInventariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.vwInventariosDataGridView.DataSource = this.vwInventariosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwInventariosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.vwInventariosDataGridView.EnableHeadersVisualStyles = false;
            this.vwInventariosDataGridView.Location = new System.Drawing.Point(87, 56);
            this.vwInventariosDataGridView.Name = "vwInventariosDataGridView";
            this.vwInventariosDataGridView.ReadOnly = true;
            this.vwInventariosDataGridView.RowHeadersVisible = false;
            this.vwInventariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwInventariosDataGridView.Size = new System.Drawing.Size(858, 419);
            this.vwInventariosDataGridView.TabIndex = 0;
            this.vwInventariosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.vwInventariosDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idInventario";
            this.dataGridViewTextBoxColumn1.HeaderText = "idInventario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecioCosto";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrecioCosto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PrecioVentas";
            this.dataGridViewTextBoxColumn5.HeaderText = "PrecioVentas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ExistenciaActual";
            this.dataGridViewTextBoxColumn6.HeaderText = "Stock Actual";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ExistenciaMinima";
            this.dataGridViewTextBoxColumn7.HeaderText = "Stock Minima";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FechaVencimiento";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha Vencimiento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn9.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // vwInventariosBindingSource
            // 
            this.vwInventariosBindingSource.DataMember = "vwInventarios";
            this.vwInventariosBindingSource.DataSource = this.bdSistemVDataSet;
            // 
            // bdSistemVDataSet
            // 
            this.bdSistemVDataSet.DataSetName = "bdSistemVDataSet";
            this.bdSistemVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwInventariosTableAdapter
            // 
            this.vwInventariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbBitacoraIngresoTableAdapter = null;
            this.tableAdapterManager.tbBitacoraTableAdapter = null;
            this.tableAdapterManager.tbCategoriaTableAdapter = null;
            this.tableAdapterManager.tbComprasTableAdapter = null;
            this.tableAdapterManager.tbDetallCompraTableAdapter = null;
            this.tableAdapterManager.tbDetallVentasTableAdapter = null;
            this.tableAdapterManager.tbInventarioTableAdapter = null;
            this.tableAdapterManager.tbMovimientoTableAdapter = null;
            this.tableAdapterManager.tbPermisosTableAdapter = null;
            this.tableAdapterManager.tbProductosTableAdapter = null;
            this.tableAdapterManager.tbUsuariosTableAdapter = null;
            this.tableAdapterManager.tbVentasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SisInvetario.bdSistemVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ModuloInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFondo);
            this.Name = "ModuloInventario";
            this.Size = new System.Drawing.Size(1108, 649);
            this.panelFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwInventariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInventariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFondo;
        private bdSistemVDataSet bdSistemVDataSet;
        private System.Windows.Forms.BindingSource vwInventariosBindingSource;
        private bdSistemVDataSetTableAdapters.vwInventariosTableAdapter vwInventariosTableAdapter;
        private bdSistemVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vwInventariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
