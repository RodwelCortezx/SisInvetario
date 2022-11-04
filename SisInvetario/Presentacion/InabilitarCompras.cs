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
    public partial class InabilitarCompras : UserControl
    {

        int idCompra = 0;
        public InabilitarCompras()
        {
            InitializeComponent();

            //this.vwVentasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwVentasActivos);

            this.vwComprasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwComprasActivos);
            this.vwComprasInactivosTableAdapter.Fill(this.bdSistemVDataSet.vwComprasInactivos);
        
        }

        private void vwComprasActivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCompra = Convert.ToInt32(vwComprasActivosDataGridView.CurrentRow.Cells[0].Value);
            cbEstado.Text = vwComprasActivosDataGridView.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idCompra == 0)
            {
                MessageBox.Show("Seleccione la compra que desea modificar el estado");
            }
            else
            {
                this.tbComprasTableAdapter.InabilitarCompra(idCompra, cbEstado.Text);

                this.vwComprasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwComprasActivos);
            }


            this.vwComprasInactivosTableAdapter.Fill(this.bdSistemVDataSet.vwComprasInactivos);
        }

        private void vwComprasInactivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCompra = Convert.ToInt32(vwComprasInactivosDataGridView.CurrentRow.Cells[0].Value);
            cbEstado.Text = vwComprasInactivosDataGridView.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
