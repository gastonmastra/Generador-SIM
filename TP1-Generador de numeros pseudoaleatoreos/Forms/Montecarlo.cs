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
            //validarDatos();
            dgvCorrectiva.Rows.Clear();
            dgvPreventiva.Rows.Clear();
            controller.ingresarDatos(int.Parse(txtN.Text), int.Parse(txtDesde.Text), int.Parse(txtKo.Text), int.Parse(txtKm.Text));
            
        }

        private void validarDatos()
        {
            throw new NotImplementedException();
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
