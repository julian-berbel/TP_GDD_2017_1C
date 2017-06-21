namespace UberFrba.Listado_Estadistico
{
    partial class ListadoEstadisticoForm
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
            this.dataGridViewEstadistica = new System.Windows.Forms.DataGridView();
            this.comboBoxEstadisticas = new System.Windows.Forms.ComboBox();
            this.numericUpDownTrimestre = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAnio = new System.Windows.Forms.NumericUpDown();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstadistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEstadistica
            // 
            this.dataGridViewEstadistica.AllowUserToAddRows = false;
            this.dataGridViewEstadistica.AllowUserToDeleteRows = false;
            this.dataGridViewEstadistica.AllowUserToResizeRows = false;
            this.dataGridViewEstadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstadistica.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewEstadistica.MultiSelect = false;
            this.dataGridViewEstadistica.Name = "dataGridViewEstadistica";
            this.dataGridViewEstadistica.ReadOnly = true;
            this.dataGridViewEstadistica.RowHeadersVisible = false;
            this.dataGridViewEstadistica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstadistica.Size = new System.Drawing.Size(501, 180);
            this.dataGridViewEstadistica.TabIndex = 20;
            // 
            // comboBoxEstadisticas
            // 
            this.comboBoxEstadisticas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadisticas.FormattingEnabled = true;
            this.comboBoxEstadisticas.Location = new System.Drawing.Point(12, 25);
            this.comboBoxEstadisticas.Name = "comboBoxEstadisticas";
            this.comboBoxEstadisticas.Size = new System.Drawing.Size(219, 21);
            this.comboBoxEstadisticas.TabIndex = 21;
            // 
            // numericUpDownTrimestre
            // 
            this.numericUpDownTrimestre.Location = new System.Drawing.Point(338, 25);
            this.numericUpDownTrimestre.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownTrimestre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTrimestre.Name = "numericUpDownTrimestre";
            this.numericUpDownTrimestre.ReadOnly = true;
            this.numericUpDownTrimestre.Size = new System.Drawing.Size(31, 20);
            this.numericUpDownTrimestre.TabIndex = 22;
            this.numericUpDownTrimestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownAnio
            // 
            this.numericUpDownAnio.Location = new System.Drawing.Point(237, 26);
            this.numericUpDownAnio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownAnio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAnio.Name = "numericUpDownAnio";
            this.numericUpDownAnio.ReadOnly = true;
            this.numericUpDownAnio.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownAnio.TabIndex = 23;
            this.numericUpDownAnio.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(404, 16);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 24;
            this.buttonCalcular.Text = "Calcular!";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Estadistica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Trimestre:";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(226, 238);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 28;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // ListadoEstadisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 271);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.numericUpDownAnio);
            this.Controls.Add(this.numericUpDownTrimestre);
            this.Controls.Add(this.comboBoxEstadisticas);
            this.Controls.Add(this.dataGridViewEstadistica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ListadoEstadisticoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoEstadisticoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstadistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEstadistica;
        private System.Windows.Forms.ComboBox comboBoxEstadisticas;
        private System.Windows.Forms.NumericUpDown numericUpDownTrimestre;
        private System.Windows.Forms.NumericUpDown numericUpDownAnio;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonVolver;
    }
}