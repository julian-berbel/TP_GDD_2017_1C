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
        public TablaAutomovilForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        public TablaAutomovilForm() {
            InitializeComponent();
        }

        public DataGridView DataGridViewAutomovil
        {
            get { return dataGridViewAutomovil; }
        }

        public int Chofer {
            get {
                int resultado;
                return int.TryParse(textBoxChofer.Text, out resultado) ? resultado : 0;
            }
        }
        public string Modelo {
            get {
                return textBoxModelo.Text;
            }
        }
        public string Patente {
            get
            {
                return textBoxPatente.Text;
            }
        }
        public string Marca {
            get
            {
                return textBoxMarca.Text;
            }
        }

        public override void Refrescar()
        {
            DataTable data = Automovil.getAutomoviles();
            dataGridViewAutomovil.DataSource = data;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (sinFiltros()) Refrescar();
            else
                dataGridViewAutomovil.DataSource = Automovil.getAutomovilesConFiltro(Chofer,
                                                                                        Modelo,
                                                                                        Patente,
                                                                                        Marca);
        }

        private Boolean sinFiltros()
        {
            return string.IsNullOrWhiteSpace(Patente) &&
                    string.IsNullOrWhiteSpace(Modelo) &&
                    string.IsNullOrWhiteSpace(Marca) &&
                    Chofer == 0;
        }
    }
}
