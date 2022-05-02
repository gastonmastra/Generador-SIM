using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class Uniforme : IControllerDistribucion
    {
        double A;
        double B;
        double Fe;

        public Uniforme(double a, double b){
            this.A = a;
            this.B = b;
        }

        public double[] calcularFe(int N, List<double> probabilidades)
        {
            double[] frecuenciasEsperadas = new double[probabilidades.Count];
            Fe = N / (double) probabilidades.Count;
            for (int i = 0; i < probabilidades.Count; i++)
            {
                frecuenciasEsperadas[i] = Fe;
            }
            return frecuenciasEsperadas;
        }

        public List<double> calcularProbabilidades(List<double> listaIntervalos)
        {
            //List<double> probabilidades = new List<double>();
            //double probabilidad = Fe / tamaño_serie;
            //for (int i = 0; i < listaIntervalos.Count; i++)
            //{
            //    probabilidades.Add(probabilidad);
            //}
            //return probabilidades;
            throw new NotImplementedException();
        }

        public List<double> generarNrosAleatorios(int cantidad)
        {
            List<double> listaNrosExponencialesAleatorios = new List<double>();
            Random generador = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                double rnd = Math.Truncate(generador.NextDouble() * 10000) / 10000; //Simboliza Generador uniforme (0,1)
                double x = this.A + (rnd * (this.B - this.A));
                listaNrosExponencialesAleatorios.Add(x);
            }
            return listaNrosExponencialesAleatorios;
        }
    }
}
