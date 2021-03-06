using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Generica;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OleDbDataReader Lector;


        private void Form1_Load(object sender, EventArgs e)
        {


            string consulta = "SELECT Persona.Apellido, Persona.Nombre, Persona.Dir,"+
                       " Persona.Fecha_Nac, Persona.Mail, Telefono.Tipo_Tel," +
                       " Telefono.Num_Tel FROM Telefono INNER JOIN "+
                       "(Persona INNER JOIN Per_Tel ON Persona.Id_persona ="+
                       " Per_Tel.Id_persona) ON Telefono.Id_Tel = Per_Tel.Id_tel;";


            Lector = ConectaDB.lecturaDB(consulta); // solo SELECT

            while (Lector.Read())
            {
                grilla_datos.Rows.Add();
                grilla_datos[0, grilla_datos.Rows.Count - 1].Value = Lector["Nombre"];
                grilla_datos[1, grilla_datos.Rows.Count - 1].Value = Lector["Apellido"];
                grilla_datos[2, grilla_datos.Rows.Count - 1].Value = Lector["Dir"];
                grilla_datos[3, grilla_datos.Rows.Count - 1].Value = Lector["Fecha_Nac"];
                grilla_datos[4, grilla_datos.Rows.Count - 1].Value = Lector["Mail"];
                grilla_datos[5, grilla_datos.Rows.Count - 1].Value = Lector["Tipo_Tel"];
                grilla_datos[6, grilla_datos.Rows.Count - 1].Value = Lector["Num_Tel"];
            }

            grilla_datos.ClearSelection();
            Lector.Close();

            ConectaDB.cerrarDB();

        }
    }
}
