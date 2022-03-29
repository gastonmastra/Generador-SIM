
namespace TP1_Generador_de_numeros_pseudoaleatoreos.Forms
{
    partial class Home
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
            this.lblHome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(112, 12);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(104, 39);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Inicio";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(58, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prueba de bondad de ajuste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.abrirPruebaBondad);
            // 
            // btnGenerador
            // 
            this.btnGenerador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGenerador.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerador.Location = new System.Drawing.Point(58, 117);
            this.btnGenerador.Name = "btnGenerador";
            this.btnGenerador.Size = new System.Drawing.Size(218, 48);
            this.btnGenerador.TabIndex = 2;
            this.btnGenerador.Text = "Generador de números pseudoaleatorios";
            this.btnGenerador.UseVisualStyleBackColor = false;
            this.btnGenerador.Click += new System.EventHandler(this.abrirGeneradorNros);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(348, 205);
            this.Controls.Add(this.btnGenerador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHome);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(364, 244);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerador;
    }
}