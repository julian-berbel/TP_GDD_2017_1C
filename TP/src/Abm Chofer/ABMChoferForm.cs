using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Chofer
{
    public partial class ABMChoferForm : UberFrba.Abm_Chofer.TablaChoferForm
    {
        public ABMChoferForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)DataGridViewUsuario.SelectedRows[0].DataBoundItem).Row;
            new EditarChoferForm(this, new Chofer(fila)).abrir();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            new NuevoChoferForm(this).abrir();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            Chofer.inhabilitar((int)DataGridViewUsuario.SelectedRows[0].Cells["usua_id"].Value);
            CargarTabla();
        }
    }
}
