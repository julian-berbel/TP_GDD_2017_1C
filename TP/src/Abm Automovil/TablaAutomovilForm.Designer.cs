namespace UberFrba.Abm_Automovil
{
    partial class TablaAutomovilForm
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
            this.dataGridViewAutomovil = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxPatente = new System.Windows.Forms.TextBox();
            this.textBoxChofer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomovil)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAutomovil
            // 
            this.dataGridViewAutomovil.AllowUserToAddRows = false;
            this.dataGridViewAutomovil.AllowUserToDeleteRows = false;
            this.dataGridViewAutomovil.AllowUserToResizeRows = false;
            this.dataGridViewAutomovil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAutomovil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutomovil.Location = new System.Drawing.Point(14, 68);
            this.dataGridViewAutomovil.MultiSelect = false;
            this.dataGridViewAutomovil.Name = "dataGridViewAutomovil";
            this.dataGridViewAutomovil.ReadOnly = true;
            this.dataGridViewAutomovil.RowHeadersVisible = false;
            this.dataGridViewAutomovil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAutomovil.Size = new System.Drawing.Size(501, 180);
            this.dataGridViewAutomovil.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Patente:";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(65, 34);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(150, 20);
            this.textBoxModelo.TabIndex = 13;
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(274, 6);
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(150, 20);
            this.textBoxPatente.TabIndex = 14;
            // 
            // textBoxChofer
            // 
            this.textBoxChofer.Location = new System.Drawing.Point(274, 34);
            this.textBoxChofer.Name = "textBoxChofer";
            this.textBoxChofer.Size = new System.Drawing.Size(150, 20);
            this.textBoxChofer.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chofer:";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(440, 5);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 17;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(65, 5);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(150, 21);
            this.comboBoxMarca.Sorted = true;
            this.comboBoxMarca.TabIndex = 18;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(440, 34);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 19;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // TablaAutomovilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 286);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.textBoxChofer);
            this.Controls.Add(this.textBoxPatente);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.dataGridViewAutomovil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TablaAutomovilForm";
            this.Text = "TablaAutomovilForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomovil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAutomovil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.TextBox textBoxChofer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}