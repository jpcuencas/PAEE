using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConsultaBD
{
    class Program
    {
        private const string sqlCNX = "Data Source=localhost;Initial Catalog=MSDNVideoDB;Integrated Security=True";

        static void Main(string[] args)
        {
            SqlTransaction miTransaccion = null;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = sqlCNX;
                    connection.Open();
                    miTransaccion = connection.BeginTransaction();

                    string cadenaSQL = "INSERT INTO [MSDNVideoDB].[dbo].[Usuarios]" +
                                           "([NIF],[Clave],[Rol],[Nombre],[Telefono],[Email],[Direccion],[Ciudad],[Provincia],[CodigoPostal],[Saldo])" +
                                       "VALUES" +
                                           "('ZZZZZZZZZ','pass',0,'nombre','123123123','pp@terra.es','calle','ciudad','provincia',03009,0)";

                    using (SqlCommand cmd = new SqlCommand(cadenaSQL, connection))
                    {
                        cmd.Transaction = miTransaccion;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Ejecutado el insert. pulse una tecla para continuar");
                        Console.ReadKey();

                        //Fuerzo que la TX no se aplique
                        miTransaccion.Rollback();
                    }
                }
            }
            finally
            {
                if (miTransaccion != null)
                {
                    miTransaccion.Dispose();
                }
                miTransaccion = null;
            }
        }
    }
}
