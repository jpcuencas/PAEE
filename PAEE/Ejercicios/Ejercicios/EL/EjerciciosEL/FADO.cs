using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


namespace EjerciciosADO
{
    public partial class FAdo : Form
    {
        public FAdo()
        {
            InitializeComponent();
        }


        #region "-----------Ejercicios Enterprise Library-----------"
        //Las consultas de datos son las mismas que para SQLClient

        #region "Ejecutar DDL con Enterprise Library"
        //Actualizar la tabla Usuarios y poner el nombre=ANTONIO para el usuario con UsuarioId=12
        //Mostrar los resultados en el ListView
        private void btnELDDL_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui

            try
            {
                //comando sql a ejecutar
            string sql = "UPDATE Usuarios SET Nombre='ANTONIO' where UsuarioID=12";

                // instanciamos el objeto base de datos y ejecutamos el comando
            Database dataBase = DatabaseFactory.CreateDatabase();
            int fila = dataBase.ExecuteNonQuery(CommandType.Text, sql);

            // limpiamos y escribimos el resultado en el listview
            listView1.Clear();
            AddLog(fila.ToString());
                

                //lblnumfilafectadas.Text = cadena.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region "Ejecutar consulta que devuelve valor escalar con Enterprise Library"
        //Obtener el número de usuarios que hay en la tabla Usuarios.
        //Mostrar los resultados en el ListView
        private void btnELEscalar_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            try
            {
                // comando sql a ejecutar
                string sql = "SELECT count(*) FROM usuarios";
                int fila;

                // instanciamos el objeto de base de datos y ejecutamos el comando sql
                Database dataBase = DatabaseFactory.CreateDatabase();
                fila = (int)dataBase.ExecuteScalar(CommandType.Text, sql);

                // limpiamos y mostramos el resultado en el listview
                listView1.Items.Clear();
                AddLog(fila.ToString());
                
                //lblnumfilafectadas.Text = cadena.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Consulta DataReader con Enterprise Library"
        //Obtener el nif,nombre,email del usuario con id = 1
        //Mostrar los resultados en el ListView
        private void btnELDataReader_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui

            try
            {
                // comando sql a ejecutar
                string sql = "SELECT nif,nombre,email FROM usuarios where UsuarioID=1";

                // instanciamos la base de datos y ejecutamos el comando
                Database dataBase = DatabaseFactory.CreateDatabase();
                IDataReader fila = dataBase.ExecuteReader(CommandType.Text, sql);
                // cargamos los datos de la consulta en el datareader
                fila.Read();

                //limpiamos y mostramos los resultados
                listView1.Clear();
                AddLog("nif:" + fila[0].ToString() + "nombre:" + fila[1].ToString() + "email:" + fila[2].ToString());


                //lblnumfilafectadas.Text = cadena.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Ejecutar consulta y almacenarlo en un dataset con Enterprise Library"
        //Obtener todos los usuarios y mostrarlos en el DataGridView
        private void btnELDataSet_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            try
            {
                // comando sql a ejecutar
                string sql = "SELECT nif,clave,rol,nombre,telefono,email,direccion,ciudad,provincia,codigopostal,saldo FROM usuarios";
                
                // instanciamos la base de datos y ejecutamos el comando sql
                Database dataBase = DatabaseFactory.CreateDatabase();
                DataSet fila = dataBase.ExecuteDataSet(CommandType.Text, sql);

                // mostramos el resultado en el datagrid
                CargarDataSet(fila);

                //lblnumfilTotales.Text = num.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Ejecutar un SP y almacenar el resultado en un dataset con Enterprise Library"
        //Hacer una llamada al Stored Procedure ObtenerClaveUsuario
        //Mostrar los resultados en el DataGridView
        private void btnELCallSP_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // instanciamos la base de datos
            Database dataBase = DatabaseFactory.CreateDatabase();

            // ejecutamos un procedimiento almacenado con un resultado generico y un parametro
            var myObject = dataBase.ExecuteSprocAccessor<int>("ObtenerClaveUsuario", new object[] { "00000001R"}).SingleOrDefault();
           // guardamos el resultado de la ejecucion en un dataset
            DataSet ds = dataBase.ExecuteDataSet("ObtenerClaveUsuario", "00000001R");

            // mostramos el resultado en el datagrid
           CargarDataSet(ds);

        }
        #endregion

        #endregion



        #region "Metodos para grabar en ListView y DataGridView"
        //Añade al listview la cadena indicada como parámetro
        private void AddLog(string cadena)
        {
            //listView1.Items.Clear();
            this.listView1.Items.Add(cadena);
        }

        //Carga del dataset la tabla indicada como parámetro
        private void CargarDataSet(DataSet ds)
        {
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = ds.Tables[0].TableName;
            this.dataGridView1.Refresh();
            this.tabControl1.TabIndex = 1;
        }
        #endregion

    }
}
