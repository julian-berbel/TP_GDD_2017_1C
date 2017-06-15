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
            DataTable tabla = (DataTable)DataGridViewChofer.DataSource;
            new EditarChoferForm(new Chofer(tabla.Rows[0]));
        }
    }
}
