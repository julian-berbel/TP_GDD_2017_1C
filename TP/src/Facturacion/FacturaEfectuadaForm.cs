using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Facturacion
{
    public partial class FacturaEfectuadaForm : UberFrba.Facturacion.TablaFacturaForm
    {
        public FacturaEfectuadaForm(ReturningForm caller, Cliente cliente, Factura factura) : base(caller, cliente)
        {
            InitializeComponent();
            DataGridViewFactura.DataSource = Factura.getItems(factura.numero);      // obtengo los viajes de la factura
            FechaInicio = factura.fechaInicio;                                      // cargo los campos con los datos de la factura
            FechaFin = factura.fechaFin;
            ImporteTotal = factura.importeTotal;
            labelFacturaNro.Text += factura.numero.ToString();
        }
        
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
