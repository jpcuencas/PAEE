using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

using DTO;

namespace CAD
{
    public class ClassADO : ClassICAD
    {
        // cadena de conexion de sql server sql client
        private const string sqlCNX = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\Documents\\BBDD\\MSDNVideo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        private ClassDTO usuario = new ClassDTO();

        public ClassADO()
        {
            usuario = new ClassDTO();
        }

        public override int InsertarUsuario(string nif, string clave, int rol, string nombre, string telefono, string email, string direccion, string ciudad, string provincia, decimal codigoPostal, decimal saldo)
        {
            int res = 0;


            //Pon tu codigo aqui
            //Data Source=.\sqlexpress;AttachDbFilename="E:\VS 2010\Ejercicios\BBDD\MSDNVideo.mdf";Integrated Security=True

            // Creamos la conexión
            SqlConnection connection = new SqlConnection();
            try
            {

                //aplicamos la cadena de conexion
                connection.ConnectionString = sqlCNX;
                // Crear el adaptador de datos y abre la conexion
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                connection.Open();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (NIF,Clave,Rol,Nombre,Telefono,Email,Direccion,Ciudad,Provincia,CodigoPostal,Saldo) VALUES ('"+ nif +"','" + clave +"','" + rol + "','" + nombre + "','" + telefono + "','" + email + "','" + direccion + "','" + ciudad + "','" + provincia + "','" + codigoPostal + "','" + saldo + "')", connection);
                int cadena = cmd.ExecuteNonQuery();

                // limpiamos añadimos los resultados al listview
                res = 1;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //cerrar y destruir la conexion
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }

            return res;
        }

        public override int ActualizarUsuario(ClassDTO usuario, Int32 id)
        {
            int res = 0;

            // Creamos la conexión
            SqlConnection connection = new SqlConnection();
            try
            {

                //aplicamos la cadena de conexion
                connection.ConnectionString = sqlCNX;
                // Crear el adaptador de datos y abre la conexion
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                connection.Open();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd1 = new SqlCommand("UPDATE Usuarios SET nif='" + usuario.getNif() + "' where UsuarioID="+id+"", connection);
                int cadena = cmd1.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd2 = new SqlCommand("UPDATE Usuarios SET nombre='" + usuario.getNombre() + "' where UsuarioID=" + id + "", connection);
                 cadena = cmd2.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd3 = new SqlCommand("UPDATE Usuarios SET clave='" + usuario.getClave() + "' where UsuarioID=" + id + "", connection);
                cadena = cmd3.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd4 = new SqlCommand("UPDATE Usuarios SET rol='" + usuario.getRol() + "' where UsuarioID=" + id + "", connection);
                cadena = cmd4.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd5 = new SqlCommand("UPDATE Usuarios SET telefono='" + usuario.getTelefono() + "' where UsuarioID=" + id + "", connection);
                cadena = cmd5.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd6 = new SqlCommand("UPDATE Usuarios SET email='" + usuario.getEmail() + "' where UsuarioID=" + id + "", connection);
                cadena = cmd6.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd7 = new SqlCommand("UPDATE Usuarios SET direccion='" + usuario.getDireccion() + "' where UsuarioID=" + id + "", connection);
                cadena = cmd7.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd8 = new SqlCommand("UPDATE Usuarios SET provincia='" + usuario.getProvincia() + "' where UsuarioID=" + id + "", connection);
                cadena = cmd8.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd9 = new SqlCommand("UPDATE Usuarios SET ciudad='" + usuario.getCiudad() + "' where UsuarioID=" + id + "", connection);
                cadena = cmd9.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd10 = new SqlCommand("UPDATE Usuarios SET codigopostal='" + usuario.getCodigoPostal() + "' where UsuarioID=" + id + "", connection);
                cadena = cmd10.ExecuteNonQuery();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd11 = new SqlCommand("UPDATE Usuarios SET saldo='" + usuario.getSaldo() + "' where UsuarioID=" + id + "", connection);
                cadena = cmd11.ExecuteNonQuery();




                // limpiamos añadimos los resultados al listview
                res = 1;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //cerrar y destruir la conexion
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }

            return res;
        }

        public override int BorrarUsuario(Int32 id)
        {
            int res = 0;

            // Creamos la conexión
            SqlConnection connection = new SqlConnection();
            try
            {

                //aplicamos la cadena de conexion
                connection.ConnectionString = sqlCNX;
                // Crear el adaptador de datos y abre la conexion
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                connection.Open();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios where UsuarioID=" + id + "", connection);
                int cadena = cmd.ExecuteNonQuery();

                // limpiamos añadimos los resultados al listview
                res = 1;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //cerrar y destruir la conexion
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }

            return res;
        }


