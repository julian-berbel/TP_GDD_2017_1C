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
    public partial class ABMRolForm : ReturningForm
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
            DataRow fila = ((DataRowView)dataGridViewRol.SelectedRows[0].DataBoundItem).Row;
            new EditarRolForm(this, new Rol(fila)).abrir();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            Rol.inhabilitar((byte)dataGridViewRol.SelectedRows[0].Cells["rol_id"].Value);
            CargarTabla();
        }

        public override void Refrescar()
        {
            CargarTabla();
            dataGridViewRol.Columns["rol_id"].Visible = false;
        }

        protected void CargarTabla()
        {
            dataGridViewRol.DataSource = Rol.getRoles();
        }
    }
}
