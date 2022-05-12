using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JugandoDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gilla_cellmouseclick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToString(dataGridViewClick[e.ColumnIndex, e.RowIndex].Value) == "")
            {
                dataGridViewClick[e.ColumnIndex, e.RowIndex].Value = textBoxClick.Text;
                dataGridViewClick.ClearSelection();
            }else{
                MessageBox.Show("Celda ya ocupada");
                
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
          for (int i = 1; i <= 9; i++) {
                dataGridViewClick.Rows.Add();

          }
             
        }
    }
}
