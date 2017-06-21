namespace UberFrba.Abm_Turno
{
    partial class SeleccionarTurnoForm
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(339, 199);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(114, 199);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 21;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // SeleccionarTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 234);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSeleccionar);
            this.Name = "SeleccionarTurnoForm";
            this.Text = "Seleccionar Turno";
            this.Controls.SetChildIndex(this.buttonSeleccionar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSeleccionar;
    }
}
