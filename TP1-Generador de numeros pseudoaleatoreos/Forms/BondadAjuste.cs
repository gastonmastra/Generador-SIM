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
        public BondadAjuste()
        {
            InitializeComponent();
        }

        private void realizarPrueba(object sender, EventArgs e)
        {
            if (cmbK.ToString() == "" || txtN.Text.ToString() == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            N = Convert.ToInt32(txtN.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbK.SelectedIndex = -1;
            txtN.Text = "";
        }
    }
}
