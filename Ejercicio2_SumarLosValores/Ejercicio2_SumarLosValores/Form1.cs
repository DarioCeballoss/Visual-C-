using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio2_SumarLosValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double suma = 0;

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            if (isNumeric(textBoxVal1.Text) == true && isNumeric(textBoxVal2.Text) == true)
            {
                suma = (Convert.ToDouble(textBoxVal1.Text)) + (Convert.ToDouble(textBoxVal2.Text));
                labelResultado.Text = "El resultado es: " + Convert.ToString(suma);
            }else{
                MessageBox.Show("Ingrese un valor numerico");
                labelResultado.Text = "El resultado es:";
            }
            
            
        }


        public static bool isNumeric(object value)
        {
            try
            {
                double d = System.Double.Parse(value.ToString(), System.Globalization.NumberStyles.Any);
                return true;
            }
            catch (System.FormatException)
            {
                return false;
            }
        } //IsNumeric

    }
}
