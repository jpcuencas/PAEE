using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioNHibernate
{
    class Usuario
    {
        // atributos de la tabla usuarios
         private Int32 usuarioID;

         private string nif;
         private string clave;
         private int rol;
         private string nombre;
         
         private string telefono;
         private string email;
         
         private string direccion;
         private string ciudad;
         private string provincia;
         private decimal codigoPostal;
        
         private decimal saldo;

        // constructor por defecto de la clase
        public Usuario()
        {
            nif = "";
            clave = "";
            rol = 0;
            nombre = "";
            telefono = "";
            email = "";
            direccion = "";
            ciudad = "";
            provincia = "";
            codigoPostal = 0;
            saldo = 0;
        }

        // metodo getter y setter del id de usuario
        public Int32 UsuarioID 
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }

        // metodo getter y setter del nif de usuario
        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        // metodo getter y setter de la clave de usuario
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        // metodo getter y setter del rol de usuario
        public int Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        // metodo getter y setter del nombre de usuario
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // metodo getter y setter del telefono de usuario
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        // metodo getter y setter del email del usuario
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // metodo getter y setter de la direccion de usuario
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        // metodo getter y setter de la ciudad de usuario
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        // metodo getter y setter de la provincia de usuario
        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        // metodo getter y setter del codigo postal del usuario
        public decimal CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        // metodo getter y setter del saldo de usuario
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
}
