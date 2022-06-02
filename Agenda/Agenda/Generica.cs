using System;
using System.Data.OleDb;

namespace Generica
{
    public static class ConectaDB
    {
        private static OleDbConnection ConexionConBD;
        private static string strConexión = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=c:\\POO\\Agenda\\AgendaDB.mdb;";
        public static OleDbCommand Orden;

        public static OleDbDataReader lecturaDB(string consulta)
        {
            abrirDB();
            Orden = new OleDbCommand(consulta, ConexionConBD);
            return Orden.ExecuteReader();
        }
        public static void abrirDB()
        {
            ConexionConBD = new OleDbConnection(strConexión);
            ConexionConBD.Open();
        }

        public static void cerrarDB()
        {
            ConexionConBD.Close();
        }
    }
}
