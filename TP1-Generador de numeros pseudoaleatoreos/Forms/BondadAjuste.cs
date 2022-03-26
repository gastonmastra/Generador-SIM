using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Forms
{
    public partial class BondadAjuste : Form
    {
        double Fe;
        double Fo;
        double C;
        int N;
        int cantIntervalos = 0;


        public BondadAjuste()
        {
            InitializeComponent();
        }

        private void realizarPrueba(object sender, EventArgs e)
        {
            dgvNros.Rows.Clear();
            dgvBondad.Rows.Clear();
            if (cmbK.SelectedItem == null|| txtN.Text.ToString() == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            N = Convert.ToInt32(txtN.Text);

            List<double> listaNrosAleat = generarNrosAleatorios(N);
            setearTablaFrecuencias(listaNrosAleat);

        }

        private void limpiarCampos()
        {
            dgvNros.Rows.Clear();
            dgvBondad.Rows.Clear();
            cmbK.SelectedItem = null;
            txtN.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private List<double> generarNrosAleatorios(int cant)
        {
            List<double> listaAleatorios = new List<double>();
            Random rm = new Random();
            for (int i = 0; i < cant; i++)
            {
                double nro = Math.Truncate(rm.NextDouble()*10000)/10000;
                listaAleatorios.Add(nro);
                dgvNros.Rows.Add(i + 1,nro.ToString());
            }
            listaAleatorios.Sort();
            return listaAleatorios;
        }

        private void setearTablaFrecuencias(List<double> listaAleatorios)
        {
            List<double> listaIntervalos = generarIntervalos();

        }

        private List<double> generarIntervalos()
        {
            List<double> listaIntervalo = new List<double>();

            double intervalo = (1 / (double)cantIntervalos);
            double acum = 0;
            for (int i = 0; i < cantIntervalos; i++)
            {
                listaIntervalo.Add(acum);                
                acum += intervalo;
                acum = (Math.Truncate(acum * 10000) / 10000);
            }
            return listaIntervalo;
        }

        private void cmbK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cantIntervalos = Convert.ToInt32(cmbK.SelectedItem.ToString());
        }
    }
}
