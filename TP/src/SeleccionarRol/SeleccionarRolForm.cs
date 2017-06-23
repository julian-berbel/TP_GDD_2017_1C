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
using UberFrba.SeleccionarFuncionalidad;

namespace UberFrba.SeleccionarRol
{
    public partial class SeleccionarRolForm : ReturningForm
    {
        private List<String> roles = new List<String>();

        public SeleccionarRolForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }
        
        public override void Refrescar()
        {
            comboBoxRoles.Items.Clear();                                    // saco los items del combobox
            Usuario.getRoles().ForEach(r => comboBoxRoles.Items.Add(r));    // obtengo y agrego los nuevos
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            if (comboBoxRoles.SelectedItem != null) {   // si hay un rol seleccionado...
                Rol.rolSeleccionado = (Rol)comboBoxRoles.SelectedItem;
                new SeleccionarFuncionalidadForm(this).abrir();     // lo elijo y busco sus funcionalidades
            }
        }
    }
}
