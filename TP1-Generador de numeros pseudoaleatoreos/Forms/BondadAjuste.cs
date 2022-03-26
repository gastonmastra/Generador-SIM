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
        List<double> listaNrosAleat;
        List<double> listaIntervalos;


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
            if (Convert.ToInt32(txtN.Text.ToString()) < 30)
            {
                MessageBox.Show("El tamaño de la serie debe ser mayor a 30", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            N = Convert.ToInt32(txtN.Text);

            listaNrosAleat = generarNrosAleatorios(N);
            calcularIntervalos();
            int[] frecuencias_observadas = calcularFo();
            int[] frecuencias_esperadas = calcularFe();
            double[] estadisticos = calcularEstadisticoMuestreo(frecuencias_esperadas,frecuencias_observadas);
            double[] estadisticos_acum = estadisticos_acumulados(estadisticos);
            llenarTablaFrecuencias(listaIntervalos,frecuencias_observadas,frecuencias_esperadas,estadisticos,estadisticos_acum);
            generarHistograma(frecuencias_observadas, frecuencias_esperadas);
        }

        private void generarHistograma(int[] frecuencias_observadas,int[] frecuencias_esperadas)
        {
            //this.histograma.Series.Add("Frecuencia Observada").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            //this.histograma.Series.Add("Frecuencia Esperada").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;

            //foreach (double[] intervalo in this.matriz_resultados)
            //{
            //    this.histograma.Series["Frecuencia Observada"].Points.Add(intervalo[2]).AxisLabel = intervalo[0].ToString() + "-" + intervalo[1].ToString();
            //    this.histograma.Series["Frecuencia Esperada"].Points.Add(intervalo[3]);
            //}

            for (int i = 0; i < listaIntervalos.Count-1; i++)
            //Recorre los intervalos y va agregandolos al grafico junto con las frecuencias
            {
                //double marcaClase = (listaIntervalos[i + 1] - listaIntervalos[i]) / 2;
                histograma.Series["Fe"].Points.AddXY(listaIntervalos[i] + " - "+ listaIntervalos[i + 1], frecuencias_esperadas[i]); //Agrega la fe al grafico             
                histograma.Series["Fo"].Points.AddXY(listaIntervalos[i] + " - " + listaIntervalos[i + 1], frecuencias_observadas[i]);//Agrega la fo al grafico

            }
        }

        private double[] estadisticos_acumulados(double[] estadisticos)
        {
            double[] c_acum = new double[listaIntervalos.Count];
            double aux = 0;
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                c_acum[i] = estadisticos[i] + aux;
                //c_acum[i] += estadisticos[i];
                aux = c_acum[i];
            }
            return c_acum;
        }

        private double[] calcularEstadisticoMuestreo(int[] frecuencias_esperadas, int[] frecuencias_observadas)
        {
            double[] c = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                c[i] = Math.Pow((frecuencias_observadas[i] - frecuencias_esperadas[i]), 2) / frecuencias_esperadas[i];
            }
            return c;
        }

        private int[] calcularFe()
        {
            int[] fe = new int[listaIntervalos.Count];
            int frecuencia_esperada = N / cantIntervalos;
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                fe[i] = frecuencia_esperada;
            }
            return fe;
        }

        private int[] calcularFo()
        {
            int[] contadoresFo = new int[listaIntervalos.Count];
            int contador = 0;            
            for (int i = 0; i < listaIntervalos.Count ; i++)
            {
                //contador = listaNrosAleat.Count(x => x >= listaIntervalos[i] && x < listaIntervalos[i + 1]);
                //contadoresFo[i] = contador;
                if (i == (listaIntervalos.Count - 1))
                {
                    contador = listaNrosAleat.Count(x => x >= listaIntervalos[i - 1] && x < 1);
                    contadoresFo[i] = contador;
                }
                else
                {
                    contador = listaNrosAleat.Count(x => x >= listaIntervalos[i] && x < listaIntervalos[i + 1]);
                    contadoresFo[i] = contador;
                }
            }
            return contadoresFo;
            //foreach (double intervalo in listaIntervalos)
            //{
            //    contador = listaNrosAleat.Count(x => x >= intervalo && x < listaIntervalos.);
            //    contadoresFo[i] = contador;
            //}
        }

        private void llenarTablaFrecuencias(List<double> intervalos, int[] contadoresFo, int[] Fe, double[] c, double[] c_acumulado)
        {
            for (int i = 1; i < listaIntervalos.Count; i++)
            {
                dgvBondad.Rows.Add(
                    intervalos[i-1]+" - "+ intervalos[i],
                    contadoresFo[i-1],
                    Fe[i-1],
                    Math.Truncate(c[i-1]*10000)/10000,
                    Math.Truncate(c_acumulado[i - 1] * 10000) / 10000
                    );
            }
            
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

        private void calcularIntervalos()
        {
            listaIntervalos = generarIntervalos();
        }

        private List<double> generarIntervalos()
        {
            List<double> listaIntervalo = new List<double>();

            double intervalo = (1 / (double)cantIntervalos);
            double acum = 0;
            for (int i = 0; i < cantIntervalos; i++)
            {
                listaIntervalo.Add(Math.Round(acum,3));                
                acum += intervalo;
                acum = (Math.Truncate(acum * 10000) / 10000);
            }
            listaIntervalo.Add(1);
            return listaIntervalo;
        }

        private void cmbK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cantIntervalos = Convert.ToInt32(cmbK.SelectedItem.ToString());
        }
    }
}
