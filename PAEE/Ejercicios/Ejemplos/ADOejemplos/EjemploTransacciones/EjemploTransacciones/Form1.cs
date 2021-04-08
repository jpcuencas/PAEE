using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EjemploTransacciones
{
    public partial class Form1 : Form
    {
        private const string sqlCNX = "Data Source=localhost;Initial Catalog=MSDNVideoDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            SqlTransaction miTransaccion = null;
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = sqlCNX;
                connection.Open();
                miTransaccion = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Usuarios", connection);
                cmd.Transaction = miTransaccion;

                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                MessageBox.Show("Número de usuarios: " + dr[0].ToString());

                dr.Close();
                dr.Dispose();
                cmd.Dispose();
                cmd = null;
                miTransaccion.Commit();
            }
            catch (Exception ex)
            {
                miTransaccion.Rollback();
            }
            finally
            {
                if (miTransaccion != null)
                {
                    miTransaccion.Dispose();
                }
                miTransaccion = null;

                if ((connection != null) && (connection.State == ConnectionState.Open))
                {
                    connection.Close();
                    connection.Dispose();
                }
                connection = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlTransaction miTransaccion = null;
            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    connection.ConnectionString = sqlCNX;
                    connection.Open();
                    miTransaccion = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Usuarios", connection);
                    cmd.Transaction = miTransaccion;

                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();
                    MessageBox.Show("Número de usuarios: " + dr[0].ToString());

                    dr.Close();
                    dr.Dispose();
                    cmd.Dispose();
                    cmd = null;
                    miTransaccion.Commit();
                }
                catch (Exception ex)
                {
                    miTransaccion.Rollback();
                }
                finally
                {
                    if (miTransaccion != null)
                    {
                        miTransaccion.Dispose();
                    }
                    miTransaccion = null;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlTransaction miTransaccion = null;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = sqlCNX;
                    connection.Open();
                    miTransaccion = connection.BeginTransaction(IsolationLevel.RepeatableRead);

                    using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Usuarios", connection))
                    {
                        cmd.Transaction = miTransaccion;
                        SqlDataReader dr = cmd.ExecuteReader();

                        dr.Read();
                        MessageBox.Show("Número de usuarios: " + dr[0].ToString());

                        dr.Close();
                        dr.Dispose();
                    }
                    miTransaccion.Commit();
                }
            }
            catch (Exception ex)
            {
                miTransaccion.Rollback();
            }
            finally
            {
                if (miTransaccion != null)
                {
                    miTransaccion.Dispose();
                }
                miTransaccion = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = sqlCNX;
                connection.Open();
                using (SqlTransaction miTransaccion = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Usuarios", connection))
                        {
                            cmd.Transaction = miTransaccion;

                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                dr.Read();
                                MessageBox.Show("Número de usuarios: " + dr[0].ToString());
                            }
                        }
                        miTransaccion.Commit();
                    }
                    catch (Exception ex)
                    {
                        miTransaccion.Rollback();
                    }
                }                    
            }
        }
    }
}
