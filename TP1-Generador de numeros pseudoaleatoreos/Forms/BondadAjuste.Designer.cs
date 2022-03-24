
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.cmbK = new System.Windows.Forms.ComboBox();
            this.lblCantIntervalos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBondad = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadisticoMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntPruebaBondad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBondad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.AcceptsReturn = true;
            this.txtN.Location = new System.Drawing.Point(17, 37);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(121, 20);
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
            this.cmbK.Location = new System.Drawing.Point(17, 95);
            this.cmbK.Name = "cmbK";
            this.cmbK.Size = new System.Drawing.Size(121, 21);
            this.cmbK.TabIndex = 1;
            // 
            // lblCantIntervalos
            // 
            this.lblCantIntervalos.AutoSize = true;
            this.lblCantIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantIntervalos.Location = new System.Drawing.Point(12, 67);
            this.lblCantIntervalos.Name = "lblCantIntervalos";
            this.lblCantIntervalos.Size = new System.Drawing.Size(249, 25);
            this.lblCantIntervalos.TabIndex = 2;
            this.lblCantIntervalos.Text = "Cantidad de intervalos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tamaño de la serie";
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
            this.dgvBondad.Location = new System.Drawing.Point(12, 132);
            this.dgvBondad.Name = "dgvBondad";
            this.dgvBondad.Size = new System.Drawing.Size(776, 306);
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
            this.bntPruebaBondad.Location = new System.Drawing.Point(685, 93);
            this.bntPruebaBondad.Name = "bntPruebaBondad";
            this.bntPruebaBondad.Size = new System.Drawing.Size(103, 23);
            this.bntPruebaBondad.TabIndex = 5;
            this.bntPruebaBondad.Text = "Realizar prueba";
            this.bntPruebaBondad.UseVisualStyleBackColor = true;
            this.bntPruebaBondad.Click += new System.EventHandler(this.realizarPrueba);
            // 
            // BondadAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntPruebaBondad);
            this.Controls.Add(this.dgvBondad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantIntervalos);
            this.Controls.Add(this.cmbK);
            this.Controls.Add(this.txtN);
            this.Name = "BondadAjuste";
            this.Text = "BondadAjuste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBondad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ComboBox cmbK;
        private System.Windows.Forms.Label lblCantIntervalos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBondad;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadisticoMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAcum;
        private System.Windows.Forms.Button bntPruebaBondad;
    }
}