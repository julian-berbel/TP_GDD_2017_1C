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
                if (string.IsNullOrWhiteSpace(textBoxChofer.Text)) return 0;
                int resultado = 0;
                try
                {
                    resultado = int.Parse(textBoxChofer.Text);
                }catch(Exception e)
                {
                    Error.show(e.Message);
                }
                return resultado;
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
                if (string.IsNullOrWhiteSpace((string)comboBoxMarca.SelectedItem)) return "";
                return (String) comboBoxMarca.SelectedItem;
            }
        }

        public override void Refrescar()
        {
            DataTable data = Automovil.getAutomoviles();
            dataGridViewAutomovil.DataSource = data;
            dataGridViewAutomovil.Columns[0].Visible = false;
            dataGridViewAutomovil.Columns[1].Visible = false;
            comboBoxMarca.Items.Clear();
            comboBoxMarca.Items.Add("");
            Automovil.getMarcas().ForEach(marca => comboBoxMarca.Items.Add(marca));
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (sinFiltros()) Refrescar();
            else
                dataGridViewAutomovil.DataSource = Automovil.getAutomovilesConFiltro(   Chofer,
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
