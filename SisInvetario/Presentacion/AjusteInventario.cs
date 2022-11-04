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
    public partial class AjusteInventario : UserControl
    {

        int idInventario;
        int idProducto;
        int validacion;
        public AjusteInventario()
        {
            InitializeComponent();
            this.vwInventariosTableAdapter.Fill(this.bdSistemVDataSet.vwInventarios);
        }

        private void vwInventariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //idCategoria = Convert.ToInt32(tbCategoriaDataGridView.CurrentRow.Cells[0].Value);

            idInventario = Convert.ToInt32(vwInventariosDataGridView.CurrentRow.Cells[0].Value);
            idProducto = Convert.ToInt32(vwInventariosDataGridView.CurrentRow.Cells[1].Value);
            txtDescripcion.Text = vwInventariosDataGridView.CurrentRow.Cells[2].Value.ToString();
           
            txtPrecioCosto.Text = vwInventariosDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtPrecioVenta.Text = vwInventariosDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtExistencia.Text = vwInventariosDataGridView.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
              // MessageBox.Show("Cant "+ numCan.Value + " Validacion "+ validacion);
            try
            {
                if (idInventario > 0)
                {
                    if (txtPrecioCosto.Text == "" || txtPrecioVenta.Text == "")
                    {
                        MessageBox.Show("Es necesario llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.tbInventarioTableAdapter.AjusteInventario(idInventario, idProducto, Convert.ToDecimal(txtPrecioCosto.Text),
                        Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToInt32(numCan.Value), validacion, 5);
                        this.vwInventariosTableAdapter.Fill(this.bdSistemVDataSet.vwInventarios);
                        MessageBox.Show("Actualizacion  Exitosa");

                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el registro que desee Ajustar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
           
        }

        private void checkBoxAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAgregar.Checked)
            {
                validacion = 2;
                checkBoxQuitar.Checked = false;
            }
        }

        private void checkBoxQuitar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQuitar.Checked)
            {
                validacion = 1;
                checkBoxAgregar.Checked = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = txtPrecioCosto.Text;
            string filtro = "1234567890";


            if (cadena.Length > 0)
            {
                filtro += ".";
            }

            foreach (var caracter in filtro)
            {

                if (e.KeyChar == caracter)
                {
                    e.Handled = false;
                    break;
                }

                else
                {
                    e.Handled = true;
                }

            }


            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = txtPrecioVenta.Text;
            string filtro = "1234567890";


            if (cadena.Length > 0)
            {
                filtro += ".";
            }

            foreach (var caracter in filtro)
            {

                if (e.KeyChar == caracter)
                {
                    e.Handled = false;
                    break;
                }

                else
                {
                    e.Handled = true;
                }

            }


            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }


        public void FormatoMoneda(TextBox xTBox)
        {
            if (xTBox.Text == String.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;
                Monto = Convert.ToDecimal(xTBox.Text);
                xTBox.Text = Monto.ToString("N2");
            }

        }



        private void txtPrecioCosto_Leave(object sender, EventArgs e)
        {
            FormatoMoneda(txtPrecioCosto);
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            FormatoMoneda(txtPrecioVenta); 
        }


       private void Limpiar() 
        {
            txtDescripcion.Clear();
            txtPrecioCosto.Clear();
            txtPrecioVenta.Clear();
            txtExistencia.Clear();
            txtExistencia.Clear();
            numCan.Value = 1;
        }
    }
}
