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
        public SeleccionarFuncionalidadForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void Refrescar()
        {
            comboBoxFuncionalidades.Items.Clear();                      // saco los items del combobox
            Rol.rolSeleccionado.getFuncionalidades()                    // obtengo y cargo los nuevos
                .ForEach(f => comboBoxFuncionalidades.Items.Add(f));
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            if (comboBoxFuncionalidades.SelectedItem != null)   // si hay una funcionalidad seleccionada...
            {
                Funcionalidad funcionalidadSeleccionada = (Funcionalidad)comboBoxFuncionalidades.SelectedItem;
                funcionalidadSeleccionada.elegir(this);         // la elijo
            }
        }

    }
}
