using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploNHibernate
{
    class Actor
    {
         private Int32 actorID;
        private string nombre;
        private string urlPersonal;

        public Actor()
        {
        }

        public Int32 ActorID 
        {
            get { return actorID; }
            set { actorID = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string UrlPersonal
        {
            get { return urlPersonal; }
            set { urlPersonal = value; }
        }

    }
}
