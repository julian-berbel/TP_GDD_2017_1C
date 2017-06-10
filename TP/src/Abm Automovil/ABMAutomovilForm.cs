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
    public partial class ABMAutomovilForm : ReturningForm
    {
        public ABMAutomovilForm(Form caller)
        {
            this.caller = caller;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditarAutomovilForm(dataGridViewAutomovil.SelectedRows[0].Cells).ShowDialog();
            this.Show();
        }

        private void ABMAutomovilForm_Load(object sender, EventArgs e)
        {
            DataTable data = Automovil.getAutomoviles();
            dataGridViewAutomovil.DataSource = data;
        }
    }
}
