namespace UberFrba.Abm_Turno
{
    partial class ABMTurnoForm
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
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(297, 199);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(75, 23);
            this.buttonBaja.TabIndex = 30;
            this.buttonBaja.Text = "Baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(156, 199);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 29;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(438, 199);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 28;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(15, 199);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 27;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // ABMTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 234);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonNuevo);
            this.Name = "ABMTurnoForm";
            this.Controls.SetChildIndex(this.buttonNuevo, 0);
            this.Controls.SetChildIndex(this.buttonVolver, 0);
            this.Controls.SetChildIndex(this.buttonEditar, 0);
            this.Controls.SetChildIndex(this.buttonBaja, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonNuevo;
    }
}
