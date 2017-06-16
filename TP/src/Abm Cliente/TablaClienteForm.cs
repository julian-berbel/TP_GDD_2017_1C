using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Cliente
{
    public partial class TablaClienteForm : UberFrba.Dominio.TablaUsuarioForm
    {
        public TablaClienteForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        public TablaClienteForm()
        {
            InitializeComponent();
        }

        public override void Refrescar()
        {
            CargarTabla();
        }

        public override String tablaABuscar()
        {
            return "CLIENTES";
        }
    }
}
