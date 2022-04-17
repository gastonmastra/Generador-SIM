using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public List<double> calcularProbabilidades(List<double> listaNros)
        {
            List<double> listaConValores = listaNros.Distinct().ToList(); 
            List<double> probabilidades = new List<double>();
            for (int i = 0; i < listaConValores.Count; i++)
            {
                double probabilidad = (Math.Pow(lambda,listaNros[i])* Math.Exp(-lambda))/ factorial(Convert.ToInt32(listaNros[i]));
                probabilidades.Add(probabilidad);
            }
            return probabilidades;
        }

        public int factorial(int n)
        {
            return (n == 1 || n == 0) ? 1 : n * factorial(n - 1);
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
                    double U = Math.Truncate(rnd.NextDouble() * 10000) / 10000;
                    P *= U;
                    X += 1;
                } while (P >= A);
                
                listaNrosExponencialesAleatorios.Add(X);
            }

            return listaNrosExponencialesAleatorios;
        }

        
    }
}
