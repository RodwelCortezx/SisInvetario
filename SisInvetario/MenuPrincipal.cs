using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SisInvetario
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            VentasToolStripMenuItem.Enabled = Datos.Variables.Ventas;
            ComprasToolStripMenuItem.Enabled = Datos.Variables.Compras;
            ProductosToolStripMenuItem.Enabled = Datos.Variables.Productos;
            inventarioToolStripMenuItem.Enabled = Datos.Variables.Inventarios;
            usuariosToolStripMenuItem.Enabled = Datos.Variables.Usuarios;
            msIndicadores.Enabled = Datos.Variables.Dashboard;
            ReportesToolStripMenuItem.Enabled = Datos.Variables.Reportes;
            respaldoToolStripMenuItem.Enabled = Datos.Variables.Respaldo;

            Rol.Text = Datos.Variables.Rol;
            Nombre.Text = Datos.Variables.Nombre + " " + Datos.Variables.Apellido;
        }
        private void ejempplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void ejemplo21ToolStripMenuItem_Click(object sender, EventArgs e)
        {      
        }
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }
        private void rolPermisoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ejemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ejemploo33ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }
        private void registrarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void catalogoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ejemplo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        public void addformularios(Form f)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(f);
            f.Show();
        }

        public void Mostrarformularios(UserControl f)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            
            f.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(f);

        }


        private void btnAddVentas_Click(object sender, EventArgs e)
        { 
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdSistemVDataSet.tbUsuarios' Puede moverla o quitarla según sea necesario.
            this.tbUsuariosTableAdapter.Fill(this.bdSistemVDataSet.tbUsuarios);

        }
        private void btnConsola_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminarPro_Click(object sender, EventArgs e)
        {
          
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ejemplo21ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Presentacion.ModuloVentas rVentas = new Presentacion.ModuloVentas();
            Mostrarformularios(rVentas);
            lbltitulo.Text = "Modulo Ventas";
        }

        private void CrearCompra_Click(object sender, EventArgs e)
        {
            Presentacion.moduloCompras compras = new Presentacion.moduloCompras();
            Mostrarformularios(compras);
            lbltitulo.Text = "Modulo Compras";
        }

        private void ManuStripCategorias_Click(object sender, EventArgs e)
        {
            Presentacion.Categoria categoria = new Presentacion.Categoria();
            Mostrarformularios(categoria);
            lbltitulo.Text = "Modulo Categoria";
        }

        private void ProductosToolStrip_Click(object sender, EventArgs e)
        {
            Presentacion.ModuloProductos productos = new Presentacion.ModuloProductos();
            Mostrarformularios(productos);
            lbltitulo.Text = "Modulo Productos";
        }

        private void movimientoToolStrip_Click(object sender, EventArgs e)
        {
            Presentacion.moduloMovimientos movi = new Presentacion.moduloMovimientos();
            Mostrarformularios(movi);
            lbltitulo.Text = "Historial de Movimientos";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.tbUsuariosTableAdapter.CerrarSesion(Datos.Variables.idUsuario);
            //Application.Exit();
            this.Close();

        }
        bool mover = false;
        private void panelBotones_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
        }

        private void panelBotones_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panelBotones_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void StripMenuVentas_Click(object sender, EventArgs e)
        {
            Presentacion.visVentas ventas = new Presentacion.visVentas();
            Mostrarformularios(ventas);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inabilitarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.InabilitarVentas inVen = new Presentacion.InabilitarVentas();
            Mostrarformularios(inVen);
        }

        private void inabilitarProductosToolStrip_Click(object sender, EventArgs e)
        {
            Presentacion.InabilitarProducto inProduct = new Presentacion.InabilitarProducto();
            Mostrarformularios(inProduct);
        }

        private void inabilitarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.InabilitarCompras inCompra = new Presentacion.InabilitarCompras();
            Mostrarformularios(inCompra);
        }

        private void inabilitarCategoriasToolStrip_Click(object sender, EventArgs e)
        {
            Presentacion.InabilitarCategoria inCategorias = new Presentacion.InabilitarCategoria(); 
            Mostrarformularios(inCategorias);
        }

        private void salirToolStrip_Click(object sender, EventArgs e)
        {
            this.tbUsuariosTableAdapter.CerrarSesion(Datos.Variables.idUsuario);
            this.Close();

        }

        private void productosMasVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inventarioToolStrip_Click(object sender, EventArgs e)
        {
            Presentacion.ModuloInventario inventario = new Presentacion.ModuloInventario(); 
            Mostrarformularios(inventario);
            lbltitulo.Text = "Inventario";
        }

        private void reporteDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteMovimientos repMov = new Reportes.ReporteMovimientos();
            Mostrarformularios(repMov);
            lbltitulo.Text = "Reportes";

        }

        private void smUsuarios_Click(object sender, EventArgs e)
        {
            Presentacion.UsuariosPermisos user = new Presentacion.UsuariosPermisos();
            Mostrarformularios(user);
            lbltitulo.Text = "Usuarios";
        }

        private void rolPermisoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Presentacion.Dashboard dashboard = new Presentacion.Dashboard();
            Mostrarformularios(dashboard);
            lbltitulo.Text = "Dashboard";
        }

        private void usuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Notificaciones not = new Presentacion.Notificaciones();
            Mostrarformularios(not);
            lbltitulo.Text = "Modulo de Notificaciones";
        }

        private void ajusteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.AjusteInventario ajuste = new Presentacion.AjusteInventario();
            Mostrarformularios(ajuste);
            lbltitulo.Text = "Modulo de Ajuste de Inventario";

        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStrip_Click(object sender, EventArgs e)
        {
            this.tbUsuariosTableAdapter.CerrarSesion(Datos.Variables.idUsuario);

             
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void MenuInicio_Click(object sender, EventArgs e)
        {
             
        }

        private void copiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\backup\seguridad.bat");
                MessageBox.Show("Backup Realizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
