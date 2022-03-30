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
        //Para generador
        int A;
        int M;
        int c;
        double X0;


        public BondadAjuste()
        {
            InitializeComponent();
        }

        private void realizarPrueba(object sender, EventArgs e)
        {
            //controla que todos los campos esten completos tanto para el mixto como el generado por el lenguaje
            if (cmbMetodo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un método para la prueba de bondad de ajuste.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbK.SelectedItem == null || txtN.Text.ToString() == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(txtN.Text.ToString()) < 30)
            {
                MessageBox.Show("El tamaño de la serie debe ser mayor a 30", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            //controla que los campos necesarios para el mixto esten completos
            if (cmbMetodo.SelectedItem.ToString() == "Mixto (Congruencial lineal)")
            {
                if (txtC.Text.ToString() == "" || txtG.Text.ToString() == "" || txtX0.Text.ToString() == "" || txtK.Text.ToString() == "")
                {
                    MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            N = Convert.ToInt32(txtN.Text);

            if (cmbMetodo.SelectedItem.ToString() == "Mixto (Congruencial lineal)")
            {
                c = Convert.ToInt32(txtC.Text);
                X0 = Convert.ToInt32(txtX0.Text);
                controlador.realizarPruebaMixto(A, M, c, X0, N, cantIntervalos);
            }
            else
            {
                controlador.realizarPruebaLenguaje(N, cantIntervalos);
            }

        }
        
        public void generarHistograma(int[] frecuencias_observadas,int[] frecuencias_esperadas, List<double> listaIntervalos)
        {
            histograma.Series["Fe"].Points.Clear();
            histograma.Series["Fo"].Points.Clear();
            for (int i = 0; i < listaIntervalos.Count-1; i++)
            //Recorre los intervalos y va agregandolos al grafico junto con las frecuencias
            {
                histograma.Series["Fe"].Points.AddXY(listaIntervalos[i] + " - "+ listaIntervalos[i + 1], frecuencias_esperadas[i]); //Agrega la fe al grafico             
                histograma.Series["Fo"].Points.AddXY(listaIntervalos[i] + " - " + listaIntervalos[i + 1], frecuencias_observadas[i]);//Agrega la fo al grafico
                histograma.Series["Fe"].AxisLabel = "Frecuencia";
            }
        }

        public void llenarTablaFrecuencias(List<double> intervalos, int[] contadoresFo, int[] Fe, double[] c, double[] c_acumulado)
        {
            dgvBondad.Rows.Clear();
            for (int i = 1; i < intervalos.Count; i++)
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
            histograma.Series["Fe"].Points.Clear();
            histograma.Series["Fo"].Points.Clear();
            txtC.Text = "";
            txtK.Text = "";
            txtX0.Text = "";
            txtG.Text = "";
            txtA.Text = "";
            txtM.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cmbK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cantIntervalos = Convert.ToInt32(cmbK.SelectedItem.ToString());
        }

        private void calcularM(object sender, EventArgs e)
        {
            if (txtG.Text != "")
            {
                M = (int)Math.Pow(2, Convert.ToInt32(txtG.Text));
                txtM.Text = "m: " + M.ToString();
            }  
        }

        private void calcularA(object sender, EventArgs e)
        {
            if (txtK.Text != "")
            {
                A = 1 + 4 * Convert.ToInt32(txtK.Text);
                txtA.Text = "a: " + A.ToString();
            }
        }

        private void validarMetodo(object sender, EventArgs e)
        {

            if (cmbMetodo.SelectedItem.ToString() == "Mixto (Congruencial lineal)")
            {
                gbGenerador.Visible = true;
            }
            else
            {
                gbGenerador.Visible = false;
            }
        }

        private void BondadAjuste_Load(object sender, EventArgs e)
        {
            controlador = new ControllerBondadAjuste(this);
        }

        public void MostrarNumeros(List<double> nros)
        {
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
    }
}
