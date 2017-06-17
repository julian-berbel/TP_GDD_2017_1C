using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Rol
{
    public partial class ABMRolForm : TablaRolForm
    {
        public ABMRolForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        public ABMRolForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            new EditarRolForm(this).abrir();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)DataGridViewRol.SelectedRows[0].DataBoundItem).Row;
            new EditarRolForm(this, new Rol(fila)).abrir();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            Rol.inhabilitar((byte)DataGridViewRol.SelectedRows[0].Cells["rol_id"].Value);
            CargarTabla();
        }
    }
}
