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
            CargarTabla();
            dataGridViewUsuario.Columns["usua_id"].Visible = false;
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
                if (string.IsNullOrWhiteSpace(textBoxDNI.Text)) return 0;
                decimal resultado = 0;
                try
                {
                    resultado = decimal.Parse(textBoxDNI.Text);
                }
                catch (Exception e)
                {
                    Error.show(e.Message);
                }
                return resultado;
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

        protected virtual byte rolAFiltrar()
        {
            return 0;
        }

        public override void Refrescar()
        {
            CargarTabla();
        }

        protected void CargarTabla()
        {
            dataGridViewUsuario.DataSource = Usuario.getXsConFiltro(tablaABuscar(),
                                                                        Nombre,
                                                                        Apellido,
                                                                        DNI,
                                                                        rolAFiltrar());
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDNI.Text = "";
            CargarTabla();
        }
    }
}
