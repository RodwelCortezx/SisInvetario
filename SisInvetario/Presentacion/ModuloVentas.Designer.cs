namespace SisInvetario.Presentacion
{
    partial class ModuloVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbBuscarventas = new System.Windows.Forms.GroupBox();
            this.btnActualizarVenta = new System.Windows.Forms.Button();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.Descuento = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCan = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalV = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgAddVentas = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuentoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdSistemVDataSet = new SisInvetario.bdSistemVDataSet();
            this.tbVentasTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.tbVentasTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbDetallVentasTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.tbDetallVentasTableAdapter();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductosTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.tbProductosTableAdapter();
            this.lblCodigoVenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBuscarventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCan)).BeginInit();
            this.gbTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarventas
            // 
            this.gbBuscarventas.Controls.Add(this.btnActualizarVenta);
            this.gbBuscarventas.Controls.Add(this.lblDescuento);
            this.gbBuscarventas.Controls.Add(this.Descuento);
            this.gbBuscarventas.Controls.Add(this.btnAdd);
            this.gbBuscarventas.Controls.Add(this.label6);
            this.gbBuscarventas.Controls.Add(this.label5);
            this.gbBuscarventas.Controls.Add(this.label4);
            this.gbBuscarventas.Controls.Add(this.label3);
            this.gbBuscarventas.Controls.Add(this.numCan);
            this.gbBuscarventas.Controls.Add(this.txtPrecio);
            this.gbBuscarventas.Controls.Add(this.txtDescri);
            this.gbBuscarventas.Controls.Add(this.txtCod);
            this.gbBuscarventas.Controls.Add(this.btnAgregarP);
            this.gbBuscarventas.Controls.Add(this.groupBox2);
            this.gbBuscarventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarventas.Location = new System.Drawing.Point(183, 20);
            this.gbBuscarventas.Margin = new System.Windows.Forms.Padding(4);
            this.gbBuscarventas.Name = "gbBuscarventas";
            this.gbBuscarventas.Padding = new System.Windows.Forms.Padding(4);
            this.gbBuscarventas.Size = new System.Drawing.Size(661, 224);
            this.gbBuscarventas.TabIndex = 0;
            this.gbBuscarventas.TabStop = false;
            this.gbBuscarventas.Text = "Datos Productos ";
            // 
            // btnActualizarVenta
            // 
            this.btnActualizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVenta.Location = new System.Drawing.Point(499, 160);
            this.btnActualizarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarVenta.Name = "btnActualizarVenta";
            this.btnActualizarVenta.Size = new System.Drawing.Size(85, 27);
            this.btnActualizarVenta.TabIndex = 21;
            this.btnActualizarVenta.Text = "Actualizar";
            this.btnActualizarVenta.UseVisualStyleBackColor = true;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(478, 39);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(80, 18);
            this.lblDescuento.TabIndex = 20;
            this.lblDescuento.Text = "Descuento";
            // 
            // Descuento
            // 
            this.Descuento.DecimalPlaces = 2;
            this.Descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuento.Location = new System.Drawing.Point(471, 60);
            this.Descuento.Name = "Descuento";
            this.Descuento.Size = new System.Drawing.Size(113, 24);
            this.Descuento.TabIndex = 19;
            this.Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(499, 127);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 27);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo";
            // 
            // numCan
            // 
            this.numCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCan.Location = new System.Drawing.Point(316, 128);
            this.numCan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCan.Name = "numCan";
            this.numCan.Size = new System.Drawing.Size(71, 24);
            this.numCan.TabIndex = 13;
            this.numCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCan.ValueChanged += new System.EventHandler(this.numCan_ValueChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(316, 60);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(122, 24);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescri
            // 
            this.txtDescri.Enabled = false;
            this.txtDescri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescri.Location = new System.Drawing.Point(87, 122);
            this.txtDescri.Multiline = true;
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(156, 81);
            this.txtDescri.TabIndex = 5;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(87, 60);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(144, 24);
            this.txtCod.TabIndex = 4;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.Image = global::SisInvetario.Properties.Resources.addCart3;
            this.btnAgregarP.Location = new System.Drawing.Point(250, 122);
            this.btnAgregarP.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(44, 44);
            this.btnAgregarP.TabIndex = 3;
            this.btnAgregarP.Text = "+";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(892, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(191, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.label1);
            this.gbTotal.Controls.Add(this.lblTotalV);
            this.gbTotal.Controls.Add(this.btnGuardar);
            this.gbTotal.Controls.Add(this.groupBox4);
            this.gbTotal.Location = new System.Drawing.Point(891, 147);
            this.gbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Padding = new System.Windows.Forms.Padding(4);
            this.gbTotal.Size = new System.Drawing.Size(192, 202);
            this.gbTotal.TabIndex = 2;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Q";
            // 
            // lblTotalV
            // 
            this.lblTotalV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalV.Location = new System.Drawing.Point(61, 53);
            this.lblTotalV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalV.Name = "lblTotalV";
            this.lblTotalV.Size = new System.Drawing.Size(89, 36);
            this.lblTotalV.TabIndex = 2;
            this.lblTotalV.Text = "0.00";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(28, 144);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Realizar Venta";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(892, 160);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(191, 249);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dgAddVentas
            // 
            this.dgAddVentas.AllowUserToAddRows = false;
            this.dgAddVentas.AllowUserToDeleteRows = false;
            this.dgAddVentas.AllowUserToResizeColumns = false;
            this.dgAddVentas.AllowUserToResizeRows = false;
            this.dgAddVentas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAddVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAddVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgAddVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAddVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgAddVentas.ColumnHeadersHeight = 40;
            this.dgAddVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Descripcion,
            this.Cantidad,
            this.Venta,
            this.Importe,
            this.Descuentoo,
            this.btnQuitar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAddVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgAddVentas.EnableHeadersVisualStyles = false;
            this.dgAddVentas.Location = new System.Drawing.Point(133, 252);
            this.dgAddVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgAddVentas.Name = "dgAddVentas";
            this.dgAddVentas.ReadOnly = true;
            this.dgAddVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgAddVentas.RowHeadersVisible = false;
            this.dgAddVentas.RowTemplate.Height = 35;
            this.dgAddVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAddVentas.Size = new System.Drawing.Size(750, 289);
            this.dgAddVentas.TabIndex = 3;
            this.dgAddVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAddVentas_CellContentClick);
            this.dgAddVentas.Click += new System.EventHandler(this.dgAddVentas_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Desripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 90;
            // 
            // Venta
            // 
            this.Venta.HeaderText = "Precio Venta";
            this.Venta.Name = "Venta";
            this.Venta.ReadOnly = true;
            // 
            // Importe
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle5;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Descuentoo
            // 
            this.Descuentoo.HeaderText = "Descuento";
            this.Descuentoo.Name = "Descuentoo";
            this.Descuentoo.ReadOnly = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.HeaderText = "Quitar";
            this.btnQuitar.Image = global::SisInvetario.Properties.Resources.eliminar;
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbVentas";
            this.bindingSource1.DataSource = this.bdSistemVDataSet;
            // 
            // bdSistemVDataSet
            // 
            this.bdSistemVDataSet.DataSetName = "bdSistemVDataSet";
            this.bdSistemVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbVentasTableAdapter
            // 
            this.tbVentasTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tbDetallVentas";
            this.bindingSource2.DataSource = this.bdSistemVDataSet;
            // 
            // tbDetallVentasTableAdapter
            // 
            this.tbDetallVentasTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "tbProductos";
            this.bindingSource3.DataSource = this.bdSistemVDataSet;
            // 
            // tbProductosTableAdapter
            // 
            this.tbProductosTableAdapter.ClearBeforeFill = true;
            // 
            // lblCodigoVenta
            // 
            this.lblCodigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVenta.Location = new System.Drawing.Point(971, 99);
            this.lblCodigoVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoVenta.Name = "lblCodigoVenta";
            this.lblCodigoVenta.Size = new System.Drawing.Size(139, 39);
            this.lblCodigoVenta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(887, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo:";
            // 
            // ModuloVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigoVenta);
            this.Controls.Add(this.dgAddVentas);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.gbBuscarventas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModuloVentas";
            this.Size = new System.Drawing.Size(1266, 669);
            this.Load += new System.EventHandler(this.usConVentas_Load);
            this.gbBuscarventas.ResumeLayout(false);
            this.gbBuscarventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCan)).EndInit();
            this.gbTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAddVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarventas;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dgAddVentas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdSistemVDataSet bdSistemVDataSet;
        private bdSistemVDataSetTableAdapters.tbVentasTableAdapter tbVentasTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private bdSistemVDataSetTableAdapters.tbDetallVentasTableAdapter tbDetallVentasTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource3;
        private bdSistemVDataSetTableAdapters.tbProductosTableAdapter tbProductosTableAdapter;
        public System.Windows.Forms.Label lblTotalV;
        public System.Windows.Forms.Label lblCodigoVenta;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.TextBox txtDescri;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCan;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown Descuento;
        public System.Windows.Forms.Button btnActualizarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuentoo;
        private System.Windows.Forms.DataGridViewImageColumn btnQuitar;
    }
}
