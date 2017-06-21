using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Facturacion
{
    public partial class FacturaNoEfectuadaForm : UberFrba.Facturacion.TablaFacturaForm
    {
        public FacturaNoEfectuadaForm(ReturningForm caller, Cliente cliente, DateTime fecha) : base(caller, cliente)
        {
            InitializeComponent();
            DataTable viajes = Viaje.getDeCliente(cliente.id, fecha);
            DataGridViewFactura.DataSource = viajes;
            FechaInicio = new DateTime(fecha.Year, fecha.Month, 1);
            FechaFin = new DateTime(fecha.Year, fecha.Month, DateTime.DaysInMonth(fecha.Year, fecha.Month));
            ImporteTotal = viajes.AsEnumerable().Sum(f => (decimal)f["Monto"]);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGenerarFactura_Click(object sender, EventArgs e)
        {
            Factura.generar(Cliente.id, FechaInicio, FechaFin, ImporteTotal);
            this.Close();
        }
    }
}
