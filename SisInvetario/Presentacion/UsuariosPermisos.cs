using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisInvetario.Presentacion
{
    public partial class UsuariosPermisos : UserControl
    {

          int idPermisos;
          int idUsuario;

        public UsuariosPermisos()
        {
            InitializeComponent();
            this.panelEstado.Visible = false;
            this.vwUsuariosTableAdapter.Fill(this.bdSistemVDataSet.vwUsuarios);
            btnNuevo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            bool? ventas = checkVentas.Checked;
            bool? compras = checkCompras.Checked;
            bool? productos = checkProductos.Checked;
            bool? inventarios = checkInventarios.Checked;
            bool? usuarios = checkUsuarios.Checked;
            bool? dashboard = checkDashboard.Checked;
            bool? reportes = checkReportes.Checked;
            bool? respaldo = checkRespaldo.Checked;



            try
            {
                if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtRol.Text == "" || txtUsuario.Text == "")
                {
                    MessageBox.Show("LLene todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.tbPermisosTableAdapter.insertarRolPermisos(txtRol.Text, ventas.Value, compras.Value, productos.Value,
                    inventarios.Value, usuarios.Value, dashboard.Value, reportes.Value, false, respaldo.Value);

                    if (txtContra.Text == txtContraConf.Text)
                    {

                        this.tbPermisosTableAdapter.ObteberIdPermisos(out int? idPermiso);

                        this.tbUsuariosTableAdapter.insertarUsuario(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtApellido.Text, txtUsuario.Text,
                                                                txtContra.Text, idPermiso);

                        MessageBox.Show("Usuario Registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {

                        MessageBox.Show("Las contraseñas no coninciden", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vwUsuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Convert.ToInt32(vistaProdDataGridView.CurrentRow.Cells[0].Value.ToString()); 

            panelEstado.Visible = true;
            
            idUsuario = Convert.ToInt32(vwUsuariosDataGridView.CurrentRow.Cells[0].Value);
            txtCodigo.Text = vwUsuariosDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = vwUsuariosDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = vwUsuariosDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtUsuario.Text = vwUsuariosDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtRol.Text = vwUsuariosDataGridView.CurrentRow.Cells[7].Value.ToString();

            checkVentas.Checked = Convert.ToBoolean( vwUsuariosDataGridView.CurrentRow.Cells[8].Value);
            checkCompras.Checked = Convert.ToBoolean(vwUsuariosDataGridView.CurrentRow.Cells[9].Value);
            checkProductos.Checked = Convert.ToBoolean(vwUsuariosDataGridView.CurrentRow.Cells[10].Value);
            checkInventarios.Checked = Convert.ToBoolean(vwUsuariosDataGridView.CurrentRow.Cells[11].Value);
            checkUsuarios.Checked = Convert.ToBoolean(vwUsuariosDataGridView.CurrentRow.Cells[12].Value);
            checkDashboard.Checked = Convert.ToBoolean(vwUsuariosDataGridView.CurrentRow.Cells[13].Value);
            checkReportes.Checked = Convert.ToBoolean(vwUsuariosDataGridView.CurrentRow.Cells[14].Value);
            checkRespaldo.Checked = Convert.ToBoolean(vwUsuariosDataGridView.CurrentRow.Cells[16].Value);

            cbEstado.Text = vwUsuariosDataGridView.CurrentRow.Cells[17].Value.ToString();

            idPermisos = Convert.ToInt32(vwUsuariosDataGridView.CurrentRow.Cells[6].Value);

            btnNuevo.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                if (idUsuario > 0)
                {
                    // this.tbCategoriaTableAdapter.ActualizarCategoria(idCategoria, txtNombre.Text, txtDescrip.Text);
                    this.tbUsuariosTableAdapter.ActualizarUsuarios(idUsuario, txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, cbEstado.Text);

                    bool? ventas = checkVentas.Checked;
                    bool? compras = checkCompras.Checked;
                    bool? productos = checkProductos.Checked;
                    bool? inventarios = checkInventarios.Checked;
                    bool? usuarios = checkUsuarios.Checked;
                    bool? dashboard = checkDashboard.Checked;
                    bool? reportes = checkReportes.Checked;
                    bool? respaldo = checkRespaldo.Checked;


                    this.tbPermisosTableAdapter.ActualizarPermisos(idPermisos, txtRol.Text, ventas.Value, compras.Value, productos.Value,
                            inventarios.Value, usuarios.Value, dashboard.Value, reportes.Value, respaldo.Value, cbEstado.Text);
                    panelEstado.Visible = false;

                    this.vwUsuariosTableAdapter.Fill(this.bdSistemVDataSet.vwUsuarios);
                    Limpiar();
                    
                    MessageBox.Show("Actualizacion Exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else

                {
                    MessageBox.Show("Seleccione un Registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
              }

           
        }


        private void Limpiar()
        {
                txtCodigo.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtUsuario.Clear();
            txtRol.Clear();
            txtContra.Clear();
            txtContraConf.Clear();

           
          checkVentas.Checked = false;
            checkCompras.Checked = false;
            checkProductos.Checked = false;
            checkInventarios.Checked = false;
            checkUsuarios.Checked = false;
            checkDashboard.Checked = false;
            checkReportes.Checked = false;
            checkRespaldo.Checked = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            idPermisos = 0;
            idUsuario = 0;
            this.panelEstado.Visible = false;
        }
    }
}
