using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    interface IControllerDistribucion
    {
        List<double> calcularProbabilidades(List<double> listaIntervalos);
        List<double> generarNrosAleatorios(int cantidad);

        double[] calcularFe(int N, List<double> probabilidades);



    }
}
