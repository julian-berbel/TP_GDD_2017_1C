using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UberFrba.Abm_Chofer
{
    public partial class SeleccionarChoferForm : UberFrba.Abm_Chofer.TablaChoferForm
    {
        public SeleccionarChoferForm(Form caller) : base(caller)
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
