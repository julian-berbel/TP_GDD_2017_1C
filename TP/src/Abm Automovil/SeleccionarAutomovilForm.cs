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
    public partial class SeleccionarAutomovilForm : UberFrba.Abm_Automovil.TablaAutomovilForm
    {
        public SeleccionarAutomovilForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
