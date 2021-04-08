using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace CAD
{
   public class ClassEntityFramework : ClassICAD
    {
       public override int InsertarUsuario(string nif, string clave, int rol, string nombre, string telefono, string email, string direccion, string ciudad, string provincia, decimal codigoPostal, decimal saldo)
        {
            int res = 0;

            // instanciamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {
                // instanciamos y creamos un objeto de la base de datos
                Usuarios nuevoUsuario = new Usuarios();

                // rellenamos los valores del nuevo objeto
                nuevoUsuario.Nombre = nombre;
                nuevoUsuario.NIF = nif;
                nuevoUsuario.Clave = clave;
                nuevoUsuario.Rol = (short) rol;
                nuevoUsuario.Email = email;
                nuevoUsuario.Direccion = direccion;
                nuevoUsuario.Ciudad = ciudad;
                nuevoUsuario.Provincia = provincia;
                nuevoUsuario.Telefono = telefono;
                nuevoUsuario.CodigoPostal = codigoPostal;
                nuevoUsuario.Saldo = saldo;

                //añadimos el objeto a su tabla y guardamos los cambios en la base de datos
                contexto.AddToUsuarios(nuevoUsuario);
                contexto.SaveChanges();

                res = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //destruimos la entidad
                if (contexto != null)
                    contexto.Dispose();
                contexto = null;
            }

            return res;
        }

       public override int ActualizarUsuario(ClassDTO usuario, Int32 id)
        {
            int res = 0;
            // creamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {
                // realizamos una consulta a la entidad de base de datos
                // y actualizamos

                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario1 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().NIF = usuario.getNif();

                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario2 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().Nombre = usuario.getNombre();

                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario3 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().Clave = usuario.getClave();

                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario4 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                        select a).First().Rol = (short)usuario.getRol();

                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario5 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().Email = usuario.getEmail();

                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario6 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().Direccion = usuario.getDireccion();

                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario7 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().Ciudad = usuario.getCiudad();

                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario8 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().Provincia = usuario.getProvincia();

                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario9 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().Telefono = usuario.getTelefono();
        
                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario10 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().CodigoPostal= usuario.getCodigoPostal();
 
                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                        var usuario11 = (from a in contexto.Usuarios
                                       where a.UsuarioID == id
                                       select a).First().Saldo = usuario.getSaldo();
      

                // guardamos los cambios en la base de datos
                contexto.SaveChanges();

                res = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //destruimos la entidad
                if (contexto != null)
                    contexto.Dispose();
                contexto = null;
            }
            return res;
        }

       public override int BorrarUsuario(Int32 id)
        {
            int res = 0;
            // creamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {

                // consultamos la entidad de la base de datos
                var usuario = (from a in contexto.Usuarios
                               where a.UsuarioID == id
                               select a).First();

                // borramos el usuario de la consulta
                contexto.DeleteObject(usuario);
                // guardamos los cambios en la base de datos
                contexto.SaveChanges();

                res = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //destruimos la entidad
                if (contexto != null)
                    contexto.Dispose();
                contexto = null;
            }
            return res;
        }

       public override List<ClassDTO> ObtenerUsuario(string donde)
        {
            List<ClassDTO> res = new List<ClassDTO>();

            ClassDTO usuarionuevo = new ClassDTO();
            // instanciamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {
                string criterio = "";
                string valor = ""; ;

                bool igual = false;
                for (int j = 0; j < donde.Length; j++)
                {
                    if (igual)
                    {
                        if (donde[j] == ' ') j++;
                        else if (donde.Substring(3) == "AND") j += 4;
                        else if (donde[j] == '=')
                        {
                            igual = true;
                            j++;
                        }
                        else 
                        {
                            valor+=donde[j];
                        }
                    }
                    else
                    {
                        if (donde[j] == ' ') j++;
                        else if (donde.Substring(3) == "AND ") j += 4;
                        else
                        {
                            criterio += donde[j];
                        }
                    }
                }

                


                
               IEnumerable<Usuarios>  listaUsuarios1=null;
                switch (criterio)
                {
                    case "nif":
                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                      listaUsuarios1  = from usuario in contexto.Usuarios
                                    where usuario.NIF.Contains(valor.ToString())
                                    select usuario;
                        break;
                    case "nombre":
                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                      listaUsuarios1  = from usuario in contexto.Usuarios
                                    where usuario.Nombre.Contains(valor.ToString())
                                    select usuario;

                        break;
                    case "clave":
                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                       listaUsuarios1  = from usuario in contexto.Usuarios
                                    where usuario.Clave.Contains(valor.ToString())
                                    select usuario;                     
                        break;
                    case "rol":
                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                       
                        listaUsuarios1  = from usuario in contexto.Usuarios
                                          where usuario.Rol == System.Decimal.Parse(valor)
                                    select usuario;
                        
                      break;
                  case "email":
                      // realizamos una consulta a la entidad de base de datos
                      // y actualizamos
                    listaUsuarios1  = from usuario in contexto.Usuarios
                                  where usuario.Email.Contains(valor.ToString())
                                  select usuario;
                     
                      break;
                  case "direccion":
                      // realizamos una consulta a la entidad de base de datos
                      // y actualizamos
                     listaUsuarios1  = from usuario in contexto.Usuarios
                                  where usuario.Direccion.Contains(valor.ToString())
                                  select usuario;
                      
                      break;
                  case "ciudad":
                      // realizamos una consulta a la entidad de base de datos
                      // y actualizamos
                     listaUsuarios1  = from usuario in contexto.Usuarios
                                  where usuario.Ciudad.Contains(valor.ToString())
                                  select usuario;
   
                      break;
                  case "provincia":
                      // realizamos una consulta a la entidad de base de datos
                      // y actualizamos
                     listaUsuarios1  = from usuario in contexto.Usuarios
                                  where usuario.Provincia.Contains(valor.ToString())
                                  select usuario;
  
                      break;
                  case "telefono":
                      // realizamos una consulta a la entidad de base de datos
                      // y actualizamos
                     listaUsuarios1  = from usuario in contexto.Usuarios
                                  where usuario.Telefono==valor
                                  select usuario;
                     
                      break;
                  case "codigo postal":
                      // realizamos una consulta a la entidad de base de datos
                      // y actualizamos
                     listaUsuarios1  = from usuario in contexto.Usuarios
                                  where usuario.CodigoPostal==System.Decimal.Parse(valor)
                                  select usuario;
                       
                        break;
                    case "saldo":
                        // realizamos una consulta a la entidad de base de datos
                        // y actualizamos
                       listaUsuarios1  = from usuario in contexto.Usuarios
                                    where usuario.Saldo==System.Decimal.Parse(valor)
                                    select usuario;
                         
                  break;
          }
            int i =0;
          foreach (Usuarios usuario in listaUsuarios1)
          {
              usuarionuevo.setUsuarioID(usuario.UsuarioID);
              usuarionuevo.setNif(usuario.NIF);
              usuarionuevo.setNombre(usuario.Nombre);
              usuarionuevo.setClave(usuario.Clave);
              usuarionuevo.setRol(usuario.Rol);
              usuarionuevo.setEmail(usuario.Email);
              usuarionuevo.setTelefono(usuario.Telefono);
              usuarionuevo.setDireccion(usuario.Direccion);
              usuarionuevo.setCiudad(usuario.Ciudad);
              usuarionuevo.setProvincia(usuario.Provincia);
              usuarionuevo.setCodigoPostal(Convert.ToDecimal(usuario.CodigoPostal));
              usuarionuevo.setSaldo(Convert.ToDecimal(usuario.Saldo));

              i++;

              res.Add(usuarionuevo);
          }

          
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //destruimos la entidad
                if (contexto != null)
                    contexto.Dispose();
                contexto = null;
            }

            return res;
        }

       public override List<ClassDTO> ObtenerUsuarios()
        {
            List<ClassDTO> res = new List<ClassDTO>();
            int i = 0;
            ClassDTO usuarionuevo = new ClassDTO();
            // instanciamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {
                IQueryable listaUsuarios;
                listaUsuarios = from usuario in contexto.Usuarios
                                select usuario;

                foreach (Usuarios usuario in listaUsuarios)
                {
                    usuarionuevo.setUsuarioID(usuario.UsuarioID);
                    usuarionuevo.setNif(usuario.NIF);
                    usuarionuevo.setNombre(usuario.Nombre);
                    usuarionuevo.setClave(usuario.Clave);
                    usuarionuevo.setRol(usuario.Rol);
                    usuarionuevo.setEmail(usuario.Email);
                    usuarionuevo.setTelefono(usuario.Telefono);
                    usuarionuevo.setDireccion(usuario.Direccion);
                    usuarionuevo.setCiudad(usuario.Ciudad);
                    usuarionuevo.setProvincia(usuario.Provincia);
                    usuarionuevo.setCodigoPostal(Convert.ToDecimal(usuario.CodigoPostal));
                    usuarionuevo.setSaldo(Convert.ToDecimal(usuario.Saldo));

                    i++;

                    res.Add(usuarionuevo);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //destruimos la entidad
                if (contexto != null)
                    contexto.Dispose();
                contexto = null;
            }

            return res;
        }

        //public virtual bool conectar(string cadena);

        //public virtual bool desconectar(string cadena);
    }
}
