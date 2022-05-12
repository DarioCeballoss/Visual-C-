using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio3_CargaComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCarga_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Primero");
            comboBox1.Items.Add("Segundo");
            comboBox1.Items.Add("Tercero");
        }

        private void buttonBorra_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
    }
}
