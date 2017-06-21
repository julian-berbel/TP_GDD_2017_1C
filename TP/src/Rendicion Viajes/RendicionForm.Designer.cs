namespace UberFrba.Rendicion_Viajes
{
    partial class RendicionForm
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
            this.buttonSeleccionarChofer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxChofer = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonEfectuar = new System.Windows.Forms.Button();
            this.comboBoxTurnos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSeleccionarChofer
            // 
            this.buttonSeleccionarChofer.Location = new System.Drawing.Point(166, 24);
            this.buttonSeleccionarChofer.Name = "buttonSeleccionarChofer";
            this.buttonSeleccionarChofer.Size = new System.Drawing.Size(31, 20);
            this.buttonSeleccionarChofer.TabIndex = 40;
            this.buttonSeleccionarChofer.Text = "...";
            this.buttonSeleccionarChofer.UseVisualStyleBackColor = true;
            this.buttonSeleccionarChofer.Click += new System.EventHandler(this.buttonSeleccionarChofer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Chofer";
            // 
            // textBoxChofer
            // 
            this.textBoxChofer.Location = new System.Drawing.Point(33, 25);
            this.textBoxChofer.Name = "textBoxChofer";
            this.textBoxChofer.ReadOnly = true;
            this.textBoxChofer.Size = new System.Drawing.Size(127, 20);
            this.textBoxChofer.TabIndex = 38;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "MMMM,yyyy";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(33, 64);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
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
            this.buttonVolver.Location = new System.Drawing.Point(127, 141);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 44;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonEfectuar
            // 
            this.buttonEfectuar.Location = new System.Drawing.Point(28, 141);
            this.buttonEfectuar.Name = "buttonEfectuar";
            this.buttonEfectuar.Size = new System.Drawing.Size(75, 23);
            this.buttonEfectuar.TabIndex = 43;
            this.buttonEfectuar.Text = "Efectuar";
            this.buttonEfectuar.UseVisualStyleBackColor = true;
            this.buttonEfectuar.Click += new System.EventHandler(this.buttonEfectuar_Click);
            // 
            // comboBoxTurnos
            // 
            this.comboBoxTurnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurnos.FormattingEnabled = true;
            this.comboBoxTurnos.Location = new System.Drawing.Point(33, 103);
            this.comboBoxTurnos.Name = "comboBoxTurnos";
            this.comboBoxTurnos.Size = new System.Drawing.Size(127, 21);
            this.comboBoxTurnos.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Turno";
            // 
            // RendicionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 178);
            this.Controls.Add(this.comboBoxTurnos);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonEfectuar);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.buttonSeleccionarChofer);
            this.Controls.Add(this.textBoxChofer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "RendicionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeleccionarChofer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxChofer;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonEfectuar;
        private System.Windows.Forms.ComboBox comboBoxTurnos;
        private System.Windows.Forms.Label label1;
    }
}