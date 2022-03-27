using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class ControllerGeneradores
    {
        Generador interfaz;

        int i;
        double xi;

        public ControllerGeneradores(Generador interfaz)
        {
            this.interfaz = interfaz;
        }

        public double generarSerie(int k, int g, double xi, int c, int a, int m)
        {
            for (i = 0; i <= 19; i++)
            {
                xi = calcularFila(i, k, xi, c, a, m);
            }
            return xi;
        }

        private double calcularFila(int i, int k, double xi, int c, int a, int m)
        {
            double col2 = a * xi + c;
            double nextX = col2 % m;
            xi = nextX;
            double RNDi = Math.Truncate((nextX / m) * 10000) / 10000;
            interfaz.mostrarFila(i + 1, col2, nextX, RNDi);
            return xi;
        }

        public double calcularSiguiente(int k, int c, int a, int m, double ultxi)
        {
            ultxi = calcularFila(i, k, ultxi, c, a, m);
            i = i + 1;
            return ultxi;
        }
    }
}
