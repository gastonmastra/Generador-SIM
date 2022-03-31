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
        List<double> listaNrosAleatorios;
        List<double> listaIntervalos;
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
        /// enviandole como parámetro los valores de a, m, c, x0 y N al método 
        /// generarAleatoriosMixto, y luego realizando los calculos necesarios para establecer
        /// los intervalos.
        /// </summary>
        public void realizarPruebaMixto(int a, long m, int c, double x0,int N, int cantIntervalos)
        {
            generarAlatoriosMixto(a, m, c, x0, N);

            realizarCalculos(cantIntervalos, N);
        }

        /// <summary>
        /// Método que delega la responsabilidad de generar los numeros pseudo-aleatorios
        /// a partir del propio lenguaje de programación, y luego realizar los calculos necesarios para establecer
        /// los intervalos.
        /// </summary>
        public void realizarPruebaLenguaje(int N, int cantIntervalos)
        {
            generarNrosAleatorios(N);

            realizarCalculos(cantIntervalos, N);
        }

        /// <summary>
        /// Método que se encarga de generar los numeros pseudo-aleatorios a partir de la
        /// utilización del método Mixto (Congruencial Lineal).
        /// </summary>
        private void generarAlatoriosMixto(int a, long m,int c, double x0, int N)
        {
            listaNrosAleatorios = new List<double>();
            for (int i = 0; i < N; i++)
            {
                double nextX = (a * x0 + c) % m;
                x0 = nextX;
                double RNDi = Math.Truncate((nextX / m) * 10000) / 10000;
                listaNrosAleatorios.Add(RNDi);
            }
            interfaz.MostrarNumeros(listaNrosAleatorios);
        }

        /// <summary>
        /// Método que se encarga de generar los numeros pseudo-aleatorios utilizando el propio
        /// lenguaje de programación.
        /// </summary>
        private void generarNrosAleatorios(int cant)
        {
            listaNrosAleatorios = new List<double>();
            Random rm = new Random();
            for (int i = 0; i < cant; i++)
            {
                double nro = Math.Truncate(rm.NextDouble() * 10000) / 10000;
                listaNrosAleatorios.Add(nro);
            }
            interfaz.MostrarNumeros(listaNrosAleatorios);
        }

        /// <summary>
        /// Método encargado de realizar el calculo de cada uno de los parámetros a mostrar
        /// en la Tabla y el Histograma de frecuencias, definiendo también si la hipotesis
        /// se rechaza o no se rechaza a partir de los valores obtenidos de la distribución.
        /// </summary>
        private void realizarCalculos(int cantIntervalos, int N)
        {
            generarIntervalos(cantIntervalos);
            int[] frecuencias_observadas = calcularFo();
            int[] frecuencias_esperadas = calcularFe(N, cantIntervalos);
            double[] estadisticos = calcularEstadisticoMuestreo(frecuencias_esperadas, frecuencias_observadas);
            double[] estadisticos_acum = estadisticos_acumulados(estadisticos);
            interfaz.llenarTablaFrecuencias(listaIntervalos, frecuencias_observadas, frecuencias_esperadas, estadisticos, estadisticos_acum);
            interfaz.generarHistograma(frecuencias_observadas, frecuencias_esperadas, listaIntervalos);
            int gradosLibertad = cantIntervalos - 1;

            if (estadisticos_acum[estadisticos_acum.Length-2] < arrayChiCuadrado[gradosLibertad])
            {
                string mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 2] + " < " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad] + " con "+gradosLibertad+" grados de libertad\n" +
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

        /// <summary>
        /// Método que permite definir los intervalos de nuestra distribución, a partir
        /// de la cantidad de intervalos seleccionada.
        /// </summary>
        private void generarIntervalos(int cantIntervalos)
        {
            listaIntervalos = new List<double>();
            double intervalo = (1 / (double)cantIntervalos);
            double acum = 0;
            for (int i = 0; i < cantIntervalos; i++)
            {
                listaIntervalos.Add(Math.Round(acum, 3));
                acum += intervalo;
                acum = (Math.Truncate(acum * 10000) / 10000);
            }
            listaIntervalos.Add(1);
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
                    contador = listaNrosAleatorios.Count(x => x >= listaIntervalos[i - 1] && x < 1);
                    contadoresFo[i] = contador;
                }
                else
                {
                    contador = listaNrosAleatorios.Count(x => x >= listaIntervalos[i] && x < listaIntervalos[i + 1]);
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

        /// <summary>
        /// Método que calcula la Frecuencia Esperada de la distribución y devuelve como
        /// resultado un array de int.
        /// </summary>
        private int[] calcularFe(int N, int cantIntervalos)
        {
            int[] fe = new int[listaIntervalos.Count];
            int frecuencia_esperada = N / cantIntervalos;
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                fe[i] = frecuencia_esperada;
            }
            return fe;
        }
        /// <summary>
        /// Método que toma como parámetros el arrray de Frecuencias Observadas y 
        /// el de Frecuencias Esperadas y a partir de los mismos calcula el valor
        /// del estadístico de muestra para cada uno de los intervalos, y devuelve
        /// estos mismos valores contenidos en un array de doubles.
        /// </summary>
        private double[] calcularEstadisticoMuestreo(int[] frecuencias_esperadas, int[] frecuencias_observadas)
        {
            double[] c = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count; i++)
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

    }
    class GeneradorLenguaje
    {
    }
}
