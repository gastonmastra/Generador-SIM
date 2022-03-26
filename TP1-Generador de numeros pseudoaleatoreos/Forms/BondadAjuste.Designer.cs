
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBondad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.AcceptsReturn = true;
            this.txtN.Location = new System.Drawing.Point(151, 11);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(66, 20);
            this.txtN.TabIndex = 0;
            // 
            // cmbK
            // 
            this.cmbK.FormattingEnabled = true;
            this.cmbK.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12"});
            this.cmbK.Location = new System.Drawing.Point(151, 38);
            this.cmbK.Name = "cmbK";
            this.cmbK.Size = new System.Drawing.Size(66, 21);
            this.cmbK.TabIndex = 1;
            this.cmbK.SelectionChangeCommitted += new System.EventHandler(this.cmbK_SelectionChangeCommitted);
            // 
            // dgvBondad
            // 
            this.dgvBondad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBondad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBondad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.fo,
            this.fe,
            this.estadisticoMuestra,
            this.cAcum});
            this.dgvBondad.Location = new System.Drawing.Point(12, 65);
            this.dgvBondad.Name = "dgvBondad";
            this.dgvBondad.Size = new System.Drawing.Size(512, 146);
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
            this.bntPruebaBondad.Location = new System.Drawing.Point(223, 36);
            this.bntPruebaBondad.Name = "bntPruebaBondad";
            this.bntPruebaBondad.Size = new System.Drawing.Size(103, 23);
            this.bntPruebaBondad.TabIndex = 5;
            this.bntPruebaBondad.Text = "Realizar prueba";
            this.bntPruebaBondad.UseVisualStyleBackColor = true;
            this.bntPruebaBondad.Click += new System.EventHandler(this.realizarPrueba);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tamaño de la serie (n):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de intervalos (k):";
            // 
            // dgvNros
            // 
            this.dgvNros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvNros.Location = new System.Drawing.Point(541, 65);
            this.dgvNros.Name = "dgvNros";
            this.dgvNros.Size = new System.Drawing.Size(179, 373);
            this.dgvNros.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "i";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nro. Aleatorio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Histograma de Frecuencias:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 243);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(512, 195);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Serie de numeros pseudo-aleatorios:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(332, 36);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BondadAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.chart1);
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
            this.Name = "BondadAjuste";
            this.Text = "BondadAjuste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBondad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
    }
}