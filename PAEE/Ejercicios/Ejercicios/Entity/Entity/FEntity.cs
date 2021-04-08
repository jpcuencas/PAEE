using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.EntityClient;




namespace Entity
{
    public partial class FEntity : Form
    {
        public FEntity()
        {
            InitializeComponent();
        }

        #region "Metodos de acceso con Entity Framework"

        //Agregar un nuevo usuario con los datos inventados por ti
        //Mostrar los resultados en el ListView
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // instanciamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {
                // instanciamos y creamos un objeto de la base de datos
                Usuarios nuevoUsuario = new Usuarios();

                // rellenamos los valores del nuevo objeto
                nuevoUsuario.Nombre = "Desiderio Marti";
                nuevoUsuario.NIF = "00000001T";
                nuevoUsuario.Clave = "XtkPp4Hvnb96/wcy2JhhOP7LraFgWYb4";
                nuevoUsuario.Rol = 1;
                nuevoUsuario.Email = "http://desimarti.org";
                nuevoUsuario.Direccion = "c/ Hernan Cortes 19";
                nuevoUsuario.Ciudad = "Alicante";
                nuevoUsuario.Provincia = "Alitante";
                nuevoUsuario.Telefono = "983144879";
                nuevoUsuario.CodigoPostal = 03071;
                nuevoUsuario.Saldo = 37;
                
                //añadimos el objeto a su tabla y guardamos los cambios en la base de datos
                contexto.AddToUsuarios(nuevoUsuario);
                contexto.SaveChanges();

                MessageBox.Show("Usuario insertado correctamente");
                //mostramos el contenido de la tabla usuarios
                MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {
                //destruimos la entidad
                if(contexto != null)
                contexto.Dispose();
                contexto = null;
            }
        }

        //Actualizar la tabla Usuarios y poner el nombre=ANTONIO para el usuario con UsuarioId=12
        //Mostrar los resultados en el ListView
        private void btnUptUser_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // creamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {
                // realizamos una consulta a la entidad de base de datos
                // y actualizamos
                var usuario = (from a in contexto.Usuarios
                             where a.UsuarioID == 12
                             select a).First().Nombre="ANTONIO";

                // guardamos los cambios en la base de datos
                contexto.SaveChanges();

                MessageBox.Show("Usuario Actualizado correctamente");
                // mostramos el contenido de la tabla usuarios
                MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {
                //destruimos la entidad
                if (contexto != null)
                    contexto.Dispose();
                contexto = null;
            }
        }

        //Borrar de la tabla Usuarios el usuario con UsuarioId=7
        //Mostrar los resultados en el ListView
        private void btnDelUser_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // creamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {
               // consultamos la entidad de la base de datos
                var usuario = (from a in contexto.Usuarios
                             where a.UsuarioID == 7
                             select a).First();

                // borramos el usuario de la consulta
                contexto.DeleteObject(usuario);
                // guardamos los cambios en la base de datos
                contexto.SaveChanges();

                MessageBox.Show("Usuario borrado correctamente");
                // mostramos el contenido de la tabla usuarios
                MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {
                //destruimos la entidad
                if (contexto != null)
                    contexto.Dispose();
                contexto = null;
            }
        }

        //Obtener todos los usuarios de la provincia de Madrid
        //Mostrar los resultados en el ListView
        private void btnSelUser_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // instanciamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {
                // consultamos los usuarios que tiene como provincia madrid
                var listaUsuarios = from usuario in contexto.Usuarios
                                    where usuario.Provincia.Contains("Madrid")
                                    select usuario;

                // limpiamos y añadimos el resultado al listview
                this.listView1.Items.Clear();
                this.listView1.Items.Add("LINQ to Entities");
                foreach (Usuarios usuario in listaUsuarios)
                {
                    this.listView1.Items.Add(usuario.UsuarioID + ", " + usuario.NIF + ", " + usuario.Nombre + ", " + usuario.Clave + ", " + usuario.Rol + ", " + usuario.Email + ", " + usuario.Telefono + ", " + usuario.Direccion + ", " + usuario.Ciudad + ", " + usuario.Provincia + ", " + usuario.CodigoPostal + ", " + usuario.Saldo);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {
                //destruimos la entidad
                if (contexto != null)
                    contexto.Dispose();
                contexto = null;
            }

        }
        #endregion

        #region "Mostar todos los usuairos"
        private void MostrarUsuarios()
        {
            // instanciamos una entidad de la base de datos
            MSDNVideoEntities1 contexto = new MSDNVideoEntities1();
            try
            {
                //Consultamos todos los usuarios de la tabla usuaros
                var listaUsuarios = from usuario in contexto.Usuarios
                                   select usuario;

                // limpiamos y añadimos el resultado al listview
                this.listView1.Items.Clear();
                foreach (Usuarios usuario in listaUsuarios)
                {
                    this.listView1.Items.Add(usuario.UsuarioID + ", " + usuario.NIF + ", " + usuario.Nombre + ", " + usuario.Clave + ", " + usuario.Rol + ", " + usuario.Email + ", " + usuario.Telefono + ", " + usuario.Direccion + ", " + usuario.Ciudad + ", " + usuario.Provincia + ", " + usuario.CodigoPostal + ", " + usuario.Saldo);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {
                //destruimos la entidad
                if (contexto != null)
                    contexto.Dispose();
                contexto = null;
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
