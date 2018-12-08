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
using UberFrba.Usuarios;

namespace UberFrba.Abm_Chofer {
  public partial class NuevoChoferForm : ReturningForm {
    public NuevoChoferForm(ReturningForm caller) : base(caller) {
      InitializeComponent();
    }
    
    private Usuario usuarioSeleccionado = null;

    public string Nombre {
      set {
        textBoxNombre.Text = value;
      }
    }

    public string Apellido {
      set {
        textBoxApellido.Text = value;
      }
    }

    public decimal DNI {
      set {
        textBoxDNI.Text = value.ToString();
      }
    }

    public string Domicilio {
      set {
        textBoxDomicilio.Text = value;
      }
    }

    public decimal Telefono {
      set {
        textBoxTelefono.Text = value.ToString();
      }
    }

    public string Mail {
      set {
        textBoxMail.Text = value;
      }
    }

    public DateTime FechaNac {
      set {
        dateTimePickerFechaNac.Value = value;
      }
    }

    public bool Habilitado {
      set {
        checkBoxHabilitado.Checked = value;
      }
    }

    private void buttonAceptar_Click(object sender, EventArgs e) {
      try {
        if (usuarioSeleccionado == null) throw new UsuarioNoSeleccionadoException();  // valido los datos ingresados
        else Chofer.nuevo(usuarioSeleccionado.id, checkBoxHabilitado.Checked);      // persisto el nuevo chofer

        this.Close();
      }
      catch (SqlException) { }
      catch (Exception exception) {
        if (exception is FormatException ||
            exception is UsuarioNoSeleccionadoException) Error.show(exception.Message);
        else throw;
      }
    }

    private void buttonCancelar_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void buttonSeleccionarUsuario_Click(object sender, EventArgs e) {
      Usuario seleccionado = new SeleccionarUsuarioForm(this).getNoChofer();  // Selecciono un chofer
      if(seleccionado != null) {                        // Si es null(porque cancelaron) no hago nada
        usuarioSeleccionado = seleccionado;                 // en caso contrario lleno los campos
        Nombre = seleccionado.nombre;
        Apellido = seleccionado.apellido;
        DNI = seleccionado.dni;
        Domicilio = seleccionado.domicilio;
        Telefono = seleccionado.telefono;
        Mail = seleccionado.mail;
        FechaNac = seleccionado.fechaNac;
      }
    }
  }
}
