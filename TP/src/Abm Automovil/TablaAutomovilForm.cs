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
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Automovil
{
    public partial class TablaAutomovilForm : ReturningForm
    {
        public TablaAutomovilForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
            comboBoxMarca.Items.Add("");
            Automovil.getMarcas().ForEach(marca => comboBoxMarca.Items.Add(marca));
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
                return int.Parse(textBoxChofer.Text);
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
            CargarTabla();
            dataGridViewAutomovil.Columns["vehi_chofer"].Visible = false;
            dataGridViewAutomovil.Columns["vehi_id"].Visible = false;
            dataGridViewAutomovil.Columns["vehi_turno"].Visible = false;
        }

        protected void CargarTabla()
        {
            dataGridViewAutomovil.DataSource = Automovil.getAutomovilesConFiltro(Chofer,
                                                                                        Modelo,
                                                                                        Patente,
                                                                                        Marca);
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try {
                validar();
                CargarTabla();
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is ValorNegativoException) Error.show(ex.Message);
                else throw;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxChofer.Text = "";
            textBoxModelo.Text = "";
            textBoxPatente.Text = "";
            comboBoxMarca.SelectedItem = "";
            CargarTabla();
        }

        private void validar()
        {
            if (Chofer < 0) throw new ValorNegativoException("DNI Chofer");
        }
    }
}
