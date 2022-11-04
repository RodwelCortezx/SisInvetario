using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SisInvetario.Presentacion
{
    public partial class Dashboard : UserControl
    {
        DateTime Desde;
        DateTime Hasta;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ObtenerTotal() 
        {
            this.tbDetallVentasTableAdapter.dashboard(out decimal? TotalV,out decimal? TotaG, out int? Cproductos, out int? cCategorias );
            lblTotalVentas.Text = TotalV.ToString();    
            lblTotalGastos.Text = TotaG.ToString(); 
            lblCanProductos.Text = Cproductos.ToString();
            lblCanCategorias.Text = cCategorias.ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ObtenerTotal();
            Grafica();
        }

        private void Grafica()
        {
            bdSistemVDataSetTableAdapters.cProductXcategoriaTableAdapter n = new bdSistemVDataSetTableAdapters.cProductXcategoriaTableAdapter();
            DataTable dt = new DataTable();

            dt = n.GetData();
            ArrayList Nombre = new ArrayList();
            ArrayList Cantidad = new ArrayList();

            foreach (DataRow row in dt.Rows)
            {
                Nombre.Add(row["Nombre"].ToString());
                Cantidad.Add(row["cantidad"].ToString());
                
                //Series series = chartVentas.Series.Add(row["Nombre"].ToString());
                //series.Points.Add(Convert.ToInt32(row["cantidad"].ToString()));
                //series.Label = row["Cantidad"].ToString();
            }
            chartProductXcat.Series[0].Points.DataBindXY(Nombre,Cantidad);


            bdSistemVDataSetTableAdapters.ProductoPreferidosTableAdapter n1 = new bdSistemVDataSetTableAdapters.ProductoPreferidosTableAdapter();
            DataTable dt1 = new DataTable();
            dt1 = n1.GetData();

            foreach (DataRow row in dt1.Rows)
            {
                Series series = chartProductosPrefe.Series.Add(row["Descripcion"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad"].ToString()));
                series.Label = row["Cantidad"].ToString();
            }

            bdSistemVDataSetTableAdapters.stockBajoTableAdapter n4 = new bdSistemVDataSetTableAdapters.stockBajoTableAdapter();
            DataTable dt4 = new DataTable();
            dt4 = n4.GetData();

            foreach (DataRow row in dt4.Rows)
            {
                Series series = chartProdStockBajo.Series.Add(row["Descripcion"].ToString());
                series.Points.Add(Convert.ToInt32(row["Stock"].ToString()));
                series.Label = row["Stock"].ToString();
            }

            bdSistemVDataSetTableAdapters.ProductoMenosPreferidosTableAdapter n5 = new bdSistemVDataSetTableAdapters.ProductoMenosPreferidosTableAdapter();
            DataTable dt5 = new DataTable();
            dt5 = n5.GetData();

            foreach (DataRow row in dt5.Rows)
            {
                Series series = chartProducMensP.Series.Add(row["Descripcion"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad"].ToString()));
                series.Label = row["Cantidad"].ToString();
            }




        }

        private void chartProductXcat_Click(object sender, EventArgs e)
        {

        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            Hasta = dtHasta.Value;
        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            Desde = dtDesde.Value;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            GraficaFecha();
        }

        private void GraficaFecha() 
        {
            bdSistemVDataSetTableAdapters.VentasXfechaTableAdapter n2 = new bdSistemVDataSetTableAdapters.VentasXfechaTableAdapter();
            DataTable dt2 = new DataTable();

            dt2 = n2.GetData(Desde, Hasta);



            foreach (DataRow row in dt2.Rows)
            {
                Series series = chartVentas.Series.Add(row["FechaVenta"].ToString());
                series.Points.Add(Convert.ToDouble(row["total"].ToString()));
                series.Label = row["total"].ToString();


            }

            bdSistemVDataSetTableAdapters.GastosXfechaTableAdapter n3 = new bdSistemVDataSetTableAdapters.GastosXfechaTableAdapter();
            DataTable dt3 = new DataTable();

            dt3 = n3.GetData(Desde, Hasta);



            foreach (DataRow row in dt3.Rows)
            {
                Series series = chartCompras.Series.Add(row["FechaCompra"].ToString());
                series.Points.Add(Convert.ToDouble(row["total"].ToString()));
                series.Label = row["total"].ToString();


            }



        }
    }
}
