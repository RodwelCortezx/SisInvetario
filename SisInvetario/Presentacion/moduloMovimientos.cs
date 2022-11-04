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
    public partial class moduloMovimientos : UserControl
    {
        public moduloMovimientos()
        {
            InitializeComponent();
     
            this.vwMovimientosTableAdapter.Fill(this.bdSistemVDataSet.vwMovimientos);
        
            
        }

 

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


