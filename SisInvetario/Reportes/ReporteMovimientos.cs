using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisInvetario.Reportes
{
    public partial class ReporteMovimientos : UserControl
    {
        DateTime Desde;
        DateTime Hasta;
        public ReporteMovimientos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.reporteMovimientosRTableAdapter.Fill(this.bdSistemVDataSet.ReporteMovimientosR, Desde, Hasta);
            this.reportViewer1.RefreshReport();

            MessageBox.Show("Desde "+Desde+"Hasta "+Hasta);
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            Hasta = dtpHasta.Value;
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            Desde = dtpDesde.Value;
        }
    }
}
