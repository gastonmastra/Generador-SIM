using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class ExponencialNegativa : IControllerDistribucion
    {
        double lambda;
        public ExponencialNegativa(double lambda) 
        {
            this.lambda = lambda; 
        }
        public long calcularProbabilidad(long x, long media, long desvStd)
        {
            throw new NotImplementedException();
        }

        public long calcularProbabilidad(long x, long media)
        {
            throw new NotImplementedException();
        }

        public List<double> generarNrosAleatorios(int cantidad, long media)
        {
            //No corresponde a esta distribución
            throw new NotImplementedException();
        }

        public List<double> generarNrosAleatorios(int cantidad)
        {
            List<double> listaNrosAleatorios = new List<double>();
            Random rm = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                double nro = Math.Truncate(rm.NextDouble() * 10000) / 10000;
                double x = -1/this.lambda * Math.Log(1 - nro);
                listaNrosAleatorios.Add(x);
            }
            return listaNrosAleatorios;
        }

    }
}
