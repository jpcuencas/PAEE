using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Atributos
            //Guarda el contenido de la pantalla
            private string pantalla;
            //el resultado anterior para operaciones de 2 operandos
            private string resultado;
            //selecciona la operacion
            private int operacion;
            //Pantalla de historial auxiliar
            private string pantallatxt;
            //booleano de control para la pantalla auxiliar
            bool control = true;
        #endregion


        public MainWindow()
        {
            InitializeComponent();
        }

        #region getters
            public string getPantallatxt()
            {
                return pantallatxt;
            }
            public string getPantalla()
            {
                return pantalla;
            }
            public string getResultado()
            {
                return resultado;
            }
            public int getOperacion()
            {
                return operacion;
            }
        #endregion

        #region setters
            public void setPantallatxt(string pnt)
            {
                pantallatxt = pnt;
            }
            public void setPantalla(string pnt)
            {
                pantalla = pnt;
            }
            public void setResultado(string res)
            {
                resultado = res;
            }
            public void setOperacion(int op)
            {
                operacion = op;
            }
        #endregion


        #region Operaciones
            /**
             * operaciones valor = operacion
             * 1 = div
             * 2 = mult
             * 3 = rest
             * 4 = sum
             * 5 = potencia
             * sqrt en la funcion
             **/

            private void btnIgual_Click(object sender, RoutedEventArgs e)
            {
                string message = "";
                bool error = false;
                try
                {
                    switch (getOperacion())
                    {
                            //Division
                        case 1:
                            //2ºoperando es cero
                            if (getPantalla() == "0")
                            {
                                throw new DivideByZeroException();
                            }
                            //calculo de la opercion
                            setPantalla((Convert.ToDouble(getResultado()) / Convert.ToDouble(getPantalla())).ToString());
                            Pantalla.Content = getPantalla();
                            break;
                            //Multiplicacion
                        case 2:
                            //calculo de la operacion
                            setPantalla((Convert.ToDouble(getResultado()) * Convert.ToDouble(getPantalla())).ToString());
                            Pantalla.Content = getPantalla();
                            break;
                            //Resta
                        case 3:
                            //calculo de la operacion
                            setPantalla((Convert.ToDouble(getResultado()) - Convert.ToDouble(getPantalla())).ToString());
                            Pantalla.Content = getPantalla();
                            break;
                            //suma
                        case 4:
                            //Calculo de la operacion
                            setPantalla((Convert.ToDouble(getResultado()) + Convert.ToDouble(getPantalla())).ToString());
                            Pantalla.Content = getPantalla();
                            break;
                            //Potencia
                        case 5:
                            //calculo de la operacion
                            setPantalla((System.Math.Pow(Convert.ToDouble(getResultado()),Convert.ToDouble(getPantalla()))).ToString());
                            Pantalla.Content = getPantalla();
                            break;

                        default:
                            operacion = 0;
                            break;
                    }
                }//Excepciones
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
                    //tipo de error y si error muestra mensaje
                    if (error)
                    {
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption);

                    }

                    TxtbxPantalla.Text = getPantalla();
                }
                //inicializar control
                control = true;
            }

            private void btnPotencia_Click(object sender, RoutedEventArgs e)
            {
                //Guardar resultado y seleccionar operacion
                setResultado(getPantalla());
                setOperacion(5);
                setPantalla("0");
                Pantalla.Content = "0";
                //para almacenar mas cosas en el historial
                control = false;
            }

            private void btnRaiz_Click(object sender, RoutedEventArgs e)
            {
                string message = "";
                bool Error = false;
                //coger resultado
                setResultado(getPantalla());
                try
                {
                    //calculamos la operacion
                    setPantalla((System.Math.Sqrt(Convert.ToDouble(getResultado()))).ToString());
                    Pantalla.Content = getPantalla();
                }//Excepciones
                catch (Exception e5)
                {
                    message = "Error en la raiz cuadrada!";
                    Error = true;
                }
                finally
                {
                    if (Error)
                    {
                        string caption = "Se ha detectado un error";
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption);
                    }
                }
                TxtbxPantalla.Text = getPantalla();
            }

            private void btnDiv_Click(object sender, RoutedEventArgs e)
            {
                //guardamos el resultado y seleccionamos la operacion
                setResultado(getPantalla());
                setOperacion(1);
                setPantalla("0");
                Pantalla.Content = "0";
                TxtbxPantalla.Text = TxtbxPantalla.Text +"\n / \n";
                //para almacenar mas cosas en el historial
                control = false;
            }

            private void btnMult_Click(object sender, RoutedEventArgs e)
            {
                //guardamos el resultado y seleccionamos la operacion
                setResultado(getPantalla());
                setOperacion(2);
                setPantalla("0");
                Pantalla.Content = "0";
                TxtbxPantalla.Text = TxtbxPantalla.Text + "\n * \n";
                //para almacenar mas cosas en el historial
                control = false;
            }

            private void btnMenos_Click(object sender, RoutedEventArgs e)
            {
                //guardamos el resultado y seleccionamos la operacion
                setResultado(getPantalla());
                setOperacion(3);
                setPantalla("0");
                Pantalla.Content = "0";
                TxtbxPantalla.Text = TxtbxPantalla.Text + "\n - \n";
                //para guardar mas cosas en el historial
                control = false;
            }

            private void btnMas_Click(object sender, RoutedEventArgs e)
            {
                //guardamos el resultado y seleccionamos la operacion
                setResultado(getPantalla());
                setOperacion(4);
                setPantalla("0");
                Pantalla.Content = "0";
                TxtbxPantalla.Text = TxtbxPantalla.Text + "\n + \n";
                //para guardar mas cosas en el historial
                control = false;
            }

        #endregion

        #region Borrar

            //borrar pantalla
            private void btnBorrar_Click(object sender, RoutedEventArgs e)
            {
                //inicializamos los valores de la aplicacion
                setPantalla("0");
                Pantalla.Content = "0";
                TxtbxPantalla.Text = TxtbxPantalla.Text + "\n0";
                control = true;
            }

            //Borrar todo
            private void btnBorrarTodo_Click(object sender, RoutedEventArgs e)
            {
                //inicializamos los valores de la aplicacion
                setPantalla("0");
                setOperacion(0);
                setResultado("0");
                Pantalla.Content = "0";
                TxtbxPantalla.Text = "0";
                control = true;
            }

        #endregion

        #region Numeros
            private void btnCero_Click(object sender, RoutedEventArgs e)
            {
                //para no poner varios ceros seguidos solo
                if (getPantalla() != "0")
                {
                    //añadir el numero
                    setPantalla(getPantalla() + "0");

                    Pantalla.Content = getPantalla();
                    //añadir el numero en el historial
                    if (control)
                        TxtbxPantalla.Text = getPantalla();
                    else
                        TxtbxPantalla.Text = TxtbxPantalla.Text + "0";
                }
            }

            private void btnUno_Click(object sender, RoutedEventArgs e)
            {
                //boorar el cero inicial
                if (getPantalla() == "0") setPantalla("");
                //añadir el numero
                setPantalla(getPantalla() + "1");

                Pantalla.Content = getPantalla();
                //añadir el numero en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + "1";
                
            }

            private void btnDos_Click(object sender, RoutedEventArgs e)
            {
                //borrar el cero inicial
                if (getPantalla() == "0") setPantalla("");
                //añadir el numero
                setPantalla(getPantalla() + "2");

                Pantalla.Content = getPantalla();
                //añadir el numero en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + "2";
                
            }
            private void btnTres_Click(object sender, RoutedEventArgs e)
            {
                //borrar el cero inicial
                if (getPantalla() == "0") setPantalla("");
                //añadir el numero
                setPantalla(getPantalla() + "3");

                Pantalla.Content = getPantalla();
                //añadir el numero en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + "3";
                
            }

            private void btnCuatro_Click(object sender, RoutedEventArgs e)
            {
                //borrar el cero inicial
                if (getPantalla() == "0") setPantalla("");
                //añadir el numero
                setPantalla(getPantalla() + "4");

                Pantalla.Content = getPantalla();
                //añadir el numero en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + "4";
               
            }

            private void btnCinco_Click(object sender, RoutedEventArgs e)
            {
                //borrar el cero inicial
                if (getPantalla() == "0") setPantalla("");
                //añadir el numero
                setPantalla(getPantalla() + "5");

                Pantalla.Content = getPantalla();
                //añadir el numero en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + "5";
            }

            private void btnSeis_Click(object sender, RoutedEventArgs e)
            {
                //borrar el cero inicial
                if (getPantalla() == "0") setPantalla("");
                //añadir el numero
                setPantalla(getPantalla() + "6");

                Pantalla.Content = getPantalla();
                //añadir el numero en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + "6";
                
            }

            private void btnSiete_Click(object sender, RoutedEventArgs e)
            {
                //borrar el cero inicial
                if (getPantalla() == "0") setPantalla("");
                //añadir el numero
                setPantalla(getPantalla() + "7");

                Pantalla.Content = getPantalla();
                //añadir el numero en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + "7";
                
            }

            private void btnOcho_Click(object sender, RoutedEventArgs e)
            {
                //borrar el cero inicial
                if (getPantalla() == "0") setPantalla("");
                //añadir el numero en el historial
                setPantalla(getPantalla() + "8");

                Pantalla.Content = getPantalla();
                //añadir el numero en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + "8";
                
            }

            private void btnNueve_Click(object sender, RoutedEventArgs e)
            {
                //borrar el cero inicial
                if (getPantalla() == "0") setPantalla("");
                //añadir el numero
                setPantalla(getPantalla() + "9");

                Pantalla.Content = getPantalla();
                //añadir el numero en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + "9";
                
            }
            private void btnPunto_Click(object sender, RoutedEventArgs e)
            {
                //añadir la coma
                setPantalla(Pantalla.Content + ",");
                Pantalla.Content = getPantalla();
                //añadir la coma en el historial
                if (control)
                    TxtbxPantalla.Text = getPantalla();
                else
                    TxtbxPantalla.Text = TxtbxPantalla.Text + ",";              
            }

        #endregion



    }
}
