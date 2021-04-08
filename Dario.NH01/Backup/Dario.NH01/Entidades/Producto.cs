using System;
using System.Collections.Generic;

namespace Dario.NH01.Entidades
{
    [Serializable]
    public class Producto : IEquatable<Producto>
    {
        private int id;
        private string nombre;
        private string categoria;
        private IList<LineaFactura> lineas;


        public Producto(string nombre, string categoria) : this()
        {
            this.nombre = nombre;
            this.categoria = categoria;
        }

        public Producto()
        {
            lineas = new List<LineaFactura>();
        }

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public virtual string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public virtual IList<LineaFactura> Lineas
        {
            get { return lineas; }
            set { lineas = value; }
        }

        #region IEquatable<Producto> Members

        public bool Equals(Producto other)
        {
            if (this == other) return true;
            if (this.Id == other.Id) return true;
            return false;
        }

        #endregion
    }
}