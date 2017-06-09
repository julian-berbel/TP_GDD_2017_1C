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

namespace UberFrba.SeleccionarFuncionalidad
{
    public partial class SeleccionarFuncionalidadForm : ReturningForm
    {
        public SeleccionarFuncionalidadForm(Form caller)
        {
            this.caller = caller;
            InitializeComponent();
        }

        private void SeleccionarFuncionalidadForm_Load(object sender, EventArgs e)
        {
            Rol.rolSeleccionado.getFuncionalidades()
                .ForEach(f => comboBoxFuncionalidades.Items.Add(f));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidadSeleccionada = (Funcionalidad)comboBoxFuncionalidades.SelectedItem;
            funcionalidadSeleccionada.elegir(this);
            this.Hide();
        }

    }
}
