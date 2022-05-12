using System;
using System.Data;
using System.Data.OleDb;
using System.Threading;

namespace LectorBD
{
    public class BaseDeDatos
    {
        // para las consultas select se susa ExexuteReader para todas las demas Se usa Execute reader
        private OleDbConnection ConexionConBD;
        private OleDbCommand Orden;
        private OleDbDataReader Lector;

        public void LeerDeBaseDeDatos()
        {
            // Crear la conexión con la base de datos
            string strConexión = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\POO\\AccesoaDBporConsola\\AccesoDBconsola.mdb;";
            ConexionConBD = new OleDbConnection(strConexión);

            // Crear una consulta
            string Consulta = "SELECT DNI, Nombre, Apellido FROM Personas";
            Orden = new OleDbCommand(Consulta, ConexionConBD);

            // Abrir la base de datos
            ConexionConBD.Open();
            // ExecuteReader hace la consulta y devuelve un OleDbDataReader
            Lector = Orden.ExecuteReader();
            // Llamar siempre a Read antes de acceder a los datos
            while (Lector.Read()) // siguiente registro
                Console.WriteLine(Lector["Apellido"] + " " + Lector["Nombre"] + " " + Lector["DNI"]);

            // Llamar siempre a Close una vez finalizada la lectura
            Lector.Close();
        }

        public void CerrarConexion()
        {
            // Cerrar la conexión cuando ya no sea necesaria
            if (Lector != null)
                Lector.Close();
            if (ConexionConBD != null)
                ConexionConBD.Close();
        }

        public static void Main()
        {
            BaseDeDatos bd = new BaseDeDatos();
            try
            {
                bd.LeerDeBaseDeDatos();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            Thread.Sleep(3000);
        }
    }
}
