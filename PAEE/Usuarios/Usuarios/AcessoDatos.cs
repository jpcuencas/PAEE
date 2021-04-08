using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using CAD;

namespace Usuarios
{
    public partial class AcessoDatos : Form
    {
        static ClassICAD Driver=null;
        Usuarios frm;
        int id;
        /**
         * opcion 1 ADO
         * opcion 2 Nhibernate
         * opcion 3 Enterprise Library
         * opcion 4 Entity Framework 
         **/
        static int opcion;
        public AcessoDatos()
        {
            id = 0;
            opcion = 0;
            Driver = null;
            InitializeComponent();
        }

        public static ClassICAD getDriver()
        {
            return Driver;
        }

        public static int getOpcion()
        {
            return opcion;
        }

        private void btnADO_Click(object sender, EventArgs e)
        {
            //try
            //{
                if(Driver==null)
                    Driver = new ClassADO();
                opcion = 1;
                if (frm == null)
                {
                    frm = new Usuarios();
                }
                frm.Show();
                //this.Close();
                this.Hide();

            //}
            //catch (Exception ex)
            //{
              //  MessageBox.Show("Se ha producido un error: " + ex.Message);
            //}
            //finally
            //{

            //}
        }

        private void btnNHibernate_Click(object sender, EventArgs e)
        {

            //try
            //{
            if(Driver==null)
                Driver = new ClassNHibernate();
                    
            opcion = 2;

            if (frm == null)
            {
                frm = new Usuarios();
            }
            frm.Show();
            this.Hide();
            //this.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Se ha producido un error: " + ex.Message);
            //}
            //finally
            //{

            //}
        }

        private void btnEL_Click(object sender, EventArgs e)
        {
            try
            {
                if (Driver == null)
                    Driver = new ClassEL();

                opcion = 3;

                if (frm == null)
                {
                    frm = new Usuarios();
                }
                frm.Show();
                this.Hide();
                //this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {

            }
        }

        private void btnEF_Click(object sender, EventArgs e)
        {
            try
            {
                if (Driver == null)
                    Driver = new ClassEntityFramework();
                opcion = 4;
                if (frm == null)
                {
                    frm = new Usuarios();
                }
                frm.Show();
                this.Hide();
                //this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {

            }
        }
    }
}
