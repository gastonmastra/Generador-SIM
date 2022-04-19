﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_Generador_de_numeros_pseudoaleatoreos.Forms;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class ControllerBondadAjuste
    {
        BondadAjuste interfaz;
        List<double> listaIntervalos;
        List<double> listaNrosConDistribucion;
        

        //iguales para k-s y chi-cuadrado
        int[] frecuencias_observadas;
        double[] frecuencias_esperadas;
        List<double> probabilidades;

        //m
        int parametros_empiricos;
        IControllerDistribucion distribucion;

        double[] arrayChiCuadrado = new double[] {3.84, 5.99, 7.81,
                                                  9.49, 11.1, 12.6,
                                                  14.1, 15.5, 16.9,
                                                  18.3, 19.7, 21.0,
                                                  22.4, 23.7, 25.0,
                                                  26.3, 27.6, 28.9,
                                                  30.1, 31.4 };
        

        public ControllerBondadAjuste(BondadAjuste interfaz)
        {
            this.interfaz = interfaz;
            
        }


        /// <summary>
        /// Método que delega la responsabilidad de generar los numeros pseudo-aleatorios
        /// a partir del propio lenguaje de programación, y luego realizar los calculos necesarios para establecer
        /// los intervalos.
        /// </summary>
        public void realizarPruebaLenguaje(int N, int cantIntervalos)
        {
<<<<<<< HEAD
            generarIntervalos(cantIntervalos); //poisson no los usa
            generarNrosConDistribucion(N);
=======
            //generarIntervalos(cantIntervalos);
            generarNrosConDistribucion(N, cantIntervalos);
>>>>>>> 6cc1d74ae418b92c79814d42bca64aefe24ed8bf
            realizarTestChiCuadrado(cantIntervalos, N);
            interfaz.generarHistograma(frecuencias_observadas, frecuencias_esperadas, listaIntervalos);
            realizarTestKs(cantIntervalos);
        }


        /// <summary>
        /// Método encargado de realizar el calculo de cada uno de los parámetros a mostrar
        /// en la Tabla y el Histograma de frecuencias, definiendo también si la hipotesis
        /// se rechaza o no se rechaza a partir de los valores obtenidos de la distribución.
        /// </summary>
        private void realizarTestChiCuadrado(int cantIntervalos, int N)
        {
            if (interfaz.getDistribucionSeleccionada() == "Distribucion Poisson")
            {
                frecuencias_observadas = calcularFoP();
            }
            else
            {
                frecuencias_observadas = calcularFo();
            }
            

            frecuencias_esperadas = distribucion.calcularFe(N, probabilidades);
            double[] estadisticos = calcularEstadisticoMuestreo(frecuencias_esperadas, frecuencias_observadas);
            double[] estadisticos_acum = estadisticos_acumulados(estadisticos);
            interfaz.llenarTablaChiCuadrado(listaIntervalos, frecuencias_observadas, frecuencias_esperadas, estadisticos, estadisticos_acum);
            int gradosLibertad = (listaIntervalos.Count-1) - 1 - parametros_empiricos;

            if (estadisticos_acum[estadisticos_acum.Length - 2] < arrayChiCuadrado[gradosLibertad])
            {
                string mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 2] + " < " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad] + " con " + gradosLibertad + " grados de libertad\n" +
                    "\t La hipotesis no se rechaza. Nivel de significancia 1−∝= 0,95";
                string hex = "#0096c7";
                Color color = System.Drawing.ColorTranslator.FromHtml(hex);
                //Color color = Color.BlueViolet;
                interfaz.mostrarResultadoHipotesis(mensaje, color);
            }
            else
            {
                string mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 2] + " > " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad] + " con " + gradosLibertad + " grados de libertad\n" +
                    "\t La hipotesis se rechaza. Nivel de significancia 1−∝= 0,95";
                Color color = Color.DarkRed;
                interfaz.mostrarResultadoHipotesis(mensaje, color);
            }
            //listaNrosAleatorios = this.generarNrosAleatorios(N);
            //interfaz.cargarListaNrosAleatorios(listaNrosAleatorios);
        }

        private void generarNrosConDistribucion(int N, int cantIntervalos)
        {
            switch (interfaz.getDistribucionSeleccionada())
            {
                case "Distribucion Normal (Box-Muller)":
                    double mediaBox = interfaz.getMediaNormal();
                    double desvEstandarBox = interfaz.getDesvEstandarNormal();
                    distribucion = new Normal(desvEstandarBox, mediaBox, 1);
                    listaNrosConDistribucion = distribucion.generarNrosAleatorios(N);
                    generarIntervalos(cantIntervalos, listaNrosConDistribucion);
                    probabilidades = distribucion.calcularProbabilidades(listaIntervalos);
                    parametros_empiricos = 2;
                    //crear un nuevo controlador de tipo Normal Box-Muller
                    //retornar: setear lista de numeros con esta distribucion en la lista q se llama listaNrosConDistribucion
                    break;

                case "Distribucion Normal (Convolucion)":
                    double mediaConv = interfaz.getMediaNormal();
                    double desvEstandarConv = interfaz.getDesvEstandarNormal();
                    distribucion = new Normal(desvEstandarConv, mediaConv, 2);
                    listaNrosConDistribucion = distribucion.generarNrosAleatorios(N);

                    generarIntervalos(cantIntervalos, listaNrosConDistribucion);

                    probabilidades = distribucion.calcularProbabilidades(listaIntervalos);
                    parametros_empiricos = 2;
                    //calcular
                    //retornar: setear lista de numeros con esta distribucion en la lista q se llama listaNrosConDistribucion
                    break;

                case "Distribucion Exponencial Neg.":
                    //calcular
                    //retornar: setear lista de numeros con esta distribucion en la lista q se llama listaNrosConDistribucion
                    double lambda = interfaz.getLambdaExponencial();
                    //verificar si lambda es =! 0 en el metodo verificar pruebas
                    distribucion = new ExponencialNegativa(lambda);
                    listaNrosConDistribucion = distribucion.generarNrosAleatorios(N);

                    generarIntervalos(cantIntervalos, listaNrosConDistribucion);

                    probabilidades = distribucion.calcularProbabilidades(listaIntervalos);
                    parametros_empiricos = 1;


                    break;
                case "Distribucion Uniforme":
<<<<<<< HEAD
                    //calcular
                    //retornar: setear lista de numeros con esta distribucion en la lista q se llama listaNrosConDistribucion
                    
=======
                    double A = interfaz.getAUniforme();
                    double B = interfaz.getBUniforme();
                    distribucion = new Uniforme(A, B);
                    listaNrosConDistribucion = distribucion.generarNrosAleatorios(N);

                    generarIntervalos(cantIntervalos, listaNrosConDistribucion);

                    probabilidades = listaIntervalos;
                    parametros_empiricos = 0; //VER CUANTOS
>>>>>>> 6cc1d74ae418b92c79814d42bca64aefe24ed8bf
                    break;

                case "Distribucion Poisson": //No se le hace el K-S
<<<<<<< HEAD
                    //calcular
                    //retornar: setear lista de numeros con esta distribucion en la lista q se llama listaNrosConDistribucion
                    double lambdaPoisson = interfaz.getLambdaPoisson();
                    distribucion = new Poisson(lambdaPoisson);
                    listaNrosConDistribucion = distribucion.generarNrosAleatorios(N);
                    List <double> listaValores = listaNrosConDistribucion.Distinct().OrderBy(number => number).ToList();
                    IEnumerable<int> listaIntervalosP = Enumerable.Range(Convert.ToInt32(listaValores[0]), Convert.ToInt32((listaValores[listaValores.Count-1]- listaValores[0] )+ 1));
                    listaIntervalos = listaIntervalosP.Select(x => Convert.ToDouble(x)).ToList();
                    probabilidades = distribucion.calcularProbabilidades(listaIntervalos);
                    //no puede usar calcularFo porque no tiene intervalos
                    parametros_empiricos = 1;
=======


>>>>>>> 6cc1d74ae418b92c79814d42bca64aefe24ed8bf
                    break;

                default:
                    break;
            }
        }

        private void realizarTestKs(int cantIntervalos)
        {
            interfaz.llenarTablaKS(listaIntervalos, frecuencias_observadas, frecuencias_esperadas, probabilidades);
            int gradosLibertad = listaNrosConDistribucion.Count ;
            double valor_tabulado = 1.36 / (Math.Sqrt(listaNrosConDistribucion.Count));
            if (gradosLibertad < 35)
            {
                valor_tabulado = arrayKs[gradosLibertad];
            }
            double maximo = interfaz.getMax();
            if ( maximo < valor_tabulado)
            {
                string mensaje = " Estadístico de prueba: " + maximo + " < " + " Valor tabulado: " + valor_tabulado + " con " + gradosLibertad + " grados de libertad\n" +
                    "\t La hipotesis no se rechaza. Nivel de significancia 1−∝= 0,95";
                string hex = "#0096c7";
                Color color = System.Drawing.ColorTranslator.FromHtml(hex);
                //Color color = Color.BlueViolet;
                interfaz.mostrarResultadoHipotesisKs(mensaje, color);
            }
            else
            {
                string mensaje = " Estadístico de prueba: " + maximo + " > " + " Valor tabulado: " + valor_tabulado + " con " + gradosLibertad + " grados de libertad\n" +
                    "\t La hipotesis se rechaza. Nivel de significancia 1−∝= 0,95";
                Color color = Color.DarkRed;
                interfaz.mostrarResultadoHipotesisKs(mensaje, color);
            }
            //if (true) //ver condicion
            //{
            //    string mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 2] + " < " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad] + " con " + gradosLibertad + " grados de libertad\n" +
            //        "\t La hipotesis no se rechaza. Nivel de significancia 1−∝= 0,95";
            //    string hex = "#0096c7";
            //    Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            //    //Color color = Color.BlueViolet;
            //    interfaz.mostrarResultadoHipotesis(mensaje, color);
            //}
            //else
            //{
            //    string mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 2] + " > " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad] + " con " + gradosLibertad + " grados de libertad\n" +
            //        "\t La hipotesis se rechaza. Nivel de significancia 1−∝= 0,95";
            //    Color color = Color.DarkRed;
            //    interfaz.mostrarResultadoHipotesis(mensaje, color);
            //}
        }

        /// <summary>
        /// Método que permite definir los intervalos de nuestra distribución, a partir
        /// de la cantidad de intervalos seleccionada.
        /// </summary>
        private void generarIntervalos(int cantIntervalos, List<double> listaNrosAleatorios)
        {
            listaIntervalos = new List<double>();
            double maximo = listaNrosAleatorios.Max();
            double minimo = listaNrosAleatorios.Min();
            double intervalo = ( (maximo - minimo)/ (double)cantIntervalos);
            double acum = minimo;
            //listaIntervalos.Add(Math.Round(minimo, 3));

            for (int i = 0; i < cantIntervalos+1; i++)
            {
                listaIntervalos.Add(Math.Round(acum, 3));
                acum += intervalo;
                acum = (Math.Truncate(acum * 10000) / 10000);
            }
            
            //listaIntervalos.Add(1);
        }

        public void mostrarSerie()
        {
            if (this.listaNrosConDistribucion != null)
            {
                interfaz.MostrarNumeros(listaNrosConDistribucion);
            }
            else
            {
                MessageBox.Show("No hay números generados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Método que calcula la Frecuencia Observada recorriendo cada uno de los intervalos 
        /// y estableciendo una condición para verificar a que intervalo pertenece cada uno
        /// de los nros pseudo-aleatorios, y devuelve como resultado un array de int de contadores
        /// en donde cada posición corresponde con cada uno de los intervalos.
        /// </summary>
        private int[] calcularFo()
        {
            int[] contadoresFo = new int[listaIntervalos.Count];
            int contador = 0;
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                //contador = listaNrosAleat.Count(x => x >= listaIntervalos[i] && x < listaIntervalos[i + 1]);
                //contadoresFo[i] = contador;
                if (i == (listaIntervalos.Count - 1))
                {
                    contador = listaNrosConDistribucion.Count(x => x >= listaIntervalos[i - 1] && x <= 1);
                    contadoresFo[i] = contador;
                }
                else
                {
                    contador = listaNrosConDistribucion.Count(x => x >= listaIntervalos[i] && x < listaIntervalos[i + 1]);
                    contadoresFo[i] = contador;
                }
            }
            return contadoresFo;
            //foreach (double intervalo in listaIntervalos)
            //{
            //    contador = listaNrosAleat.Count(x => x >= intervalo && x < listaIntervalos.);
            //    contadoresFo[i] = contador;
            //}
        }

        private int[] calcularFoP()
        {
            int[] contadoresFo = new int[listaIntervalos.Count];
            int contador = 0;
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                contador = listaNrosConDistribucion.Count(x => x == listaIntervalos[i]);
                contadoresFo[i] = contador;
               
            }
            return contadoresFo;
            
        }

        /// <summary>
        /// Método que toma como parámetros el arrray de Frecuencias Observadas y 
        /// el de Frecuencias Esperadas y a partir de los mismos calcula el valor
        /// del estadístico de muestra para cada uno de los intervalos, y devuelve
        /// estos mismos valores contenidos en un array de doubles.
        /// </summary>
        private double[] calcularEstadisticoMuestreo(double[] frecuencias_esperadas, int[] frecuencias_observadas)
        {
            double[] c = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                c[i] = Math.Pow((frecuencias_observadas[i] - frecuencias_esperadas[i]), 2) / frecuencias_esperadas[i];
            }
            return c;
        }
        /// <summary>
        /// Método que calcula el estadistico acumulado a partir de los estadísticos
        /// obtenidos en cada uno de los intervalos, y retorna los valores obtenidos
        /// para cada intervalo contenidos en un array de doubles.
        /// </summary>
        private double[] estadisticos_acumulados(double[] estadisticos)
        {
            double[] c_acum = new double[listaIntervalos.Count];
            double aux = 0;
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                c_acum[i] = estadisticos[i] + aux;
                //c_acum[i] += estadisticos[i];
                aux = c_acum[i];
            }
            return c_acum;
        }

        double[] arrayKs = new double[] { 0.97500,
                                          0.70760,
                                          0.84189,
                                          0.62394,
                                          0.56328,
                                          0.51926,
                                          0.48342,
                                          0.45427,
                                          0.43001,
                                          0.40925,
                                          0.39122,
                                          0.37543,
                                          0.36143,
                                          0.34890,
                                          0.33750,
                                          0.32733,
                                          0.31796,
                                          0.30936,
                                          0.30143,
                                          0.29408,
                                          0.28724,
                                          0.28087,
                                          0.2749,
                                          0.26931,
                                          0.26404,
                                          0.25908,
                                          0.25438,
                                          0.24993,
                                          0.24571,
                                          0.24170,
                                          0.23788,
                                          0.23424,
                                          0.23076,
                                          0.22743,
                                          0.22425, };
    }
}
