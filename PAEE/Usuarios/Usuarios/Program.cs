using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Usuarios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //int id = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AcessoDatos());//AcessoDatos
        }
    }
}
