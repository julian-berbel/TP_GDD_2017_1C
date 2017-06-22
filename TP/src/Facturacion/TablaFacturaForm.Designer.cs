namespace UberFrba.Facturacion
{
    partial class TablaFacturaForm
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
            this.dataGridViewFactura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.AllowUserToAddRows = false;
            this.dataGridViewFactura.AllowUserToDeleteRows = false;
            this.dataGridViewFactura.AllowUserToResizeRows = false;
            this.dataGridViewFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Location = new System.Drawing.Point(15, 49);
            this.dataGridViewFactura.MultiSelect = false;
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.ReadOnly = true;
            this.dataGridViewFactura.RowHeadersVisible = false;
            this.dataGridViewFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFactura.Size = new System.Drawing.Size(501, 180);
            this.dataGridViewFactura.TabIndex = 9;
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
            this.labelCliente.Size = new System.Drawing.Size(45, 13);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente: ";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.Location = new System.Drawing.Point(200, 9);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(316, 13);
            this.labelFechaInicio.TabIndex = 12;
            this.labelFechaInicio.Text = "Fecha Inicio: ";
            this.labelFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.Location = new System.Drawing.Point(189, 33);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(328, 13);
            this.labelFechaFin.TabIndex = 13;
            this.labelFechaFin.Text = "Fecha Fin: ";
            this.labelFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TablaFacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 285);
            this.Controls.Add(this.dataGridViewFactura);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Name = "TablaFacturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaFacturaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
    }
}