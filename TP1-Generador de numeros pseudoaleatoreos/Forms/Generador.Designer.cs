
namespace TP1_Generador_de_numeros_pseudoaleatoreos
{
    partial class Generador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generador));
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Items.AddRange(new object[] {
            "Mixto (Congruencial lineal)",
            "Multiplicativo"});
            this.cmbMetodo.Location = new System.Drawing.Point(15, 25);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodo.TabIndex = 0;
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.validarSeleccion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccionar el método";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "K:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X0:";
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(239, 6);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(38, 20);
            this.txtM.TabIndex = 10;
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(363, 6);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(38, 20);
            this.txtA.TabIndex = 12;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(301, 58);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar números";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.generarNumeros);
            // 
            // dgvTabla
            // 
            this.dgvTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.iCol2,
            this.nextX,
            this.iRnd});
            this.dgvTabla.Location = new System.Drawing.Point(20, 87);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(1326, 622);
            this.dgvTabla.TabIndex = 14;
            this.dgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
            // 
            // iteracion
            // 
            this.iteracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iteracion.HeaderText = "i";
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            this.iteracion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iteracion.Width = 34;
            // 
            // iCol2
            // 
            this.iCol2.HeaderText = "aXi+c";
            this.iCol2.Name = "iCol2";
            this.iCol2.ReadOnly = true;
            // 
            // nextX
            // 
            this.nextX.HeaderText = "Xi+1";
            this.nextX.Name = "nextX";
            this.nextX.ReadOnly = true;
            // 
            // iRnd
            // 
            this.iRnd.HeaderText = "RNDi";
            this.iRnd.Name = "iRnd";
            this.iRnd.ReadOnly = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(15, 58);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(121, 23);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente número";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.calcularSiguiente);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(183, 6);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(49, 20);
            this.txtG.TabIndex = 1;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(183, 32);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(49, 20);
            this.txtC.TabIndex = 2;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(301, 6);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(49, 20);
            this.txtK.TabIndex = 3;
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(301, 32);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(49, 20);
            this.txtX0.TabIndex = 4;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.Location = new System.Drawing.Point(20, 711);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Generador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMetodo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(428, 445);
            this.Name = "Generador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generador de números pseudo-aleatorios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextX;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRnd;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Button btnVolver;
    }
}

