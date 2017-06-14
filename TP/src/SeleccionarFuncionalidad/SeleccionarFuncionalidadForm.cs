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
        public SeleccionarFuncionalidadForm(Form caller) : base(caller)
        {
            InitializeComponent();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void Mostrar()
        {
            base.Mostrar();
            comboBoxFuncionalidades.Items.Clear();
            Rol.rolSeleccionado.getFuncionalidades()
                .ForEach(f => comboBoxFuncionalidades.Items.Add(f));
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidadSeleccionada = (Funcionalidad)comboBoxFuncionalidades.SelectedItem;
            funcionalidadSeleccionada.elegir(this);
            this.Hide();
        }

    }
}
