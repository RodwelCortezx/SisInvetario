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
    public partial class ModuloProductos : UserControl
    {


        private static int idProducto;

        public ModuloProductos()
        {
            InitializeComponent();
            this.tbCategoriaTableAdapter.Fill(this.bdSistemVDataSet.tbCategoria);
            this.visRegProdutoTableAdapter.Fill(this.bdSistemVDataSet.VisRegProduto);
            //   Limpiar();

             btnNuevo.Enabled = false;

        }

        private void categoriaLabel_Click(object sender, EventArgs e)
        {

        }

        private void stock_MínimoLabel_Click(object sender, EventArgs e)
        {

        }
        DateTime FechaV;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtcodigo.Text == "" || txtdescripcion.Text == "" || txtPrecioVenta.Text == "" )
                {
                    MessageBox.Show("Es necesario llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {

                        int idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);

                        this.tbProductosTableAdapter.insertarProductos(txtcodigo.Text, txtdescripcion.Text, Convert.ToDecimal(txtPrecioVenta.Text),
                        Convert.ToInt32(Existencia.Value.ToString()), Convert.ToInt32(StockMin.Value.ToString()), FechaV, idCategoria,
                        out String Error, out String ManError);

                        if (Error != null)
                        {
                            MessageBox.Show("Error " + Error);
                        }
                        else if (ManError != null)
                        {
                            MessageBox.Show("Error " + ManError);
                        }

                        this.visRegProdutoTableAdapter.Fill(this.bdSistemVDataSet.VisRegProduto);
                        Limpiar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }             
                }
            }
            catch (Exception ex) { MessageBox.Show("Error " + ex); }
        }

        private void Limpiar()
        {
            txtcodigo.Clear();
            txtdescripcion.Clear();
            
            cbCategoria.Text = "";
            txtPrecioVenta.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProducto > 0)
                {
                    int idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                    this.tbProductosTableAdapter.ActualizarProductos(idProducto, txtcodigo.Text, txtdescripcion.Text,
                    Convert.ToInt32(StockMin.Value.ToString()), idCategoria);

                    this.visRegProdutoTableAdapter.Fill(this.bdSistemVDataSet.VisRegProduto);
                    Limpiar();

                    MessageBox.Show("Registro Actualizado");

                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void visRegProdutoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNuevo.Enabled = true;

          
            idProducto = Convert.ToInt32(visRegProdutoDataGridView.CurrentRow.Cells[0].Value);

            txtcodigo.Text = visRegProdutoDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtdescripcion.Text = visRegProdutoDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtPrecioVenta.Text = visRegProdutoDataGridView.CurrentRow.Cells[3].Value.ToString();   
            Existencia.Value = Convert.ToInt32(visRegProdutoDataGridView.CurrentRow.Cells[4].Value);

            StockMin.Text = visRegProdutoDataGridView.CurrentRow.Cells[5].Value.ToString();
             
           // date

            cbCategoria.Text = visRegProdutoDataGridView.CurrentRow.Cells[4].Value.ToString();
         //   cbEstado.Text = visRegProdutoDataGridView.CurrentRow.Cells[5].Value.ToString();

   


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            idProducto = 0 ;
        }

        private void dtpFechaVen_ValueChanged(object sender, EventArgs e)
        {
            FechaV = dtpFechaVen.Value;
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

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            FormatoMoneda(txtPrecioVenta);
        }
    }
}
