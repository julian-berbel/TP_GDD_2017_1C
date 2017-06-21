using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Facturacion
{
    public partial class TablaFacturaForm : ReturningForm
    {
        public TablaFacturaForm(ReturningForm caller, Cliente cliente) : base(caller)
        {
            InitializeComponent();
            Cliente = cliente;
        }

        public TablaFacturaForm()
        {
            InitializeComponent();
        }

        private Cliente cliente;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private decimal importeTotal;

        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
                labelCliente.Text += cliente.apellido + ", " + cliente.nombre;
            }
        }

        internal DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }
            set
            {
                fechaInicio = value;
                labelFechaInicio.Text += fechaInicio.ToLongDateString();
            }
        }

        internal DateTime FechaFin
        {
            get
            {
                return fechaFin;
            }
            set
            {
                fechaFin = value;
                labelFechaFin.Text += fechaFin.ToLongDateString();
            }
        }

        internal decimal ImporteTotal
        {
            get
            {
                return importeTotal;
            }
            set
            {
                importeTotal = value;
                labelTotal.Text += importeTotal.ToString();
            }
        }

        public DataGridView DataGridViewFactura
        {
            get
            {
                return dataGridViewFactura;
            }
        }

        public TablaFacturaForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }
    }
}
