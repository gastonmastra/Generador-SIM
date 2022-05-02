using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class MantenimientoCorrectivo
    {
        public void simular(int n, int desde, int ko)
        {
            int[] actual = new int[8];
            Random rnd = new Random();
            int costo = 0;
            for (int i = 1; i <= n; i++)
            {
                double rnd1 = rnd.NextDouble();
                int diaAveria = obtenerDiaAveria(rnd1);
                actual = actual[diaAveria, rnd1];
                
            }    
        }

        public int obtenerDiaAveria(double rnd)
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
