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
    public partial class TablaChoferForm : TablaUsuarioForm
    {
        public TablaChoferForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        public TablaChoferForm()
        {
            InitializeComponent();
        }
        
        public override void Refrescar()
        {
            DataTable data = Chofer.getChoferes();
            DataGridViewUsuario.DataSource = data;
        }

        public override String tablaABuscar()
        {
            return "CHOFERES";
        }
    }
}
