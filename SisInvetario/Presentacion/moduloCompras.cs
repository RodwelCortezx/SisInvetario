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
    public partial class moduloCompras : UserControl
    {

        int CodigoCom;

        int idProducto;
        public moduloCompras()
        {
            InitializeComponent();
            panelFechaVen.Visible = false;
            panelAddProduct.Visible = false;
            this.vistaProdTableAdapter.Fill(this.bdSistemVDataSet.VistaProd);

            //bdSistemVDataSetTableAdapters.vwComprasTableAdapter n = new bdSistemVDataSetTableAdapters.vwComprasTableAdapter();
            //dgVistaCompras.DataSource = n.GetData();

            this.vwComprasTableAdapter.Fill(this.bdSistemVDataSet1.vwCompras);

            GenerarCodigo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBFecha.Checked == true)
            {
                panelFechaVen.Visible = true;
            }
            else
            {
                panelFechaVen.Visible = false;
            }
           
        }

        private void btnSelProducto_Click(object sender, EventArgs e)
        {
            panelAddProduct.Visible = true;
        }

        private void vistaProdDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
            idProducto = Convert.ToInt32(vistaProdDataGridView.CurrentRow.Cells[0].Value.ToString()); 
            txtProducto.Text = vistaProdDataGridView.CurrentRow.Cells[2].Value.ToString();

           
        }
        DateTime FechaV;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            try
            {
                if ( txtProducto.Text == "" || txtPrecioCompra.Text == "" || txtPrecioVenta.Text == "")
                {
                    MessageBox.Show("Es necesario llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { 


                    this.tbComprasTableAdapter.insertarCompra(txtCodigo.Text, Datos.Variables.idUsuario);

                    this.tbComprasTableAdapter.ObtenerIdCompras(out int? idCompras);

                    double precio = Convert.ToDouble(txtPrecioCompra.Text);
                    int cantidad = Convert.ToInt32(txtCantidad.Text);

                    double Total = (cantidad * precio);

                    this.tbDetallCompraTableAdapter.insertDetCompra(cantidad, Convert.ToDecimal(txtPrecioCompra.Text),
                    Convert.ToDecimal(txtPrecioVenta.Text), FechaV, idCompras, idProducto, Datos.Variables.idUsuario);


                    this.tbComprasTableAdapter.ActualizarCompra(idCompras, Convert.ToDecimal( Total));


                    MessageBox.Show("Compra Registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.vwComprasTableAdapter.Fill(this.bdSistemVDataSet1.vwCompras);
                    GenerarCodigo();

                }

            }
            catch (Exception    ex)
            {
                MessageBox.Show("Error "+ex);
            }
        }

        private void dtpFechaVen_ValueChanged(object sender, EventArgs e)
        {
            FechaV = dtpFechaVen.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.vistaProdTableAdapter.Fill(this.bdSistemVDataSet.VistaProd);

            this.vistaProdTableAdapter.FillBy(this.bdSistemVDataSet.VistaProd,txtbuscar.Text);

        }
        private void GenerarCodigo()
        {
         //   this.tbVentasTableAdapter.obtenerCodVen(out int? idventa, out string cod);
            this.tbComprasTableAdapter.obtenerCodCompra(out string cod);
          
            int conCod = Convert.ToInt32(cod);
            CodigoCom = conCod + 1;
            txtCodigo.Text = CodigoCom.ToString();
        }

        private void panelP_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            FormatoMoneda(txtPrecioCompra);
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            FormatoMoneda(txtPrecioVenta);
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {

            string cadena = txtPrecioCompra.Text;
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

            //if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Solo se aceptan numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
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
            //if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Solo se aceptan numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  

        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Limpiar()
        { 
           txtCodigo.Clear();
           txtPrecioVenta.Clear();
            txtPrecioCompra.Clear();
            txtProducto.Clear();
            txtCantidad.Clear();


        }

        int idDetComp;
        int idComp;
        private void vwComprasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (vwComprasDataGridView.RowCount == 0)
                {
                    MessageBox.Show("Seleccione un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {


                    idDetComp = Convert.ToInt32(vwComprasDataGridView.CurrentRow.Cells[9].Value.ToString());
                    // txtPrecioVenta.Text = visRegProdutoDataGridView.CurrentRow.Cells[3].Value.ToString();
                    txtCodigo.Text = vwComprasDataGridView.CurrentRow.Cells[1].Value.ToString();
                    txtProducto.Text = vwComprasDataGridView.CurrentRow.Cells[3].Value.ToString();
                    txtPrecioCompra.Text = vwComprasDataGridView.CurrentRow.Cells[5].Value.ToString();
                    txtPrecioVenta.Text = vwComprasDataGridView.CurrentRow.Cells[6].Value.ToString();
                    txtCantidad.Text = vwComprasDataGridView.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            { 
            
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(txtPrecioCompra.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            double Total = (cantidad * precio);

            this.tbDetallCompraTableAdapter.ActualizarDetCompra(idDetComp,cantidad, Convert.ToDecimal(txtPrecioCompra.Text),
            Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToDecimal(Total)); 


           // this.tbComprasTableAdapter.ActualizarCompra(idCompras, Convert.ToDecimal(Total));


            MessageBox.Show("Compra Registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.vwComprasTableAdapter.Fill(this.bdSistemVDataSet1.vwCompras);
            GenerarCodigo();
            Limpiar();
            idDetComp = 0;
        }

       
    }
}


