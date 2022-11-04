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
    public partial class Categoria : UserControl
    {

        public static int idCategoria;
        public Categoria()
        {
            InitializeComponent();
          
            this.tbCategoriaTableAdapter.Fill(this.bdSistemVDataSet1.tbCategoria);

            btnNuevo.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "" ||  txtNombre.Text == ""  || txtDescrip.Text == "")
                {
                    MessageBox.Show("Es necesario llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    this.tbCategoriaTableAdapter.insertarCategoria(txtCodigo.Text, txtNombre.Text, txtDescrip.Text);
                    this.tbCategoriaTableAdapter.Fill(this.bdSistemVDataSet1.tbCategoria);
                    Limpiar();

                    MessageBox.Show("Categoria Registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

               



            }
            catch (Exception ex) { MessageBox.Show("Error " + ex); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idCategoria > 0)

            {
                try
                {
                    this.tbCategoriaTableAdapter.ActualizarCategoria(idCategoria, txtNombre.Text, txtDescrip.Text);
                    this.tbCategoriaTableAdapter.Fill(this.bdSistemVDataSet1.tbCategoria);
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Seleccione el Registro que desea Actualizar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbCategoriaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void Categoria_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar() 
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescrip.Clear();
           
        }

        private void tbCategoriaDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idCategoria = Convert.ToInt32(tbCategoriaDataGridView.CurrentRow.Cells[0].Value);
                txtCodigo.Text = tbCategoriaDataGridView.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tbCategoriaDataGridView.CurrentRow.Cells[2].Value.ToString();
                txtDescrip.Text = tbCategoriaDataGridView.CurrentRow.Cells[3].Value.ToString();
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            idCategoria = 0;
            btnGuardar.Enabled = true;
        }
    }
}
