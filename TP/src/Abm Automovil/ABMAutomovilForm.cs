using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Automovil
{
    public partial class ABMAutomovilForm : UberFrba.Abm_Automovil.TablaAutomovilForm
    {
        public ABMAutomovilForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }
        
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            new EditarAutomovilForm(this).abrir();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)DataGridViewAutomovil.SelectedRows[0].DataBoundItem).Row;
            new EditarAutomovilForm(this, new Automovil(fila)).abrir();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            Automovil.inhabilitar((int)DataGridViewAutomovil.SelectedRows[0].Cells["vehi_id"].Value);
            CargarTabla();
        }
    }
}
