using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DTO;


namespace CAD
{
   
    public abstract class ClassICAD
    {
        //public abstract void DoWork(in

       public abstract int InsertarUsuario(string nif, string clave, int rol, string nombre, string telefono, string email, string direccion, string ciudad, string provincia, decimal codigoPostal, decimal saldo);

       public abstract int ActualizarUsuario(ClassDTO usr, Int32 id);

       public abstract int BorrarUsuario(Int32 id);

       public abstract List<ClassDTO> ObtenerUsuario(string criterio);

       public abstract List<ClassDTO> ObtenerUsuarios();

        //public abstract bool conectar(string cadena);

        //public abstract bool desconectar(string cadena);

    }
}
