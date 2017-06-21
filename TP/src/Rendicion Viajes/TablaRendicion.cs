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

namespace UberFrba.Rendicion_Viajes
{
    public partial class TablaRendicionForm : ReturningForm
    {
        public TablaRendicionForm(ReturningForm caller, Chofer chofer, DateTime fecha) : base(caller)
        {
            InitializeComponent();
            Chofer = chofer;
            Fecha = fecha;
        }

        public TablaRendicionForm()
        {
            InitializeComponent();
        }

        private Chofer chofer;
        private DateTime fecha;
        private Turno turno;
        private decimal importeTotal;

        internal Chofer Chofer
        {
            get
            {
                return chofer;
            }
            set
            {
                chofer = value;
                labelCliente.Text += chofer.apellido + ", " + chofer.nombre;
            }
        }

        internal DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
                labelFecha.Text += fecha.ToLongDateString();
            }
        }

        internal Turno Turno
        {
            get
            {
                return turno;
            }
            set
            {
                turno = value;
                labelTurno.Text += Turno.descripcion;
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
                labelTotal.Text = "Total: " + importeTotal.ToString();
            }
        }

        public DataGridView DataGridViewRendicion
        {
            get
            {
                return dataGridViewRendicion;
            }
        }

        public TablaRendicionForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }
    }
}
