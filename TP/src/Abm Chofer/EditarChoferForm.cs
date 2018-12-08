using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Chofer {
  public partial class EditarChoferForm : ReturningForm {
    public EditarChoferForm(ReturningForm caller, Chofer choferAEditar) : base(caller) {
      this.choferAEditar = choferAEditar;
      InitializeComponent();

      Nombre = choferAEditar.nombre;    // cargo los campos con los datos del chofer
      Apellido = choferAEditar.apellido;
      DNI = choferAEditar.dni;
      Domicilio = choferAEditar.domicilio;
      Telefono = choferAEditar.telefono;
      Mail = choferAEditar.mail;
      FechaNac = choferAEditar.fechaNac;
      Habilitado = choferAEditar.habilitado;
    }
    
    private Chofer choferAEditar = null;

    public string Nombre {
      get {
        return textBoxNombre.Text;
      }

      set {
        textBoxNombre.Text = value;
      }
    }

    public string Apellido {
      get {
        return textBoxApellido.Text;
      }

      set {
        textBoxApellido.Text = value;
      }
    }

    public decimal DNI {
      get {
        return decimal.Parse(textBoxDNI.Text);
      }

      set {
        textBoxDNI.Text = value.ToString();
      }
    }

    public string Domicilio {
      get {
        return textBoxDomicilio.Text;
      }

      set {
        textBoxDomicilio.Text = value;
      }
    }

    public decimal Telefono {
      get {
        return decimal.Parse(textBoxDNI.Text);
      }

      set {
        textBoxTelefono.Text = value.ToString();
      }
    }

    public string Mail {
      get {
        return textBoxMail.Text;
      }

      set {
        textBoxMail.Text = value;
      }
    }

    public DateTime FechaNac {
      get {
        return dateTimePickerFechaNac.Value;
      }

      set {
        dateTimePickerFechaNac.Value = value;
      }
    }

    public bool Habilitado {
      get {
        return checkBoxHabilitado.Checked;
      }

      set {
        checkBoxHabilitado.Checked = value;
      }
    }

    private void buttonAceptar_Click(object sender, EventArgs e) {
      try {
        validar();                //valido los datos ingresados
        choferAEditar.nombre = Nombre;      //edito el chofer
        choferAEditar.apellido = Apellido;
        choferAEditar.dni = DNI;
        choferAEditar.domicilio = Domicilio;
        choferAEditar.telefono = Telefono;
        choferAEditar.mail = Mail;
        choferAEditar.fechaNac = FechaNac;
        choferAEditar.habilitado = Habilitado;

        choferAEditar.editar();         //persisto los cambios

        this.Close();
      }
      catch (SqlException) { }
      catch (Exception exception) {
        if (exception is FormatException || 
            exception is CampoVacioException ||
            exception is ValorNegativoException) Error.show(exception.Message);
        else throw;
      }
    }

    private void validar() {  // valido los datos ingresados
      if (string.IsNullOrWhiteSpace(Nombre)) throw new CampoVacioException("Nombre");
      if (string.IsNullOrWhiteSpace(Apellido)) throw new CampoVacioException("Apellido");
      if (string.IsNullOrWhiteSpace(textBoxDNI.Text)) throw new CampoVacioException("DNI");
      if (string.IsNullOrWhiteSpace(Domicilio)) throw new CampoVacioException("Domicilio");
      if (string.IsNullOrWhiteSpace(textBoxTelefono.Text)) throw new CampoVacioException("Telefono");
      if (FechaNac == null) throw new CampoVacioException("FechaNac");
      if (DNI <= 0) throw new ValorNegativoException("DNI");
      if (Telefono <= 0) throw new ValorNegativoException("Telefono");
    }

    private void buttonCancelar_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
