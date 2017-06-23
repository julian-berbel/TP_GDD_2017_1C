using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Usuarios
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
            DataRow fila = ((DataRowView)DataGridViewUsuario.SelectedRows[0].DataBoundItem).Row;    // obtengo la fila seleccionada
            usuarioSeleccionado = new Usuario(fila);                                                // creo un usuario de la fila
            this.Close();
        }
        
        public Usuario getNoCliente()
        {
            _usuariosABuscar = "NO_CLIENTES";   // seteo el tipo de usuario a buscar
            abrir();
            return usuarioSeleccionado;         // devuelvo el usuario seleccionado
        }

        public Usuario getNoChofer()
        {
            _usuariosABuscar = "NO_CHOFERES";   // seteo el tipo de usuario a buscar
            abrir();
            return usuarioSeleccionado;         // devuelvo el usuario seleccionado
        }
    }
}
