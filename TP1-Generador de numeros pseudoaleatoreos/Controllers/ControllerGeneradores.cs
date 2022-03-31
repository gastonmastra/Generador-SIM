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

        /// <summary>
        /// Método que toma por parámetros los datos necesarios ingresados
        /// por el usuario para generar los numeros pseudo-aleatorios y genera
        /// una por una todas las filas, devolviendo por parametro el ultimo
        /// valor de xi calculado.
        /// </summary>
        public double generarSerie(int k, int g, double xi, int c, int a, int m)
        {
            for (i = 0; i <= 19; i++)
            {
                xi = calcularFila(i, k, xi, c, a, m);
            }
            return xi;
        }

        /// <summary>
        /// Método que calcula las filas, devolviendo como parámetro el valor del
        /// siguiente xi calculado.
        /// </summary>
        private double calcularFila(int i, int k, double xi, int c, int a, int m)
        {
            double col2 = a * xi + c;
            double nextX = col2 % m;
            xi = nextX;
            double RNDi = Math.Truncate((nextX / m) * 10000) / 10000;
            interfaz.mostrarFila(i + 1, col2, nextX, RNDi);
            return xi;
        }

        /// <summary>
        /// Método que se encarga de realizar una llamada a la función que lleva
        /// a cabo el calculo de una fila, con el fin de calcular una y solamente
        /// una fila.
        /// </summary>
        public double calcularSiguiente(int k, int c, int a, int m, double ultxi)
        {
            ultxi = calcularFila(i, k, ultxi, c, a, m);
            i = i + 1;
            return ultxi;
        }
    }
}
