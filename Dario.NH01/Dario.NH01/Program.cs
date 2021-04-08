using System;
using System.Collections.Generic;
using Dario.NH01.Entidades;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;


namespace Dario.NH01
{
    internal class Program
    {
        private static void Main()
        {
            Configuration cfg = new Configuration();

            cfg.Configure("hibernate.cfg.xml");

            //procedimiento para crear el script de la Base de datos.
            ConfigurarLaDB(cfg);
            
            ISessionFactory sesiones = cfg.BuildSessionFactory();

            ISession sesion = sesiones.OpenSession();

            //Creación de Productos
            Producto prod1 = new Producto("Leche Entera", "Lacteos");
            Producto prod2 = new Producto("Lavandina", "Limpieza");
            Producto prod3 = new Producto("Vasos", "Bazar");

            sesion.Save(prod1);
            sesion.Save(prod2);
            sesion.Save(prod3);

            Factura factura = new Factura(DateTime.Now);
            factura.Lineas.Add(new LineaFactura(factura, prod1, 2.25m, 5));
            factura.Lineas.Add(new LineaFactura(factura, prod2, 3.5m, 1));
            factura.Lineas.Add(new LineaFactura(factura, prod3, 5.4m, 10));

            sesion.Save(factura);

            sesion.Flush();

            //Pido todas las facturas a la base.
            IList<Factura> facturas = sesion.CreateCriteria(typeof (Factura)).List<Factura>();

            //Y las imprimo
            foreach (Factura fact in facturas)
            {
                Console.WriteLine(fact);

                foreach (LineaFactura linea in fact.Lineas)
                {
                    Console.WriteLine(linea);
                }

                Console.WriteLine();
            }

            sesion.Delete(prod3);


            //Cierro la Session
            sesion.Close();

            Console.ReadLine();
        }

        private static void ConfigurarLaDB(Configuration config)
        {
            SchemaExport exporter = new SchemaExport(config);
            exporter.Create(true, true); //borra y crea nuevamente las tablas en la base.
            Console.WriteLine();
        }
    }
}