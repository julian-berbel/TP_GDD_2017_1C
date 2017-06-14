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

namespace UberFrba.Abm_Automovil
{
    public partial class TablaAutomovilForm : ReturningForm
    {
        public TablaAutomovilForm()
        {
            InitializeComponent();
        }

        public TablaAutomovilForm(Form caller) : base(caller)
        {
            InitializeComponent();
        }
        
        public DataGridView DataGridViewAutomovil
        {
            get { return dataGridViewAutomovil; }
        }

        public override void Mostrar()
        {
            DataTable data = Automovil.getAutomoviles();
            dataGridViewAutomovil.DataSource = data;
            base.Mostrar();
        }
    }
}
