using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class MantenimientoCorrectivo
    {
        ControllerMontecarlo controller;
        public MantenimientoCorrectivo(ControllerMontecarlo controller) {
            this.controller = controller;
        }
        public void simular(int cantidadCiclos, int desde, int ko)
        {
            Random random = new Random();
            double rnd = random.NextDouble();
            double[] actual = new double[9] { 1, 1, rnd, obtenerDiaAveria(rnd), 1 + obtenerDiaAveria(rnd), 0, 0, 0, 0};
            int costoAcum = 0;
            double filasMostradas = 0;
            double cantReparaciones = 1;
            double costoAveriasEn5 = 0;
            double dia = 0;
            if (desde == 1)
                controller.MostrarFilaCorrectiva(actual);

            for (int ciclo = 2; ciclo <= cantidadCiclos; ciclo++)
            {
                dia = actual[4];
                rnd = random.NextDouble();
                double enCuantoAveria = obtenerDiaAveria(rnd);
                double diaDeAveria = dia + enCuantoAveria;
                costoAcum += ko;
                cantReparaciones++;
                if (enCuantoAveria == 5)
                {
                    costoAveriasEn5 += ko;
                }
                actual = new double[]{ ciclo, dia, rnd, enCuantoAveria, diaDeAveria, ko, costoAcum, cantReparaciones, costoAveriasEn5};
                if (ciclo >= desde && filasMostradas <= 400)
                {
                    controller.MostrarFilaCorrectiva(actual);
                    filasMostradas++;
                }
            }
            controller.MostrarFilaCorrectiva(actual);
            controller.setearAcumuladoCorrectiva(costoAcum);
            controller.SetearCantidadDiasCorrectiva(dia);
        }

        public double obtenerDiaAveria(double rnd)
        {
            
            if(rnd > 0 && rnd < 0.25)
            {
                return 4;
            }
            else
            {
                if(rnd < 0.7)
                {
                    return 5;
                }
                else
                {
                    if(rnd < 0.9)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }


    }
}
