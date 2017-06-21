namespace UberFrba.Rendicion_Viajes
{
    partial class RendicionNoEfectuadaForm
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
            this.buttonGenerarRendicion = new System.Windows.Forms.Button();
            this.numericUpDownPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(335, 262);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 14;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonGenerarRendicion
            // 
            this.buttonGenerarRendicion.Location = new System.Drawing.Point(118, 262);
            this.buttonGenerarRendicion.Name = "buttonGenerarRendicion";
            this.buttonGenerarRendicion.Size = new System.Drawing.Size(97, 23);
            this.buttonGenerarRendicion.TabIndex = 15;
            this.buttonGenerarRendicion.Text = "Generar";
            this.buttonGenerarRendicion.UseVisualStyleBackColor = true;
            this.buttonGenerarRendicion.Click += new System.EventHandler(this.buttonGenerarRendicion_Click);
            // 
            // numericUpDownPorcentaje
            // 
            this.numericUpDownPorcentaje.Location = new System.Drawing.Point(75, 232);
            this.numericUpDownPorcentaje.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownPorcentaje.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPorcentaje.Name = "numericUpDownPorcentaje";
            this.numericUpDownPorcentaje.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownPorcentaje.TabIndex = 16;
            this.numericUpDownPorcentaje.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownPorcentaje.ValueChanged += new System.EventHandler(this.numericUpDownPorcentaje_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Porcentaje:                 %";
            // 
            // RendicionNoEfectuadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 295);
            this.Controls.Add(this.numericUpDownPorcentaje);
            this.Controls.Add(this.buttonGenerarRendicion);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label2);
            this.Name = "RendicionNoEfectuadaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.buttonVolver, 0);
            this.Controls.SetChildIndex(this.buttonGenerarRendicion, 0);
            this.Controls.SetChildIndex(this.numericUpDownPorcentaje, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorcentaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonGenerarRendicion;
        private System.Windows.Forms.NumericUpDown numericUpDownPorcentaje;
        private System.Windows.Forms.Label label2;
    }
}
