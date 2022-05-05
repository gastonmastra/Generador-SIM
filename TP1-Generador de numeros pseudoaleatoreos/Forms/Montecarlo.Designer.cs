namespace TP1_Generador_de_numeros_pseudoaleatoreos.Forms
{
    partial class Montecarlo
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
            this.dgvPreventiva = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaPreventiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndPreventiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadAveriasPreventivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadRevisiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPromPreventivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCorrectiva = new System.Windows.Forms.DataGridView();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasParaAveria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDeAveria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadAverias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblEstrategia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.costoMensualPromPreventiva = new System.Windows.Forms.Label();
            this.costoMensualPromCorrectiva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrectiva)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreventiva
            // 
            this.dgvPreventiva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreventiva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreventiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreventiva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DiaPreventiva,
            this.rndPreventiva,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.cantidadAveriasPreventivo,
            this.cantidadRevisiones,
            this.costoPromPreventivo});
            this.dgvPreventiva.Location = new System.Drawing.Point(39, 314);
            this.dgvPreventiva.MultiSelect = false;
            this.dgvPreventiva.Name = "dgvPreventiva";
            this.dgvPreventiva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreventiva.Size = new System.Drawing.Size(748, 165);
            this.dgvPreventiva.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Reloj (Ciclo)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DiaPreventiva
            // 
            this.DiaPreventiva.HeaderText = "Dia";
            this.DiaPreventiva.Name = "DiaPreventiva";
            // 
            // rndPreventiva
            // 
            this.rndPreventiva.HeaderText = "Rnd";
            this.rndPreventiva.Name = "rndPreventiva";
            this.rndPreventiva.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Dias para Averia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dia en el que hay averia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Costo de reparación";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Costo de mantenimiento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Costo Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Costo Acumulado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // cantidadAveriasPreventivo
            // 
            this.cantidadAveriasPreventivo.HeaderText = "Cantidad Averias";
            this.cantidadAveriasPreventivo.Name = "cantidadAveriasPreventivo";
            // 
            // cantidadRevisiones
            // 
            this.cantidadRevisiones.HeaderText = "Cantidad Revisiones";
            this.cantidadRevisiones.Name = "cantidadRevisiones";
            // 
            // costoPromPreventivo
            // 
            this.costoPromPreventivo.HeaderText = "Costo Total dia 5";
            this.costoPromPreventivo.Name = "costoPromPreventivo";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tabla Estrategia Preventiva";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(712, 90);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.calcular);
            // 
            // txtKm
            // 
            this.txtKm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKm.Location = new System.Drawing.Point(386, 62);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(39, 20);
            this.txtKm.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Costo de mantenimiento";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Costo de reparación";
            // 
            // txtKo
            // 
            this.txtKo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKo.Location = new System.Drawing.Point(386, 23);
            this.txtKo.Name = "txtKo";
            this.txtKo.Size = new System.Drawing.Size(39, 20);
            this.txtKo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tabla Estrategia Correctiva";
            // 
            // dgvCorrectiva
            // 
            this.dgvCorrectiva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCorrectiva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCorrectiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrectiva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reloj,
            this.Dia,
            this.Rnd,
            this.DiasParaAveria,
            this.DiaDeAveria,
            this.CostoTotal,
            this.CostoAcumulado,
            this.cantidadAverias,
            this.costoProm});
            this.dgvCorrectiva.Location = new System.Drawing.Point(39, 119);
            this.dgvCorrectiva.MultiSelect = false;
            this.dgvCorrectiva.Name = "dgvCorrectiva";
            this.dgvCorrectiva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCorrectiva.Size = new System.Drawing.Size(748, 165);
            this.dgvCorrectiva.TabIndex = 18;
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj (Ciclo)";
            this.Reloj.Name = "Reloj";
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Rnd
            // 
            this.Rnd.HeaderText = "Rnd";
            this.Rnd.Name = "Rnd";
            this.Rnd.ReadOnly = true;
            // 
            // DiasParaAveria
            // 
            this.DiasParaAveria.HeaderText = "Dias para Averia";
            this.DiasParaAveria.Name = "DiasParaAveria";
            this.DiasParaAveria.ReadOnly = true;
            // 
            // DiaDeAveria
            // 
            this.DiaDeAveria.HeaderText = "Dia en el que hay averia";
            this.DiaDeAveria.Name = "DiaDeAveria";
            this.DiaDeAveria.ReadOnly = true;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            // 
            // CostoAcumulado
            // 
            this.CostoAcumulado.HeaderText = "Costo Acumulado";
            this.CostoAcumulado.Name = "CostoAcumulado";
            // 
            // cantidadAverias
            // 
            this.cantidadAverias.HeaderText = "Cantidad Averias";
            this.cantidadAverias.Name = "cantidadAverias";
            // 
            // costoProm
            // 
            this.costoProm.HeaderText = "Costo Total dia 5";
            this.costoProm.Name = "costoProm";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Desde";
            // 
            // txtDesde
            // 
            this.txtDesde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDesde.Location = new System.Drawing.Point(147, 59);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "N (cantidad de ciclos)";
            // 
            // txtN
            // 
            this.txtN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtN.Location = new System.Drawing.Point(147, 23);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 14;
            // 
            // lblEstrategia
            // 
            this.lblEstrategia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstrategia.AutoSize = true;
            this.lblEstrategia.Location = new System.Drawing.Point(39, 492);
            this.lblEstrategia.Name = "lblEstrategia";
            this.lblEstrategia.Size = new System.Drawing.Size(0, 13);
            this.lblEstrategia.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 29;
            // 
            // costoMensualPromPreventiva
            // 
            this.costoMensualPromPreventiva.AutoSize = true;
            this.costoMensualPromPreventiva.Location = new System.Drawing.Point(39, 524);
            this.costoMensualPromPreventiva.Name = "costoMensualPromPreventiva";
            this.costoMensualPromPreventiva.Size = new System.Drawing.Size(0, 13);
            this.costoMensualPromPreventiva.TabIndex = 30;
            // 
            // costoMensualPromCorrectiva
            // 
            this.costoMensualPromCorrectiva.AutoSize = true;
            this.costoMensualPromCorrectiva.Location = new System.Drawing.Point(39, 549);
            this.costoMensualPromCorrectiva.Name = "costoMensualPromCorrectiva";
            this.costoMensualPromCorrectiva.Size = new System.Drawing.Size(0, 13);
            this.costoMensualPromCorrectiva.TabIndex = 31;
            // 
            // Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 586);
            this.Controls.Add(this.costoMensualPromCorrectiva);
            this.Controls.Add(this.costoMensualPromPreventiva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEstrategia);
            this.Controls.Add(this.dgvPreventiva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCorrectiva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.MinimumSize = new System.Drawing.Size(853, 593);
            this.Name = "Montecarlo";
            this.Text = "Montecarlo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrectiva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreventiva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCorrectiva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblEstrategia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaPreventiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndPreventiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadAveriasPreventivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadRevisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPromPreventivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasParaAveria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDeAveria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadAverias;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoProm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label costoMensualPromPreventiva;
        private System.Windows.Forms.Label costoMensualPromCorrectiva;
    }
}