using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Cliente {
  public partial class ABMClienteForm : UberFrba.Abm_Cliente.TablaClienteForm {
    public ABMClienteForm(ReturningForm caller) : base(caller) {
      InitializeComponent();
    }

    private void buttonEditar_Click(object sender, EventArgs e) {
      DataRow fila = ((DataRowView)DataGridViewUsuario.SelectedRows[0].DataBoundItem).Row;  // Obtengo fila seleccionada
      new EditarClienteForm(this, new Cliente(fila)).abrir();                 // Construyo un cliente de la fila y se lo paso a la ventada de edición
    }

    private void buttonVolver_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void buttonNuevo_Click(object sender, EventArgs e) {
      new NuevoClienteForm(this).abrir();
    }

    private void buttonBaja_Click(object sender, EventArgs e) {
      Cliente.inhabilitar((int)DataGridViewUsuario.SelectedRows[0].Cells["usua_id"].Value);   // Obtengo el id del cliente seleccionado y lo inhabilito
      CargarTabla();
    }
  }
}
