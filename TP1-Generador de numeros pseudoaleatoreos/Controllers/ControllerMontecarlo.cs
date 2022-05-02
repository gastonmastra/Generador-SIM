using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_Generador_de_numeros_pseudoaleatoreos.Forms;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class ControllerMontecarlo
    {
        int n;
        int desde;
        int ko;
        int km;
        Montecarlo Interfaz;

        public ControllerMontecarlo(Montecarlo interfaz)
        {
            this.Interfaz = interfaz;
        }

        public void ingresarDatos(int n, int desde, int ko, int km)
        {
            this.n = n;
            this.desde = desde;
            this.ko = ko;
            this.km = km;

            MantenimientoCorrectivo gestorCorrectivo = new MantenimientoCorrectivo(this);
            gestorCorrectivo.simular(n, desde, ko);
        }

        public void MostrarFila(double[] filaAMostrar)
        {
            Interfaz.MostrarFila(filaAMostrar);
        }
    }
}
