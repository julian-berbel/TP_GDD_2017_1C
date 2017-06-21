namespace UberFrba.Rendicion_Viajes
{
    partial class RendicionEfectuadaForm
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.labelRendicionNro = new System.Windows.Forms.Label();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(227, 250);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 14;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // labelRendicionNro
            // 
            this.labelRendicionNro.AutoSize = true;
            this.labelRendicionNro.Location = new System.Drawing.Point(16, 232);
            this.labelRendicionNro.Name = "labelRendicionNro";
            this.labelRendicionNro.Size = new System.Drawing.Size(81, 13);
            this.labelRendicionNro.TabIndex = 15;
            this.labelRendicionNro.Text = "Rendicion Nro: ";
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.Location = new System.Drawing.Point(411, 253);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(106, 23);
            this.labelPorcentaje.TabIndex = 16;
            this.labelPorcentaje.Text = "Porcentaje: ";
            this.labelPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RendicionEfectuadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 285);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.labelPorcentaje);
            this.Controls.Add(this.labelRendicionNro);
            this.Name = "RendicionEfectuadaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Rendicion";
            this.Controls.SetChildIndex(this.labelRendicionNro, 0);
            this.Controls.SetChildIndex(this.labelPorcentaje, 0);
            this.Controls.SetChildIndex(this.buttonVolver, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label labelRendicionNro;
        private System.Windows.Forms.Label labelPorcentaje;
    }
}
