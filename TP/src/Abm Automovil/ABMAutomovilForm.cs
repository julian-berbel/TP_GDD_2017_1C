using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Automovil {
  public partial class ABMAutomovilForm : ReturningForm {
    public ABMAutomovilForm(ReturningForm caller) : base(caller) {
      InitializeComponent();
      comboBoxMarca.Items.Add("");
      Automovil.getMarcas().ForEach(marca => comboBoxMarca.Items.Add(marca));
    }
    
    private void buttonNuevo_Click(object sender, EventArgs e) {
      new EditarAutomovilForm(this).abrir();
    }

    private void buttonEditar_Click(object sender, EventArgs e) {
      DataRow fila = ((DataRowView)dataGridViewAutomovil.SelectedRows[0].DataBoundItem).Row; // Obtengo fila seleccionada
      new EditarAutomovilForm(this, new Automovil(fila)).abrir(); // Construyo un Automovil de la fila y se lo paso a la ventada de edición
    }

    private void buttonVolver_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void buttonBaja_Click(object sender, EventArgs e) {
      Automovil.inhabilitar((int)dataGridViewAutomovil.SelectedRows[0].Cells["vehi_id"].Value); // Obtengo el id del vehiculo seleccionado y lo inhabilito
      CargarTabla();
    }

    public int DNIChofer {
      get {
        if (string.IsNullOrWhiteSpace(textBoxDNIChofer.Text)) return 0;
        return int.Parse(textBoxDNIChofer.Text);
      }
    }
    public string Modelo {
      get {
        return textBoxModelo.Text;
      }
    }
    public string Patente {
      get {
        return textBoxPatente.Text;
      }
    }
    public string Marca {
      get {
        if (string.IsNullOrWhiteSpace((string)comboBoxMarca.SelectedItem)) return "";
        return (String)comboBoxMarca.SelectedItem;
      }
    }

    public override void Refrescar() {
      CargarTabla();
      dataGridViewAutomovil.Columns["vehi_chofer"].Visible = false;   // oculto columnas que no quiero mostrar
      dataGridViewAutomovil.Columns["vehi_id"].Visible = false;
      dataGridViewAutomovil.Columns["vehi_turno"].Visible = false;
    }

    protected void CargarTabla() {
      dataGridViewAutomovil.DataSource = Automovil.getAutomovilesConFiltro( DNIChofer,  // cargo la tabla con los automoviles que cumplen los filtros dados
                                                                            Modelo,
                                                                            Patente,
                                                                            Marca);
    }

    private void buttonFiltrar_Click(object sender, EventArgs e) {
      try {
        validar();        // valido los datos ingresados
        CargarTabla();
      }
      catch (Exception ex) {
        if (ex is FormatException ||
            ex is ValorNegativoException) Error.show(ex.Message);
        else throw;
      }
    }

    private void buttonLimpiar_Click(object sender, EventArgs e) {
      textBoxDNIChofer.Text = "";     // borro los contenidos de los campos de filtros
      textBoxModelo.Text = "";
      textBoxPatente.Text = "";
      comboBoxMarca.SelectedItem = "";
      CargarTabla();            // cargo la tabla de nuevo
    }

    private void validar() {
      if (DNIChofer < 0) throw new ValorNegativoException("DNI Chofer");
    }
  }
}
