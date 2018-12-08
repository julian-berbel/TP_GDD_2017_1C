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
using UberFrba.Abm_Chofer;
using UberFrba.Abm_Cliente;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Rendicion_Viajes {
  public partial class RendicionForm : ReturningForm {
    public RendicionForm(ReturningForm caller) : base(caller) {
      InitializeComponent();
      dateTimePickerFecha.Value = Program.FechaEjecucion.AddDays(-1);   // la rendicion se puede calcular si el dia ya paso
      dateTimePickerFecha.MaxDate = Program.FechaEjecucion.AddDays(-1);
      Turno.getListaTurnos().ForEach(turno => comboBoxTurnos.Items.Add(turno));   // cargo combobox de turnos
    }

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

    internal Turno Turno {
      get {
        return (Turno)comboBoxTurnos.SelectedItem;
      }
    }

    internal DateTime Fecha {
      get {
        return dateTimePickerFecha.Value;
      }
    }

    private void buttonVolver_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void buttonSeleccionarChofer_Click(object sender, EventArgs e) {
      Chofer seleccionado = new SeleccionarChoferForm(this).getChofer();  // selecciono chofer
      if (seleccionado != null) Chofer = seleccionado;          // si no es null cargo los campos
    }

    private void buttonEfectuar_Click(object sender, EventArgs e) {
      try {
        if (Chofer == null) throw new CampoVacioException("Chofer");  // valido los datos ingresados
        if (Turno == null) throw new CampoVacioException("Turno");
        DataTable tabla = Rendicion.get(Chofer.id, Fecha, Turno.id);  // obtengo la rendicion

        if (tabla == null || tabla.Rows.Count == 0) {           // si no existe...
          new RendicionNoEfectuadaForm(this, Chofer, Fecha, Turno).abrir();   // abro la ventana de rendicion no efectuada
        }
        else {                                  // caso contrario...
          var confirmResult = MessageBox.Show("La Rendicion indicada ya fue efectuada, desea consultar el resultado?",
                   "Rendicion",
                   MessageBoxButtons.YesNo);
          if (confirmResult == DialogResult.Yes) {
            new RendicionEfectuadaForm(this, Chofer, new Rendicion(tabla.Rows[0])).abrir(); // abro la ventana de rendicion efectuada
          }
        }
      }
      catch (SqlException) { }
      catch (CampoVacioException exception) {
        Error.show(exception.Message);
      }
    }
  }
}
