namespace UberFrba.Abm_Rol
{
    partial class TablaRolForm
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
            this.dataGridViewRol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRol
            // 
            this.dataGridViewRol.AllowUserToAddRows = false;
            this.dataGridViewRol.AllowUserToDeleteRows = false;
            this.dataGridViewRol.AllowUserToResizeRows = false;
            this.dataGridViewRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRol.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewRol.MultiSelect = false;
            this.dataGridViewRol.Name = "dataGridViewRol";
            this.dataGridViewRol.ReadOnly = true;
            this.dataGridViewRol.RowHeadersVisible = false;
            this.dataGridViewRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRol.Size = new System.Drawing.Size(501, 180);
            this.dataGridViewRol.TabIndex = 9;
            // 
            // TablaRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 231);
            this.Controls.Add(this.dataGridViewRol);
            this.Name = "TablaRolForm";
            this.Text = "TablaRolForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRol;
    }
}