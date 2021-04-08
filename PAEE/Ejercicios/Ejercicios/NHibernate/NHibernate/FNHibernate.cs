using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;

namespace EjercicioNHibernate
{
    public partial class FNHibernate : Form
    {
        // componentes de  NHIBERNATE
        //Configuracion
        Configuration cfg;
        // para realizar la sesion
        ISessionFactory factory;
        // session con la base de datos
        ISession session;

        public FNHibernate()
        {
            InitializeComponent();
            // aplicamos la configuracion del ensamblaje
            cfg = new Configuration();
            cfg.AddAssembly("EjercicioNHibernate");

            // asignamos la configuracion para crear las sesiones con la base de datos
            factory = cfg.BuildSessionFactory();
        }

        #region "Metodos de acceso con NHibernate"

        //Agregar un nuevo usuario con los datos inventados por ti
        //Mostrar los resultados en el ListView
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            try
            {
                // abrimos la session con la base de datos
                session = factory.OpenSession();

                // creamos un usuario nuevo
                Usuario nuevoUsuario = new Usuario();

                // rellenamos el usuario
                nuevoUsuario.Nombre = "Desiderio Marti";
                nuevoUsuario.Nif = "00000001T";
                nuevoUsuario.Clave = "XtkPp4Hvnb96/wcy2JhhOP7LraFgWYb4";
                nuevoUsuario.Rol = 1;
                nuevoUsuario.Email = "http://desimarti.org";
                nuevoUsuario.Direccion = "c/ Hernan Cortes 19";
                nuevoUsuario.Ciudad = "Alicante";
                nuevoUsuario.Provincia = "Alitante";
                nuevoUsuario.Telefono = "983144879";
                nuevoUsuario.CodigoPostal = 03071;
                nuevoUsuario.Saldo = 37;

                // Guardar el objeto en la base de datos
                session.Save(nuevoUsuario);


                MessageBox.Show("Usuario insertado correctamente");

                // mostramos la tabla en el listview
                MostrarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
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
        }

        //Actualizar la tabla Usuarios y poner el nombre=ANTONIO para el usuario con UsuarioId=12
        //Mostrar los resultados en el ListView
        private void btnUptUser_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            try
            {
                // abrimos una session con la base de datos
                session = factory.OpenSession();

                // obtenemos el usuario del id 12 y lo modificamos
                Usuario Antonio = (Usuario)session.Load(typeof(Usuario), 12);
                Antonio.Nombre = "ANTONIO";
                // actualizamos la session con la base de datos
                session.Flush();

                MessageBox.Show("Usuario Actualizado correctamente");
                // mostramos la base de datos en el listview
                MostrarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
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
        }

        //Borrar de la tabla Usuarios el usuario con UsuarioId=7
        //Mostrar los resultados en el ListView
        private void btnDelUser_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            try
            {
                // abrimos una session con la base de datos
                session = factory.OpenSession();

                // obtenemos el usuario con el id 7 y lo borramos
                Usuario desiMarti = (Usuario)session.Load(typeof(Usuario), 7);
                session.Delete(desiMarti);

                // refrescamos la session con la base de datos
                session.Flush();

                MessageBox.Show("Usuario borrado correctamente");
                // mostramos la tabla usuarios en el listview
                MostrarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
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
        }

        //Obtener todos los usuarios de la provincia de Madrid
        //Mostrar los resultados en el ListView
        private void btnSelUser_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            try
            {
                // abrimos la session en la base de datos
                session = factory.OpenSession();

                //buscamos los usuarios que tengan como ciudad algo que contenga Madrid
                IList recentUsuarios = session.CreateCriteria(typeof(Usuario))
                    //.Add(Expression.Like("Nombre", "%deri%"))
                    .Add(Expression.Sql("ciudad like '%Madrid%'"))
                    //.Add(Expression.Like("Nombre", "%mart%")) para añadir otra restricción con "and"
                    .List();


                // limpiamos y mostramos los resultados en el listview
                this.listView1.Items.Clear();
                foreach (Usuario usuario in recentUsuarios)
                {
                    AddLog(usuario.UsuarioID + ", " + usuario.Nif + ", " + usuario.Nombre + ", " + usuario.Clave + ", " + usuario.Rol + ", " + usuario.Email + ", " + usuario.Telefono + ", " + usuario.Direccion + ", " + usuario.Ciudad + ", " + usuario.Provincia + ", " + usuario.CodigoPostal + ", " + usuario.Saldo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
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
        }
        #endregion

        #region "Metodos para mostrar todos los usuarios"
        private void MostrarTabla()
        {
            //Pon tu codigo aqui
            try
            {
                // abrimos una session en la base de datos
                session = factory.OpenSession();

                //obtenemos los usuarios de la tabla usuarios
                IList recentUsuarios = session.CreateCriteria(typeof(Usuario)).List();
                
                // limpiamos y mostramos los resultados en el listview
                this.listView1.Items.Clear();
                foreach (Usuario usuario in recentUsuarios)
                {
                    AddLog(usuario.UsuarioID + ", " + usuario.Nif + ", " + usuario.Nombre + ", " + usuario.Clave + ", " + usuario.Rol + ", " + usuario.Email + ", " + usuario.Telefono + ", " + usuario.Direccion + ", " + usuario.Ciudad + ", " + usuario.Provincia + ", " + usuario.CodigoPostal + ", " + usuario.Saldo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
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
        }

        #endregion

        #region "Metodos para grabar en ListView y DataGridView"
        //Añade al listview la cadena indicada como parámetro
        private void AddLog(string cadena)
        {
            this.listView1.Items.Add(cadena);
        }
        #endregion

    }
}
