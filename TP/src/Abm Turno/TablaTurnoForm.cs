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

namespace UberFrba.Abm_Turno
{
    public partial class TablaTurnoForm : ReturningForm
    {
        public TablaTurnoForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        public TablaTurnoForm() {
            InitializeComponent();
        }

        public DataGridView DataGridViewTurno
        {
            get { return dataGridViewTurno; }
        }
        
        public override void Refrescar()
        {
            CargarTabla();
            dataGridViewTurno.Columns["turn_id"].Visible = false;
        }

        protected void CargarTabla()
        {
            dataGridViewTurno.DataSource = Turno.getTurnos();
        }
    }
}
