using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace validacionNumerica
{
    public partial class Form1 : Form
    {
        private double datoCajaTexto;

        public Form1()
        {
            InitializeComponent();
        }

        private void tbKeyPres(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(13))
            { 
                // Se pulsó la tecla retroceso
                e.Handled = true;
            }
            else if (e.KeyChar == Convert.ToChar(8))
            {
                //Se pulso la tecla retroceso
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                TextBox ObjtexBox = (TextBox)sender;
                if (ObjtexBox.Text.IndexOf(',') != -1)
                { 
                //Solo puede haber una coma
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == '-' || e.KeyChar == '+')
            {
                TextBox ObjetextBox = (TextBox)sender;
                // Admitir - o+ solo en la primera posicion
                if (ObjetextBox.SelectionLength == ObjetextBox.TextLength)
                {
                    //Todo el texto seleccionado: se sobreescribe con el signo
                    e.Handled = false;
                }
                else if (ObjetextBox.TextLength != 0)
                { 
                // La primera posicion ya esta ocupada
                    e.Handled = true;
                }
            }
             else if (e.KeyChar < '0' || e.KeyChar > '9')
             {
                 //Desechar los caracteres que no son digitos
                 e.Handled = true;
             }
        }

        private void tbValidated(object sender, EventArgs e)
        {
            ProveedorDeError.Clear();
        }

        private void tbValidating(object sender, CancelEventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            try
            {
                datoCajaTexto = Convert.ToDouble(objTextBox.Text);

            }
            catch
            {
                e.Cancel = true;
                objTextBox.SelectAll();
                ProveedorDeError.SetError(objTextBox, "Tiene que ser numerico!!");
                MessageBox.Show("Tiene que ser numerico!!");
            }
        }
    }
}
