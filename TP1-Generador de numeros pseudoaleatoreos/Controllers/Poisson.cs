using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class Poisson : IControllerDistribucion
    {
        double lambda;
        public Poisson(double lambda)
        {
            this.lambda = lambda;
        }

        public double[] calcularFe(int N, List<double> probabilidades)
        {
            double[] frecuenciasEsperadas = new double[probabilidades.Count];
            for (int i = 0; i < probabilidades.Count; i++)
            {
                frecuenciasEsperadas[i] = Math.Round(N * probabilidades[i]);
            }
            return frecuenciasEsperadas;
        }

        public List<double> calcularProbabilidades(List<double> listaConValores)
        {
            List<double> probabilidades = new List<double>();
            for (int i = 0; i < listaConValores.Count; i++)
            {
                double numerador1 = Math.Pow(lambda, listaConValores[i]);
                double numerador2 = Math.Exp(-lambda);
                //double denominador = factorial((long)(listaConValores[i]));
                double factorial = 1;
                for (double j = listaConValores[i]; j >= 1; j--)
                {
                    factorial *= j;
                }
                double probabilidad = (numerador1 * numerador2) / factorial;
                //double probabilidad = Math.Truncate((Math.Pow(lambda,listaConValores[i])* Math.Exp(-lambda))/ factorial(Convert.ToInt32(listaConValores[i])) * 100000000) / 100000000;
                probabilidades.Add(probabilidad);
                
            }
            return probabilidades;
        }

        public long factorial(long n)
        {
            return (n == 1 || n == 0) ? 1 : n * factorial(n - 1);
                
            //long n = 0;
            //while (num > 0)
            //{
            //     n = num;
            //    for (long i = n - 1; i > 0; i--)
            //    {
            //        n *= i;
            //    }
            //    num--;
            //}
            //return n;
        }


        public List<double> generarNrosAleatorios(int cantidad)
        {
            List<double> listaNrosExponencialesAleatorios = new List<double>();
            
            Random rnd = new Random();

            double A = Math.Exp(-lambda);

            for (int i = 0; i < cantidad; i++)
            {
                double P = 1;
                int X = -1;

                do
                {
                    double U = rnd.NextDouble();// Math.Truncate( * 100000000) / 100000000;
                    P *= U;
                    X += 1;
                } while (P >= A);
                
                listaNrosExponencialesAleatorios.Add(X);
            }

            return listaNrosExponencialesAleatorios;
        }

        
    }
}
