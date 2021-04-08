using System;

namespace Dario.NH01.Entidades
{
    [Serializable]
    public class LineaFactura : IEquatable<LineaFactura>
    {
        private int id;
        private Factura factura;
        private Producto producto;
        private decimal precio;
        private int cantidad;

        public LineaFactura(Factura factura, Producto producto, decimal precio, int cantidad) : this()
        {
            this.factura = factura;
            this.producto = producto;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public LineaFactura()
        {
        }

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }

        public virtual Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public virtual decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public virtual int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            LineaFactura lineaFactura = obj as LineaFactura;
            if (lineaFactura == null) return false;
            return id == lineaFactura.id && Equals(factura, lineaFactura.factura);
        }

        public override int GetHashCode()
        {
            return id + 29*factura.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Linea {0} - Producto:{1}, Cantidad {2}", this.Id,this.Producto.Nombre, this.Cantidad);
        }

        #region IEquatable<LineaFactura> Members

        public bool Equals(LineaFactura other)
        {
            if (other == this) return true;
            if (other.Id == this.Id) return true;
            return false;
        }

        #endregion
    }
}