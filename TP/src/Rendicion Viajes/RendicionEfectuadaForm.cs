using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Rendicion_Viajes {
  public partial class RendicionEfectuadaForm : UberFrba.Rendicion_Viajes.TablaRendicionForm {
    public RendicionEfectuadaForm(ReturningForm caller, Chofer chofer, Rendicion rendicion) : base(caller, chofer, rendicion.fecha) {
      InitializeComponent();
      DataGridViewRendicion.DataSource = Rendicion.getItems(rendicion.numero);  // obtengo los viajes de la rendicion
      ImporteTotal = rendicion.importeTotal;                    // cargo campos
      labelRendicionNro.Text += rendicion.numero.ToString();
      labelPorcentaje.Text += (rendicion.porcentaje * 100).ToString() + "%";
      Turno = rendicion.turno;
    }
    
    private void buttonVolver_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
