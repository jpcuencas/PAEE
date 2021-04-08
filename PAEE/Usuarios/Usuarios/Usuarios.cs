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
using System.Text.RegularExpressions;

namespace Usuarios
{
    public partial class Usuarios : Form
    {
        ClassICAD BaseDatos=null;
        Buscador frm;

        int id=0;
        public Usuarios()
        {
            //id = id1;
            //obtener tipo conexion
            BaseDatos = AcessoDatos.getDriver();
            InitializeComponent();
        }


  
        private void butNuevo_Click(object sender, EventArgs e)
        {
                txtNIF.Clear();
                txtNombre.Clear();
                txtClave.Clear();
                txtTelf.Clear();
                txtCP.Clear();
                txtCiudad.Clear();
                txtDireccion.Clear();
                txtEmail.Clear();
                txtSaldo.Clear();
                txtProvincia.Clear();
                int rol = 1;
                if (AdminOK!=null && AdminOK.Checked)
                {
                    rol = 0;
                }
                
                //BaseDatos.InsertarUsuario(txtNIF.Text.ToString(), txtClave.Text.ToString(), rol, txtNombre.Text.ToString(), txtTelf.Text.ToString(), txtEmail.Text.ToString(), txtDireccion.Text.ToString(), txtCiudad.Text.ToString(), txtProvincia.Text.ToString(),Convert.ToDecimal(txtCP.Text.ToString()), Convert.ToDecimal(txtSaldo.Text.ToString()));

        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            //try
            //{
                //BaseDatos = AcessoDatos.getDriver();
                ClassDTO usuario = new ClassDTO();
                //ClassDTO usuario = Buscador.getUsuario();
                bool correcto = true;
                int rol = 1;
                if (AdminOK != null && AdminOK.Checked)
                {
                    rol = 0;
                }
               /* if (txtNIF.Text=="" || Regex.Match(txtNIF.Text, @"^\d{1,8}[A-Z]$").Success == false)
                {
                    MessageBox.Show("NIF incorrecto");
                }
                else if (txtCP.Text.Length != 5)
                {
                    MessageBox.Show("Codigo postal incorrecto");
                }
                else if (txtEmail.Text == "" || Regex.Match(txtEmail.Text, @"^.+\@.+\..+$").Success == false)
                {
                    MessageBox.Show("Email incorrecto incorrecto");
                }
                else
                {*/
                    usuario.setNif(txtNIF.Text);
                    usuario.setNombre(txtNombre.Text);
                    usuario.setRol(rol);
                    usuario.setClave(txtClave.Text);
                    usuario.setEmail(txtEmail.Text);
                    usuario.setTelefono(txtTelf.Text);
                    usuario.setCiudad(txtCiudad.Text);
                    usuario.setProvincia(txtProvincia.Text);
                    usuario.setDireccion(txtDireccion.Text);
                    usuario.setCodigoPostal(Convert.ToDecimal(txtCP.Text));
                    usuario.setSaldo(Convert.ToDecimal(txtSaldo.Text));
                    if (usuario.getUsuarioID() != 0)
                    {
                        BaseDatos.ActualizarUsuario(usuario, usuario.getUsuarioID());
                    }
                    else
                    { 
                        BaseDatos.InsertarUsuario(txtNIF.Text,txtClave.Text,rol,txtNombre.Text,
                            txtTelf.Text,txtEmail.Text,txtDireccion.Text,txtCiudad.Text,txtProvincia.Text,
                            Convert.ToDecimal(txtCP.Text),Convert.ToDecimal(txtSaldo.Text));
                    }
                //}
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Se ha producido un error: " + ex.Message);
            //}
            //finally
            //{

            //}
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            try
            {//REVISAR
                //BaseDatos = AcessoDatos.getDriver();
                //ClassDTO usuario = new ClassDTO();
                if (txtNIF.Text == "" && txtClave.Text == "" && txtNombre.Text == "" && txtTelf.Text == "" && txtEmail.Text == "" && txtDireccion.Text == "" && txtCiudad.Text == "" && txtProvincia.Text == "" && txtCP.Text == "" && txtSaldo.Text == "")
                {
                    MessageBox.Show("Debes seleccionar un usuario");
                }
                else
                {
                    string str = "¿Estás seguro de eliminar el usuario?";
                    string caption = "Confirma la eliminacion del Usuario";

                    if (MessageBox.Show(str, caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClassDTO usuario = Buscador.getUsuario();

                        if (usuario != null)
                        {
                            BaseDatos.BorrarUsuario(usuario.getUsuarioID());
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un usuario ");
                        }
                    }
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
                 * Acesso base datos
                 **/


                if(frm==null)
                {
                    frm=new Buscador();
                }
                frm.WindowState = FormWindowState.Normal;
                id = (int)frm.ShowDialog();
                if (id > 0)
                {
                    //DataSet usuarios = new DataSet();
                    IList<ClassDTO> usuarios;
                    string criterio = "UsuarioID=" + "'" + int.Parse(id.ToString()) + "'";
                    int rol = 0;

                    usuarios = BaseDatos.ObtenerUsuario(criterio);
                    //Muestro los campos en el formulario
                    //usuarios[0].setID( int.Parse(usus.Tables[0].Rows[0]["UsuarioID"].ToString()));
                    if (usuarios[0] != null)
                    {
                        txtNIF.Text = usuarios[0].getNif().ToString();

                        txtClave.Text = usuarios[0].getClave().ToString();


                        rol = int.Parse(usuarios[0].getRol().ToString());

                        if (rol == 1)
                        {
                            AdminOK.Checked = true;
                            AdminNo.Checked = false;
                        }
                        else
                        {
                            AdminNo.Checked = true;
                            AdminOK.Checked = false;
                        }

                        txtNombre.Text = usuarios[0].getNombre().ToString();

                        txtTelf.Text = usuarios[0].getTelefono().ToString();

                        txtEmail.Text = usuarios[0].getEmail().ToString();

                        txtDireccion.Text = usuarios[0].getDireccion().ToString();

                        txtCiudad.Text = usuarios[0].getCiudad().ToString();

                        txtProvincia.Text = usuarios[0].getProvincia().ToString();

                        txtCP.Text = usuarios[0].getCodigoPostal().ToString();
                        string saldo = "";
                        saldo = usuarios[0].getSaldo().ToString();


                        if (saldo[0] == '-')
                        {
                            txtSaldo.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            txtSaldo.ForeColor = System.Drawing.Color.Black;
                        }
                        txtSaldo.Text = saldo;
                    }
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
    }
}
