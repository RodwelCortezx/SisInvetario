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
    public partial class visVentas : UserControl
    {

        int idVentas = 0;

        public visVentas()
        {
            InitializeComponent();
            this.vwVentasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwVentasActivos);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void vwVentasActivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vwVentasActivosDataGridView.RowCount != 0)

            {
                idVentas = Convert.ToInt32(vwVentasActivosDataGridView.CurrentRow.Cells[0].Value);

                cbEstado.Text = vwVentasActivosDataGridView.CurrentRow.Cells[4].Value.ToString();


                this.detallVentasTableAdapter.FillBy(bdSistemVDataSet.DetallVentas, idVentas);


            }
            else
            {

            }



            


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (idVentas == 0)
            {
                MessageBox.Show("Seleccione una Venta");
            }
            else
            {

                
                this.vwVentasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwVentasActivos);



                for (int i = 0; i < detallVentasDataGridView.RowCount - 1; i++)
                {
                    int cantidad;

                    
                    int idProducto;


                      int.TryParse(  detallVentasDataGridView.Rows[i].Cells[0].Value.ToString(), out idProducto);


                    int.TryParse(detallVentasDataGridView.Rows[i].Cells[2].Value.ToString(), out cantidad);


                    this.tbVentasTableAdapter.InabiltarVentas(idVentas,idProducto ,cantidad, cbEstado.Text, 5);
                  
                    MessageBox.Show(""+idProducto);

            
                }


                //  this.vwVentasInactivosTableAdapter.Fill(this.bdSistemVDataSet.vwVentasInactivos);


            }
        }
    }
}
