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
    public partial class Montecarlo : Form
    {
        ControllerMontecarlo controller;
        public Montecarlo()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            controller = new ControllerMontecarlo(this);
            dgvCorrectiva.Rows.Clear();
            dgvPreventiva.Rows.Clear();
            if(validarDatos())
                controller.ingresarDatos(int.Parse(txtN.Text), int.Parse(txtDesde.Text), int.Parse(txtKo.Text), int.Parse(txtKm.Text));

        }

        private bool validarDatos()
        {
            if (txtN.Text =="" && txtDesde.Text == "" &&
               txtKm.Text == "" && txtKo.Text == ""){
                MessageBox.Show("Ingrese todos los valores", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (int.Parse(txtN.Text) <= 0 && int.Parse(txtDesde.Text) <= 0 &&
                int.Parse(txtKm.Text) <= 0 && int.Parse(txtKo.Text) <= 0){
                MessageBox.Show("Debe ingresar valores positivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if(int.Parse(txtN.Text) < 400)
            {
                MessageBox.Show("Debe ingresar valores iguales o mayores a 400", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if((int.Parse(txtN.Text)-400) < int.Parse(txtDesde.Text))
            {
                MessageBox.Show("Ingrese un valor valido para Desde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesde.Text = ""; txtDesde.Focus();
                return false;
            }
            return true;
        }

        public void MostrarFilaCorrectiva(double[] filaAMostrar)
        {
            dgvCorrectiva.Rows.Add(filaAMostrar[0], filaAMostrar[1], filaAMostrar[2], filaAMostrar[3],
                filaAMostrar[4], filaAMostrar[5], "$" + filaAMostrar[6].ToString(), filaAMostrar[7].ToString(), filaAMostrar[8].ToString());
        }

        public void MostrarFilaPreventiva(double[] filaAMostrar)
        {
            dgvPreventiva.Rows.Add(filaAMostrar[0], filaAMostrar[1], filaAMostrar[2], filaAMostrar[3],
                filaAMostrar[4], "$" + filaAMostrar[5].ToString(), "$" + filaAMostrar[6].ToString(), "$" + filaAMostrar[7].ToString(), "$" + filaAMostrar[8].ToString(), filaAMostrar[9].ToString(), filaAMostrar[10].ToString(), filaAMostrar[11].ToString());
        }

        public void mostrarMensaje(string mensaje)
        {
            lblEstrategia.Text = mensaje;
        }
    }
}
