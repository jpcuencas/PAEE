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

namespace EjemploNHibernate
{
    public partial class FNHibernate : Form
    {
        Configuration cfg;
        ISessionFactory factory;
        ISession session;

        public FNHibernate()
        {
            InitializeComponent();

            cfg = new Configuration();
            cfg.AddAssembly("EjemploNHibernate");

            factory = cfg.BuildSessionFactory();
        }

        private void AddActor_Click(object sender, EventArgs e)
        {
            try
            {
                session = factory.OpenSession();

                //Ejemplo con transacciones
                ITransaction transaction = session.BeginTransaction();

                Actor nuevoActor = new Actor();
                nuevoActor.Nombre = "Desiderio Marti";
                nuevoActor.UrlPersonal = "http://desimarti.org";

                // Guardar el objeto
                session.Save(nuevoActor);

                // Hacer Commit
                transaction.Commit();

                MessageBox.Show("Actor insertado correctamente");
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

        private void UpdateActor_Click(object sender, EventArgs e)
        {
            try
            {
                session = factory.OpenSession();

                Actor desiMarti = (Actor)session.Load(typeof(Actor), 613);
                desiMarti.Nombre = "Desiderio";
                session.Flush();

                MessageBox.Show("Actor Actualizado correctamente");
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

        private void SelectAllActores_Click(object sender, EventArgs e)
        {
            try
            {
                session = factory.OpenSession();

                IList userList = session.CreateCriteria(typeof(Actor)).List();
                this.listaResultados.Items.Clear();
                foreach (Actor actor in userList)
                {
                    this.listaResultados.Items.Add(actor.ActorID + ", " + actor.Nombre + ", " + actor.UrlPersonal);
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

        private void SelectFilterActores_Click(object sender, EventArgs e)
        {
            try
            {
                session = factory.OpenSession();

                IList recentActores = session.CreateCriteria(typeof(Actor))
                    //.Add(Expression.Like("Nombre", "%deri%"))
                    .Add(Expression.Sql("nombre like '%nina%'"))
                    //.Add(Expression.Like("Nombre", "%mart%")) para añadir otra restricción con "and"
                    .List();

                

                this.listaResultados.Items.Clear();
                foreach (Actor actor in recentActores)
                {
                    this.listaResultados.Items.Add(actor.ActorID + ", " + actor.Nombre + ", " + actor.UrlPersonal);
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

        private void DeleteActor_Click(object sender, EventArgs e)
        {
            try
            {
                session = factory.OpenSession();

                Actor desiMarti = (Actor)session.Load(typeof(Actor), 614);
                session.Delete(desiMarti);

                session.Flush();

                MessageBox.Show("Actor borrado correctamente");
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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
