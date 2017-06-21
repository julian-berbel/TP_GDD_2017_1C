namespace UberFrba.Facturacion
{
    partial class FacturaNoEfectuadaForm
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
            this.buttonGenerarFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(335, 252);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 14;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonGenerarFactura
            // 
            this.buttonGenerarFactura.Location = new System.Drawing.Point(118, 252);
            this.buttonGenerarFactura.Name = "buttonGenerarFactura";
            this.buttonGenerarFactura.Size = new System.Drawing.Size(97, 23);
            this.buttonGenerarFactura.TabIndex = 15;
            this.buttonGenerarFactura.Text = "Generar Factura";
            this.buttonGenerarFactura.UseVisualStyleBackColor = true;
            this.buttonGenerarFactura.Click += new System.EventHandler(this.buttonGenerarFactura_Click);
            // 
            // FacturaNoEfectuadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 285);
            this.Controls.Add(this.buttonGenerarFactura);
            this.Controls.Add(this.buttonVolver);
            this.Name = "FacturaNoEfectuadaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.buttonVolver, 0);
            this.Controls.SetChildIndex(this.buttonGenerarFactura, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonGenerarFactura;
    }
}
