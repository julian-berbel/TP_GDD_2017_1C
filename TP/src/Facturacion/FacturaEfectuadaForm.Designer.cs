namespace UberFrba.Facturacion
{
    partial class FacturaEfectuadaForm
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
            this.labelFacturaNro = new System.Windows.Forms.Label();
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
            // labelFacturaNro
            // 
            this.labelFacturaNro.AutoSize = true;
            this.labelFacturaNro.Location = new System.Drawing.Point(16, 232);
            this.labelFacturaNro.Name = "labelFacturaNro";
            this.labelFacturaNro.Size = new System.Drawing.Size(69, 13);
            this.labelFacturaNro.TabIndex = 15;
            this.labelFacturaNro.Text = "Factura Nro: ";
            // 
            // FacturaEfectuadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 285);
            this.Controls.Add(this.labelFacturaNro);
            this.Controls.Add(this.buttonVolver);
            this.Name = "FacturaEfectuadaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Factura";
            this.Controls.SetChildIndex(this.buttonVolver, 0);
            this.Controls.SetChildIndex(this.labelFacturaNro, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label labelFacturaNro;
    }
}
