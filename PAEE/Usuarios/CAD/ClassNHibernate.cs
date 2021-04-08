using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;

using DTO;
using System.Collections;

namespace CAD
{
    public class ClassNHibernate : ClassICAD
    {
                // componentes de  NHIBERNATE
        //Configuracion
        Configuration cfg;
        // para realizar la sesion
        ISessionFactory factory;
        // session con la base de datos
        ISession session;

        public ClassNHibernate()
        {
            // aplicamos la configuracion del ensamblaje
            cfg = new Configuration();
            cfg.AddAssembly("CAD");

            // asignamos la configuracion para crear las sesiones con la base de datos
            factory = cfg.BuildSessionFactory();
        }

        public override int InsertarUsuario(string nif, string clave, int rol, string nombre, string telefono, string email, string direccion, string ciudad, string provincia, decimal codigoPostal, decimal saldo)
        {
            try
            {
                // abrimos la session con la base de datos
                session = factory.OpenSession();

                // creamos un usuario nuevo
                EjercicioNHibernate.Usuario nuevoUsuario = new EjercicioNHibernate.Usuario();

                // rellenamos el usuario
                nuevoUsuario.Nombre = nombre;
                nuevoUsuario.Nif = nif;
                nuevoUsuario.Clave = clave;
                nuevoUsuario.Rol = rol;
                nuevoUsuario.Email = email;
                nuevoUsuario.Direccion = direccion;
                nuevoUsuario.Ciudad = ciudad;
                nuevoUsuario.Provincia = provincia;
                nuevoUsuario.Telefono = telefono;
                nuevoUsuario.CodigoPostal = codigoPostal;
                nuevoUsuario.Saldo = saldo;

                // Guardar el objeto en la base de datos
                session.Save(nuevoUsuario);



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (session != null)
                {
                    //Cerrar la sesión
                    session.Close();
                }
                session = null;
            }
            return 1;
        }
        public override int ActualizarUsuario(ClassDTO usuario, Int32 id)
        {
            try
            {
                // abrimos una session con la base de datos
                session = factory.OpenSession();

                // obtenemos el usuario del id 12 y lo modificamos
                EjercicioNHibernate.Usuario Antonio = (EjercicioNHibernate.Usuario)session.Load(typeof(EjercicioNHibernate.Usuario), id);

                        Antonio.Nif = usuario.getNif();

                        Antonio.Nombre = usuario.getNombre();

                        Antonio.Clave = usuario.getClave();

                        Antonio.Rol = (int)usuario.getRol();
    
                        Antonio.Email = usuario.getEmail();
        
                        Antonio.Direccion = usuario.getDireccion();
     
                        Antonio.Ciudad = usuario.getCiudad();

                        Antonio.Provincia = usuario.getProvincia();

                        Antonio.Telefono = usuario.getTelefono();

                        Antonio.CodigoPostal = usuario.getCodigoPostal();

                        Antonio.Saldo = usuario.getSaldo();

                // actualizamos la session con la base de datos
                session.Flush();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (session != null)
                {
                    //Cerrar la sesión
                    session.Close();
                }
                session = null;
            }
            return 1;
        }

        public override int BorrarUsuario(Int32 id)
        {
            try
            {
                // abrimos una session con la base de datos
                session = factory.OpenSession();

                // obtenemos el usuario con el id 7 y lo borramos
                EjercicioNHibernate.Usuario desiMarti = (EjercicioNHibernate.Usuario)session.Load(typeof(EjercicioNHibernate.Usuario), id);
                session.Delete(desiMarti);

                // refrescamos la session con la base de datos
                session.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (session != null)
                {
                    //Cerrar la sesión
                    session.Close();
                }
                session = null;
            }
            return  1;
        
        }

        public override List<ClassDTO> ObtenerUsuario(string criterio)
        {
            List<ClassDTO> Users = new List<ClassDTO>();
            try
            {
               
                // abrimos la session en la base de datos
                session = factory.OpenSession();

                //buscamos los usuarios que tengan como ciudad algo que contenga Madrid
                IList recentUsuarios = session.CreateCriteria(typeof(EjercicioNHibernate.Usuario))
                    //.Add(Expression.Like("Nombre", "%deri%"))
                    .Add(Expression.Sql(criterio))
                    //.Add(Expression.Like("Nombre", "%mart%")) para añadir otra restricción con "and"
                    .List();
                foreach (EjercicioNHibernate.Usuario usuario in recentUsuarios)
                {
                    ClassDTO usr = new ClassDTO();
                    usr.setUsuarioID(usuario.UsuarioID);
                    usr.setNif(usuario.Nif);
                    usr.setClave(usuario.Clave);
                    usr.setRol(usuario.Rol);
                    usr.setNombre(usuario.Nombre);
                    usr.setTelefono(usuario.Telefono);
                    usr.setEmail(usuario.Email);
                    usr.setDireccion(usuario.Direccion);
                    usr.setCiudad(usuario.Ciudad);
                    usr.setProvincia(usuario.Provincia);
                    usr.setCodigoPostal(usuario.CodigoPostal);
                    usr.setSaldo(usuario.Saldo);

                   Users.Add(usr);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (session != null)
                {
                    //Cerrar la sesión
                    session.Close();
                }
                session = null;
            }
            return Users;

        }

        public override List<ClassDTO> ObtenerUsuarios()
        {

            List<ClassDTO> Users = new List<ClassDTO>();
            try
            {
                
               
                // abrimos la session en la base de datos
                session = factory.OpenSession();

                //buscamos los usuarios que tengan como ciudad algo que contenga Madrid
                IList recentUsuarios = session.CreateCriteria(typeof(EjercicioNHibernate.Usuario)).List();
                foreach (EjercicioNHibernate.Usuario usuario in recentUsuarios)
                {
                    ClassDTO usr = new ClassDTO();
                    usr.setUsuarioID(usuario.UsuarioID);
                    usr.setNif(usuario.Nif);
                    usr.setClave(usuario.Clave);
                    usr.setRol(usuario.Rol);
                    usr.setNombre(usuario.Nombre);
                    usr.setTelefono(usuario.Telefono);
                    usr.setEmail(usuario.Email);
                    usr.setDireccion(usuario.Direccion);
                    usr.setCiudad(usuario.Ciudad);
                    usr.setProvincia(usuario.Provincia);
                    usr.setCodigoPostal(usuario.CodigoPostal);
                    usr.setSaldo(usuario.Saldo);

                   Users.Add(usr);
                }
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (session != null)
                {
                    //Cerrar la sesión
                    session.Close();
                }
                session = null;
                
               
            }
            return Users;
        }

        //public abstract bool conectar(string cadena);

        //public abstract bool desconectar(string cadena);
    }
}
