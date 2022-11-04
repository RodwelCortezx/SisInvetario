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
    public partial class ModuloInventario : UserControl
    {
        public ModuloInventario()
        {
            InitializeComponent();
            this.vwInventariosTableAdapter.Fill(bdSistemVDataSet.vwInventarios);
  
        }

        private void vwInventariosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.vwInventariosDataGridView.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn6")
            {
                if (Convert.ToInt32(e.Value) <= 10)
                { 
                 e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Orange;
                }
            
            }

        }
    }
}
