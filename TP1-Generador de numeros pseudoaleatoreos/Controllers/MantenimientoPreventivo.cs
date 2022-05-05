using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class MantenimientoPreventivo
    {
        ControllerMontecarlo controller;
        public MantenimientoPreventivo(ControllerMontecarlo controller)
        {
            this.controller = controller;
        }

        public void simular(int cantidadCiclos, int desde, int ko, int km)
        {
            Random random = new Random();
            double rnd = random.NextDouble();
            double[] actual = new double[12] {1, 1, rnd, obtenerDiaAveria(rnd), 1 + obtenerDiaAveria(rnd), 0, 0, 0, 0, 0, 0, 0};
            double costoAcum = 0;
            double filasMostradas = 0;
            double cantReparaciones = 0;
            double cantRevisiones = 0;
            double costoEnDia5 = 0;
            double dia = 0;
            for (int ciclo = 1; ciclo <= cantidadCiclos; ciclo++)
            {
                dia = actual[4];
                rnd = random.NextDouble();
                double enCuantoAveria = obtenerDiaAveria(rnd);
                if (enCuantoAveria > 5)
                {
                    costoEnDia5 += km;
                    cantRevisiones++;
                    double diaDeAveria = dia + 5;
                    costoAcum = actual[8] + km;
                    actual = new double[] { ciclo, dia, rnd, enCuantoAveria, diaDeAveria, km, 0, km, costoAcum, cantReparaciones, cantRevisiones, costoEnDia5};
                }
                else
                {
                    if (enCuantoAveria == 5)
                    {
                        costoEnDia5 += ko;
                    }
                    cantReparaciones++;
                    double diaDeAveria = dia + enCuantoAveria;
                    costoAcum = actual[8] + ko;
                    actual = new double[] { ciclo, dia, rnd, enCuantoAveria, diaDeAveria, 0, ko, ko, costoAcum, cantReparaciones, cantRevisiones, costoEnDia5};
                }
               
                if (ciclo >= desde && filasMostradas <= 400)
                {
                    controller.MostrarFilaPreventiva(actual);
                    filasMostradas++;
                }
            }
            controller.MostrarFilaPreventiva(actual);
            controller.setearAcumuladoPreventiva(costoAcum);
            controller.SetearCantidadDiasPreventiva(dia);
        }

        public double obtenerDiaAveria(double rnd)
        {

            if (rnd > 0 && rnd < 0.25)
            {
                return 4;
            }
            else
            {
                if (rnd < 0.7)
                {
                    return 5;
                }
                else
                {
                    if (rnd < 0.9)
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
