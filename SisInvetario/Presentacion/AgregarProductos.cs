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
    public partial class AgregarProductos : Form
    {
       ModuloVentas Mp;

       

        public AgregarProductos(ModuloVentas mp)
        {
            InitializeComponent();
            this.Mp = mp;
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdSistemVDataSet.VistaProductos' Puede moverla o quitarla según sea necesario.
              this.vistaProductosTableAdapter.Fill(this.bdSistemVDataSet.VistaProductos);

            //bdSistemVDataSetTableAdapters.VistaProductosTableAdapter prod = new bdSistemVDataSetTableAdapters.VistaProductosTableAdapter();
            //dataGridView1.DataSource = prod.GetData();

            //

        }




       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           //this.vistaProductosTableAdapter.ValidarStock(idprod,Convert.ToInt32(numCan.Value), out string val);



           // if (val == "Si")
           // {
           //     try
           //     {

           //         int cant = Convert.ToInt32(numCan.Value.ToString());
           //         double prec = Convert.ToDouble(txtPrecio.Text);
           //         Total = (cant * prec);
           //         Mp.dgAddVentas.Rows.Add(txtCodigo.Text, txtDescripcion.Text, numCan.Value.ToString(), prec, Total);
                    
           //         this.Hide();
           //     }
           //     catch (Exception ex)
           //     {
           //         MessageBox.Show(ex + "");
           //     }
           // }
           // else
           // {
           //     MessageBox.Show("No hay suficientes Productos ");
           // }

           


        }
     
        private void vistaProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

              this.vistaProductosTableAdapter.FillBy(this.bdSistemVDataSet.VistaProductos,txtDescrip.Text);
           
            
            //bdSistemVDataSetTableAdapters.VistaProductosTableAdapter prod = new bdSistemVDataSetTableAdapters.VistaProductosTableAdapter();
            //dataGridView1.DataSource = prod.GetDataBy(txtDescrip.Text);




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numCan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vistaProductosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (vistaProductosDataGridView.Columns[e.ColumnIndex].Name == "btnAdd")
            
            {



                Mp.txtCod.Text = vistaProductosDataGridView.CurrentRow.Cells[0].Value.ToString();
                Mp.txtDescri.Text = vistaProductosDataGridView.CurrentRow.Cells[1].Value.ToString();
                Mp.txtPrecio.Text = vistaProductosDataGridView.CurrentRow.Cells[2].Value.ToString();
                Mp.ValidarStock = Convert.ToInt32(vistaProductosDataGridView.CurrentRow.Cells[3].Value);
                Mp.idProducto = Convert.ToInt32(vistaProductosDataGridView.CurrentRow.Cells[5].Value);
               
                Hide();
                //  MessageBox.Show("Hola");
            
            }




            //txtCodigo.Text = vistaProductosDataGridView.CurrentRow.Cells[0].Value.ToString();
            //txtDescripcion.Text = vistaProductosDataGridView.CurrentRow.Cells[1].Value.ToString();
            //txtPrecio.Text = vistaProductosDataGridView.CurrentRow.Cells[2].Value.ToString();
            //idprod = Convert.ToInt32(vistaProductosDataGridView.CurrentRow.Cells[5].Value);
           // MessageBox.Show("err " + idprod);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
