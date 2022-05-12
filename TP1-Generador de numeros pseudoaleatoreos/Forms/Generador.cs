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

namespace TP1_Generador_de_numeros_pseudoaleatoreos
{
    public partial class Generador : Form
    {

        double xi;
        int g;
        int k;
        int c;
        int i;
        int a = 0;
        int m;

        ControllerGeneradores controlador;

        double ultxi;

        public Generador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controlador = new ControllerGeneradores(this);
        }


        /// <summary>
        /// Método que se encarga de la delegación de la generación de los nros pseudo-aleatorios a partir
        /// de las constantes k, g, xi, c, a y m. 
        /// </summary>
        private void generarNumeros(object sender, EventArgs e)
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

            
            if (cmbMetodo.SelectedItem.ToString() == "Multiplicativo")
            {
                a = 3 + 8 * k;
            }
            else
            {
                a = 1 + 4 * k;
            }
            m = (int)Math.Pow(2, g);

            txtA.Text = "a: " + a.ToString();
            txtM.Text = "m: " + m.ToString();

            ultxi = controlador.generarSerie(k, g, xi, c, a, m);
            btnSiguiente.Enabled = true;
        }

        /// <summary>
        /// Método que permite establecer en cero el valor de c, constante que no se utiliza
        /// en el método Multiplicativo.
        /// </summary>
        private void validarSeleccion(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedItem.ToString() == "Multiplicativo")
            {
                txtC.Text = "0";
                txtC.Enabled = false;
            }
            else
            {
                txtC.Enabled = true;
            }
        }

        /// <summary>
        /// Método que permite calcular de a un valor por vez, a partir de haber generado
        /// los primeros 20 nros de la serie. 
        /// </summary>
        private void calcularSiguiente(object sender, EventArgs e)
        {
            ultxi = controlador.calcularSiguiente(k, c, a, m, ultxi);
            //xi = calcularFila(i, k, g, xi, c);
            //i = i + 1;
        }

        /// <summary>
        /// Método que se encarga de llenar el objeto Data Grid View con la información 
        /// referida a la serie generada de manera pseudo-aleatoria.
        /// </summary>
        public void mostrarFila(int il, double col2, double nextXi, double RNDi)
        {
            dgvTabla.Rows.Add(il, col2, nextXi, RNDi);
        }

        /// <summary>
        /// Método que se activa a partir del evento click del btnVolver_Click, el cual permite
        /// volver al formulario anterior.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
