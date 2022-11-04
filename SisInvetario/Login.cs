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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        //  Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdSistemVDataSet1.tbPermisos' Puede moverla o quitarla según sea necesario.
          //  this.tbPermisosTableAdapter.Fill(this.bdSistemVDataSet1.tbPermisos);
            // TODO: esta línea de código carga datos en la tabla 'bdSistemVDataSet1.tbUsuarios' Puede moverla o quitarla según sea necesario.
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                this.tbUsuariosTableAdapter.pLogin(txtUsuario.Text, txtContra.Text, out int? cod, out int? idUser, out string nombre,
                out string apellido);


                Datos.Variables.User = txtUsuario.Text;
                Datos.Variables.idUsuario = Convert.ToInt32(idUser);
                Datos.Variables.Nombre = nombre;
                Datos.Variables.Apellido = apellido;
                //MessageBox.Show((cod>0)? "Usuario Existe":"Credenciales incorrectas");




                if (cod > 0)
                {
                    this.obtenerPermisosTableAdapter.Fill(this.bdSistemVDataSet1.ObtenerPermisos, cod);


                    Datos.Variables.Rol = bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Rol"].ToString();
                    Datos.Variables.Ventas = Convert.ToBoolean(bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Ventas"]);
                    Datos.Variables.Compras = Convert.ToBoolean(bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Compras"]);
                    Datos.Variables.Productos = Convert.ToBoolean(bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Productos"]);
                    Datos.Variables.Inventarios = Convert.ToBoolean(bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Inventario"]);
                    Datos.Variables.Usuarios = Convert.ToBoolean(bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Usuarios"]);
                    Datos.Variables.Dashboard = Convert.ToBoolean(bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Dashboard"]);
                    Datos.Variables.Reportes = Convert.ToBoolean(bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Reportes"]);
                    Datos.Variables.Bitacora = Convert.ToBoolean(bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Bitacora"]);
                    Datos.Variables.Respaldo = Convert.ToBoolean(bdSistemVDataSet1.Tables["ObtenerPermisos"].Rows[0]["Respaldo"]);

                    // MessageBox.Show(""+ Datos.Variables.Rol);



                    this.Hide();
                    MenuPrincipal menuPrin = new MenuPrincipal();
                    menuPrin.ShowDialog();

                }
                else
                {
                   
                    MessageBox.Show("Usuario o Contraseñas Incorrectas", " Error de Inicio Sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
           
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "CONTRASEÑA")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "CONTRASEÑA";
                txtContra.ForeColor = Color.Black;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
