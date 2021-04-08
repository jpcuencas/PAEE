using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        #region Atributos
            private double pantalla;
            private double memoria;
            private double resultado;
            private int operacion;
        #endregion

        #region Constructores
            public Calculadora()
            {
                InitializeComponent();
                pantalla = 0;
                resultado = 0;
                memoria = 0;
            }
        #endregion

        #region getters 
            public double getPantalla()
            {
                return pantalla;
            }
            public double getMemoria()
            {
                return memoria;
            }
            public double getResultado()
            {
                return resultado;
            }
            public int getOperacion()
            {
                return operacion;
            }
        #endregion

        #region setters
            public void setPantalla(double pnt)
            {
                pantalla=pnt;
            }

            public void setMemoria(double mem)
            {
                memoria = mem;
            }
            public void setResultado(double res)
            {
                resultado = res;
            }
            public void setOperacion(int op)
            {
                operacion = op;
            }
        #endregion

        #region OpMemoria
            private void MemR_Click(object sender, EventArgs e)
            {
                setMemoria(getPantalla());
            }

            private void MemMas_Click(object sender, EventArgs e)
            {
                setPantalla(getPantalla() + getMemoria());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void MemMenos_Click(object sender, EventArgs e)
            {
                setPantalla(getPantalla() - getMemoria());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }
        #endregion

        #region Numeros
            private void num9_Click(object sender, EventArgs e)
            {
                setPantalla(9+10*getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void num8_Click(object sender, EventArgs e)
            {
                setPantalla(8 + 10 * getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void num7_Click(object sender, EventArgs e)
            {
                setPantalla(7 + 10 * getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void num6_Click(object sender, EventArgs e)
            {
                setPantalla(6 + 10 * getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void num5_Click(object sender, EventArgs e)
            {
                setPantalla(5 + 10 * getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void num4_Click(object sender, EventArgs e)
            {
                setPantalla(4 + 10 * getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void num1_Click(object sender, EventArgs e)
            {
                setPantalla(1 + 10 * getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void num2_Click(object sender, EventArgs e)
            {
                setPantalla(2 + 10 * getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void num3_Click(object sender, EventArgs e)
            {
                setPantalla(3 + 10 * getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void num0_Click(object sender, EventArgs e)
            {
                setPantalla(10 * getPantalla());
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }

            private void Punto_Click(object sender, EventArgs e)
            {
                int cont= System.Convert.ToString(getPantalla()).Length;

                setPantalla(getPantalla() / (10 ^ cont));
                Pantalla.Text = System.Convert.ToString(getPantalla());
            }
        #endregion

        #region Borrar
            private void Borrar1_Click(object sender, EventArgs e)
            {
                setPantalla(0);
                Pantalla.Text = "0";
            }

            private void BorrarTodo_Click(object sender, EventArgs e)
            {
                setPantalla(0);
                setOperacion(0);
                setResultado(0);
                setMemoria(0);
                Pantalla.Text = "0";
            }
        #endregion

            /**
         * operaciones
         * 1 = div
         * 2 = mult
         * 3 = rest
         * 4 = sum
         * sqrt en la funcion
         **/
     #region Operaciones

            private void Raiz_Click(object sender, EventArgs e)
            {
                string message = "";
                bool Error = false;
                setResultado(getPantalla());
                try
                {
                    setPantalla(System.Math.Sqrt(getResultado()));
                    Pantalla.Text = System.Convert.ToString(getPantalla());
                }
                catch (Exception e5)
                {
                    message = "Error en la raiz cuadrada!";
                    Error = true;
                }
                finally
                {
                    if(Error)
                    {
                        string caption = "Se ha detectado un error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        // Displays the MessageBox.

                        MessageBox.Show(message, caption, buttons);
                    }
                }

            }
            private void Div_Click(object sender, EventArgs e)
            {
                setResultado(getPantalla());
                setOperacion(1);
                setPantalla(0);
                Pantalla.Text = "0";
            }


            private void Mult_Click(object sender, EventArgs e)
            {
                setResultado(getPantalla());
                setOperacion(2);
                setPantalla(0);
                Pantalla.Text = "0";
            }

            private void Resta_Click(object sender, EventArgs e)
            {
                setResultado(getPantalla());
                setOperacion(3);
                setPantalla(0);
                Pantalla.Text = "0";
            }

            private void mas_Click(object sender, EventArgs e)
            {
                setResultado(getPantalla());
                setOperacion(4);
                setPantalla(0);
                Pantalla.Text = "0";
            }

            private void Igual_Click(object sender, EventArgs e)
            {
                string message = "";
                bool error = false;
                try
                {
                    switch (getOperacion())
                    {
                        case 1:
                            if (getPantalla() == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            setPantalla(getResultado() / getPantalla());
                            Pantalla.Text = System.Convert.ToString(getPantalla());
                            break;
                        case 2:
                            setPantalla(getResultado() * getPantalla());
                            Pantalla.Text = System.Convert.ToString(getPantalla());
                            break;
                        case 3:
                            setPantalla(getResultado() - getPantalla());
                            Pantalla.Text = System.Convert.ToString(getPantalla());
                            break;
                        case 4:
                            setPantalla(getResultado() + getPantalla());
                            Pantalla.Text = System.Convert.ToString(getPantalla());
                            break;
                        default:
                            operacion = 0;
                            break;

                    }
                }
                catch (DivideByZeroException e1)
                {
                    message = "Error division por cero";
                    error = true;
                }
                catch (System.UnauthorizedAccessException e2)
                {
                    message = "Error violacion de segmento";
                    error = true;
                }
                catch (ArgumentNullException e3)
                {
                    message = "Error de asignacion nula";
                    error = true;
                }
                catch (System.IO.IOException e4)
                {
                    message = "Error de entrada de datos";
                    error = true;
                }
                catch (Exception e5)
                {
                    message = "Error inesperado!";
                    error = true;
                }
                finally
                {
                    string caption = "Se ha detectado un error";
                    if (error)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        // Displays the MessageBox.

                        MessageBox.Show(message, caption, buttons);

                    }

                }
            }
     #endregion

    }
}
