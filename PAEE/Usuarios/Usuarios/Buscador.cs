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
    public partial class Buscador : Form
    {
        private static ClassDTO usuario;

        ClassICAD BaseDatos=null;
        Usuarios frm=null;

        int id=0;
        public Buscador()
        {
            id = 0;
            BaseDatos = AcessoDatos.getDriver();
            InitializeComponent();
        }
        public int showDialog()
        {

            base.ShowDialog();
            return id;
        }

        public static ClassDTO getUsuario()
        {
            return usuario;
        }

        public static void setUsuario(ClassDTO u)
        {
            usuario=u;
        }

        /**
         * Coger el usuario seleccionado y almacenarlo en usuario
         * Para cuando este en el otro formulario
         **/
        private void butSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount < 1)
                {
                    MessageBox.Show("No puedes seleccionar un usuario el grid esta vacio");
                }
                else
                {
                   id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    this.Close();

                    if (frm == null)
                    {
                        frm = new Usuarios();
                    }

                    frm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {

            }
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                 * Falta completar 
                 **/
                bool control = false;
                string donde="";
                List<ClassDTO> usuarios;


               if(txtNombre.Text!="")
               {
                   donde = donde + " NOMBRE ='" + txtNombre.Text + "'";
                   control = true;
               }
               if (control)
               {
                   if (txtCiudad.Text != "")
                   {
                       donde = donde + " AND CIUDAD ='" + txtCiudad.Text + "'";
                   }
               }
               else
               {
                   if (txtCiudad.Text != "")
                   {
                       donde = donde + " CIUDAD ='" + txtCiudad.Text + "'";
                       control = true;
                   }
               }

               if (control)
               {
                   if (txtCP.Text != "" && txtCP.Text.Length == 5)
                   {
                       donde = donde + " AND CODIGOPOSTAL ='" + txtCP.Text + "'";
                   }
               }
               else
               {
                   if (txtCP.Text != "")
                   {
                       donde = donde + " CODIGOPOSTAL ='" + txtCP.Text + "'";
                       control = true;
                   }
               }
               usuarios = BaseDatos.ObtenerUsuario(donde);


               DataTable dt = ConvertToDataTable(usuarios);

               this.dataGridView1.DataSource = dt;

               this.dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            finally
            {

            }
        }

        public DataTable ConvertToDataTable(IList<ClassDTO> data)
        {
           //  PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
       DataTable table = new DataTable();
       /*for (int i = 0; i < props.Count;i++ )
       {
          PropertyDescriptor prp = props[i];
          table.Columns.Add(prp.Name,prp.PropertyType);
       }*/
       table.Columns.Add("ID", typeof(string));
            table.Columns.Add("NIF",typeof(string));
            table.Columns.Add("Clave",typeof(string));
            table.Columns.Add("rol",typeof(string));
            table.Columns.Add("nombre",typeof(string));
            table.Columns.Add("Telefono",typeof(string));
            table.Columns.Add("Email",typeof(string));
            table.Columns.Add("direccion", typeof(string));
            table.Columns.Add("ciudad", typeof(string));
            table.Columns.Add("provincia", typeof(string));
            table.Columns.Add("Codigo Postal", typeof(decimal));
            table.Columns.Add("Saldo", typeof(decimal));


       object[] values = new object[12];
       foreach (ClassDTO item in data)
       {
           values[0] = item.getUsuarioID();
           values[1] = item.getNif();
           values[2] = item.getClave();
           if(item.getRol()==1)
              values[3] = "Admin";
           else
               values[3] = "No Admin";
           values[4] = item.getNombre();
           values[5] = item.getTelefono();
           values[6] = item.getEmail();
           values[7] = item.getDireccion();
           values[8] = item.getCiudad();
           values[9] = item.getProvincia();
           values[10] = item.getCodigoPostal();
           values[11] = item.getSaldo();
          table.Rows.Add(values);
       }
       return table;

            /*
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;*/
        }


    }
}
