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
using UberFrba.Usuarios;

namespace UberFrba.Abm_Cliente
{
    public partial class NuevoClienteForm : ReturningForm
    {
        public NuevoClienteForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        private Usuario usuarioSeleccionado = null;

        public string Nombre
        {
            set
            {
                textBoxNombre.Text = value;
            }
        }

        public string Apellido
        {
            set
            {
                textBoxApellido.Text = value;
            }
        }

        public decimal DNI
        {
            set
            {
                textBoxDNI.Text = value.ToString();
            }
        }

        public string Domicilio
        {
            set
            {
                textBoxDomicilio.Text = value;
            }
        }

        public decimal Telefono
        {
            set
            {
                textBoxTelefono.Text = value.ToString();
            }
        }

        public string Mail
        {
            set
            {
                textBoxMail.Text = value;
            }
        }

        public decimal CodigoPostal
        {
            get
            {
                return decimal.Parse(textBoxCodigoPostal.Text);
            }
            set
            {
                textBoxCodigoPostal.Text = value.ToString();
            }
        }

        public DateTime FechaNac
        {
            set
            {
                dateTimePickerFechaNac.Value = value;
            }
        }

        public bool Habilitado
        {
            set
            {
                checkBoxHabilitado.Checked = value;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();                                                                          // valido los datos ingresados

                Cliente.nuevo(usuarioSeleccionado.id, CodigoPostal, checkBoxHabilitado.Checked);    // persisto el nuevo cliente
                this.Close();
            }
            catch (SqlException) { }
            catch (Exception exception)
            {
                if (exception is FormatException || 
                    exception is CampoVacioException || 
                    exception is UsuarioNoSeleccionadoException ||
                    exception is ValorNegativoException) Error.show(exception.Message);
                else throw;
            }
        }

        private void validar()          // valido los datos ingresados
        {
            if (usuarioSeleccionado == null) throw new UsuarioNoSeleccionadoException();
            if (string.IsNullOrWhiteSpace(textBoxCodigoPostal.Text)) throw new CampoVacioException("Codigo Postal");
            if (CodigoPostal <= 0) throw new ValorNegativoException("Codigo Postal");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionarUsuario_Click(object sender, EventArgs e)     // Selecciono un cliente
        {
            Usuario seleccionado = new SeleccionarUsuarioForm(this).getNoCliente(); // Si es null(porque cancelaron) no hago nada
            if (seleccionado != null)
            {
                usuarioSeleccionado = seleccionado;                                 // en caso contrario lleno los campos
                Nombre = seleccionado.nombre;
                Apellido = seleccionado.apellido;
                DNI = seleccionado.dni;
                Domicilio = seleccionado.domicilio;
                Telefono = seleccionado.telefono;
                Mail = seleccionado.mail;
                FechaNac = seleccionado.fechaNac;
            }
        }
    }
}
