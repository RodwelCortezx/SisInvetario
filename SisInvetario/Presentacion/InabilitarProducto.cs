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
    public partial class InabilitarProducto : UserControl
    {

        int idProducto;
        public InabilitarProducto()
        {
            InitializeComponent();
            //   this.vwVentasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwVentasActivos);
            this.vwProductosActivosTableAdapter.Fill(this.bdSistemVDataSet.vwProductosActivos);
            this.vwProductosInactivosTableAdapter.Fill(this.bdSistemVDataSet.vwProductosInactivos);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vwProductosActivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //vwVentasActivosDataGridView.CurrentRow.Cells[4].Value.ToString();

            idProducto = Convert.ToInt32(vwProductosActivosDataGridView.CurrentRow.Cells[0].Value);
            cbEstado.Text = vwProductosActivosDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (idProducto==0)
            {
                MessageBox.Show("Seleccione un Producto");
            }
            else
            {
                this.tbProductosTableAdapter.InabiltarProductos(idProducto, cbEstado.Text);
                this.vwProductosActivosTableAdapter.Fill(this.bdSistemVDataSet.vwProductosActivos);
                this.vwProductosInactivosTableAdapter.Fill(this.bdSistemVDataSet.vwProductosInactivos);

            }
            // this.tbVentasTableAdapter.InabiltarVentas(idVentas, cbEstado.Text);
           
        }

        private void vwProductosInactivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = Convert.ToInt32(vwProductosInactivosDataGridView.CurrentRow.Cells[0].Value);
            cbEstado.Text = vwProductosInactivosDataGridView.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
