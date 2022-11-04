namespace SisInvetario.Presentacion
{
    partial class moduloCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelP = new System.Windows.Forms.Panel();
            this.vwComprasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetCompras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdSistemVDataSet1 = new SisInvetario.bdSistemVDataSet();
            this.panelAddProduct = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.vistaProdDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdSistemVDataSet = new SisInvetario.bdSistemVDataSet();
            this.gbCompras = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSelProducto = new System.Windows.Forms.Button();
            this.checkBFecha = new System.Windows.Forms.CheckBox();
            this.panelFechaVen = new System.Windows.Forms.Panel();
            this.dtpFechaVen = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vistaProdTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.VistaProdTableAdapter();
            this.tableAdapterManager = new SisInvetario.bdSistemVDataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbComprasTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.tbComprasTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbDetallCompraTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.tbDetallCompraTableAdapter();
            this.vwComprasTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.vwComprasTableAdapter();
            this.panelP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet1)).BeginInit();
            this.panelAddProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProdDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).BeginInit();
            this.gbCompras.SuspendLayout();
            this.panelFechaVen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelP
            // 
            this.panelP.AutoScroll = true;
            this.panelP.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panelP.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.panelP.Controls.Add(this.vwComprasDataGridView);
            this.panelP.Controls.Add(this.panelAddProduct);
            this.panelP.Controls.Add(this.gbCompras);
            this.panelP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelP.Location = new System.Drawing.Point(0, 0);
            this.panelP.Name = "panelP";
            this.panelP.Size = new System.Drawing.Size(1197, 758);
            this.panelP.TabIndex = 1;
            this.panelP.Paint += new System.Windows.Forms.PaintEventHandler(this.panelP_Paint);
            // 
            // vwComprasDataGridView
            // 
            this.vwComprasDataGridView.AllowUserToAddRows = false;
            this.vwComprasDataGridView.AllowUserToDeleteRows = false;
            this.vwComprasDataGridView.AllowUserToResizeColumns = false;
            this.vwComprasDataGridView.AllowUserToResizeRows = false;
            this.vwComprasDataGridView.AutoGenerateColumns = false;
            this.vwComprasDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vwComprasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwComprasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.vwComprasDataGridView.ColumnHeadersHeight = 41;
            this.vwComprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.idDetCompras,
            this.dataGridViewTextBoxColumn13});
            this.vwComprasDataGridView.DataSource = this.vwComprasBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwComprasDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.vwComprasDataGridView.EnableHeadersVisualStyles = false;
            this.vwComprasDataGridView.Location = new System.Drawing.Point(57, 392);
            this.vwComprasDataGridView.Name = "vwComprasDataGridView";
            this.vwComprasDataGridView.ReadOnly = true;
            this.vwComprasDataGridView.RowHeadersVisible = false;
            this.vwComprasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwComprasDataGridView.Size = new System.Drawing.Size(1031, 219);
            this.vwComprasDataGridView.TabIndex = 2;
            this.vwComprasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwComprasDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idCompras";
            this.dataGridViewTextBoxColumn4.HeaderText = "idCompras";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaCompra";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha Compra";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 160;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 85;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PrecioCompra";
            this.dataGridViewTextBoxColumn9.HeaderText = "Precio Compra";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Precio_Venta";
            this.dataGridViewTextBoxColumn10.HeaderText = "Precio Venta";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn11.HeaderText = "Total";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FechaVencimiento";
            this.dataGridViewTextBoxColumn12.HeaderText = "Fecha Vencimiento";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 130;
            // 
            // idDetCompras
            // 
            this.idDetCompras.DataPropertyName = "idDetCompras";
            this.idDetCompras.HeaderText = "idDetCompras";
            this.idDetCompras.Name = "idDetCompras";
            this.idDetCompras.ReadOnly = true;
            this.idDetCompras.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn13.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 85;
            // 
            // vwComprasBindingSource
            // 
            this.vwComprasBindingSource.DataMember = "vwCompras";
            this.vwComprasBindingSource.DataSource = this.bdSistemVDataSet1;
            // 
            // bdSistemVDataSet1
            // 
            this.bdSistemVDataSet1.DataSetName = "bdSistemVDataSet";
            this.bdSistemVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelAddProduct
            // 
            this.panelAddProduct.Controls.Add(this.groupBox1);
            this.panelAddProduct.Controls.Add(this.vistaProdDataGridView);
            this.panelAddProduct.Location = new System.Drawing.Point(577, 8);
            this.panelAddProduct.Name = "panelAddProduct";
            this.panelAddProduct.Size = new System.Drawing.Size(445, 360);
            this.panelAddProduct.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(40, 19);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(240, 24);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vistaProdDataGridView
            // 
            this.vistaProdDataGridView.AllowUserToAddRows = false;
            this.vistaProdDataGridView.AllowUserToDeleteRows = false;
            this.vistaProdDataGridView.AutoGenerateColumns = false;
            this.vistaProdDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vistaProdDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaProdDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.vistaProdDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vistaProdDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.vistaProdDataGridView.ColumnHeadersHeight = 28;
            this.vistaProdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.vistaProdDataGridView.DataSource = this.vistaProdBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vistaProdDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.vistaProdDataGridView.EnableHeadersVisualStyles = false;
            this.vistaProdDataGridView.Location = new System.Drawing.Point(43, 64);
            this.vistaProdDataGridView.Name = "vistaProdDataGridView";
            this.vistaProdDataGridView.ReadOnly = true;
            this.vistaProdDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vistaProdDataGridView.RowHeadersVisible = false;
            this.vistaProdDataGridView.RowTemplate.Height = 28;
            this.vistaProdDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vistaProdDataGridView.Size = new System.Drawing.Size(376, 258);
            this.vistaProdDataGridView.TabIndex = 0;
            this.vistaProdDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vistaProdDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // vistaProdBindingSource
            // 
            this.vistaProdBindingSource.DataMember = "VistaProd";
            this.vistaProdBindingSource.DataSource = this.bdSistemVDataSet;
            // 
            // bdSistemVDataSet
            // 
            this.bdSistemVDataSet.DataSetName = "bdSistemVDataSet";
            this.bdSistemVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbCompras
            // 
            this.gbCompras.Controls.Add(this.btnActualizar);
            this.gbCompras.Controls.Add(this.btnGuardar);
            this.gbCompras.Controls.Add(this.btnSelProducto);
            this.gbCompras.Controls.Add(this.checkBFecha);
            this.gbCompras.Controls.Add(this.panelFechaVen);
            this.gbCompras.Controls.Add(this.txtCantidad);
            this.gbCompras.Controls.Add(this.label5);
            this.gbCompras.Controls.Add(this.txtPrecioVenta);
            this.gbCompras.Controls.Add(this.label4);
            this.gbCompras.Controls.Add(this.txtPrecioCompra);
            this.gbCompras.Controls.Add(this.label3);
            this.gbCompras.Controls.Add(this.txtProducto);
            this.gbCompras.Controls.Add(this.label2);
            this.gbCompras.Controls.Add(this.txtCodigo);
            this.gbCompras.Controls.Add(this.label1);
            this.gbCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompras.Location = new System.Drawing.Point(167, 2);
            this.gbCompras.Name = "gbCompras";
            this.gbCompras.Size = new System.Drawing.Size(392, 365);
            this.gbCompras.TabIndex = 0;
            this.gbCompras.TabStop = false;
            this.gbCompras.Text = "Nueva Compra";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(178, 318);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 31);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(86, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 31);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSelProducto
            // 
            this.btnSelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelProducto.Location = new System.Drawing.Point(248, 68);
            this.btnSelProducto.Name = "btnSelProducto";
            this.btnSelProducto.Size = new System.Drawing.Size(51, 26);
            this.btnSelProducto.TabIndex = 14;
            this.btnSelProducto.Text = "+";
            this.btnSelProducto.UseVisualStyleBackColor = true;
            this.btnSelProducto.Click += new System.EventHandler(this.btnSelProducto_Click);
            // 
            // checkBFecha
            // 
            this.checkBFecha.AutoSize = true;
            this.checkBFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBFecha.Location = new System.Drawing.Point(33, 215);
            this.checkBFecha.Name = "checkBFecha";
            this.checkBFecha.Size = new System.Drawing.Size(182, 20);
            this.checkBFecha.TabIndex = 13;
            this.checkBFecha.Text = "Aplica Fecha Vencimiento";
            this.checkBFecha.UseVisualStyleBackColor = true;
            this.checkBFecha.CheckedChanged += new System.EventHandler(this.checkBFecha_CheckedChanged);
            // 
            // panelFechaVen
            // 
            this.panelFechaVen.Controls.Add(this.dtpFechaVen);
            this.panelFechaVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFechaVen.Location = new System.Drawing.Point(51, 241);
            this.panelFechaVen.Name = "panelFechaVen";
            this.panelFechaVen.Size = new System.Drawing.Size(200, 60);
            this.panelFechaVen.TabIndex = 12;
            // 
            // dtpFechaVen
            // 
            this.dtpFechaVen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVen.Location = new System.Drawing.Point(35, 17);
            this.dtpFechaVen.Name = "dtpFechaVen";
            this.dtpFechaVen.Size = new System.Drawing.Size(147, 22);
            this.dtpFechaVen.TabIndex = 0;
            this.dtpFechaVen.ValueChanged += new System.EventHandler(this.dtpFechaVen_ValueChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(105, 181);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(128, 22);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(133, 143);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioVenta.TabIndex = 9;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio Venta";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(133, 106);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioCompra.TabIndex = 7;
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            this.txtPrecioCompra.Leave += new System.EventHandler(this.txtPrecioCompra_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio Compra";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(105, 68);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(128, 22);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(105, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vistaProdTableAdapter
            // 
            this.vistaProdTableAdapter.ClearBeforeFill = true;
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
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbCompras";
            this.bindingSource1.DataSource = this.bdSistemVDataSet1;
            // 
            // tbComprasTableAdapter
            // 
            this.tbComprasTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tbDetallCompra";
            this.bindingSource2.DataSource = this.bdSistemVDataSet1;
            // 
            // tbDetallCompraTableAdapter
            // 
            this.tbDetallCompraTableAdapter.ClearBeforeFill = true;
            // 
            // vwComprasTableAdapter
            // 
            this.vwComprasTableAdapter.ClearBeforeFill = true;
            // 
            // moduloCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelP);
            this.Name = "moduloCompras";
            this.Size = new System.Drawing.Size(1197, 758);
            this.panelP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet1)).EndInit();
            this.panelAddProduct.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProdDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).EndInit();
            this.gbCompras.ResumeLayout(false);
            this.gbCompras.PerformLayout();
            this.panelFechaVen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelP;
        private System.Windows.Forms.GroupBox gbCompras;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAddProduct;
        private System.Windows.Forms.CheckBox checkBFecha;
        private System.Windows.Forms.Panel panelFechaVen;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaVen;
        private System.Windows.Forms.Button btnSelProducto;
        private System.Windows.Forms.DataGridView vistaProdDataGridView;
        private System.Windows.Forms.BindingSource vistaProdBindingSource;
        private bdSistemVDataSet bdSistemVDataSet;
        private bdSistemVDataSetTableAdapters.VistaProdTableAdapter vistaProdTableAdapter;
        private bdSistemVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdSistemVDataSet bdSistemVDataSet1;
        private bdSistemVDataSetTableAdapters.tbComprasTableAdapter tbComprasTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private bdSistemVDataSetTableAdapters.tbDetallCompraTableAdapter tbDetallCompraTableAdapter;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView vwComprasDataGridView;
        private System.Windows.Forms.BindingSource vwComprasBindingSource;
        private bdSistemVDataSetTableAdapters.vwComprasTableAdapter vwComprasTableAdapter;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}
