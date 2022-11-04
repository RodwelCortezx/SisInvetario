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
    public partial class InabilitarCategoria : UserControl
    {

        int idCategoria=0;
        public InabilitarCategoria()
        {
            InitializeComponent();
            //  this.vwProductosActivosTableAdapter.Fill(this.bdSistemVDataSet.vwProductosActivos);
            this.vwCategoriasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwCategoriasActivos);
            this.vwCategoriasInactivosTableAdapter.Fill(this.bdSistemVDataSet.vwCategoriasInactivos);
        }

        private void vwCategoriasActivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //vwProductosActivosDataGridView.CurrentRow.Cells[4].Value.ToString();

            if (vwCategoriasActivosDataGridView.RowCount != 0)

            {
                idCategoria = Convert.ToInt32(vwCategoriasActivosDataGridView.CurrentRow.Cells[0].Value);
                cbEstado.Text = vwCategoriasActivosDataGridView.CurrentRow.Cells[4].Value.ToString();


            }
            else
            {

            }



            

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // this.tbVentasTableAdapter.InabiltarVentas(idVentas, cbEstado.Text);

            if (idCategoria == 0)
            {
                MessageBox.Show("Seleccionde una Categoria");
            }
            else
            {
                this.tbCategoriaTableAdapter.InabilitarCategoria(idCategoria, cbEstado.Text);

                this.vwCategoriasActivosTableAdapter.Fill(this.bdSistemVDataSet.vwCategoriasActivos);
            }

          
            this.vwCategoriasInactivosTableAdapter.Fill(this.bdSistemVDataSet.vwCategoriasInactivos);
        }

        private void vwCategoriasInactivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCategoria = Convert.ToInt32(vwCategoriasInactivosDataGridView.CurrentRow.Cells[0].Value);
            cbEstado.Text = vwCategoriasInactivosDataGridView.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
