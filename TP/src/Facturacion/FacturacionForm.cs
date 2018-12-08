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
using UberFrba.Abm_Cliente;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Facturacion {
  public partial class FacturacionForm : ReturningForm {
    public FacturacionForm(ReturningForm caller) : base(caller) {
      InitializeComponent();
      dateTimePickerFecha.Value = Program.FechaEjecucion.AddMonths(-1);
      dateTimePickerFecha.MaxDate = Program.FechaEjecucion.AddMonths(-1); // la facturacion solo se puede realizar una vez terminado el mes
    }

    private Cliente cliente;

    internal Cliente Cliente {
      get {
        return cliente;
      }
      set {
        cliente = value;
        textBoxCliente.Text = cliente.apellido + ", " + cliente.nombre;
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

    private void buttonSeleccionarCliente_Click(object sender, EventArgs e) {
      Cliente seleccionado = new SeleccionarClienteForm(this).getCliente();   // selecciono cliente
      if (seleccionado != null) Cliente = seleccionado;             // si no es null lleno el campo
    }

    private void buttonFacturar_Click(object sender, EventArgs e) {
      try {
        if (Cliente == null) throw new CampoVacioException("Cliente");    // valido los datos ingresados
        DataTable tabla = Factura.get(Cliente.id, Fecha);           // obtengo la factura de ese cliente y esa fecha

        if(tabla == null || tabla.Rows.Count == 0) {              // si no hubo resultado...
          new FacturaNoEfectuadaForm(this, Cliente, Fecha).abrir();     // abro la ventana de factura no efectuada
        }
        else {                                // caso contrario...
          var confirmResult = MessageBox.Show("La Factura indicada ya fue efectuada, desea consultar el resultado?",
                                              "Factura",
                                              MessageBoxButtons.YesNo);
          if (confirmResult == DialogResult.Yes) {
            new FacturaEfectuadaForm(this, Cliente, new Factura(tabla.Rows[0])).abrir();  // abro la ventana de factura efectuada
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
