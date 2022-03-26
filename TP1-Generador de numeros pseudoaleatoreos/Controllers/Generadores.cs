using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_Generador_de_numeros_pseudoaleatoreos.Forms;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class ControllerBondadAjuste
    {
        BondadAjuste interfaz;
        List<double> listaNrosAleatorios;
        public ControllerBondadAjuste(BondadAjuste interfaz)
        {
            this.interfaz = interfaz;
        }

        public void realizarPrueba(int a, int m, int c, int x0, int cantIntervalos, int N)
        {
            listaNrosAleatorios = this.generarNrosAleatorios(N);

            interfaz.cargarListaNrosAleatorios(listaNrosAleatorios);

        }

        private List<double> generarNrosAleatorios(int cant)
        {
            List<double> listaAleatorios = new List<double>();
            Random rm = new Random();
            for (int i = 0; i < cant; i++)
            {
                double nro = Math.Truncate(rm.NextDouble() * 10000) / 10000;
                listaAleatorios.Add(nro);
                dgvNros.Rows.Add(i + 1, nro.ToString());
            }
            listaAleatorios.Sort();
            return listaAleatorios;
        }


        private List<double> generarNumeros(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedItem == null || txtC.Text.ToString() == "" || txtG.Text.ToString() == "" || txtX0.Text.ToString() == "" || txtK.Text.ToString() == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dgvTabla.Rows.Clear();
            k = Convert.ToInt32(txtK.Text);
            g = Convert.ToInt32(txtG.Text);
            c = Convert.ToInt32(txtC.Text);
            int x0 = Convert.ToInt32(txtX0.Text);

            xi = x0;
            for (i = 0; i <= 19; i++)
            {
                xi = calcularFila(i, k, g, xi, c);
            }

            return 1;
        }
    }
    class GeneradorLenguaje
    {
    }
}
