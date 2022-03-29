
namespace TP1_Generador_de_numeros_pseudoaleatoreos.Forms
{
    partial class BondadAjuste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtN = new System.Windows.Forms.TextBox();
            this.cmbK = new System.Windows.Forms.ComboBox();
            this.dgvBondad = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadisticoMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntPruebaBondad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNros = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroAleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.gbGenerador = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBondad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).BeginInit();
            this.gbGenerador.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.AcceptsReturn = true;
            this.txtN.Location = new System.Drawing.Point(168, 50);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(66, 20);
            this.txtN.TabIndex = 1;
            // 
            // cmbK
            // 
            this.cmbK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbK.FormattingEnabled = true;
            this.cmbK.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12"});
            this.cmbK.Location = new System.Drawing.Point(171, 77);
            this.cmbK.Name = "cmbK";
            this.cmbK.Size = new System.Drawing.Size(66, 21);
            this.cmbK.TabIndex = 2;
            this.cmbK.SelectionChangeCommitted += new System.EventHandler(this.cmbK_SelectionChangeCommitted);
            // 
            // dgvBondad
            // 
            this.dgvBondad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBondad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBondad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBondad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.fo,
            this.fe,
            this.estadisticoMuestra,
            this.cAcum});
            this.dgvBondad.Location = new System.Drawing.Point(12, 130);
            this.dgvBondad.Name = "dgvBondad";
            this.dgvBondad.Size = new System.Drawing.Size(576, 259);
            this.dgvBondad.TabIndex = 4;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.Name = "intervalo";
            this.intervalo.ReadOnly = true;
            // 
            // fo
            // 
            this.fo.HeaderText = "Fo";
            this.fo.Name = "fo";
            this.fo.ReadOnly = true;
            // 
            // fe
            // 
            this.fe.HeaderText = "Fe";
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            // 
            // estadisticoMuestra
            // 
            this.estadisticoMuestra.HeaderText = "C";
            this.estadisticoMuestra.Name = "estadisticoMuestra";
            this.estadisticoMuestra.ReadOnly = true;
            // 
            // cAcum
            // 
            this.cAcum.HeaderText = "C Acumulado";
            this.cAcum.Name = "cAcum";
            this.cAcum.ReadOnly = true;
            // 
            // bntPruebaBondad
            // 
            this.bntPruebaBondad.Location = new System.Drawing.Point(239, 75);
            this.bntPruebaBondad.Name = "bntPruebaBondad";
            this.bntPruebaBondad.Size = new System.Drawing.Size(103, 23);
            this.bntPruebaBondad.TabIndex = 4;
            this.bntPruebaBondad.Text = "Realizar prueba";
            this.bntPruebaBondad.UseVisualStyleBackColor = true;
            this.bntPruebaBondad.Click += new System.EventHandler(this.realizarPrueba);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tamaño de la serie (n):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de intervalos (k):";
            // 
            // dgvNros
            // 
            this.dgvNros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.nroAleatorio});
            this.dgvNros.Location = new System.Drawing.Point(605, 130);
            this.dgvNros.Name = "dgvNros";
            this.dgvNros.Size = new System.Drawing.Size(179, 548);
            this.dgvNros.TabIndex = 4;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "i";
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            // 
            // nroAleatorio
            // 
            this.nroAleatorio.HeaderText = "Nro. Aleatorio";
            this.nroAleatorio.Name = "nroAleatorio";
            this.nroAleatorio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Histograma de Frecuencias:";
            // 
            // histograma
            // 
            this.histograma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.histograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Hola";
            this.histograma.Legends.Add(legend1);
            this.histograma.Location = new System.Drawing.Point(12, 449);
            this.histograma.Name = "histograma";
            this.histograma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Hola";
            series1.Name = "Fo";
            series1.XValueMember = "Hola";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Hola";
            series2.Name = "Fe";
            this.histograma.Series.Add(series1);
            this.histograma.Series.Add(series2);
            this.histograma.Size = new System.Drawing.Size(576, 212);
            this.histograma.TabIndex = 7;
            this.histograma.Text = "chart1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Serie de numeros pseudo-aleatorios:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(345, 75);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(63, 32);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(49, 20);
            this.txtX0.TabIndex = 0;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(198, 32);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(49, 20);
            this.txtK.TabIndex = 2;
            this.txtK.TextChanged += new System.EventHandler(this.calcularA);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(63, 65);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(49, 20);
            this.txtC.TabIndex = 1;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(198, 65);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(49, 20);
            this.txtG.TabIndex = 3;
            this.txtG.TextChanged += new System.EventHandler(this.calcularM);
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(254, 32);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(38, 20);
            this.txtA.TabIndex = 24;
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(254, 65);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(38, 20);
            this.txtM.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X0:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "K:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "C:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "G:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Seleccionar el método";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Items.AddRange(new object[] {
            "Mixto (Congruencial lineal)",
            "Propio del lenguaje"});
            this.cmbMetodo.Location = new System.Drawing.Point(148, 9);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(161, 21);
            this.cmbMetodo.TabIndex = 0;
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.validarMetodo);
            // 
            // gbGenerador
            // 
            this.gbGenerador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGenerador.Controls.Add(this.label8);
            this.gbGenerador.Controls.Add(this.txtX0);
            this.gbGenerador.Controls.Add(this.label7);
            this.gbGenerador.Controls.Add(this.txtK);
            this.gbGenerador.Controls.Add(this.label6);
            this.gbGenerador.Controls.Add(this.txtC);
            this.gbGenerador.Controls.Add(this.label5);
            this.gbGenerador.Controls.Add(this.txtG);
            this.gbGenerador.Controls.Add(this.txtM);
            this.gbGenerador.Controls.Add(this.txtA);
            this.gbGenerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenerador.Location = new System.Drawing.Point(456, 9);
            this.gbGenerador.Name = "gbGenerador";
            this.gbGenerador.Size = new System.Drawing.Size(328, 102);
            this.gbGenerador.TabIndex = 3;
            this.gbGenerador.TabStop = false;
            this.gbGenerador.Text = "Constantes";
            this.gbGenerador.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.Location = new System.Drawing.Point(11, 663);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 23);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // BondadAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(801, 690);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbGenerador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbMetodo);
            this.Controls.Add(this.histograma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.bntPruebaBondad);
            this.Controls.Add(this.dgvNros);
            this.Controls.Add(this.dgvBondad);
            this.Controls.Add(this.cmbK);
            this.Controls.Add(this.txtN);
            this.MinimumSize = new System.Drawing.Size(817, 729);
            this.Name = "BondadAjuste";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BondadAjuste";
            this.Load += new System.EventHandler(this.BondadAjuste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBondad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).EndInit();
            this.gbGenerador.ResumeLayout(false);
            this.gbGenerador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ComboBox cmbK;
        private System.Windows.Forms.DataGridView dgvBondad;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadisticoMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAcum;
        private System.Windows.Forms.Button bntPruebaBondad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart histograma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroAleatorio;
        private System.Windows.Forms.GroupBox gbGenerador;
        private System.Windows.Forms.Button btnVolver;
    }
}