        public override List<ClassDTO> ObtenerUsuario(string criterio)
        {
            List<ClassDTO> res = new List<ClassDTO>();
            int i = 0;
            ClassDTO usuario = new ClassDTO();
            //Pon tu codigo aqui
            // Creamos la conexión
            SqlConnection connection = new SqlConnection();
            try
            {
                // asignamos la cadena de conexion y abrimos la conexion
                connection.ConnectionString = sqlCNX;
                connection.Open();

                // creamos y ejecutamos el comando sql
               // SqlCommand cmd2 = new SqlCommand("SELECT * FROM usuarios where " + criterio + "='" + valor + "'", connection);
                string donde = criterio;
                /*bool control=false;
                switch (criterio)
                {
                    case "nif":
                        if (control)
                            donde  = donde+" AND NIF ='" +valor+"'";
                        else
                            donde = donde + " AND NIF ='" + valor + "'";
                        control = true;
                        break;
                    case "nombre":
                        if (control)
                            donde  = donde+" AND NOMBRE ='" +valor+"'";
                        else
                            donde = donde + " AND NOMBRE ='" + valor + "'";
                        control = true;
                        break;
                    case "clave":
                        if (control)
                            donde  = donde+" AND CLAVE ='" +valor+"'";
                        else
                            donde = donde + " AND CLAVE ='" + valor + "'";
                        control = true;
                        break;
                    case "rol":
                        if (control)
                            donde  = donde+" AND ROL ='" +valor+"'";
                        else
                            donde = donde + " AND ROL ='" + valor + "'";
                        control = true;
                        break;
                    case "email":
                        if (control)
                            donde  = donde+" AND EMAIL ='" +valor+"'";
                        else
                            donde = donde + " AND EMAIL ='" + valor + "'";
                        control = true;
                        break;
                    case "direccion":
                        if (control)
                            donde  = donde+" AND DIRECCION ='" +valor+"'";
                        else
                            donde = donde + " AND DIRECCION ='" + valor + "'";
                        control = true;
                        break;
                    case "ciudad":
                        if (control)
                            donde  = donde+" AND CIUDAD ='" +valor+"'";
                        else
                            donde = donde + " AND CIUDAD ='" + valor + "'";
                        control = true;
                        break;
                    case "provincia":
                        if (control)
                            donde  = donde+" AND PROVINCIA ='" +valor+"'";
                        else
                            donde = donde + " AND PROVINCIA ='" + valor + "'";
                        control = true;
                        break;
                    case "telefono":
                        if (control)
                            donde  = donde+" AND TELEFONO ='" +valor+"'";
                        else
                            donde = donde + " AND TELEFONO ='" + valor + "'";
                        control = true;;
                        break;
                    case "codigo postal":
                        if (control)
                            donde  = donde+" AND CODIGOPOSTAL ='" +valor+"'";
                        else
                            donde = donde + " AND CODIGOPOSTAL ='" + valor + "'";
                        control = true;
                        break;
                    case "saldo":
                        if (control)
                            donde  = donde+" AND SALDO ='" +valor+"'";
                        else
                            donde = donde + " AND SALDO ='" + valor + "'";
                        control = true;
                        break;
                }*/
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM usuarios where " + donde, connection);
                //IDataReader
                SqlDataReader num = cmd2.ExecuteReader();

                // limpiamos y añadimos los elementos

                while (num.Read())
                {
                    usuario.setUsuarioID(Convert.ToInt32(num[0]));
                    usuario.setNif(num[1].ToString());
                    usuario.setClave(num[2].ToString());
                    usuario.setRol(Convert.ToInt32(num[3]));
                    usuario.setNombre(num[4].ToString());
                    usuario.setTelefono(num[5].ToString());
                    usuario.setEmail(num[6].ToString());
                    usuario.setDireccion(num[7].ToString());
                    usuario.setCiudad(num[8].ToString());
                    usuario.setProvincia(num[9].ToString());
                    usuario.setCodigoPostal(Convert.ToDecimal(num[10]));
                    usuario.setSaldo(Convert.ToDecimal(num[11]));
                    i++;
                    res.Add(usuario);
                }

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                {
                    // cerramos y destruimos la conexion
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }

            }

            return res;
        }


        public override List<ClassDTO> ObtenerUsuarios()
        {
            List<ClassDTO> res = new List<ClassDTO>();
            int i = 0;
            ClassDTO usuario = new ClassDTO();
            //Pon tu codigo aqui
            // Creamos la conexión
            SqlConnection connection = new SqlConnection();
            try
            {
                // asignamos la cadena de conexion y abrimos la conexion
                connection.ConnectionString = sqlCNX;
                connection.Open();

                // creamos y ejecutamos el comando sql
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM usuarios", connection);

                //IDataReader
                SqlDataReader num = cmd2.ExecuteReader();

                // limpiamos y añadimos los elementos

                while (num.Read())
                {
                    usuario.setUsuarioID(Convert.ToInt32(num[0]));
                    usuario.setNif(num[1].ToString());
                    usuario.setClave(num[2].ToString());
                    usuario.setRol(Convert.ToInt32(num[3]));
                    usuario.setNombre(num[4].ToString());
                    usuario.setTelefono(num[5].ToString());
                    usuario.setEmail(num[6].ToString());
                    usuario.setDireccion(num[7].ToString());
                    usuario.setCiudad(num[8].ToString());
                    usuario.setProvincia(num[9].ToString());
                    usuario.setCodigoPostal(Convert.ToDecimal(num[10]));
                    usuario.setSaldo(Convert.ToDecimal(num[11]));
                    i++;
                    res.Add(usuario);
                }

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                {
                    // cerramos y destruimos la conexion
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }

            }

            return res;
        }

        //public virtual bool conectar(string cadena);

        //public virtual bool desconectar(string cadena);



    }
}
