using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_Generador_de_numeros_pseudoaleatoreos.Forms;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class ControllerBondadAjuste
    {
        BondadAjuste interfaz;
        List<double> listaNrosAleatorios;
        List<double> listaIntervalos;
        public ControllerBondadAjuste(BondadAjuste interfaz)
        {
            this.interfaz = interfaz;
            
        }

        public void realizarPruebaMixto(int a, int m, int c, double x0,int N, int cantIntervalos)
        {
            generarAlatoriosMixto(a, m, c, x0, N);

            realizarCalculos(cantIntervalos, N);
        }

        public void realizarPruebaLenguaje(int N, int cantIntervalos)
        {
            generarNrosAleatorios(N);

            realizarCalculos(cantIntervalos, N);
        }

        private void generarAlatoriosMixto(int a, int m,int c, double x0, int N)
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

        private void realizarCalculos(int cantIntervalos, int N)
        {
            generarIntervalos(cantIntervalos);
            int[] frecuencias_observadas = calcularFo();
            int[] frecuencias_esperadas = calcularFe(N, cantIntervalos);
            double[] estadisticos = calcularEstadisticoMuestreo(frecuencias_esperadas, frecuencias_observadas);
            double[] estadisticos_acum = estadisticos_acumulados(estadisticos);
            interfaz.llenarTablaFrecuencias(listaIntervalos, frecuencias_observadas, frecuencias_esperadas, estadisticos, estadisticos_acum);
            interfaz.generarHistograma(frecuencias_observadas, frecuencias_esperadas, listaIntervalos);

            //listaNrosAleatorios = this.generarNrosAleatorios(N);

            //interfaz.cargarListaNrosAleatorios(listaNrosAleatorios);
        }

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

        private double[] calcularEstadisticoMuestreo(int[] frecuencias_esperadas, int[] frecuencias_observadas)
        {
            double[] c = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                c[i] = Math.Pow((frecuencias_observadas[i] - frecuencias_esperadas[i]), 2) / frecuencias_esperadas[i];
            }
            return c;
        }

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
