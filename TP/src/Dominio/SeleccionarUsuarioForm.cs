using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UberFrba.Dominio
{
    public partial class SeleccionarUsuarioForm : TablaUsuarioForm
    {
        private Usuario usuarioSeleccionado;

        public SeleccionarUsuarioForm(ReturningForm caller) : base(caller)
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
            usuarioSeleccionado = new Usuario(fila);
            this.Close();
        }
        
        public Usuario getNoCliente()
        {
            _usuariosABuscar = "NO_CLIENTES";
            abrir();
            return usuarioSeleccionado;
        }

        public Usuario getNoChofer()
        {
            _usuariosABuscar = "NO_CHOFERES";
            abrir();
            return usuarioSeleccionado;
        }
    }
}
