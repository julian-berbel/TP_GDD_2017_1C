using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;
using UberFrba.Usuarios;

namespace UberFrba.Abm_Chofer {
  public partial class TablaChoferForm : TablaUsuarioForm {
    public TablaChoferForm(ReturningForm caller) : base(caller) {
      _usuariosABuscar = "CHOFERES";    // seteo tipo de usuarios a buscar
      InitializeComponent();
    }

    public override void Refrescar() {
      base.Refrescar();
      DataGridViewUsuario.Columns["Usuario_Habilitado"].Visible = false;  // oculto columna que no quiero mostrar
      DataGridViewUsuario.Columns["Chofer_Habilitado"].HeaderText = "Habilitado"; //  cambio nombre visible de columna
    }

    public TablaChoferForm() {
      InitializeComponent();
    }
  }
}
