using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_Generador_de_numeros_pseudoaleatoreos.Controllers;

namespace TP1_Generador_de_numeros_pseudoaleatoreos.Forms
{
    public partial class BondadAjuste : Form
    {
        ControllerBondadAjuste controlador;

        double Fe;
        double Fo;
        double C;
        int N;
        int cantIntervalos = 0;
        List<double> listaNrosAleat;
        List<double> listaIntervalos;
        string cmbDistribucionSeleccionada { get; set; }

        public BondadAjuste()
        {
            InitializeComponent();
        }

        public string getDistribucionSeleccionada()
        {
            return this.cmbDistribucionSeleccionada;
        }

        /// <summary>
        /// Método que delega la responsabilidad de realizar la prueba en función.
        /// de lo que se haya seleccionado dentro del Combo Box.
        /// </summary>
        private void realizarPrueba(object sender, EventArgs e)
        {
            label4.Visible = false;
            dgvNros.Visible = false;
            dgvNros.Rows.Clear();
            //controla que todos los campos esten completos tanto para el mixto como el generado por el lenguaje
            if (cmbDistribucion.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una distribucion para la prueba de bondad de ajuste.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((cmbK.SelectedItem == null || txtN.Text.ToString() == "") && cmbDistribucion.SelectedItem.ToString() != "Distribucion Poisson")
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            cmbDistribucionSeleccionada = cmbDistribucion.SelectedItem.ToString();
            N = Convert.ToInt32(txtN.Text);

            if (cmbDistribucionSeleccionada == "Distribucion Poisson")
            {
                controlador.realizarPruebaLenguaje(N, 0);
            }
            else
            {
                controlador.realizarPruebaLenguaje(N, cantIntervalos);
            }
            
        }

        public double getLambdaExponencial()
        {
            return Convert.ToDouble(this.txtLambdaExponencial.Text);
        }

        public double getLambdaPoisson()
        {
            return Convert.ToDouble(this.textBox2.Text);
        }

        public void generarHistograma(int[] frecuencias_observadas, double[] frecuencias_esperadas, List<double> listaIntervalos)
        {
            histograma.Series["Fe"].Points.Clear();
            histograma.Series["Fo"].Points.Clear();
            if (cmbDistribucionSeleccionada == "Distribucion Poisson")
            {
                for (int i = 0; i < listaIntervalos.Count; i++)
                //Recorre los intervalos y va agregandolos al grafico junto con las frecuencias
                {
                    histograma.Series["Fe"].Points.AddXY(listaIntervalos[i], frecuencias_esperadas[i]); //Agrega la fe al grafico             
                    histograma.Series["Fo"].Points.AddXY(listaIntervalos[i], frecuencias_observadas[i]);//Agrega la fo al grafico
                    //histograma.Series["Fe"].AxisLabel = "Frecuencia";
                }
            }
            else
            {
                for (int i = 0; i < listaIntervalos.Count - 1; i++)
                //Recorre los intervalos y va agregandolos al grafico junto con las frecuencias
                {
                    histograma.Series["Fe"].Points.AddXY(listaIntervalos[i] + " - " + listaIntervalos[i + 1], frecuencias_esperadas[i]); //Agrega la fe al grafico             
                    histograma.Series["Fo"].Points.AddXY(listaIntervalos[i] + " - " + listaIntervalos[i + 1], frecuencias_observadas[i]);//Agrega la fo al grafico
                    histograma.Series["Fe"].AxisLabel = "Frecuencia";
                }
            }
                
        }
        /// <summary>
        /// Método que se encarga de llenar la tabla de frecuencias en base a los 
        /// datos obtenidos, a partir de la frecuencia observada y esperada obtenidas, y
        /// las formulas de estadistico de muestra y estadistico acumulado.
        /// </summary>
        public void llenarTablaChiCuadrado(List<double> intervalos, int[] contadoresFo, double[] Fe, double[] c, double[] c_acumulado)
        {
            dgvChiCuadrado.Rows.Clear();
            if (cmbDistribucionSeleccionada == "Distribucion Poisson")
            {
                for (int i = 1; i <= intervalos.Count; i++)
                {
                    dgvChiCuadrado.Rows.Add(
                        intervalos[i - 1],
                        contadoresFo[i - 1],
                        Fe[i - 1],
                        Math.Truncate(c[i - 1] * 10000) / 10000,
                        Math.Truncate(c_acumulado[i - 1] * 10000) / 10000
                        );
                }
            }
            else
            {
                for (int i = 1; i < intervalos.Count; i++)
                {
                    dgvChiCuadrado.Rows.Add(
                        intervalos[i - 1] + " - " + intervalos[i],
                        contadoresFo[i - 1],
                        Fe[i - 1],
                        Math.Truncate(c[i - 1] * 10000) / 10000,
                        Math.Truncate(c_acumulado[i - 1] * 10000) / 10000
                        );
                }
            }
            
        }

        public void llenarTablaKS(List<double> intervalos, int[] contadoresFo, double[] Fe, List<double> probabilidades)
        {
            double maxDifAcum = 0;
            double NasDouble = Convert.ToDouble(N);
            double PoAcum = 0;
            double PeAcum = 0;
            dgvKs.Rows.Clear();

            for (int i = 0; i < intervalos.Count - 1; i++)
            {
                double Po = Convert.ToDouble(contadoresFo[i]) / NasDouble;
                PoAcum = PoAcum + Po;


                double Pe = probabilidades[i];
                PeAcum = PeAcum + Pe;

                if (i == 0)
                {
                    PoAcum = Po;
                    PeAcum = Pe;
                }

                string desdeHasta = intervalos[i] + " - " + intervalos[i + 1];
                if (i == intervalos.Count)
                {
                    desdeHasta = intervalos[i] + " - " + 1;
                }

                double diferenciaAcum = Math.Abs(PeAcum - PoAcum);
                if (diferenciaAcum > maxDifAcum)
                {
                    maxDifAcum = diferenciaAcum;
                };



                dgvKs.Rows.Add(
                    desdeHasta,
                    contadoresFo[i],
                    Fe[i],
                    Po,
                    PoAcum,
                    Pe,
                    PeAcum,
                    diferenciaAcum,
                    maxDifAcum
                    );
            }
        }
        /// <summary>
        /// Método que se encarga de limpiar los campos del formulario.
        /// </summary>
        private void limpiarCampos()
        {
            dgvNros.Rows.Clear();
            dgvChiCuadrado.Rows.Clear();
            dgvKs.Rows.Clear();
            cmbK.SelectedItem = null;
            txtN.Text = "";
            histograma.Series["Fe"].Points.Clear();
            histograma.Series["Fo"].Points.Clear();
            lblHipotesis.Text = "";
            lblHipotesisKs.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cmbK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cantIntervalos = Convert.ToInt32(cmbK.SelectedItem.ToString());
        }


        private void BondadAjuste_Load(object sender, EventArgs e)
        {
            controlador = new ControllerBondadAjuste(this);
        }
        /// <summary>
        /// Método que toma la lista de nros pseudo-aleatorios generados por parámetro
        /// y los agrega uno por uno a un elemento del tipo Data Grid View para que 
        /// puedan ser visualizados.
        /// </summary>
        public void MostrarNumeros(List<double> nros)
        {
            listaNrosAleat = nros;
            dgvNros.Rows.Clear();
            for (int i = 0; i < nros.Count; i++)
            {
            dgvNros.Rows.Add(i + 1, nros[i].ToString());
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void mostrarResultadoHipotesis(string mensaje, Color color)
        {
            lblHipotesis.Text = mensaje;
            lblHipotesis.Visible = true;
            lblHipotesis.ForeColor = color;
        }



        private void validarDistribucion(object sender, EventArgs e)
        {
            deshabilitarParametros();
            dgvKs.Visible = true;
            lblHipotesisKs.Visible = true;
            label1.Visible = true;
            cmbK.Visible = true;
            switch (cmbDistribucion.SelectedItem.ToString())
            {
                case "Distribucion Normal (Box-Muller)":
                    gbNormal.Visible = true;
                    
                    break;
                case "Distribucion Normal (Convolucion)":
                    gbNormal.Visible = true;

                    break;
                case "Distribucion Exponencial Neg.":
                    gbExponencial.Visible = true;

                    break;
                case "Distribucion Uniforme":
                    gbUniforme.Visible = true;

            
                    break;
                case "Distribucion Poisson":
                    gbPoisson.Visible = true;
                    cmbK.Visible = false;
                    dgvKs.Visible = false;
                    lblHipotesisKs.Visible = false;
                    label1.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void deshabilitarParametros()
        {
            gbUniforme.Visible = false;
            gbPoisson.Visible = false;
            gbNormal.Visible = false;
            gbExponencial.Visible = false;
        }

        public double getMediaNormal()
        {
            return Convert.ToDouble(txtMediaNormal.Text.ToString());
        }

        public double getDesvEstandarNormal()
        {
            return Convert.ToDouble(txtDesviacionNormal.Text.ToString());
        }

        private void verSerie(object sender, EventArgs e)
        {
            controlador.mostrarSerie();
            dgvNros.Visible = true;
            label4.Visible = true;
        }
    }
}
