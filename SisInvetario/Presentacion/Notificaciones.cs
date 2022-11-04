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
    public partial class Notificaciones : UserControl
    {
        DateTime FechaV;
        public Notificaciones()
        {
            InitializeComponent();
            this.vwProductosPorVencerTableAdapter.Fill(this.bdSistemVDataSet.vwProductosPorVencer);
            this.vwProductosStockBajosTableAdapter.Fill(this.bdSistemVDataSet.vwProductosStockBajos);

            this.vwProductosVencidosTableAdapter.Fill(this.bdSistemVDataSet.vwProductosVencidos);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechaV = dtFecha.Value;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
           // vwProductosVencidosDataGridView.DataSource = null;

            this.vwProductosVencidosTableAdapter.FillBy(this.bdSistemVDataSet.vwProductosVencidos, FechaV);
        }
    }
}
