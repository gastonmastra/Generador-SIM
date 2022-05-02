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
        //Costos acumulados
        double costoAcumCorrectivo;
        double costoAcumPreventivo;


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

            MantenimientoPreventivo gestorPreventivo = new MantenimientoPreventivo(this);
            gestorPreventivo.simular(n, desde, ko, km);

            generarConclusion();
        }

        public void MostrarFilaCorrectiva(double[] filaAMostrar)
        {
            Interfaz.MostrarFilaCorrectiva(filaAMostrar);
        }

        public void MostrarFilaPreventiva(double[] filaAMostrar)
        {
            Interfaz.MostrarFilaPreventiva(filaAMostrar);
        }

        public void setearAcumuladoCorrectiva(double calculoAcum)
        {
            this.costoAcumCorrectivo = calculoAcum;
        }

        public void setearAcumuladoPreventiva(double calculoAcum)
        {
            this.costoAcumPreventivo = calculoAcum;
        }

        public void generarConclusion()
        {
            string mensaje;
            if(costoAcumCorrectivo < costoAcumPreventivo)
            {
                mensaje = "El valor del Costo Acumulado del Correctivo es igual a $" + costoAcumCorrectivo + ", mientras que el de la estrategia Preventiva es $" + costoAcumPreventivo + ". De esta forma, se decide de que la mejor estrategia es la Correctiva.";
            }
            else
            {
                mensaje = "El valor del Costo Acumulado del Correctivo es igual a $" + costoAcumCorrectivo + ", mientras que el de la estrategia Preventiva es $" + costoAcumPreventivo + ". De esta forma, se decide de que la mejor estrategia es la Preventiva.";
            }
            Interfaz.mostrarMensaje(mensaje);
        }
    }
}
