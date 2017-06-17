using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Turno
{
    public partial class ABMTurnoForm : TablaTurnoForm
    {
        public ABMTurnoForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        public ABMTurnoForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            new EditarTurnoForm(this).abrir();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)DataGridViewTurno.SelectedRows[0].DataBoundItem).Row;
            new EditarTurnoForm(this, new Turno(fila)).abrir();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            Turno.inhabilitar((byte)DataGridViewTurno.SelectedRows[0].Cells["turn_id"].Value);
            CargarTabla();
        }
    }
}
