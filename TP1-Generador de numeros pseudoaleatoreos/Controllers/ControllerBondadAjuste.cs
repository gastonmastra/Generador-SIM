using System;
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
        int[] frecuencias_observadas;
        double[] frecuencias_esperadas;
        List<double> probabilidades;
        int parametros_empiricos;
        IControllerDistribucion distribucion;

        double[] arrayChiCuadrado = new double[] { 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6,
                                                   28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8, 43.8, 43.8, 43.8, 43.8,
                                                   43.8, 55.8, 55.8, 55.8, 55.8, 55.8, 55.8, 55.8, 55.8, 55.8, 55.8, 67.5, 67.5, 67.5, 67.5, 67.5, 67.5, 
                                                   67.5, 67.5, 67.5, 67.5, 79.1, 79.1, 79.1, 79.1, 79.1, 79.1, 79.1, 79.1, 79.1, 79.1, 90.5, 90.5, 90.5, 
                                                   90.5, 90.5, 90.5, 90.5, 90.5, 90.5, 90.5, 101.9, 101.9, 101.9, 101.9, 101.9, 101.9, 101.9, 101.9, 101.9, 
                                                   101.9, 113.1, 113.1, 113.1, 113.1, 113.1, 113.1, 113.1, 113.1, 113.1, 113.1, 124.3, 124.3, 124.3, 124.3, 124.3 };
        double[] arrayKs = new double[] { 0.97500, 0.70760, 0.84189, 0.62394, 0.56328, 0.51926, 0.48342, 0.45427, 0.43001, 0.40925, 0.39122, 0.37543,
                                          0.36143, 0.34890, 0.33750, 0.32733, 0.31796, 0.30936, 0.30143, 0.29408, 0.28724, 0.28087, 0.2749, 0.26931,
                                          0.26404, 0.25908, 0.25438, 0.24993, 0.24571, 0.24170, 0.23788, 0.23424, 0.23076, 0.22743, 0.22425};


        public ControllerBondadAjuste(BondadAjuste interfaz)
        {
            this.interfaz = interfaz;
        }

        private void calcularFrecuencias(int N)
        {
            if (interfaz.getDistribucionSeleccionada() == "Distribucion Poisson")
                frecuencias_observadas = calcularFoP();
            else
                frecuencias_observadas = calcularFo();

            frecuencias_esperadas = distribucion.calcularFe(N, probabilidades);
        }


        /// <summary>
        /// Método que delega la responsabilidad de generar los numeros pseudo-aleatorios
        /// a partir del propio lenguaje de programación, y luego realizar los calculos necesarios para establecer
        /// los intervalos.
        /// </summary>
        public void realizarPruebaLenguaje(int N, int cantIntervalos)
        {
            generarNrosConDistribucion(N, cantIntervalos);
            calcularFrecuencias(N);
            interfaz.generarHistograma(frecuencias_observadas, frecuencias_esperadas, listaIntervalos);
            realizarTestKs(cantIntervalos, N);
            realizarTestChiCuadrado(cantIntervalos, N);

        }


        /// <summary>
        /// Método encargado de realizar el calculo de cada uno de los parámetros a mostrar
        /// en la Tabla y el Histograma de frecuencias, definiendo también si la hipotesis
        /// se rechaza o no se rechaza a partir de los valores obtenidos de la distribución.
        /// </summary>
        private void realizarTestChiCuadrado(int cantIntervalos, int N)
        {
            if (interfaz.getDistribucionSeleccionada() == "Distribucion Poisson")
                frecuencias_observadas = calcularFoP();
            else
                frecuencias_observadas = calcularFo();

            frecuencias_esperadas = distribucion.calcularFe(N, probabilidades);
            acumular();

            double[] estadisticos = calcularEstadisticoMuestreo(frecuencias_esperadas, frecuencias_observadas);
            double[] estadisticos_acum = estadisticos_acumulados(estadisticos);
            interfaz.llenarTablaChiCuadrado(listaIntervalos, frecuencias_observadas, frecuencias_esperadas, estadisticos, estadisticos_acum);
            int k = listaIntervalos.Count - 1;
            int gradosLibertad = k - 1 - parametros_empiricos;
            if (estadisticos_acum[estadisticos_acum.Length - 1] < arrayChiCuadrado[gradosLibertad - 1])
            {
                string mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 1] + " < " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad - 1] + " con " + gradosLibertad + " grados de libertad\n" +
    "\t La hipotesis no se rechaza. Nivel de significancia 1−∝= 0,95";
                if (interfaz.getDistribucionSeleccionada() == "Distribucion Uniforme")
                    mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 2] + " < " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad - 1] + " con " + gradosLibertad + " grados de libertad\n" +
    "\t La hipotesis no se rechaza. Nivel de significancia 1−∝= 0,95";

                string hex = "#0096c7";
                Color color = System.Drawing.ColorTranslator.FromHtml(hex);
                interfaz.mostrarResultadoHipotesis(mensaje, color);
            }
            else
            {
                string mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 1] + " > " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad - 1] + " con " + gradosLibertad + " grados de libertad\n" +
                    "\t La hipotesis se rechaza. Nivel de significancia 1−∝= 0,95";
                if (interfaz.getDistribucionSeleccionada() == "Distribucion Uniforme")
                    mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 2] + " > " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad - 1] + " con " + gradosLibertad + " grados de libertad\n" +
                    "\t La hipotesis se rechaza. Nivel de significancia 1−∝= 0,95";
                Color color = Color.DarkRed;
                interfaz.mostrarResultadoHipotesis(mensaje, color);
            }
        }

        private void acumular()
        {
            List<double> frecuencias_esperadas_acumuladas = new List<double>();
            List<int> frecuencias_observadas_acumuladas = new List<int>();
            int indice = 0;
            frecuencias_esperadas_acumuladas.Add(frecuencias_esperadas[0]);
            frecuencias_observadas_acumuladas.Add(frecuencias_observadas[0]);

            List<double> listaIntervalosArtificiales = new List<double>();

            listaIntervalosArtificiales.Add(listaIntervalos[0]);

            for(int i = 1; i <= frecuencias_esperadas.Length - 1; i++)
            {
                if (frecuencias_esperadas_acumuladas[indice] <= 5)
                {
                    frecuencias_esperadas_acumuladas[indice] += frecuencias_esperadas[i];
                    frecuencias_observadas_acumuladas[indice] += frecuencias_observadas[i];             
                } 
                else
                {
                    indice += 1;
                    frecuencias_esperadas_acumuladas.Add(frecuencias_esperadas[i]);
                    frecuencias_observadas_acumuladas.Add(frecuencias_observadas[i]);

                    listaIntervalosArtificiales.Add(listaIntervalos[i]);
                }
            }
            if (interfaz.getDistribucionSeleccionada() != "Distribucion Uniforme")
                listaIntervalosArtificiales.Add(listaIntervalos[listaIntervalos.Count - 1]);

            if (frecuencias_esperadas_acumuladas[indice] < 5)
            {
                frecuencias_esperadas_acumuladas[indice-1] += frecuencias_esperadas_acumuladas[indice];
                frecuencias_observadas_acumuladas[indice - 1] += frecuencias_observadas_acumuladas[indice];

                frecuencias_esperadas_acumuladas.RemoveAt(indice);
                frecuencias_observadas_acumuladas.RemoveAt(indice);
                listaIntervalosArtificiales.RemoveAt(indice - 1);
            }
            frecuencias_esperadas = frecuencias_esperadas_acumuladas.ToArray();
            frecuencias_observadas = frecuencias_observadas_acumuladas.ToArray();
            listaIntervalos = listaIntervalosArtificiales;
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
                    break;
                case "Distribucion Normal (Convolucion)":
                    double mediaConv = interfaz.getMediaNormal();
                    double desvEstandarConv = interfaz.getDesvEstandarNormal();
                    distribucion = new Normal(desvEstandarConv, mediaConv, 2);
                    listaNrosConDistribucion = distribucion.generarNrosAleatorios(N);
                    generarIntervalos(cantIntervalos, listaNrosConDistribucion);
                    probabilidades = distribucion.calcularProbabilidades(listaIntervalos);
                    parametros_empiricos = 2;
                    break;
                case "Distribucion Exponencial Neg.":
                    double lambda = interfaz.getLambdaExponencial();
                    distribucion = new ExponencialNegativa(lambda);
                    listaNrosConDistribucion = distribucion.generarNrosAleatorios(N);
                    generarIntervalos(cantIntervalos, listaNrosConDistribucion);
                    probabilidades = distribucion.calcularProbabilidades(listaIntervalos);
                    parametros_empiricos = 1;
                    break;
                case "Distribucion Uniforme":
                    double A = interfaz.getAUniforme();
                    double B = interfaz.getBUniforme();
                    distribucion = new Uniforme(A, B);
                    listaNrosConDistribucion = distribucion.generarNrosAleatorios(N);
                    generarIntervalos(cantIntervalos, listaNrosConDistribucion, A, B);
                    probabilidades = listaIntervalos;
                    parametros_empiricos = 0; //VER CUANTOS
                    break;
                case "Distribucion Poisson": //No se le hace el K-S
                    double lambdaPoisson = interfaz.getLambdaPoisson();
                    distribucion = new Poisson(lambdaPoisson);
                    listaNrosConDistribucion = distribucion.generarNrosAleatorios(N);
                    List <double> listaValores = listaNrosConDistribucion.Distinct().OrderBy(number => number).ToList();
                    IEnumerable<int> listaIntervalosP = Enumerable.Range(Convert.ToInt32(listaValores[0]), Convert.ToInt32((listaValores[listaValores.Count-1]- listaValores[0] )+ 1));
                    listaIntervalos = listaIntervalosP.Select(x => Convert.ToDouble(x)).ToList();
                    probabilidades = distribucion.calcularProbabilidades(listaIntervalos);
                    //no puede usar calcularFo porque no tiene intervalos
                    parametros_empiricos = 1;
                    break;
                default:
                    break;
            }
        }

        private void realizarTestKs(int cantIntervalos, int N)
        {
            frecuencias_observadas = calcularFo();
            frecuencias_esperadas = distribucion.calcularFe(N, probabilidades);
            double[] probabilidad = calcularProbabilidad(frecuencias_observadas, N);
            double[] probabilidadAcum = calcularProbabilidadAcum(probabilidad);
            double[] probabilidadE = calcularProbabilidadE(probabilidades);
            double[] probabilidadEAcum = calcularProbabilidadEAcum(probabilidadE);
            double[] diferenciaAcum = calcularDiferenciaAcum(probabilidadAcum, probabilidadEAcum);
            double[] maxDifAcum = calcularMaxDifAcum(diferenciaAcum);
            interfaz.llenarTablaKS(listaIntervalos, frecuencias_observadas, frecuencias_esperadas, probabilidades, probabilidad, probabilidadAcum, probabilidadE, probabilidadEAcum, diferenciaAcum, maxDifAcum);
            int gradosLibertadKs = N;
            double valor_tabulado = 1.36 / (Math.Sqrt(listaNrosConDistribucion.Count));
            if (gradosLibertadKs < 35)
            {
                valor_tabulado = arrayKs[gradosLibertadKs - 1];
            }
            if ( maxDifAcum.Max() < valor_tabulado)
            {
                string mensaje = " Estadístico de prueba: " + maxDifAcum[maxDifAcum.Length-2] + " < " + " Valor tabulado: " + valor_tabulado + " con " + gradosLibertadKs + " grados de libertad\n" +
                    "\t La hipotesis no se rechaza. Nivel de significancia 1−∝= 0,95";
                string hex = "#0096c7";
                Color color = System.Drawing.ColorTranslator.FromHtml(hex);
                interfaz.mostrarResultadoHipotesisKs(mensaje, color);
            }
            else
            {
                string mensaje = " Estadístico de prueba: " + maxDifAcum[maxDifAcum.Length-2] + " > " + " Valor tabulado: " + valor_tabulado + " con " + gradosLibertadKs + " grados de libertad\n" +
                    "\t La hipotesis se rechaza. Nivel de significancia 1−∝= 0,95";
                Color color = Color.DarkRed;
                interfaz.mostrarResultadoHipotesisKs(mensaje, color);
            }
        }

        /// <summary>
        /// Método que permite definir los intervalos de nuestra distribución, a partir
        /// de la cantidad de intervalos seleccionada.
        /// </summary>
        private void generarIntervalos(int cantIntervalos, List<double> listaNrosAleatorios, double a = 1, double b = 0)
        {
            listaIntervalos = new List<double>();
            double minimo;
            double maximo;
            if (a > b)
            {
                minimo = listaNrosAleatorios.Min();
                maximo = listaNrosAleatorios.Max();
            }
            else
            {
                minimo = a;
                maximo = b;
            }
            double intervalo = ( (maximo - minimo)/ (double)cantIntervalos);
            double acum = minimo;
            for (int i = 0; i <= cantIntervalos; i++)
            {
                listaIntervalos.Add(Math.Round(acum, 3));
                acum += intervalo;
                acum = (Math.Truncate(acum * 10000) / 10000);
            }
        }

        public void mostrarSerie()
        {
            if (this.listaNrosConDistribucion != null)
                interfaz.MostrarNumeros(listaNrosConDistribucion);
            else
                MessageBox.Show("No hay números generados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (i == (listaIntervalos.Count - 1))
                {
                    contador = listaNrosConDistribucion.Count(x => x >= listaIntervalos[i - 1] && x < listaIntervalos[listaIntervalos.Count - 1]);
                    contadoresFo[i] = contador;
                }
                else
                {
                    contador = listaNrosConDistribucion.Count(x => x >= listaIntervalos[i] && x < listaIntervalos[i + 1]);
                    contadoresFo[i] = contador;
                }
            }
            return contadoresFo;
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
            double[] c = new double[frecuencias_esperadas.Length];
            for (int i = 0; i <= frecuencias_esperadas.Length - 1; i++)
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
            double[] c_acum = new double[frecuencias_esperadas.Length];
            double aux = 0;
            for (int i = 0; i <= frecuencias_esperadas.Length - 1; i++)
            {
                c_acum[i] = estadisticos[i] + aux;
                aux = c_acum[i];
            }
            return c_acum;
        }


        private double[] calcularProbabilidad(int[] frecuenciasObservadas, int N)
        {
            double NasDouble = Convert.ToDouble(N);
            double[] Po = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                Po[i] = Convert.ToDouble(frecuencias_observadas[i] / NasDouble);
            }
            return Po;
        }

        private double[] calcularProbabilidadAcum(double[] probabilidades)
        {
            double[] PoAcum = new double[listaIntervalos.Count];
            double aux = 0;
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                PoAcum[i] = probabilidades[i] + aux;
                aux = PoAcum[i];
            }
            return PoAcum;

        }

        private double[] calcularProbabilidadE(List<double> probabilidades)
        {
            double[] Pe = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                Pe[i] = probabilidades[i];
            }
            return Pe;
        }

        private double[] calcularProbabilidadEAcum(double[] probabilidadE)
        {
            double[] PeAcum = new double[listaIntervalos.Count];
            double aux = 0;
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                PeAcum[i] = probabilidadE[i] + aux;
                aux = PeAcum[i];
            }
            return PeAcum;
        }

        private double[] calcularDiferenciaAcum(double[] probabilidadAcum, double[] probabilidadEAcum)
        {
            double[] dif = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                dif[i] = Math.Abs(probabilidadAcum[i] - probabilidadEAcum[i]);
            }
            return dif;
        }
        private double[] calcularMaxDifAcum(double[] difAcum)
        {
            double[] maxDif = new double[listaIntervalos.Count];
            maxDif[0] = difAcum[0];
            for (int i = 1; i < listaIntervalos.Count - 1; i++)
            {
                if (maxDif[i - 1] < difAcum[i])
                    maxDif[i] = difAcum[i];
                else
                    maxDif[i] = maxDif[i - 1];
            }
            return maxDif;
        }

    }
}
