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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void abrirPruebaBondad(object sender, EventArgs e)
        {
            BondadAjuste bondadAjuste = new BondadAjuste();
            bondadAjuste.ShowDialog();
        }

        private void abrirGeneradorNros(object sender, EventArgs e)
        {
            Generador generador = new Generador();
            generador.ShowDialog();
        }
    }
}
