using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Turno {
  public partial class ABMTurnoForm : ReturningForm {
    public ABMTurnoForm(ReturningForm caller) : base(caller) {
      InitializeComponent();
    }

    internal String Descripcion {
      get {
        return textBoxDescripcion.Text;
      }
    }

    private void buttonNuevo_Click(object sender, EventArgs e) {
      new EditarTurnoForm(this).abrir();
    }

    private void buttonEditar_Click(object sender, EventArgs e) {
      DataRow fila = ((DataRowView)dataGridViewTurno.SelectedRows[0].DataBoundItem).Row;  // obtengo fila seleccionada
      new EditarTurnoForm(this, new Turno(fila)).abrir();                 // creo turno a partir de la fila y se lo paso a la ventana de edicion
    }

    private void buttonVolver_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void buttonBaja_Click(object sender, EventArgs e) {
      Turno.inhabilitar((byte)dataGridViewTurno.SelectedRows[0].Cells["turn_id"].Value);  // obtengo id del turno seleccionado y lo inhabilito
      CargarTabla();
    }

    public override void Refrescar() {
      CargarTabla();
      dataGridViewTurno.Columns["turn_id"].Visible = false;                 // oculto columna que no quiero mostrar
    }

    protected void CargarTabla() {
       dataGridViewTurno.DataSource = Turno.getTurnosConFiltros(Descripcion);
    }

    private void buttonFiltrar_Click(object sender, EventArgs e) {
      CargarTabla();
    }

    private void buttonLimpiar_Click(object sender, EventArgs e) {
      textBoxDescripcion.Text = "";                             // borro los campos de filtros
      CargarTabla();                                    // cargo la tabla de nuevo
    }
  }
}
