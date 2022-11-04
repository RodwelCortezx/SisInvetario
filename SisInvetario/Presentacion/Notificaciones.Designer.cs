namespace SisInvetario.Presentacion
{
    partial class Notificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlNotificaciones = new System.Windows.Forms.TabControl();
            this.ProdXvencer = new System.Windows.Forms.TabPage();
            this.vwProductosPorVencerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwProductosPorVencerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdSistemVDataSet = new SisInvetario.bdSistemVDataSet();
            this.prodVencidos = new System.Windows.Forms.TabPage();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.vwProductosVencidosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwProductosVencidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProdStockBajos = new System.Windows.Forms.TabPage();
            this.vwProductosStockBajosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwProductosStockBajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwProductosPorVencerTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.vwProductosPorVencerTableAdapter();
            this.tableAdapterManager = new SisInvetario.bdSistemVDataSetTableAdapters.TableAdapterManager();
            this.vwProductosStockBajosTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.vwProductosStockBajosTableAdapter();
            this.vwProductosVencidosTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.vwProductosVencidosTableAdapter();
            this.reporteMovimientosRTableAdapter1 = new SisInvetario.bdSistemVDataSetTableAdapters.ReporteMovimientosRTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControlNotificaciones.SuspendLayout();
            this.ProdXvencer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosPorVencerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosPorVencerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).BeginInit();
            this.prodVencidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosVencidosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosVencidosBindingSource)).BeginInit();
            this.ProdStockBajos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosStockBajosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosStockBajosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlNotificaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 591);
            this.panel1.TabIndex = 0;
            // 
            // tabControlNotificaciones
            // 
            this.tabControlNotificaciones.Controls.Add(this.ProdXvencer);
            this.tabControlNotificaciones.Controls.Add(this.prodVencidos);
            this.tabControlNotificaciones.Controls.Add(this.ProdStockBajos);
            this.tabControlNotificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlNotificaciones.Location = new System.Drawing.Point(0, 0);
            this.tabControlNotificaciones.Name = "tabControlNotificaciones";
            this.tabControlNotificaciones.SelectedIndex = 0;
            this.tabControlNotificaciones.Size = new System.Drawing.Size(955, 591);
            this.tabControlNotificaciones.TabIndex = 0;
            // 
            // ProdXvencer
            // 
            this.ProdXvencer.Controls.Add(this.vwProductosPorVencerDataGridView);
            this.ProdXvencer.Location = new System.Drawing.Point(4, 29);
            this.ProdXvencer.Name = "ProdXvencer";
            this.ProdXvencer.Padding = new System.Windows.Forms.Padding(3);
            this.ProdXvencer.Size = new System.Drawing.Size(947, 558);
            this.ProdXvencer.TabIndex = 0;
            this.ProdXvencer.Text = "Productos por vencer";
            this.ProdXvencer.UseVisualStyleBackColor = true;
            // 
            // vwProductosPorVencerDataGridView
            // 
            this.vwProductosPorVencerDataGridView.AllowUserToAddRows = false;
            this.vwProductosPorVencerDataGridView.AllowUserToDeleteRows = false;
            this.vwProductosPorVencerDataGridView.AutoGenerateColumns = false;
            this.vwProductosPorVencerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vwProductosPorVencerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwProductosPorVencerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.vwProductosPorVencerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwProductosPorVencerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vwProductosPorVencerDataGridView.DataSource = this.vwProductosPorVencerBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwProductosPorVencerDataGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.vwProductosPorVencerDataGridView.EnableHeadersVisualStyles = false;
            this.vwProductosPorVencerDataGridView.Location = new System.Drawing.Point(141, 21);
            this.vwProductosPorVencerDataGridView.Name = "vwProductosPorVencerDataGridView";
            this.vwProductosPorVencerDataGridView.ReadOnly = true;
            this.vwProductosPorVencerDataGridView.RowHeadersVisible = false;
            this.vwProductosPorVencerDataGridView.Size = new System.Drawing.Size(629, 220);
            this.vwProductosPorVencerDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 220;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ExistenciaActual";
            this.dataGridViewTextBoxColumn2.HeaderText = "Existencia Actual";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaVencimiento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha Vencimiento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dias";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dias Faltantes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // vwProductosPorVencerBindingSource
            // 
            this.vwProductosPorVencerBindingSource.DataMember = "vwProductosPorVencer";
            this.vwProductosPorVencerBindingSource.DataSource = this.bdSistemVDataSet;
            // 
            // bdSistemVDataSet
            // 
            this.bdSistemVDataSet.DataSetName = "bdSistemVDataSet";
            this.bdSistemVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodVencidos
            // 
            this.prodVencidos.Controls.Add(this.btnBuscar);
            this.prodVencidos.Controls.Add(this.dtFecha);
            this.prodVencidos.Controls.Add(this.vwProductosVencidosDataGridView);
            this.prodVencidos.Location = new System.Drawing.Point(4, 29);
            this.prodVencidos.Name = "prodVencidos";
            this.prodVencidos.Padding = new System.Windows.Forms.Padding(3);
            this.prodVencidos.Size = new System.Drawing.Size(947, 558);
            this.prodVencidos.TabIndex = 1;
            this.prodVencidos.Text = "Productos Vencidos";
            this.prodVencidos.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(341, 30);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 26);
            this.dtFecha.TabIndex = 1;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // vwProductosVencidosDataGridView
            // 
            this.vwProductosVencidosDataGridView.AllowUserToAddRows = false;
            this.vwProductosVencidosDataGridView.AllowUserToDeleteRows = false;
            this.vwProductosVencidosDataGridView.AutoGenerateColumns = false;
            this.vwProductosVencidosDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vwProductosVencidosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vwProductosVencidosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwProductosVencidosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.vwProductosVencidosDataGridView.ColumnHeadersHeight = 48;
            this.vwProductosVencidosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.vwProductosVencidosDataGridView.DataSource = this.vwProductosVencidosBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwProductosVencidosDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.vwProductosVencidosDataGridView.EnableHeadersVisualStyles = false;
            this.vwProductosVencidosDataGridView.Location = new System.Drawing.Point(137, 92);
            this.vwProductosVencidosDataGridView.Name = "vwProductosVencidosDataGridView";
            this.vwProductosVencidosDataGridView.ReadOnly = true;
            this.vwProductosVencidosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwProductosVencidosDataGridView.Size = new System.Drawing.Size(607, 335);
            this.vwProductosVencidosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 180;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ExistenciaActual";
            this.dataGridViewTextBoxColumn10.HeaderText = "Existencia";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FechaVencimiento";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fecha Vencimiento";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 160;
            // 
            // vwProductosVencidosBindingSource
            // 
            this.vwProductosVencidosBindingSource.DataMember = "vwProductosVencidos";
            this.vwProductosVencidosBindingSource.DataSource = this.bdSistemVDataSet;
            // 
            // ProdStockBajos
            // 
            this.ProdStockBajos.Controls.Add(this.vwProductosStockBajosDataGridView);
            this.ProdStockBajos.Location = new System.Drawing.Point(4, 29);
            this.ProdStockBajos.Name = "ProdStockBajos";
            this.ProdStockBajos.Padding = new System.Windows.Forms.Padding(3);
            this.ProdStockBajos.Size = new System.Drawing.Size(947, 558);
            this.ProdStockBajos.TabIndex = 2;
            this.ProdStockBajos.Text = "Productos con stock bajos";
            this.ProdStockBajos.UseVisualStyleBackColor = true;
            // 
            // vwProductosStockBajosDataGridView
            // 
            this.vwProductosStockBajosDataGridView.AllowUserToAddRows = false;
            this.vwProductosStockBajosDataGridView.AllowUserToDeleteRows = false;
            this.vwProductosStockBajosDataGridView.AutoGenerateColumns = false;
            this.vwProductosStockBajosDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vwProductosStockBajosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vwProductosStockBajosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwProductosStockBajosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.vwProductosStockBajosDataGridView.ColumnHeadersHeight = 44;
            this.vwProductosStockBajosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vwProductosStockBajosDataGridView.DataSource = this.vwProductosStockBajosBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwProductosStockBajosDataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.vwProductosStockBajosDataGridView.EnableHeadersVisualStyles = false;
            this.vwProductosStockBajosDataGridView.Location = new System.Drawing.Point(112, 41);
            this.vwProductosStockBajosDataGridView.Name = "vwProductosStockBajosDataGridView";
            this.vwProductosStockBajosDataGridView.ReadOnly = true;
            this.vwProductosStockBajosDataGridView.RowHeadersVisible = false;
            this.vwProductosStockBajosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwProductosStockBajosDataGridView.Size = new System.Drawing.Size(675, 220);
            this.vwProductosStockBajosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 220;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn7.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StockMinimo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Stock Minimo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // vwProductosStockBajosBindingSource
            // 
            this.vwProductosStockBajosBindingSource.DataMember = "vwProductosStockBajos";
            this.vwProductosStockBajosBindingSource.DataSource = this.bdSistemVDataSet;
            // 
            // vwProductosPorVencerTableAdapter
            // 
            this.vwProductosPorVencerTableAdapter.ClearBeforeFill = true;
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
            // vwProductosStockBajosTableAdapter
            // 
            this.vwProductosStockBajosTableAdapter.ClearBeforeFill = true;
            // 
            // vwProductosVencidosTableAdapter
            // 
            this.vwProductosVencidosTableAdapter.ClearBeforeFill = true;
            // 
            // reporteMovimientosRTableAdapter1
            // 
            this.reporteMovimientosRTableAdapter1.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(570, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Notificaciones";
            this.Size = new System.Drawing.Size(955, 591);
            this.panel1.ResumeLayout(false);
            this.tabControlNotificaciones.ResumeLayout(false);
            this.ProdXvencer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosPorVencerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosPorVencerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).EndInit();
            this.prodVencidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosVencidosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosVencidosBindingSource)).EndInit();
            this.ProdStockBajos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosStockBajosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosStockBajosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlNotificaciones;
        private System.Windows.Forms.TabPage ProdXvencer;
        private System.Windows.Forms.TabPage prodVencidos;
        private System.Windows.Forms.TabPage ProdStockBajos;
        private System.Windows.Forms.DataGridView vwProductosPorVencerDataGridView;
        private System.Windows.Forms.BindingSource vwProductosPorVencerBindingSource;
        private bdSistemVDataSet bdSistemVDataSet;
        private System.Windows.Forms.DataGridView vwProductosStockBajosDataGridView;
        private System.Windows.Forms.BindingSource vwProductosStockBajosBindingSource;
        private bdSistemVDataSetTableAdapters.vwProductosPorVencerTableAdapter vwProductosPorVencerTableAdapter;
        private bdSistemVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bdSistemVDataSetTableAdapters.vwProductosStockBajosTableAdapter vwProductosStockBajosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView vwProductosVencidosDataGridView;
        private System.Windows.Forms.BindingSource vwProductosVencidosBindingSource;
        private bdSistemVDataSetTableAdapters.vwProductosVencidosTableAdapter vwProductosVencidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private bdSistemVDataSetTableAdapters.ReporteMovimientosRTableAdapter reporteMovimientosRTableAdapter1;
        private System.Windows.Forms.Button btnBuscar;
    }
}
