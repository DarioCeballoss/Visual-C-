using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccesoDB
{
    public partial class Form1 : Form
    {
        private OleDbConnection ConexionConBD;
        private OleDbCommand Orden;
        private OleDbDataReader Lector;

        public Form1()
        {
            InitializeComponent();
        }

        private void Conecta_Click(object sender, EventArgs e)
        {
            string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\POO\\AccesoDB\\DatabaseDB.mdb;";
            ConexionConBD = new OleDbConnection(strConexion);

            try
            {
                ConexionConBD.Open();
                MessageBox.Show("Base de Datos abierta");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir la DB");
            }
        }

        private void Carga_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Personas;";
            Orden = new OleDbCommand(consulta, ConexionConBD);
            Lector = Orden.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Lector);
            dataGridViewPersona.DataSource = dt;
            dataGridViewPersona.ClearSelection();
            Lector.Close();
        }

        private void Desconecta_Click(object sender, EventArgs e)
        {
            if (Lector != null)
                Lector.Close();
            if (ConexionConBD != null)
            {
                try
                {
                    ConexionConBD.Close();
                    MessageBox.Show("Base de datos Cerrada");
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al Cerrar la DB");
                }
            }
            if (ConexionConBD == null)
            {
                MessageBox.Show("No hay ninguna base de datos abierta ");
            }

        }
    }
}
