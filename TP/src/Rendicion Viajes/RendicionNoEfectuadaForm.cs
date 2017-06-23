using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Rendicion_Viajes
{
    public partial class RendicionNoEfectuadaForm : UberFrba.Rendicion_Viajes.TablaRendicionForm
    {
        private Chofer chofer;
        private DateTime fecha;
        private Turno turno;
        public RendicionNoEfectuadaForm(ReturningForm caller, Chofer chofer, DateTime fecha, Turno turno) : base(caller, chofer, fecha)
        {
            InitializeComponent();
            this.chofer = chofer;   // cargo campos
            this.fecha = fecha;
            this.turno = turno;
            Cargar();
            
            Turno = turno;
        }

        internal decimal Porcentaje
        {
            get
            {
                return numericUpDownPorcentaje.Value / 100;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGenerarRendicion_Click(object sender, EventArgs e)
        {
            Rendicion.generar(Chofer.id, Fecha, Turno.id, ImporteTotal, Porcentaje);        // genero la rendicion
            this.Close();
        }

        private void Cargar()
        {
            DataTable viajes = Viaje.getDeChofer(chofer.id, fecha, turno.id, Porcentaje);   // obtengo los viajes
            DataGridViewRendicion.DataSource = viajes;                                      // cargo la tabla
            ImporteTotal = viajes.AsEnumerable().Sum(f => (decimal)f["Monto"]);             // calculo el total
        }

        private void numericUpDownPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
