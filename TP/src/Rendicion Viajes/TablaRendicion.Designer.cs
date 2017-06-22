namespace UberFrba.Rendicion_Viajes
{
    partial class TablaRendicionForm
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
            this.dataGridViewRendicion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelTurno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendicion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRendicion
            // 
            this.dataGridViewRendicion.AllowUserToAddRows = false;
            this.dataGridViewRendicion.AllowUserToDeleteRows = false;
            this.dataGridViewRendicion.AllowUserToResizeRows = false;
            this.dataGridViewRendicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRendicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRendicion.Location = new System.Drawing.Point(15, 49);
            this.dataGridViewRendicion.MultiSelect = false;
            this.dataGridViewRendicion.Name = "dataGridViewRendicion";
            this.dataGridViewRendicion.ReadOnly = true;
            this.dataGridViewRendicion.RowHeadersVisible = false;
            this.dataGridViewRendicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRendicion.Size = new System.Drawing.Size(501, 180);
            this.dataGridViewRendicion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Detalle:";
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(331, 232);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(186, 17);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total:";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(12, 9);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(44, 13);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Chofer: ";
            // 
            // labelFecha
            // 
            this.labelFecha.Location = new System.Drawing.Point(273, 9);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(243, 13);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha: ";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTurno
            // 
            this.labelTurno.Location = new System.Drawing.Point(270, 33);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(246, 13);
            this.labelTurno.TabIndex = 13;
            this.labelTurno.Text = "Turno: ";
            this.labelTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TablaRendicionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 285);
            this.Controls.Add(this.dataGridViewRendicion);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTurno);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Name = "TablaRendicionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaRendicionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRendicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelTurno;
    }
}