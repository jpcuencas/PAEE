using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace EjerciciosADO
{
    public partial class FAdo : Form
    {

        //Leer una cadena de conexión desde el fichero app.config
       // private const string sqlCNX =  "Data Source=.\\sqlexpress;AttachDbFilename=\"E:\\VS 2010\\Ejercicios\\BBDD\\MSDNVideo.mdf\";Integrated Security=True";
       // cadena de conexion de sql server sql client
        private const string sqlCNX  = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\BBDD\\MSDNVideo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        // cadena de conexion sql server ODBC client
        private const string oleCNX = @"Provider=SQLOLEDB;Data Source=.\sqlexpress;Integrated Security=SSPI;Initial Catalog=MSDNVideoDB";
        
        //constructor por defecto del Formulario
        public FAdo()
        {
            InitializeComponent();
            lblnumfilafectadas.Text = "0";
            lblnumfilTotales.Text = "0";
        }

        #region "-----------Ejercicios SQLClient Provider-----------"

        #region "Ejecutar Update con SQLClient"
        //Actualizar la tabla Usuarios y poner el nombre=ANTONIO para el usuario con UsuarioId=12
        //Mostrar los resultados en el ListView
        private void btnSQLDDL_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            //Data Source=.\sqlexpress;AttachDbFilename="E:\VS 2010\Ejercicios\BBDD\MSDNVideo.mdf";Integrated Security=True
            
            // Creamos la conexión
            SqlConnection connection = new SqlConnection();
            try
            {
                
                //aplicamos la cadena de conexion
                connection.ConnectionString = sqlCNX;
                // Crear el adaptador de datos y abre la conexion
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                connection.Open();

                // Comando con la sonsultaSQL y su ejecucion
                SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Nombre='ANTONIO' where UsuarioID=12", connection);
                int cadena = cmd.ExecuteNonQuery();

                // limpiamos añadimos los resultados al listview
                listView1.Items.Clear();
                AddLog(Convert.ToString(cadena));

                lblnumfilafectadas.Text = cadena.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                //cerrar y destruir la conexion
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }
        }
        #endregion
        
        #region "Ejecutar consulta que devuelve un valor escalar con SQLClient"
        //Obtener el número de usuarios que hay en la tabla Usuarios.
        //Mostrar los resultados en el ListView
        private void btnSQLEscalar_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // Creamos la conexión
            SqlConnection connection = new SqlConnection();

            try
            {
                 // aplicar la cadena de conexion
                 connection.ConnectionString = sqlCNX;
                // abrir la conexion
                connection.Open();
              
                // Crear y ejecutar el comando sql en la base de datos
                SqlCommand cmd2 = new SqlCommand("SELECT count(*) FROM usuarios", connection);
                int num = (int)cmd2.ExecuteScalar();

                // limpiamos y añadimos el resultado al listview
                listView1.Items.Clear();
                AddLog(Convert.ToString(num));

                lblnumfilTotales.Text = num.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {

                if (connection!=null)
                {
                    // cerramos y destruimos la nocexion
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }
        }
        #endregion

        #region "Consulta DataReader con SQLClient"
        //Obtener el nif,nombre,email del usuario con id = 1
        //Mostrar los resultados en el ListView
        private void btnSQLDataReader_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // Creamos la conexión
            SqlConnection connection = new SqlConnection();
            try
            {
                // asignamos la cadena de conexion y abrimos la conexion
                connection.ConnectionString = sqlCNX;
                connection.Open();

                // creamos y ejecutamos el comando sql
                SqlCommand cmd2 = new SqlCommand("SELECT nif,nombre,email FROM usuarios where UsuarioID=1", connection);
                SqlDataReader num = cmd2.ExecuteReader();

                // limpiamos y añadimos los elementos
                listView1.Items.Clear();
                while (num.Read())
                {
                    AddLog("Nif" + num[0] + "Nombre" + num[1] + "Email" + num[2]);
                }


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (connection != null)
                {
                        // cerramos y destruimos la conexion
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            
            }
            
        }
        #endregion

        #region "Ejecutar consulta y almacenarlo en un Dataset con SQLClient"
        //Obtener todos los usuarios y mostrarlos en el DataGridView
        private void btnSQLDataSet_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // Creamos la conexión
            SqlConnection connection = new SqlConnection();
            try
            {
                listView1.Items.Clear();
                connection.ConnectionString = sqlCNX;
                // Abrimos la conexion
                connection.Open();

                // ejecutamos el comando sql y recogemos el resultado
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM usuarios", connection);
                //adaptador del provedor de datos
                SqlDataAdapter da = new SqlDataAdapter(cmd2);

                //Creamos y rellenamos el dataset
                DataSet ds = new DataSet("Usuarios");
                da.Fill(ds, "Usuarios");

                //Cargamos en el datagrid el resultado
                CargarDataSet(ds);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (connection != null)
                {
                    //cerramos y destruimos la conexion
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }

        }
        #endregion

        #region "Ejecutar un SP y almacenar el resultado en un DataSet con SQLClient"
        //Hacer una llamada al Stored Procedure ObtenerClaveUsuario
        //Mostrar los resultados en el DataGridView
        private void btnSQLCallSP_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // Creamos la conexión
            SqlConnection connection = new SqlConnection();
            try
            {
                //asignamos la cadena de conexion
                connection.ConnectionString = sqlCNX;
                // Creamos un comando
                SqlCommand cmd = new SqlCommand();
                // Especificamos que el comando es del tipo Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                // Especificamos el nombre del Procedimiento Almacenado
                cmd.CommandText = "ObtenerClaveUsuario";
                // Asignamos la conexión al comando
                cmd.Connection = connection;
                // Creamos un parametro SQL
                SqlParameter param = new SqlParameter();
                // Le damos nombre (el que usa el Procedimiento Almacenado)
                param.ParameterName = "@NIF";
                // Tipo, longitud y valor del parametro
                param.SqlDbType = SqlDbType.NChar;
                param.Size = 9;
                param.Value = "00000001R";
                // Adjuntamos el parametro al comando
                cmd.Parameters.Add(param);
                // Creamos un objeto del tipo DataAdapter
                SqlDataAdapter da = new SqlDataAdapter();
                // Adjuntamos el comando al DataAdapter
                da.SelectCommand = cmd;
                // Creamos un objeto del tipo DataSet
                DataSet ds = new DataSet("UserProfile");
                // Rellenar el DataSet
                da.Fill(ds, "UserProfile");
                // Utilizamos CargarDateSet para mostrar el resultado
                CargarDataSet(ds);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (connection != null)
                {
                    //destruimos y cerramos la conexion
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }
        }
        #endregion

        #endregion


        #region "-----------Ejercicios OleDB Provider-----------"
        //Las consultas de datos son las mismas que para SQLClient
        //Obtener el nif,nombre,email del usuario con id = 1
        //Mostrar los resultados en el ListView
        #region "Ejecutar DDL con OleDb Provider"
        private void btnOleDBDDL_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // Creamos la conexión
            OleDbConnection connection = new OleDbConnection();
            try
            {
                //asignamos la cadena de conexion
                connection.ConnectionString = oleCNX;
                // Crear el adaptador de datos y abrir la conexion
                OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter();
                connection.Open();

                // Comando con la sonsultaSQL y lo ejecutamos
                OleDbCommand cmd = new OleDbCommand("UPDATE Usuarios SET Nombre='ANTONIO' where UsuarioID=12", connection);
                int cadena = cmd.ExecuteNonQuery();

                //añadir el resultado al listview
                listView1.Clear();
                AddLog(cadena.ToString());

                lblnumfilafectadas.Text = cadena.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    //cerrar y destruir la conexion
                    connection.Close();
                    connection.Dispose();
                }
                connection = null;
            }
            
        }
        #endregion

        #region "Ejecutar consulta que devuelve valor escalar con OleDB Provider"
        //Obtener el número de usuarios que hay en la tabla Usuarios.
        //Mostrar los resultados en el ListView
        private void btnOleDBEscalar_Click(object sender, EventArgs e)
        {

             //Pon tu codigo aqui
            // Creamos la conexión
            OleDbConnection connection = new OleDbConnection();
            try
            {
                //asignamos la cadena de conexion
                connection.ConnectionString = oleCNX;
                // Crear el adaptador de datos y abrir la conexion
                OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter();
                connection.Open();

                // creamos y ejecutamos el comando sql
                OleDbCommand cmd2 = new OleDbCommand("SELECT count(*) FROM usuarios", connection);
                int num = (int)cmd2.ExecuteScalar();

                // limpiamos y rellenamos el listview con el resultado
                listView1.Items.Clear();
                AddLog(num.ToString());

                lblnumfilTotales.Text = num.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    // destruimos y cerramos la conexion
                    connection.Close();
                    connection.Dispose();
                }
                connection = null;
            }
        }
        #endregion

        #region "Consulta DataReader con OleDb Provider"
        //Obtener el nif,nombre,email del usuario con id = 1
        //Mostrar los resultados en el ListView
        private void btnOleDBDataReader_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
             // Creamos la conexión
            OleDbConnection connection = new OleDbConnection();
            try
            {
                // asignamos la cadena de conexion
                connection.ConnectionString = oleCNX;
                // Crear el adaptador de datos y abrimos la conexion
                OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter();
                connection.Open();

                // creamos y ejecutamos el comando sql
                OleDbCommand cmd2 = new OleDbCommand("SELECT nif,nombre,email FROM usuarios", connection);
                OleDbDataReader num = cmd2.ExecuteReader();

                // limpiamos y añadimos el resultado al listview
                listView1.Clear();
                while (num.Read())
                {
                    AddLog("Nif" + num[0] + "Nombre" + num[1] + "Email" + num[2]);
                }

                //lblnumfilTotales.Text = num.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    // destruimos y cerramos la conexion
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }

            }
        }
        #endregion

        #region "Ejecutar consulta y almacenarlo en un dataset con OleDB Provider"
        //Obtener todos los usuarios y mostrarlos en el DataGridView
        private void btnOleDbDataset_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // Creamos la conexión
            OleDbConnection connection = new OleDbConnection();
            try
            {
                // asignamos la cadena de conexion
                connection.ConnectionString = oleCNX;
                OleDbCommand cmd2 = new OleDbCommand(" SELECT * FROM usuarios", connection);
               
                // Crear el adaptador de datos y abrir la conexion
                OleDbDataAdapter da = new OleDbDataAdapter(cmd2);
                connection.Open();

                // creamos y rellenamos el dataset
                DataSet ds = new DataSet("Usuarios");
                da.Fill(ds, "Usuarios");

                // rellenamos el gridview con el resltado
                CargarDataSet(ds);

                //lblnumfilTotales.Text = num.ToString();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (connection != null)
                {
                    // cerramos y destruimos la conexion
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }
        }
        #endregion

        #region "Ejecutar un SP y almacenar el resultado en un dataset con OleDB Provider"
        //Hacer una llamada al Stored Procedure ObtenerClaveUsuario
        //Mostrar los resultados en el DataGridView
        private void btnOleDbCallSP_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // Creamos la conexión
            OleDbConnection connection = new OleDbConnection();
            try
            {
                // asignamos la cadena de conexion
                connection.ConnectionString = oleCNX;
                // Creamos un comando
                OleDbCommand cmd = new OleDbCommand();
                // Especificamos que el comando es del tipo Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                // Especificamos el nombre del Procedimiento Almacenado
                cmd.CommandText = "ObtenerClaveUsuario";
                // Asignamos la conexión al comando
                cmd.Connection = connection;
                // Creamos un parametro SQL
                OleDbParameter param = new OleDbParameter();
                // Le damos nombre (el que usa el Procedimiento Almacenado)
                param.ParameterName = "@NIF";
                // Tipo, longitud y valor del parametro
                param.OleDbType = OleDbType.VarChar;
                param.Size = 9;
                param.Value = "00000001R";
                // Adjuntamos el parametro al comando
                cmd.Parameters.Add(param);
                // Creamos un objeto del tipo DataAdapter
                OleDbDataAdapter da = new OleDbDataAdapter();
                // Adjuntamos el comando al DataAdapter
                da.SelectCommand = cmd;
                // Creamos un objeto del tipo DataSet
                DataSet ds = new DataSet("UserProfile");
                // Rellenar el DataSet
                da.Fill(ds, "UserProfile");
                // Utilizamos CargarDateSet para mostrar el resultado

                // rellenamos el datagrid con el resultado
                CargarDataSet(ds);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }
        }
        #endregion

        #endregion


        #region "-----------Ejercicios Transaccion-----------"
        //Ejecutar 3 consultas INSERT(NIF,Clave,Rol,Nombre) de forma transaccional.
        //Probar que si falla la ultima, las 2 anteriores no se reflejan en la BD.
        //Probar que si todo funciona OK, los 3 nuevos registros estan en BD.
        private void btnLanzarTx_Click(object sender, EventArgs e)
        {
            //Pon tu codigo aqui
            // creamos  configuramos y abrimos la conexion
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = sqlCNX;
                connection.Open();

                // realizamos la transacion de 3 insert en la base de  datos en modo serie
                using (SqlTransaction miTransaccion = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    try
                    {
                        // 1 insercion
                        using (SqlCommand cmd1 = new SqlCommand("INSERT INTO Usuarios (NIF,Clave,Rol,Nombre,Telefono,Email,Direccion,Ciudad,Provincia,CodigoPostal,Saldo) VALUES ('01234078T','cUjPle3fXF+P5WsUPQnIM0PkgKdk0sYA','0','Juan','967143846','juanelcano@gmail.com','C/ molinos 32','Villarrobledo','Albacete','02600','54')", connection))
                        {
                            // comando 1 pertenece a la transacion
                            cmd1.Transaction = miTransaccion;
                            //ejecutamos el comando
                            using (SqlDataReader dr = cmd1.ExecuteReader())
                            {
                                //dr.Read();
                                MessageBox.Show("1 Usuario insertado");
                            }
                        }
                        using (SqlCommand cmd2 = new SqlCommand("INSERT INTO Usuarios (NIF,Clave,Rol,Nombre,Telefono,Email,Direccion,Ciudad,Provincia,CodigoPostal,Saldo) VALUES ('01654768T','cUjPle3fXF+P5WsUPQnIM0PkgKdk0sYA','0','Pepon','956245687','Lapepa@gmail.com','av/miguel cervantes 22','Albacete','Albacete','02000','76')", connection))
                        {
                            //comando 2 pertenece a la transacion
                            cmd2.Transaction = miTransaccion;
                            //ejecutamos el comando
                            using (SqlDataReader dr = cmd2.ExecuteReader())
                            {
                                //dr.Read();
                                MessageBox.Show("2 Usuario insertado");
                            }
                        }
                        //INSERT INTO Usuarios (NIF,Clave,Rol,Nombre,Telefono,Email,Direccion,Ciudad,Provincia,CodigoPostal,Saldo) VALUES ('01234078T','cUjPle3fXF+P5WsUPQnIM0PkgKdk0sYA','0','Juan Jose','987654321','jojuan@yahoo.es','C/tinajeros 54','Alcazar de san juan','toledo','04588','87') mal
                        //INSERT INTO Usuarios VALUES INSERT INTO Usuarios (NIF,Clave,Rol,Nombre,Telefono,Email,Direccion,Ciudad,Provincia,CodigoPostal,Saldo) VALUES ('08735478H','cUjPle3fXF+P5WsUPQnIM0PkgKdk0sYA','0','Juan Jose','987654321','jojuan@yahoo.es','C/tinajeros 54','Alcazar de san juan','toledo','04588','87') bien
                        using (SqlCommand cmd3 = new SqlCommand("INSERT INTO Usuarios (NIF,Clave,Rol,Nombre,Telefono,Email,Direccion,Ciudad,Provincia,CodigoPostal,Saldo) VALUES ('08735478H','cUjPle3fXF+P5WsUPQnIM0PkgKdk0sYA','0','Juan Jose','987654321','jojuan@yahoo.es','C/tinajeros 54','Alcazar de san juan','toledo','04588','87')", connection))
                        {
                            // comando 3 pertenece a la transacion
                            cmd3.Transaction = miTransaccion;
                            // ejecutamos el comando
                            using (SqlDataReader dr = cmd3.ExecuteReader())
                            {
                                //dr.Read();
                                MessageBox.Show("3 Usuario insertado");
                            }
                        }
                        // hacemos el commit en la base de datos
                        miTransaccion.Commit();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        // en caso de error hacemos el rollback
                        miTransaccion.Rollback();
                         
                    }
                    finally
                    {
                        // cerramos y destruimos la conexion
                        connection.Close();
                        connection.Dispose();
                        connection = null;
                    }
                }                    
            }       
        #endregion


        #region "Metodos para grabar en ListView y DataGridView"
        //Añade al listview la cadena indicada como parámetro
        private void AddLog(string cadena)
        {
            //this.listView1.Items.Clear();
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
