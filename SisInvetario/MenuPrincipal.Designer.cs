namespace SisInvetario
{
    partial class MenuPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelNotificaciones = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNuevaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.inabilitarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.inabilitarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManuStripCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.inabilitarCategoriasToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.inabilitarProductosToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.restablecerContraseñasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inabilitarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msIndicadores = new System.Windows.Forms.ToolStripMenuItem();
            this.rolPermisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdSistemVDataSet = new SisInvetario.bdSistemVDataSet();
            this.tbUsuariosTableAdapter = new SisInvetario.bdSistemVDataSetTableAdapters.tbUsuariosTableAdapter();
            this.panelFondo.SuspendLayout();
            this.panelNotificaciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.panelPrincipal);
            this.panelFondo.Controls.Add(this.panelNotificaciones);
            this.panelFondo.Controls.Add(this.menuStrip1);
            this.panelFondo.Controls.Add(this.panelBotones);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1163, 649);
            this.panelFondo.TabIndex = 2;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 153);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1163, 496);
            this.panelPrincipal.TabIndex = 7;
            // 
            // panelNotificaciones
            // 
            this.panelNotificaciones.BackColor = System.Drawing.SystemColors.Control;
            this.panelNotificaciones.Controls.Add(this.lbltitulo);
            this.panelNotificaciones.Controls.Add(this.panel1);
            this.panelNotificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNotificaciones.Location = new System.Drawing.Point(0, 104);
            this.panelNotificaciones.Name = "panelNotificaciones";
            this.panelNotificaciones.Size = new System.Drawing.Size(1163, 49);
            this.panelNotificaciones.TabIndex = 6;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(0, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(999, 49);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.Rol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(999, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(164, 49);
            this.panel1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(5, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(155, 23);
            this.Nombre.TabIndex = 1;
            // 
            // Rol
            // 
            this.Rol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Rol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.Location = new System.Drawing.Point(5, 22);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(155, 23);
            this.Rol.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInicio,
            this.VentasToolStripMenuItem,
            this.ComprasToolStripMenuItem,
            this.ProductosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.msIndicadores,
            this.notificacionesToolStripMenuItem,
            this.ReportesToolStripMenuItem,
            this.respaldoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 43);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 61);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuInicio
            // 
            this.MenuInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStrip,
            this.salirToolStrip});
            this.MenuInicio.Image = global::SisInvetario.Properties.Resources.inicio32;
            this.MenuInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicio.Name = "MenuInicio";
            this.MenuInicio.Size = new System.Drawing.Size(60, 57);
            this.MenuInicio.Text = "Inicio";
            this.MenuInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInicio.Click += new System.EventHandler(this.MenuInicio_Click);
            // 
            // cerrarSesionToolStrip
            // 
            this.cerrarSesionToolStrip.Name = "cerrarSesionToolStrip";
            this.cerrarSesionToolStrip.Size = new System.Drawing.Size(179, 22);
            this.cerrarSesionToolStrip.Text = "Cerrar Sesion";
            this.cerrarSesionToolStrip.Click += new System.EventHandler(this.cerrarSesionToolStrip_Click);
            // 
            // salirToolStrip
            // 
            this.salirToolStrip.Name = "salirToolStrip";
            this.salirToolStrip.Size = new System.Drawing.Size(179, 22);
            this.salirToolStrip.Text = "Salir";
            this.salirToolStrip.Click += new System.EventHandler(this.salirToolStrip_Click);
            // 
            // VentasToolStripMenuItem
            // 
            this.VentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNuevaVenta,
            this.StripMenuVentas,
            this.inabilitarVentasToolStripMenuItem});
            this.VentasToolStripMenuItem.Image = global::SisInvetario.Properties.Resources.cart32;
            this.VentasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VentasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem";
            this.VentasToolStripMenuItem.Size = new System.Drawing.Size(70, 57);
            this.VentasToolStripMenuItem.Text = "Ventas";
            this.VentasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStripNuevaVenta
            // 
            this.menuStripNuevaVenta.Name = "menuStripNuevaVenta";
            this.menuStripNuevaVenta.Size = new System.Drawing.Size(199, 22);
            this.menuStripNuevaVenta.Text = "Nueva Venta";
            this.menuStripNuevaVenta.Click += new System.EventHandler(this.ejemplo21ToolStripMenuItem_Click_1);
            // 
            // StripMenuVentas
            // 
            this.StripMenuVentas.Name = "StripMenuVentas";
            this.StripMenuVentas.Size = new System.Drawing.Size(199, 22);
            this.StripMenuVentas.Text = "Inabilitar Ventas ";
            this.StripMenuVentas.Click += new System.EventHandler(this.StripMenuVentas_Click);
            // 
            // inabilitarVentasToolStripMenuItem
            // 
            this.inabilitarVentasToolStripMenuItem.Name = "inabilitarVentasToolStripMenuItem";
            this.inabilitarVentasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.inabilitarVentasToolStripMenuItem.Text = "Vista Ventas";
            this.inabilitarVentasToolStripMenuItem.Click += new System.EventHandler(this.inabilitarVentasToolStripMenuItem_Click);
            // 
            // ComprasToolStripMenuItem
            // 
            this.ComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearCompra,
            this.inabilitarCompraToolStripMenuItem});
            this.ComprasToolStripMenuItem.Image = global::SisInvetario.Properties.Resources.Compra32;
            this.ComprasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem";
            this.ComprasToolStripMenuItem.Size = new System.Drawing.Size(86, 57);
            this.ComprasToolStripMenuItem.Text = "Compras";
            this.ComprasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // CrearCompra
            // 
            this.CrearCompra.Name = "CrearCompra";
            this.CrearCompra.Size = new System.Drawing.Size(210, 22);
            this.CrearCompra.Text = "Crear una compra";
            this.CrearCompra.Click += new System.EventHandler(this.CrearCompra_Click);
            // 
            // inabilitarCompraToolStripMenuItem
            // 
            this.inabilitarCompraToolStripMenuItem.Name = "inabilitarCompraToolStripMenuItem";
            this.inabilitarCompraToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.inabilitarCompraToolStripMenuItem.Text = "Inabilitar Compra";
            this.inabilitarCompraToolStripMenuItem.Click += new System.EventHandler(this.inabilitarCompraToolStripMenuItem_Click);
            // 
            // ProductosToolStripMenuItem
            // 
            this.ProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManuStripCategorias,
            this.inabilitarCategoriasToolStrip,
            this.ProductosToolStrip,
            this.inabilitarProductosToolStrip});
            this.ProductosToolStripMenuItem.Image = global::SisInvetario.Properties.Resources.caja32;
            this.ProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            this.ProductosToolStripMenuItem.Size = new System.Drawing.Size(95, 57);
            this.ProductosToolStripMenuItem.Text = "Productos";
            this.ProductosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ManuStripCategorias
            // 
            this.ManuStripCategorias.Name = "ManuStripCategorias";
            this.ManuStripCategorias.Size = new System.Drawing.Size(225, 22);
            this.ManuStripCategorias.Text = "Categorias";
            this.ManuStripCategorias.Click += new System.EventHandler(this.ManuStripCategorias_Click);
            // 
            // inabilitarCategoriasToolStrip
            // 
            this.inabilitarCategoriasToolStrip.Name = "inabilitarCategoriasToolStrip";
            this.inabilitarCategoriasToolStrip.Size = new System.Drawing.Size(225, 22);
            this.inabilitarCategoriasToolStrip.Text = "Inabilitar Categorias";
            this.inabilitarCategoriasToolStrip.Click += new System.EventHandler(this.inabilitarCategoriasToolStrip_Click);
            // 
            // ProductosToolStrip
            // 
            this.ProductosToolStrip.Name = "ProductosToolStrip";
            this.ProductosToolStrip.Size = new System.Drawing.Size(225, 22);
            this.ProductosToolStrip.Text = "Productos";
            this.ProductosToolStrip.Click += new System.EventHandler(this.ProductosToolStrip_Click);
            // 
            // inabilitarProductosToolStrip
            // 
            this.inabilitarProductosToolStrip.Name = "inabilitarProductosToolStrip";
            this.inabilitarProductosToolStrip.Size = new System.Drawing.Size(225, 22);
            this.inabilitarProductosToolStrip.Text = "Inabilitar Productos";
            this.inabilitarProductosToolStrip.Click += new System.EventHandler(this.inabilitarProductosToolStrip_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStrip,
            this.movimientoToolStrip,
            this.ajusteToolStripMenuItem});
            this.inventarioToolStripMenuItem.Image = global::SisInvetario.Properties.Resources.lista32;
            this.inventarioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.inventarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(94, 57);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // inventarioToolStrip
            // 
            this.inventarioToolStrip.Name = "inventarioToolStrip";
            this.inventarioToolStrip.Size = new System.Drawing.Size(162, 22);
            this.inventarioToolStrip.Text = "Inventario";
            this.inventarioToolStrip.Click += new System.EventHandler(this.inventarioToolStrip_Click);
            // 
            // movimientoToolStrip
            // 
            this.movimientoToolStrip.Name = "movimientoToolStrip";
            this.movimientoToolStrip.Size = new System.Drawing.Size(162, 22);
            this.movimientoToolStrip.Text = "Movimiento ";
            this.movimientoToolStrip.Click += new System.EventHandler(this.movimientoToolStrip_Click);
            // 
            // ajusteToolStripMenuItem
            // 
            this.ajusteToolStripMenuItem.Name = "ajusteToolStripMenuItem";
            this.ajusteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ajusteToolStripMenuItem.Text = "Ajuste";
            this.ajusteToolStripMenuItem.Click += new System.EventHandler(this.ajusteToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smUsuarios,
            this.restablecerContraseñasToolStripMenuItem,
            this.inabilitarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = global::SisInvetario.Properties.Resources.usuario32;
            this.usuariosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.usuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(85, 57);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // smUsuarios
            // 
            this.smUsuarios.Name = "smUsuarios";
            this.smUsuarios.Size = new System.Drawing.Size(262, 22);
            this.smUsuarios.Text = "Usuarios";
            this.smUsuarios.Click += new System.EventHandler(this.smUsuarios_Click);
            // 
            // restablecerContraseñasToolStripMenuItem
            // 
            this.restablecerContraseñasToolStripMenuItem.Name = "restablecerContraseñasToolStripMenuItem";
            this.restablecerContraseñasToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.restablecerContraseñasToolStripMenuItem.Text = "Restablecer Contraseñas";
            // 
            // inabilitarUsuariosToolStripMenuItem
            // 
            this.inabilitarUsuariosToolStripMenuItem.Name = "inabilitarUsuariosToolStripMenuItem";
            this.inabilitarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.inabilitarUsuariosToolStripMenuItem.Text = "Inabilitar Usuarios";
            // 
            // msIndicadores
            // 
            this.msIndicadores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolPermisoToolStripMenuItem});
            this.msIndicadores.Image = global::SisInvetario.Properties.Resources.dashboard32;
            this.msIndicadores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.msIndicadores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msIndicadores.Name = "msIndicadores";
            this.msIndicadores.Size = new System.Drawing.Size(100, 57);
            this.msIndicadores.Text = "Dashboard";
            this.msIndicadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // rolPermisoToolStripMenuItem
            // 
            this.rolPermisoToolStripMenuItem.Name = "rolPermisoToolStripMenuItem";
            this.rolPermisoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolPermisoToolStripMenuItem.Text = "General";
            this.rolPermisoToolStripMenuItem.Click += new System.EventHandler(this.rolPermisoToolStripMenuItem_Click_1);
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Image = global::SisInvetario.Properties.Resources.notificaciones32;
            this.notificacionesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.notificacionesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(124, 57);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            this.notificacionesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.notificacionesToolStripMenuItem.Click += new System.EventHandler(this.notificacionesToolStripMenuItem_Click);
            // 
            // ReportesToolStripMenuItem
            // 
            this.ReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteVentasToolStripMenuItem,
            this.reporteComprasToolStripMenuItem,
            this.reporteDeMovimientosToolStripMenuItem});
            this.ReportesToolStripMenuItem.Image = global::SisInvetario.Properties.Resources.reporte32;
            this.ReportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem";
            this.ReportesToolStripMenuItem.Size = new System.Drawing.Size(87, 57);
            this.ReportesToolStripMenuItem.Text = "Reportes";
            this.ReportesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReportesToolStripMenuItem.Click += new System.EventHandler(this.ReportesToolStripMenuItem_Click);
            // 
            // reporteVentasToolStripMenuItem
            // 
            this.reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            this.reporteVentasToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.reporteVentasToolStripMenuItem.Text = "Reporte Ventas";
            // 
            // reporteComprasToolStripMenuItem
            // 
            this.reporteComprasToolStripMenuItem.Name = "reporteComprasToolStripMenuItem";
            this.reporteComprasToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.reporteComprasToolStripMenuItem.Text = "Reporte Compras";
            // 
            // reporteDeMovimientosToolStripMenuItem
            // 
            this.reporteDeMovimientosToolStripMenuItem.Name = "reporteDeMovimientosToolStripMenuItem";
            this.reporteDeMovimientosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.reporteDeMovimientosToolStripMenuItem.Text = "Reporte de Movimientos";
            this.reporteDeMovimientosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeMovimientosToolStripMenuItem_Click);
            // 
            // respaldoToolStripMenuItem
            // 
            this.respaldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaDeSeguridadToolStripMenuItem});
            this.respaldoToolStripMenuItem.Image = global::SisInvetario.Properties.Resources.copia_de_seguridad32;
            this.respaldoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.respaldoToolStripMenuItem.Name = "respaldoToolStripMenuItem";
            this.respaldoToolStripMenuItem.Size = new System.Drawing.Size(88, 57);
            this.respaldoToolStripMenuItem.Text = "Respaldo";
            this.respaldoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // copiaDeSeguridadToolStripMenuItem
            // 
            this.copiaDeSeguridadToolStripMenuItem.Name = "copiaDeSeguridadToolStripMenuItem";
            this.copiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.copiaDeSeguridadToolStripMenuItem.Text = "Copia de Seguridad";
            this.copiaDeSeguridadToolStripMenuItem.Click += new System.EventHandler(this.copiaDeSeguridadToolStripMenuItem_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.panelBotones.Controls.Add(this.btnMin);
            this.panelBotones.Controls.Add(this.btnMax);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1163, 43);
            this.panelBotones.TabIndex = 0;
            this.panelBotones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBotones_MouseDown);
            this.panelBotones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBotones_MouseMove);
            this.panelBotones.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBotones_MouseUp);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::SisInvetario.Properties.Resources.min;
            this.btnMin.Location = new System.Drawing.Point(1012, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 35);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::SisInvetario.Properties.Resources.max;
            this.btnMax.Location = new System.Drawing.Point(1062, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 35);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::SisInvetario.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(1112, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbUsuarios";
            this.bindingSource1.DataSource = this.bdSistemVDataSet;
            // 
            // bdSistemVDataSet
            // 
            this.bdSistemVDataSet.DataSetName = "bdSistemVDataSet";
            this.bdSistemVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuariosTableAdapter
            // 
            this.tbUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 649);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelFondo.ResumeLayout(false);
            this.panelNotificaciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSistemVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripNuevaVenta;
        private System.Windows.Forms.ToolStripMenuItem ComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CrearCompra;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManuStripCategorias;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStrip;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStrip;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ajusteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msIndicadores;
        private System.Windows.Forms.ToolStripMenuItem rolPermisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuInicio;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStrip;
        private System.Windows.Forms.Panel panelNotificaciones;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.ToolStripMenuItem salirToolStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuVentas;
        private System.Windows.Forms.ToolStripMenuItem inabilitarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inabilitarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inabilitarCategoriasToolStrip;
        private System.Windows.Forms.ToolStripMenuItem inabilitarProductosToolStrip;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smUsuarios;
        private System.Windows.Forms.ToolStripMenuItem restablecerContraseñasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inabilitarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdSistemVDataSet bdSistemVDataSet;
        private bdSistemVDataSetTableAdapters.tbUsuariosTableAdapter tbUsuariosTableAdapter;
        private System.Windows.Forms.Label lbltitulo;
    }
}

