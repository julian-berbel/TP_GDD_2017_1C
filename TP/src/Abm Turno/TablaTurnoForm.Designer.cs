namespace UberFrba.Abm_Turno
{
    partial class TablaTurnoForm
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
            this.dataGridViewTurno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTurno
            // 
            this.dataGridViewTurno.AllowUserToAddRows = false;
            this.dataGridViewTurno.AllowUserToDeleteRows = false;
            this.dataGridViewTurno.AllowUserToResizeRows = false;
            this.dataGridViewTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurno.Location = new System.Drawing.Point(14, 12);
            this.dataGridViewTurno.MultiSelect = false;
            this.dataGridViewTurno.Name = "dataGridViewTurno";
            this.dataGridViewTurno.ReadOnly = true;
            this.dataGridViewTurno.RowHeadersVisible = false;
            this.dataGridViewTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTurno.Size = new System.Drawing.Size(501, 180);
            this.dataGridViewTurno.TabIndex = 9;
            // 
            // TablaTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 234);
            this.Controls.Add(this.dataGridViewTurno);
            this.Name = "TablaTurnoForm";
            this.Text = "TablaTurnoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTurno;
    }
}