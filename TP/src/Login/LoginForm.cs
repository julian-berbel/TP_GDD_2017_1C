using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio;
using UberFrba.SeleccionarFuncionalidad;
using UberFrba.SeleccionarRol;
using UberFrba.Usuarios;

namespace UberFrba.Login {
  public partial class LoginForm : ReturningForm {
    public LoginForm() {
      InitializeComponent();
    }

    private void buttonLogin_Click(object sender, EventArgs e) {
      String usuario = textBoxUsuario.Text;

      byte[] contrasenia = Usuario.encriptar(textBoxContrasenia.Text);            // encripto la contraseña

      try {
        DB.correrProcedimiento("SPLOGIN", "usuario", usuario, "contrasenia", contrasenia);  // corro procedimiento de login

        Usuario.cargar(usuario);                              // cargo el usuario seleccionado

        List<Rol> roles = Usuario.getRoles();                         // consigo los roles del usuario                   
        int cantidadDeRoles = roles.Count;

        if (cantidadDeRoles == 0) Error.show("El usuario seleccionado no tiene ningún rol asignado!");  // si no tiene roles muestro un error
        else if (cantidadDeRoles > 1) {                                   // si tiene mas de uno doy a elegir
          new SeleccionarRolForm(this).abrir();
        }
        else {                                              // caso contrario elijo el unico directamente
          Rol.rolSeleccionado = roles.First();
          new SeleccionarFuncionalidadForm(this).abrir();
        }
      }
      catch (SqlException) { }
    }

    protected override void OnFormClosing(FormClosingEventArgs e) {
    }

    private void buttonRegistrar_Click(object sender, EventArgs e) {
      new NuevoUsuarioForm(this).abrir();                                 // abro ventana de registro
    }
  }
}
