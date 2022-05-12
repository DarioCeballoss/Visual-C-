using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgregarFilaConDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            string nom = tbNombre.Text;
            nom = nom.Replace(" ", "");
            string ape = tbApellido.Text;
            ape = ape.Replace(" ","");
            string dni = tbDNI.Text;
            dni = dni.Replace(" ", "");

            if ((nom == "") || (ape == "") || (dni == ""))
            {
                MessageBox.Show("Debe ingresar los 3 datos para poder insertar la fila.");
            }
            else
            {
                grillaPersona.Rows.Add();
                int fila = grillaPersona.Rows.Count - 1;
                grillaPersona[0, fila].Value = tbNombre.Text;
                grillaPersona[1, fila].Value = tbApellido.Text;
                grillaPersona[2, fila].Value = tbDNI.Text;
                grillaPersona.ClearSelection();
            }
            
        }
    }
}
