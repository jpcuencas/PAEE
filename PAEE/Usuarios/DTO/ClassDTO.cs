using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ClassDTO
    {
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

        public ClassDTO()
        { 
            usuarioID=0;
            nif="";
            clave="";
            rol=0;
            nombre="";
            telefono="";
            email="";
            direccion="";

            ciudad="";
            provincia="";
            codigoPostal=0;
            saldo=0;
        }

        //IDusuario
        public Int32 getUsuarioID()
        {
            return usuarioID;
        }
        public void setUsuarioID(Int32 u)
        {
            usuarioID = u;
        }

        //nif
        public string getNif()
        {
            return nif;
        }
        public void setNif(string u)
        {
            nif = u;
        }

        //clave
        public string getClave()
        {
            return clave;
        }
        public void setClave(string u)
        {
            clave = u;
        }

        //rol
        public int getRol()
        {
            return rol;
        }
        public void setRol(int u)
        {
            rol = u;
        }

        //nombre
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string u)
        {
            nombre = u;
        }

        //telefono
        public string getTelefono()
        {
            return telefono;
        }
        public void setTelefono(string u)
        {
            telefono = u;
        }

        //email
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string u)
        {
            email = u;
        }

        //direccion
        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string u)
        {
            direccion = u;
        }

        //ciudad
        public string getCiudad()
        {
            return ciudad;
        }
        public void setCiudad(string u)
        {
            ciudad = u;
        }

        //provinvia
        public string getProvincia()
        {
            return provincia;
        }
        public void setProvincia(string u)
        {
            provincia = u;
        }

        //codigo postal
        public decimal getCodigoPostal()
        {
            return codigoPostal;
        }
        public void setCodigoPostal(decimal u)
        {
            codigoPostal = u;
        }

        //saldo
        public decimal getSaldo()
        {
            return saldo;
        }
        public void setSaldo(decimal u)
        {
            saldo = u;
        }
    }
}
