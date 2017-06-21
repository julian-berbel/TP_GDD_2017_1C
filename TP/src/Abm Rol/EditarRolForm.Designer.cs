namespace UberFrba.Abm_Rol
{
    partial class EditarRolForm
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
            this.checkBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFuncionalidades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxHabilitado.Location = new System.Drawing.Point(98, 230);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(73, 17);
            this.checkBoxHabilitado.TabIndex = 31;
            this.checkBoxHabilitado.Text = "Habilitado";
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(146, 253);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(47, 253);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 17;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(31, 61);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescripcion.TabIndex = 35;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(31, 22);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // dataGridViewFuncionalidades
            // 
            this.dataGridViewFuncionalidades.AllowUserToAddRows = false;
            this.dataGridViewFuncionalidades.AllowUserToDeleteRows = false;
            this.dataGridViewFuncionalidades.AllowUserToResizeRows = false;
            this.dataGridViewFuncionalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionalidades.Location = new System.Drawing.Point(31, 87);
            this.dataGridViewFuncionalidades.MultiSelect = false;
            this.dataGridViewFuncionalidades.Name = "dataGridViewFuncionalidades";
            this.dataGridViewFuncionalidades.RowHeadersVisible = false;
            this.dataGridViewFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFuncionalidades.Size = new System.Drawing.Size(200, 137);
            this.dataGridViewFuncionalidades.TabIndex = 36;
            // 
            // EditarRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 288);
            this.Controls.Add(this.dataGridViewFuncionalidades);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxHabilitado);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "EditarRolForm";
            this.Text = "Editar Rol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxHabilitado;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewFuncionalidades;
    }
}