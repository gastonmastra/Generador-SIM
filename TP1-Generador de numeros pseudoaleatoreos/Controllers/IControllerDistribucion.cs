using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    interface IControllerDistribucion
    {
        long calcularProbabilidad(long x, long media, long desvStd);
        long calcularProbabilidad(long x, long media);
        List<double> generarNrosAleatorios(int cantidad);
        List<double> generarNrosAleatorios(int cantidad, long media);


    }
}
