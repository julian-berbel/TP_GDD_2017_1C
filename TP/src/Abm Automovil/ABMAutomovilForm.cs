using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil
{
    public partial class ABMAutomovilForm : UberFrba.Abm_Automovil.TablaAutomovilForm
    {
        public ABMAutomovilForm()
        {
            InitializeComponent();
        }

        public ABMAutomovilForm(Form caller) : base(caller)
        {
            InitializeComponent();
        }
        
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditarAutomovilForm().ShowDialog();
            this.Mostrar();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditarAutomovilForm(DataGridViewAutomovil.SelectedRows[0].Cells).ShowDialog();
            this.Mostrar();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
