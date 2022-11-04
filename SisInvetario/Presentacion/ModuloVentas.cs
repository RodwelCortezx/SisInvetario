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
    public partial class ModuloVentas : UserControl
    {


        
        int codigov;
        public int idProducto;

        public int ValidarStock=0;

        public ModuloVentas()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
           
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            AgregarProductos addProduct = new AgregarProductos(this);

            addProduct.ShowDialog();



        }

        private void usConVentas_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void dgAddVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //wCategoriasActivosDataGridView.CurrentRow.Cells[4].Value.ToString();
            try
            {
                if (dgAddVentas.RowCount == 0)

                {
                   // MessageBox.Show("Agregue al menos un Producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    txtCod.Text = dgAddVentas.CurrentRow.Cells[0].Value.ToString();
                    txtDescri.Text = dgAddVentas.CurrentRow.Cells[1].Value.ToString();
                    numCan.Value = Convert.ToInt32(dgAddVentas.CurrentRow.Cells[2].Value);
                    txtPrecio.Text = dgAddVentas.CurrentRow.Cells[3].Value.ToString();
                  //  Descuento.Value 
                    if (dgAddVentas.Columns[e.ColumnIndex].Name == "btnQuitar")
                    {
                        dgAddVentas.Rows.Remove(dgAddVentas.CurrentRow);
                        calcularTotal();
                    }


                }

            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {




            if (dgAddVentas.RowCount == 0)
            {
                 
            }
            else
            {

                MessageBox.Show("Seleccione", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //int idUsuario = 5;

            string codigoP;
            int cantidad;
            string precio;
            string descuento = "0";

            if (dgAddVentas.RowCount == 0)

            {
                MessageBox.Show("Agregue al menos un Producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

           


                this.tbVentasTableAdapter.insertarVentas(lblCodigoVenta.Text, Datos.Variables.idUsuario);

                this.tbVentasTableAdapter.ObtenerIdv(out int? idven);

                try
                {

                    for (int i = 0; i < dgAddVentas.RowCount ; i++)
                    {
                        codigoP = dgAddVentas.Rows[i].Cells[0].Value.ToString();

                        this.tbProductosTableAdapter.ProidProducto(codigoP, out int? idProducto);

                        int.TryParse(dgAddVentas.Rows[i].Cells[2].Value.ToString(), out cantidad);
                        precio = dgAddVentas.Rows[i].Cells[3].Value.ToString();
                        descuento = dgAddVentas.Rows[i].Cells[5].Value.ToString();


                        this.tbDetallVentasTableAdapter.insertDetVenta(Convert.ToInt32(cantidad), Convert.ToDecimal(precio), 
                            Convert.ToDecimal(descuento), idven, idProducto, Datos.Variables.idUsuario);
                    }

                    dgAddVentas.Rows.Clear();


                    this.tbVentasTableAdapter.ActualizarVentas(idven, Convert.ToDecimal(lblTotalV.Text));

                    MessageBox.Show("Venta Registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerarCodigo();
                    lblTotalV.Text = "0.00";


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error " + ex);
                }

            }
        }
     

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
        }

        private void GenerarCodigo() 
        {
            this.tbVentasTableAdapter.obtenerCodVen(out  string cod);

            int conCod = Convert.ToInt32(cod);
            codigov = conCod + 1;
            lblCodigoVenta.Text = codigov.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

        }

        public void calcularTotal() 
        {
            decimal TotalV = 0;
            decimal total;

            for (int i = 0; i < dgAddVentas.RowCount; i++)
            {

                decimal.TryParse(dgAddVentas.Rows[i].Cells[4].Value.ToString(), out total);

                TotalV += total;

            

                lblTotalV.Text = TotalV.ToString("N2");
            }

            if (dgAddVentas.RowCount == 0)

            {
                lblTotalV.Text = "0.00";

            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena   = txtPrecio.Text;
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

        private void dgAddVentas_Click(object sender, EventArgs e)
        {
          
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            this.tbProductosTableAdapter.ValidarStock(idProducto, Convert.ToInt32(numCan.Value), out string val);

            if (val == "Si")
            {

                try
                {
                    if (txtPrecio.Text == "" || txtDescri.Text == "")
                    {
                        MessageBox.Show("Agregue un Producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        


                    }
                    else
                    {

                        int cant = Convert.ToInt32(numCan.Value.ToString());
                        double prec = Convert.ToDouble(txtPrecio.Text);

                        double descuento = Convert.ToInt32(Descuento.Value.ToString());

                        double Total = (cant * prec) - descuento;




                        dgAddVentas.Rows.Add(txtCod.Text, txtDescri.Text, numCan.Value, txtPrecio.Text, (Total), Descuento.Value);

                        estado = 0;
                        calcularTotal();
                        txtPrecio.Clear();
                        numCan.Value = 1;
                        txtDescri.Clear();
                        txtCod.Clear();
                        ValidarStock = 0;

                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("No hay suficientes Productos ");
            }
        }
        int estado = 0;
        private void numCan_ValueChanged(object sender, EventArgs e)
        {
            
            // MessageBox.Show(" "+ValidarStock);
            if (ValidarStock == 0 && estado == 0)
            {
                
                MessageBox.Show("Agregue un Productol", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                estado = 1;
                numCan.Value = 1;
                
            }
            else if(ValidarStock > 0 )
            {
                //MessageBox.Show(" HOla Entre");

                if ( numCan.Value >  ValidarStock) 
                {
                    MessageBox.Show("No hay Suficiente Stock", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numCan.Value = ValidarStock;
                    estado = 0;
                }

            }
            estado = 0;
        }
    }
}
