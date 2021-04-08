using System;
using System.Collections.Generic;

namespace Dario.NH01.Entidades
{
    [Serializable]
    public class Factura : IEquatable<Factura>
    {
        private int id;
        private DateTime? fecha;
        private IList<LineaFactura> lineas;

        public Factura(DateTime fecha) : this()
        {
            this.fecha = fecha;
        }

        public Factura()
        {
            this.fecha = new DateTime?();
            lineas = new List<LineaFactura>();
        }

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual DateTime? Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public virtual IList<LineaFactura> Lineas
        {
            get { return lineas; }
            set { lineas = value; }
        }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            Factura factura = obj as Factura;
            if (factura == null) return false;
            return id == factura.id;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Factura Nro:{0} - Fecha Emisión: {1}", this.Id, this.Fecha);
        }

        #region IEquatable<Factura> Members

        public bool Equals(Factura other)
        {
            if (this == other) return true;
            if (other.Id == this.Id) return true;
            return false;
        }

        #endregion
    }
}