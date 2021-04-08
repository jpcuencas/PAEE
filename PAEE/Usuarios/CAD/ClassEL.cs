using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Collections;

using DTO;
using System.Data;

namespace CAD
{
    public class ClassEL : ClassICAD
    {

        public override int InsertarUsuario(string nif, string clave, int rol, string nombre, string telefono, string email, string direccion, string ciudad, string provincia, decimal codigoPostal, decimal saldo)
        {
            int res = 0;

            try
            {
                //comando sql a ejecutar
                string sql = "INSERT INTO Usuarios (NIF,Clave,Rol,Nombre,Telefono,Email,Direccion,Ciudad,Provincia,CodigoPostal,Saldo) VALUES ('"+ nif +"','" + clave +"','" + rol + "','" + nombre + "','" + telefono + "','" + email + "','" + direccion + "','" + ciudad + "','" + provincia + "','" + codigoPostal + "','" + saldo + "')";

                // instanciamos el objeto base de datos y ejecutamos el comando
                Database dataBase = DatabaseFactory.CreateDatabase();
                int fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                res = 1;
                //lblnumfilafectadas.Text = cadena.ToString();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return res;
        }

        public override int ActualizarUsuario(ClassDTO usuario, Int32 id)
        {
            int res = 0;

            try
            {
                // instanciamos el objeto base de datos 
                Database dataBase = DatabaseFactory.CreateDatabase();

                //comando sql a ejecutar
                string sql = "UPDATE Usuarios SET nif ='" + usuario.getNif() + "' where UsuarioID="+id+"";

                //ejecutamos el comando
               
                int fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET nombre ='" + usuario.getNombre() + "' where UsuarioID=" + id + "";

                //ejecutamos el comando 

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET clave ='" + usuario.getClave() + "' where UsuarioID=" + id + "";

                //ejecutamos el comando

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET rol ='" + usuario.getRol() + "' where UsuarioID=" + id + "";

                //ejecutamos el comando

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET telefono ='" + usuario.getTelefono() + "' where UsuarioID=" + id + "";

                //ejecutamos el comando

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET email ='" + usuario.getEmail() + "' where UsuarioID=" + id + "";

                //ejecutamos el comando

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET direccion ='" + usuario.getDireccion() + "' where UsuarioID=" + id + "";

                //ejecutamos el comando

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET proincia ='" + usuario.getProvincia() + "' where UsuarioID=" + id + "";

                //ejecutamos el comando

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET ciudad ='" + usuario.getCiudad() + "' where UsuarioID=" + id + "";

                //ejecutamos el comando

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET codigopostal ='" + usuario.getCodigoPostal() + "' where UsuarioID=" + id + "";

                //ejecutamos el comando

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                 sql = "UPDATE Usuarios SET saldo ='" + usuario.getSaldo() + "' where UsuarioID=" + id + "";

                 //ejecutamos el comando

                 fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                res = 1;
                //lblnumfilafectadas.Text = cadena.ToString();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return res;
        }

        public override int BorrarUsuario(Int32 id)
        {
            int res = 0;

            try
            {
                //comando sql a ejecutar
                string sql = "DELETE FROM Usuarios where UsuarioID=" + id + "";

                // instanciamos el objeto base de datos y ejecutamos el comando
                Database dataBase = DatabaseFactory.CreateDatabase();
                int fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

                res = 1;
                //lblnumfilafectadas.Text = cadena.ToString();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return res;        
        }

        public override List<ClassDTO> ObtenerUsuario(string criterio) 
        {
            List<ClassDTO> res = new List<ClassDTO>();
            int i = 0;
            ClassDTO usuario = new ClassDTO();
            try
            {
                // comando sql a ejecutar
                string donde = criterio;
               // bool control = false;
                /*switch (criterio)
                {
                    case "nif":
                        if (control)
                            donde = donde + " AND NIF ='" + valor + "'";
                        else
                            donde = donde + " AND NIF ='" + valor + "'";
                        control = true;
                        break;
                    case "nombre":
                        if (control)
                            donde = donde + " AND NOMBRE ='" + valor + "'";
                        else
                            donde = donde + " AND NOMBRE ='" + valor + "'";
                        control = true;
                        break;
                    case "clave":
                        if (control)
                            donde = donde + " AND CLAVE ='" + valor + "'";
                        else
                            donde = donde + " AND CLAVE ='" + valor + "'";
                        control = true;
                        break;
                    case "rol":
                        if (control)
                            donde = donde + " AND ROL ='" + valor + "'";
                        else
                            donde = donde + " AND ROL ='" + valor + "'";
                        control = true;
                        break;
                    case "email":
                        if (control)
                            donde = donde + " AND EMAIL ='" + valor + "'";
                        else
                            donde = donde + " AND EMAIL ='" + valor + "'";
                        control = true;
                        break;
                    case "direccion":
                        if (control)
                            donde = donde + " AND DIRECCION ='" + valor + "'";
                        else
                            donde = donde + " AND DIRECCION ='" + valor + "'";
                        control = true;
                        break;
                    case "ciudad":
                        if (control)
                            donde = donde + " AND CIUDAD ='" + valor + "'";
                        else
                            donde = donde + " AND CIUDAD ='" + valor + "'";
                        control = true;
                        break;
                    case "provincia":
                        if (control)
                            donde = donde + " AND PROVINCIA ='" + valor + "'";
                        else
                            donde = donde + " AND PROVINCIA ='" + valor + "'";
                        control = true;
                        break;
                    case "telefono":
                        if (control)
                            donde = donde + " AND TELEFONO ='" + valor + "'";
                        else
                            donde = donde + " AND TELEFONO ='" + valor + "'";
                        control = true; ;
                        break;
                    case "codigo postal":
                        if (control)
                            donde = donde + " AND CODIGOPOSTAL ='" + valor + "'";
                        else
                            donde = donde + " AND CODIGOPOSTAL ='" + valor + "'";
                        control = true;
                        break;
                    case "saldo":
                        if (control)
                            donde = donde + " AND SALDO ='" + valor + "'";
                        else
                            donde = donde + " AND SALDO ='" + valor + "'";
                        control = true;
                        break;
                }*/
                string sql = "SELECT nif,clave,rol,nombre,telefono,email,direccion,ciudad,provincia,codigopostal,saldo FROM usuarios where " + donde;

                // instanciamos la base de datos y ejecutamos el comando sql
                Database dataBase = DatabaseFactory.CreateDatabase();
                IDataReader fila = dataBase.ExecuteReader(CommandType.Text, sql);

                while (fila.Read())
                {
                    usuario.setUsuarioID(Convert.ToInt32(fila[0]));
                    usuario.setNif(fila[1].ToString());
                    usuario.setClave(fila[2].ToString());
                    usuario.setRol(Convert.ToInt32(fila[3]));
                    usuario.setNombre(fila[4].ToString());
                    usuario.setTelefono(fila[5].ToString());
                    usuario.setEmail(fila[6].ToString());
                    usuario.setDireccion(fila[7].ToString());
                    usuario.setCiudad(fila[8].ToString());
                    usuario.setProvincia(fila[9].ToString());
                    usuario.setCodigoPostal(Convert.ToDecimal(fila[10]));
                    usuario.setSaldo(Convert.ToDecimal(fila[11]));
                    i++;
                    
                    res.Add(usuario);
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return res;
        }

        public override List<ClassDTO> ObtenerUsuarios()
        {
            List<ClassDTO> res = new List<ClassDTO>();
            int i = 0;
            ClassDTO usuario = new ClassDTO();
            try
            {
                // comando sql a ejecutar
                string sql = "SELECT nif,clave,rol,nombre,telefono,email,direccion,ciudad,provincia,codigopostal,saldo FROM usuarios";

                // instanciamos la base de datos y ejecutamos el comando sql
                Database dataBase = DatabaseFactory.CreateDatabase();
                IDataReader fila = dataBase.ExecuteReader(CommandType.Text, sql);

                while (fila.Read())
                {
                    usuario.setUsuarioID(Convert.ToInt32(fila[0]));
                    usuario.setNif(fila[1].ToString());
                    usuario.setClave(fila[2].ToString());
                    usuario.setRol(Convert.ToInt32(fila[3]));
                    usuario.setNombre(fila[4].ToString());
                    usuario.setTelefono(fila[5].ToString());
                    usuario.setEmail(fila[6].ToString());
                    usuario.setDireccion(fila[7].ToString());
                    usuario.setCiudad(fila[8].ToString());
                    usuario.setProvincia(fila[9].ToString());
                    usuario.setCodigoPostal(Convert.ToDecimal(fila[10]));
                    usuario.setSaldo(Convert.ToDecimal(fila[11]));
                    i++;
                    
                    res.Add(usuario);
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return res;
        }

        //public abstract bool conectar(string cadena);

        //public abstract bool desconectar(string cadena);
    }
}
