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

namespace UberFrba.Dominio
{
    public partial class TablaUsuarioForm : ReturningForm
    {
        public TablaUsuarioForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        public TablaUsuarioForm()
        {
            InitializeComponent();
        }

        public DataGridView DataGridViewUsuario
        {
            get { return dataGridViewUsuario; }
        }

        public string Nombre
        {
            get
            {
                return textBoxNombre.Text;
            }
        }
        public decimal DNI
        {
            get
            {
                decimal resultado;
                return decimal.TryParse(textBoxDNI.Text, out resultado) ? resultado : 0;
            }
        }
        public string Apellido
        {
            get
            {
                return textBoxApellido.Text;
            }
        }

        public virtual String tablaABuscar()
        {
            return "USUARIOS";
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (sinFiltros()) Refrescar();
            else
                dataGridViewUsuario.DataSource = Usuario.getXsConFiltro(tablaABuscar(),
                                                                        Nombre,
                                                                        Apellido,
                                                                        DNI);
        }

        private Boolean sinFiltros()
        {
            return string.IsNullOrWhiteSpace(Nombre) &&
                    string.IsNullOrWhiteSpace(Apellido) &&
                    DNI == 0;
        }
    }
}
