namespace SisInvetario.Presentacion
{
    partial class moduloMovimientos
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
            this.panelMov = new System.Windows.Forms.Panel();
            this.vwMovimientosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwMovimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdSistemVDataSet = new SisInvetario.bdSistemVDataSet();
            this.vwMovimientosTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.vwMovimientosTableAdapter();
            this.panelMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwMovimientosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMovimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMov
            // 
            this.panelMov.AutoScroll = true;
            this.panelMov.Controls.Add(this.vwMovimientosDataGridView);
            this.panelMov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMov.Location = new System.Drawing.Point(0, 0);
            this.panelMov.Name = "panelMov";
            this.panelMov.Size = new System.Drawing.Size(1158, 648);
            this.panelMov.TabIndex = 1;
            // 
            // vwMovimientosDataGridView
            // 
            this.vwMovimientosDataGridView.AllowUserToAddRows = false;
            this.vwMovimientosDataGridView.AllowUserToDeleteRows = false;
            this.vwMovimientosDataGridView.AllowUserToResizeColumns = false;
            this.vwMovimientosDataGridView.AllowUserToResizeRows = false;
            this.vwMovimientosDataGridView.AutoGenerateColumns = false;
            this.vwMovimientosDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vwMovimientosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMovimientosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vwMovimientosDataGridView.ColumnHeadersHeight = 45;
            this.vwMovimientosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.vwMovimientosDataGridView.DataSource = this.vwMovimientosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwMovimientosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.vwMovimientosDataGridView.EnableHeadersVisualStyles = false;
            this.vwMovimientosDataGridView.Location = new System.Drawing.Point(90, 6);
            this.vwMovimientosDataGridView.Name = "vwMovimientosDataGridView";
            this.vwMovimientosDataGridView.ReadOnly = true;
            this.vwMovimientosDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vwMovimientosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwMovimientosDataGridView.Size = new System.Drawing.Size(930, 484);
            this.vwMovimientosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn12.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 160;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Movimiento";
            this.dataGridViewTextBoxColumn13.HeaderText = "Movimiento";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ExistenciaAnterior";
            this.dataGridViewTextBoxColumn14.HeaderText = "Existencia Anterior";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn15.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn16.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ExistenciaActual";
            this.dataGridViewTextBoxColumn17.HeaderText = "Existencia Actual";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn18.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // vwMovimientosBindingSource
            // 
            this.vwMovimientosBindingSource.DataMember = "vwMovimientos";
            this.vwMovimientosBindingSource.DataSource = this.bdSistemVDataSet;
            // 
            // bdSistemVDataSet
            // 
            this.bdSistemVDataSet.DataSetName = "bdSistemVDataSet";
            this.bdSistemVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwMovimientosTableAdapter
            // 
            this.vwMovimientosTableAdapter.ClearBeforeFill = true;
            // 
            // moduloMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMov);
            this.Name = "moduloMovimientos";
            this.Size = new System.Drawing.Size(1158, 648);
            this.panelMov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwMovimientosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMovimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMov;
        private bdSistemVDataSet bdSistemVDataSet;
        private System.Windows.Forms.DataGridView vwMovimientosDataGridView;
        private System.Windows.Forms.BindingSource vwMovimientosBindingSource;
        private bdSistemVDataSetTableAdapters.vwMovimientosTableAdapter vwMovimientosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}
