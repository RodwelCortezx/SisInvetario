namespace SisInvetario
{
    partial class Admin
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMantenedor = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(419, 317);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(189, 154);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnMantenedor
            // 
            this.btnMantenedor.Location = new System.Drawing.Point(626, 317);
            this.btnMantenedor.Name = "btnMantenedor";
            this.btnMantenedor.Size = new System.Drawing.Size(189, 154);
            this.btnMantenedor.TabIndex = 5;
            this.btnMantenedor.Text = "Mantenedor";
            this.btnMantenedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMantenedor.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Image = global::SisInvetario.Properties.Resources.inventario;
            this.btnInventario.Location = new System.Drawing.Point(626, 105);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(189, 170);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.Image = global::SisInvetario.Properties.Resources.Productos;
            this.Productos.Location = new System.Drawing.Point(185, 317);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(189, 166);
            this.Productos.TabIndex = 2;
            this.Productos.Text = "Productos";
            this.Productos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Productos.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Image = global::SisInvetario.Properties.Resources.comprass;
            this.btnCompras.Location = new System.Drawing.Point(419, 105);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(189, 170);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "Compras ";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Image = global::SisInvetario.Properties.Resources.carrito;
            this.btnVentas.Location = new System.Drawing.Point(185, 105);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(189, 170);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMantenedor);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnVentas);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(995, 632);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnMantenedor;
    }
}
