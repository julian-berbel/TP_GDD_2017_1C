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
    public partial class SeleccionarChoferForm : UberFrba.Abm_Chofer.TablaChoferForm
    {
        private Chofer choferSeleccionado;

        public SeleccionarChoferForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)DataGridViewUsuario.SelectedRows[0].DataBoundItem).Row;
            choferSeleccionado = new Chofer(fila);
            this.Close();
        }

        public Chofer getChofer()
        {
            abrir();
            return choferSeleccionado;
        }
    }
}
