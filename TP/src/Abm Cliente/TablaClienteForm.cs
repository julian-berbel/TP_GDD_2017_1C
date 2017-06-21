using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;
using UberFrba.Usuarios;

namespace UberFrba.Abm_Cliente
{
    public partial class TablaClienteForm : TablaUsuarioForm
    {
        public TablaClienteForm(ReturningForm caller) : base(caller)
        {
            _usuariosABuscar = "CLIENTES";
            InitializeComponent();
        }

        public TablaClienteForm()
        {
            InitializeComponent();
        }

        public override void Refrescar()
        {
            base.Refrescar();
            DataGridViewUsuario.Columns["Usuario_Habilitado"].Visible = false;
            DataGridViewUsuario.Columns["Cliente_Habilitado"].HeaderText = "Habilitado";
        }
    }
}
