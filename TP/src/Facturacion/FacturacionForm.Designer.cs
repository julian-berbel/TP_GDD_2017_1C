namespace UberFrba.Facturacion
{
    partial class FacturacionForm
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
            this.buttonSeleccionarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonFacturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSeleccionarCliente
            // 
            this.buttonSeleccionarCliente.Location = new System.Drawing.Point(166, 24);
            this.buttonSeleccionarCliente.Name = "buttonSeleccionarCliente";
            this.buttonSeleccionarCliente.Size = new System.Drawing.Size(31, 20);
            this.buttonSeleccionarCliente.TabIndex = 40;
            this.buttonSeleccionarCliente.Text = "...";
            this.buttonSeleccionarCliente.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCliente.Click += new System.EventHandler(this.buttonSeleccionarCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Cliente";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(33, 25);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(127, 20);
            this.textBoxCliente.TabIndex = 38;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "MMMM,yyyy";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(33, 64);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.ShowUpDown = true;
            this.dateTimePickerFecha.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerFecha.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mes y Año";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(127, 97);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 44;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonFacturar
            // 
            this.buttonFacturar.Location = new System.Drawing.Point(28, 97);
            this.buttonFacturar.Name = "buttonFacturar";
            this.buttonFacturar.Size = new System.Drawing.Size(75, 23);
            this.buttonFacturar.TabIndex = 43;
            this.buttonFacturar.Text = "Facturar";
            this.buttonFacturar.UseVisualStyleBackColor = true;
            this.buttonFacturar.Click += new System.EventHandler(this.buttonFacturar_Click);
            // 
            // FacturacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 132);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonFacturar);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSeleccionarCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCliente);
            this.MaximizeBox = false;
            this.Name = "FacturacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeleccionarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonFacturar;
    }
}