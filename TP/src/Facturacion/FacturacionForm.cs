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

namespace UberFrba.Facturacion
{
    public partial class FacturacionForm : ReturningForm
    {
        public FacturacionForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
            dateTimePickerFecha.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerFecha.MaxDate = DateTime.Now.AddMonths(-1);
        }

        private Cliente cliente;

        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
                textBoxCliente.Text = cliente.apellido + ", " + cliente.nombre;
            }
        }

        internal DateTime Fecha
        {
            get
            {
                return dateTimePickerFecha.Value;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionarCliente_Click(object sender, EventArgs e)
        {
            Cliente seleccionado = new SeleccionarClienteForm(this).getCliente();
            if (seleccionado != null) Cliente = seleccionado;
        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = Factura.get(Cliente.id, Fecha);

                if(tabla == null || tabla.Rows.Count == 0)
                {
                    new FacturaNoEfectuadaForm(this, Cliente, Fecha).abrir();
                }
                else
                {
                    var confirmResult = MessageBox.Show("La Factura indicada ya fue efectuada, desea consultar el resultado?",
                                     "Factura",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        new FacturaEfectuadaForm(this, Cliente, new Factura(tabla.Rows[0])).abrir();
                    }
                }
            }
            catch (SqlException) { }
            catch (CampoVacioException exception)
            {
                Error.show(exception.Message);
            }
        }
    }
}
