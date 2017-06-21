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
    public partial class SeleccionarClienteForm : UberFrba.Abm_Cliente.TablaClienteForm
    {
        private Cliente clienteSeleccionado;

        public SeleccionarClienteForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)DataGridViewUsuario.SelectedRows[0].DataBoundItem).Row;

            if (!(Boolean)fila["Habilitado"])
            {
                Error.show("No se puede seleccionar un cliente inhabilitado!");
                return;
            }

            clienteSeleccionado = new Cliente(fila);
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Cliente getCliente()
        {
            abrir();
            return clienteSeleccionado;
        }
    }
}
