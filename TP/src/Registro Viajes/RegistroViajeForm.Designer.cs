namespace UberFrba.Registro_Viajes
{
    partial class RegistroViajeForm
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
            this.dateTimePickerFechaHoraFin = new System.Windows.Forms.DateTimePicker();
            this.buttonSeleccionarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSeleccionarChofer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCantidadKms = new System.Windows.Forms.TextBox();
            this.textBoxTurno = new System.Windows.Forms.TextBox();
            this.textBoxAutomovil = new System.Windows.Forms.TextBox();
            this.textBoxChofer = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePickerFechaHoraFin
            // 
            this.dateTimePickerFechaHoraFin.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePickerFechaHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaHoraFin.Location = new System.Drawing.Point(36, 219);
            this.dateTimePickerFechaHoraFin.Name = "dateTimePickerFechaHoraFin";
            this.dateTimePickerFechaHoraFin.ShowUpDown = true;
            this.dateTimePickerFechaHoraFin.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerFechaHoraFin.TabIndex = 38;
            this.dateTimePickerFechaHoraFin.ValueChanged += new System.EventHandler(this.dateTimePickerFechaHoraFin_ValueChanged);
            // 
            // buttonSeleccionarCliente
            // 
            this.buttonSeleccionarCliente.Location = new System.Drawing.Point(169, 257);
            this.buttonSeleccionarCliente.Name = "buttonSeleccionarCliente";
            this.buttonSeleccionarCliente.Size = new System.Drawing.Size(31, 20);
            this.buttonSeleccionarCliente.TabIndex = 37;
            this.buttonSeleccionarCliente.Text = "...";
            this.buttonSeleccionarCliente.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCliente.Click += new System.EventHandler(this.buttonSeleccionarCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Cliente";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(36, 258);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(127, 20);
            this.textBoxCliente.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha y Hora Fin";
            // 
            // buttonSeleccionarChofer
            // 
            this.buttonSeleccionarChofer.Location = new System.Drawing.Point(169, 24);
            this.buttonSeleccionarChofer.Name = "buttonSeleccionarChofer";
            this.buttonSeleccionarChofer.Size = new System.Drawing.Size(31, 20);
            this.buttonSeleccionarChofer.TabIndex = 32;
            this.buttonSeleccionarChofer.Text = "...";
            this.buttonSeleccionarChofer.UseVisualStyleBackColor = true;
            this.buttonSeleccionarChofer.Click += new System.EventHandler(this.buttonSeleccionarChofer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha y Hora Inicio";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(127, 296);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 28;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cantidad de Kms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Automovil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Chofer";
            // 
            // textBoxCantidadKms
            // 
            this.textBoxCantidadKms.Location = new System.Drawing.Point(36, 141);
            this.textBoxCantidadKms.Name = "textBoxCantidadKms";
            this.textBoxCantidadKms.Size = new System.Drawing.Size(127, 20);
            this.textBoxCantidadKms.TabIndex = 23;
            // 
            // textBoxTurno
            // 
            this.textBoxTurno.Location = new System.Drawing.Point(36, 102);
            this.textBoxTurno.Name = "textBoxTurno";
            this.textBoxTurno.ReadOnly = true;
            this.textBoxTurno.Size = new System.Drawing.Size(127, 20);
            this.textBoxTurno.TabIndex = 22;
            // 
            // textBoxAutomovil
            // 
            this.textBoxAutomovil.Location = new System.Drawing.Point(36, 63);
            this.textBoxAutomovil.Name = "textBoxAutomovil";
            this.textBoxAutomovil.ReadOnly = true;
            this.textBoxAutomovil.Size = new System.Drawing.Size(127, 20);
            this.textBoxAutomovil.TabIndex = 21;
            // 
            // textBoxChofer
            // 
            this.textBoxChofer.Location = new System.Drawing.Point(36, 24);
            this.textBoxChofer.Name = "textBoxChofer";
            this.textBoxChofer.ReadOnly = true;
            this.textBoxChofer.Size = new System.Drawing.Size(127, 20);
            this.textBoxChofer.TabIndex = 20;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(28, 296);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 19;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // dateTimePickerFechaHoraInicio
            // 
            this.dateTimePickerFechaHoraInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePickerFechaHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaHoraInicio.Location = new System.Drawing.Point(36, 180);
            this.dateTimePickerFechaHoraInicio.Name = "dateTimePickerFechaHoraInicio";
            this.dateTimePickerFechaHoraInicio.ShowUpDown = true;
            this.dateTimePickerFechaHoraInicio.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerFechaHoraInicio.TabIndex = 39;
            this.dateTimePickerFechaHoraInicio.ValueChanged += new System.EventHandler(this.dateTimePickerFechaHoraInicio_ValueChanged);
            // 
            // RegistroViajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 333);
            this.Controls.Add(this.dateTimePickerFechaHoraInicio);
            this.Controls.Add(this.dateTimePickerFechaHoraFin);
            this.Controls.Add(this.buttonSeleccionarCliente);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.buttonSeleccionarChofer);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxCantidadKms);
            this.Controls.Add(this.textBoxTurno);
            this.Controls.Add(this.textBoxAutomovil);
            this.Controls.Add(this.textBoxChofer);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RegistroViajeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeleccionarChofer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCantidadKms;
        private System.Windows.Forms.TextBox textBoxTurno;
        private System.Windows.Forms.TextBox textBoxAutomovil;
        private System.Windows.Forms.TextBox textBoxChofer;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSeleccionarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHoraFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHoraInicio;
    }
}