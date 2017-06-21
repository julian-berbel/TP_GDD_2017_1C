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
    public partial class ABMTurnoForm : ReturningForm
    {
        public ABMTurnoForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        internal String Descripcion
        {
            get
            {
                return textBoxDescripcion.Text;
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            new EditarTurnoForm(this).abrir();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)dataGridViewTurno.SelectedRows[0].DataBoundItem).Row;
            new EditarTurnoForm(this, new Turno(fila)).abrir();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            Turno.inhabilitar((byte)dataGridViewTurno.SelectedRows[0].Cells["turn_id"].Value);
            CargarTabla();
        }

        public override void Refrescar()
        {
            CargarTabla();
            dataGridViewTurno.Columns["turn_id"].Visible = false;
        }

        protected void CargarTabla()
        {
             dataGridViewTurno.DataSource = Turno.getTurnosConFiltros(Descripcion);
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDescripcion.Text = "";
            CargarTabla();
        }
    }
}
