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
    public partial class InabilitarVentas : UserControl
    {

        int idVentas=0;
        public InabilitarVentas()
        {
            InitializeComponent();
            this.vwVentasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwVentasActivos);
            this.vwVentasInactivosTableAdapter.Fill(this.bdSistemVDataSet.vwVentasInactivos);
        }

        private void vwVentasActivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vwVentasActivosDataGridView.RowCount != 0)
            {
                idVentas = Convert.ToInt32(vwVentasActivosDataGridView.CurrentRow.Cells[0].Value);
                this.detallVentasTableAdapter.FillBy(bdSistemVDataSet.DetallVentas, idVentas);
            }
            else
            {
            
            }


            


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (idVentas==0)
            {
                MessageBox.Show("Seleccione una Venta");
            }
            else
            {
             //   this.tbVentasTableAdapter.InabiltarVentas(idVentas, cbEstado.Text);

                this.vwVentasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwVentasActivos);
                this.vwVentasInactivosTableAdapter.Fill(this.bdSistemVDataSet.vwVentasInactivos);
            }
           
        }

        private void vwVentasInactivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vwVentasInactivosDataGridView.RowCount != 0)

            {

                idVentas = Convert.ToInt32(vwVentasActivosDataGridView.CurrentRow.Cells[0].Value);
                this.detallVentasTableAdapter.FillBy(bdSistemVDataSet.DetallVentas, idVentas);

            }
            else
            { 
            
            }




            // this.detallVentasTableAdapter.FillBy(bdSistemVDataSet.DetallVentas, idVentas);
            //cbEstado.Text = vwVentasInactivosDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
