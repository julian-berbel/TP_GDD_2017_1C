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

namespace UberFrba.Usuarios
{
    public partial class TablaUsuarioForm : ReturningForm
    {
        public String _usuariosABuscar = "USUARIOS";

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

        public virtual String usuariosABuscar()
        {
            return _usuariosABuscar;
        }

        public override void Refrescar()
        {
            CargarTabla();
            dataGridViewUsuario.Columns["usua_id"].Visible = false;
        }

        protected void CargarTabla()
        {
            dataGridViewUsuario.DataSource = Usuario.getXsConFiltros(usuariosABuscar(),
                                                                        Nombre,
                                                                        Apellido,
                                                                        DNI);
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
