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
        private decimal total;
        public RendicionNoEfectuadaForm(ReturningForm caller, Chofer chofer, DateTime fecha, Turno turno) : base(caller, chofer, fecha)
        {
            InitializeComponent();
            DataTable viajes = Viaje.getDeChofer(chofer.id, fecha, turno.id);
            DataGridViewRendicion.DataSource = viajes;
            total = viajes.AsEnumerable().Sum(f => (decimal)f["Monto"]);
            ImporteTotal = total * Porcentaje;
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
            Rendicion.generar(Chofer.id, Fecha, Turno.id, ImporteTotal, Porcentaje);
            this.Close();
        }

        private void numericUpDownPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            ImporteTotal = total * Porcentaje;
        }
    }
}
