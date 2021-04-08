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
using EjemploEntityFramework;


namespace EjemploNHibernate
{
    public partial class FNHibernate : Form
    {
        

        public FNHibernate()
        {
            InitializeComponent();
        }

        private void AddActor_Click(object sender, EventArgs e)
        {
            try
            {
                MSDNVideoDBEntities contexto = new MSDNVideoDBEntities();

                Actores nuevoActor = new Actores();
                nuevoActor.Nombre = "Desiderio Marti";
                nuevoActor.UrlPersonal = "http://desimarti.org";
                contexto.AddToActores(nuevoActor);
                contexto.SaveChanges();

                MessageBox.Show("Actor insertado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {
            }
        }

        private void UpdateActor_Click(object sender, EventArgs e)
        {
            try
            {
                MSDNVideoDBEntities contexto = new MSDNVideoDBEntities();

                var actor = (from a in contexto.Actores
                            where a.ActorID == 611
                            select a).First();

                actor.Nombre = "Desiderio";
                contexto.SaveChanges();

                MessageBox.Show("Actor Actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {
            }
        }

        private void SelectAllActores_Click(object sender, EventArgs e)
        {
            try
            {
                MSDNVideoDBEntities contexto = new MSDNVideoDBEntities();

                //LINQ to Entities
                var listaActores = from actor in contexto.Actores
                                select actor;
                this.listaResultados.Items.Clear();
                this.listaResultados.Items.Add("LINQ to Entities");
                foreach (Actores actor in listaActores)
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
                
            }
            
        }

        private void SelectFilterActores_Click(object sender, EventArgs e)
        {
            try
            {
                MSDNVideoDBEntities contexto = new MSDNVideoDBEntities();

                //LINQ to Entities
                var listaActores = from actor in contexto.Actores
                                   where actor.Nombre.Contains("deri")
                                   select actor;
                this.listaResultados.Items.Clear();
                this.listaResultados.Items.Add("LINQ to Entities");
                foreach (Actores actor in listaActores)
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
            }
        }

        private void DeleteActor_Click(object sender, EventArgs e)
        {
            try
            {
                MSDNVideoDBEntities contexto = new MSDNVideoDBEntities();

                var actor = (from a in contexto.Actores
                            where a.ActorID == 610
                            select a).First();

                contexto.DeleteObject(actor);
                contexto.SaveChanges();          

                MessageBox.Show("Actor borrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
