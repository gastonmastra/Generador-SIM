using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Generador_de_numeros_pseudoaleatoreos
{
    public partial class Generador : Form
    {

        double xi;
        int g;
        int k;
        int c;
        int i;

        public Generador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
            for (i = 0; i <= 19; i++)
            {
                xi = calcularFila(i, k, g, xi, c);
            }
            btnSiguiente.Enabled = true;
        }

        private double calcularFila(int i, int k, int g, double xi, int c)
        {
            int a = 0;
            if (cmbMetodo.SelectedItem.ToString() == "Multiplicativo")
            {
                a = 3 + 8 * k;
            }
            else
            {
                a = 1 + 4 * k;
            }
            int m = (int)Math.Pow(2, g);

            txtA.Text = "a: " +  a.ToString();
            txtM.Text = "m: " + m.ToString();

            double col2 = a * xi + c;
            double nextX = col2 % m;
            xi = nextX;
            double RNDi = Math.Truncate((nextX / m) * 10000) / 10000;
            dgvTabla.Rows.Add(i+1, col2, nextX, RNDi);
            return xi;
        }

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

        private void calcularSiguiente(object sender, EventArgs e)
        {
            xi = calcularFila(i, k, g, xi, c);
            i = i + 1;
        }
    }
}
