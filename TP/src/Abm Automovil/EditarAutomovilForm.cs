using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_Chofer;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Automovil {
  public partial class EditarAutomovilForm : ReturningForm {
    private Boolean edicion = false;
    private Automovil autoAEditar = null;

    private Chofer chofer;

    internal Chofer Chofer {
      get {
        return chofer;
      }

      set {
        chofer = value;
        textBoxChofer.Text = chofer.apellido + ", " + chofer.nombre;
      }
    }

    public string Patente {
      get {
        return textBoxPatente.Text;
      }

      set {
        textBoxPatente.Text = value;
      }
    }

    public string Licencia {
      get {
        return textBoxLicencia.Text;
      }

      set {
        textBoxLicencia.Text = value.ToString();
      }
    }

    public string Rodado {
      get {
        return textBoxRodado.Text;
      }

      set {
        textBoxRodado.Text = value;
      }
    }

    public string Modelo {
      get {
        return textBoxModelo.Text;
      }

      set {
        textBoxModelo.Text = value;
      }
    }

    public string Marca {
      get {
        return (String) comboBoxMarca.SelectedItem;
      }

      set {
        comboBoxMarca.SelectedItem = value;
      }
    }

    public Turno Turno {
      get {
        return (Turno)comboBoxTurno.SelectedItem;
      }

      set {
        comboBoxTurno.Text = value.ToString();
      }
    }

    public Boolean Habilitado {
      get {
        return (Boolean)checkBoxHabilitado.Checked;
      }

      set {
        checkBoxHabilitado.Checked = value;
      }
    }

    public EditarAutomovilForm(ReturningForm caller) : base(caller) {
      edicion = false;
      autoAEditar = new Automovil();
      InitializeComponent();
      Automovil.getMarcas().ForEach(marca => comboBoxMarca.Items.Add(marca)); // cargo el combobox de marcas
      Turno.getListaTurnos().ForEach(turno => comboBoxTurno.Items.Add(turno));// cargo el combobox de turnos
    }

    public EditarAutomovilForm(ReturningForm caller, Automovil autoAEditar) : base(caller) {
      edicion = true;
      this.autoAEditar = autoAEditar;
      InitializeComponent();

      Automovil.getMarcas().ForEach(marca => comboBoxMarca.Items.Add(marca)); // cargo el combobox de marcas
      Turno.getListaTurnos().ForEach(turno => comboBoxTurno.Items.Add(turno));// cargo el combobox de turnos
      Chofer = autoAEditar.chofer;                      // cargo los campos con los datos del auto
      Patente = autoAEditar.patente;
      Licencia = autoAEditar.licencia;
      Rodado = autoAEditar.rodado;
      Modelo = autoAEditar.modelo;
      Marca = autoAEditar.marca;
      Turno = autoAEditar.turno;
      Habilitado = autoAEditar.habilitado;
    }

    private void buttonAceptar_Click(object sender, EventArgs e) {
      try {
        validar();                // valido los datos ingresados
        autoAEditar.chofer = Chofer;      // modifico el automovil
        autoAEditar.patente = Patente;
        autoAEditar.licencia = Licencia;
        autoAEditar.rodado = Rodado;
        autoAEditar.modelo = Modelo;
        autoAEditar.marca = Marca;
        autoAEditar.turno = Turno;
        autoAEditar.habilitado = Habilitado;

        if (edicion) {
          autoAEditar.editar();         // Persisto los cambios
        }
        else {
          autoAEditar.nuevo();        // Persisto el nuevo automovil
        }
        this.Close();
      }
      catch (SqlException) { }
      catch (CampoVacioException exception) {
        Error.show(exception.Message);
      }
    }

    private void validar() { // Valido los datos ingresados
      if (Chofer == null) throw new CampoVacioException("Chofer");
      if (string.IsNullOrWhiteSpace(Patente)) throw new CampoVacioException("Patente");
      if (string.IsNullOrWhiteSpace(Licencia)) throw new CampoVacioException("Licencia");
      if (string.IsNullOrWhiteSpace(Rodado)) throw new CampoVacioException("Rodado");
      if (string.IsNullOrWhiteSpace(Modelo)) throw new CampoVacioException("Modelo");
      if (string.IsNullOrWhiteSpace(Marca)) throw new CampoVacioException("Marca");
  }

    private void buttonCancelar_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void buttonSeleccionarChofer_Click(object sender, EventArgs e) {
      Chofer seleccionado = new SeleccionarChoferForm(this).getChofer();  // Selecciono un chofer
      if (seleccionado != null) Chofer = seleccionado;          // Si es null (porque apretaron el botón cancelar) no hago nada, sino, me lo quedo
    }
  }
}
