namespace SisInvetario.Presentacion
{
    partial class ModuloProductos
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label precio_VentaLabel;
            System.Windows.Forms.Label stock_MínimoLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StockMin = new System.Windows.Forms.NumericUpDown();
            this.checkBFecha = new System.Windows.Forms.CheckBox();
            this.Existencia = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFechaVen = new System.Windows.Forms.Panel();
            this.dtpFechaVen = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdSistemVDataSet = new SisInvetario.bdSistemVDataSet();
            this.visRegProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.visRegProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visRegProdutoTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.VisRegProdutoTableAdapter();
            this.tableAdapterManager = new SisInvetario.bdSistemVDataSetTableAdapters.TableAdapterManager();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductosTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.tbProductosTableAdapter();
            this.tbCategoriaTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.tbCategoriaTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_VenAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            precio_VentaLabel = new System.Windows.Forms.Label();
            stock_MínimoLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia)).BeginInit();
            this.panelFechaVen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visRegProdutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visRegProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(47, 52);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(63, 20);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(47, 94);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(96, 20);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // precio_VentaLabel
            // 
            precio_VentaLabel.AutoSize = true;
            precio_VentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio_VentaLabel.Location = new System.Drawing.Point(373, 46);
            precio_VentaLabel.Name = "precio_VentaLabel";
            precio_VentaLabel.Size = new System.Drawing.Size(82, 20);
            precio_VentaLabel.TabIndex = 6;
            precio_VentaLabel.Text = "Categoria:";
            // 
            // stock_MínimoLabel
            // 
            stock_MínimoLabel.AutoSize = true;
            stock_MínimoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stock_MínimoLabel.Location = new System.Drawing.Point(373, 127);
            stock_MínimoLabel.Name = "stock_MínimoLabel";
            stock_MínimoLabel.Size = new System.Drawing.Size(108, 20);
            stock_MínimoLabel.TabIndex = 8;
            stock_MínimoLabel.Text = "Stock Mínimo:";
            stock_MínimoLabel.Click += new System.EventHandler(this.stock_MínimoLabel_Click);
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.Location = new System.Drawing.Point(373, 127);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(0, 20);
            categoriaLabel.TabIndex = 10;
            categoriaLabel.Click += new System.EventHandler(this.categoriaLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(373, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 20);
            label1.TabIndex = 25;
            label1.Text = "Existencia:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.visRegProdutoDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 649);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StockMin);
            this.groupBox1.Controls.Add(this.checkBFecha);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.Existencia);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panelFechaVen);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(precio_VentaLabel);
            this.groupBox1.Controls.Add(stock_MínimoLabel);
            this.groupBox1.Controls.Add(categoriaLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(197, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Productos";
            // 
            // StockMin
            // 
            this.StockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockMin.Location = new System.Drawing.Point(488, 126);
            this.StockMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StockMin.Name = "StockMin";
            this.StockMin.Size = new System.Drawing.Size(91, 24);
            this.StockMin.TabIndex = 27;
            this.StockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StockMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBFecha
            // 
            this.checkBFecha.AutoSize = true;
            this.checkBFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBFecha.Location = new System.Drawing.Point(377, 169);
            this.checkBFecha.Name = "checkBFecha";
            this.checkBFecha.Size = new System.Drawing.Size(182, 20);
            this.checkBFecha.TabIndex = 26;
            this.checkBFecha.Text = "Aplica Fecha Vencimiento";
            this.checkBFecha.UseVisualStyleBackColor = true;
            // 
            // Existencia
            // 
            this.Existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existencia.Location = new System.Drawing.Point(487, 90);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(92, 24);
            this.Existencia.TabIndex = 24;
            this.Existencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(149, 173);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(172, 26);
            this.txtPrecioVenta.TabIndex = 23;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Precio Venta";
            // 
            // panelFechaVen
            // 
            this.panelFechaVen.Controls.Add(this.dtpFechaVen);
            this.panelFechaVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFechaVen.Location = new System.Drawing.Point(451, 195);
            this.panelFechaVen.Name = "panelFechaVen";
            this.panelFechaVen.Size = new System.Drawing.Size(200, 60);
            this.panelFechaVen.TabIndex = 21;
            // 
            // dtpFechaVen
            // 
            this.dtpFechaVen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVen.Location = new System.Drawing.Point(35, 17);
            this.dtpFechaVen.Name = "dtpFechaVen";
            this.dtpFechaVen.Size = new System.Drawing.Size(122, 22);
            this.dtpFechaVen.TabIndex = 0;
            this.dtpFechaVen.ValueChanged += new System.EventHandler(this.dtpFechaVen_ValueChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(75, 256);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 36);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(149, 92);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(172, 69);
            this.txtdescripcion.TabIndex = 18;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(149, 50);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(162, 24);
            this.txtcodigo.TabIndex = 17;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(277, 256);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 36);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(176, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 36);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataSource = this.bindingSource1;
            this.cbCategoria.DisplayMember = "Nombre";
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(487, 46);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 28);
            this.cbCategoria.TabIndex = 14;
            this.cbCategoria.ValueMember = "idCategoria";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbCategoria";
            this.bindingSource1.DataSource = this.bdSistemVDataSet;
            // 
            // bdSistemVDataSet
            // 
            this.bdSistemVDataSet.DataSetName = "bdSistemVDataSet";
            this.bdSistemVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visRegProdutoDataGridView
            // 
            this.visRegProdutoDataGridView.AllowUserToAddRows = false;
            this.visRegProdutoDataGridView.AllowUserToDeleteRows = false;
            this.visRegProdutoDataGridView.AutoGenerateColumns = false;
            this.visRegProdutoDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.visRegProdutoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visRegProdutoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.visRegProdutoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visRegProdutoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.visRegProdutoDataGridView.ColumnHeadersHeight = 41;
            this.visRegProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Precio_Venta,
            this.Stock,
            this.StockMinimo,
            this.Fecha_VenAc,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.visRegProdutoDataGridView.DataSource = this.visRegProdutoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.visRegProdutoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.visRegProdutoDataGridView.EnableHeadersVisualStyles = false;
            this.visRegProdutoDataGridView.Location = new System.Drawing.Point(91, 363);
            this.visRegProdutoDataGridView.Name = "visRegProdutoDataGridView";
            this.visRegProdutoDataGridView.ReadOnly = true;
            this.visRegProdutoDataGridView.RowHeadersVisible = false;
            this.visRegProdutoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visRegProdutoDataGridView.Size = new System.Drawing.Size(912, 200);
            this.visRegProdutoDataGridView.TabIndex = 0;
            this.visRegProdutoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visRegProdutoDataGridView_CellContentClick);
            // 
            // visRegProdutoBindingSource
            // 
            this.visRegProdutoBindingSource.DataMember = "VisRegProduto";
            this.visRegProdutoBindingSource.DataSource = this.bdSistemVDataSet;
            // 
            // visRegProdutoTableAdapter
            // 
            this.visRegProdutoTableAdapter.ClearBeforeFill = true;
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
            // bindingSource
            // 
            this.bindingSource.DataMember = "tbProductos";
            this.bindingSource.DataSource = this.bdSistemVDataSet;
            // 
            // tbProductosTableAdapter
            // 
            this.tbProductosTableAdapter.ClearBeforeFill = true;
            // 
            // tbCategoriaTableAdapter
            // 
            this.tbCategoriaTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.DataPropertyName = "Precio_Venta";
            this.Precio_Venta.HeaderText = "Precio Venta";
            this.Precio_Venta.Name = "Precio_Venta";
            this.Precio_Venta.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // StockMinimo
            // 
            this.StockMinimo.DataPropertyName = "StockMinimo";
            this.StockMinimo.HeaderText = "Stock Minimo";
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.ReadOnly = true;
            // 
            // Fecha_VenAc
            // 
            this.Fecha_VenAc.DataPropertyName = "Fecha_VenAc";
            this.Fecha_VenAc.HeaderText = "Fecha Vencimiento";
            this.Fecha_VenAc.Name = "Fecha_VenAc";
            this.Fecha_VenAc.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn6.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // ModuloProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ModuloProductos";
            this.Size = new System.Drawing.Size(1053, 649);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia)).EndInit();
            this.panelFechaVen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visRegProdutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visRegProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource visRegProdutoBindingSource;
        private bdSistemVDataSet bdSistemVDataSet;
        private System.Windows.Forms.DataGridView visRegProdutoDataGridView;
        private bdSistemVDataSetTableAdapters.VisRegProdutoTableAdapter visRegProdutoTableAdapter;
        private bdSistemVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.BindingSource bindingSource;
        private bdSistemVDataSetTableAdapters.tbProductosTableAdapter tbProductosTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdSistemVDataSetTableAdapters.tbCategoriaTableAdapter tbCategoriaTableAdapter;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panelFechaVen;
        private System.Windows.Forms.DateTimePicker dtpFechaVen;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Existencia;
        private System.Windows.Forms.NumericUpDown StockMin;
        private System.Windows.Forms.CheckBox checkBFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_VenAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
