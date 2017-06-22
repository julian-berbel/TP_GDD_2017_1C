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

namespace UberFrba.Usuarios
{
    public partial class NuevoUsuarioForm : ReturningForm
    {
        private Usuario usuarioAEditar;

        public NuevoUsuarioForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
            usuarioAEditar = new Usuario();
        }

        public string NombreDeUsuario
        {
            get
            {
                return textBoxNombreDeUsuario.Text;
            }
        }

        public byte[] Contrasenia
        {
            get
            {
                return Usuario.encriptar(textBoxContrasenia.Text);
            }
        }

        public string Nombre
        {
            get
            {
                return textBoxNombre.Text;
            }
        }

        public string Apellido
        {
            get
            {
                return textBoxApellido.Text;
            }
        }

        public decimal DNI
        {
            get
            {
                return decimal.Parse(textBoxDNI.Text);
            }
        }

        public string Domicilio
        {
            get
            {
                return textBoxDomicilio.Text;
            }
        }

        public decimal Telefono
        {
            get
            {
                return decimal.Parse(textBoxTelefono.Text);
            }
        }

        public string Mail
        {
            get
            {
                return textBoxMail.Text;
            }
        }

        public DateTime FechaNac
        {
            get
            {
                return dateTimePickerFechaNac.Value;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();
                usuarioAEditar.nombreDeUsuario = NombreDeUsuario;
                usuarioAEditar.contrasenia = Contrasenia;
                usuarioAEditar.nombre = Nombre;
                usuarioAEditar.apellido = Apellido;
                usuarioAEditar.dni = DNI;
                usuarioAEditar.domicilio = Domicilio;
                usuarioAEditar.telefono = Telefono;
                usuarioAEditar.mail = Mail;
                usuarioAEditar.fechaNac = FechaNac;

                usuarioAEditar.nuevo();

                this.Close();
            }
            catch (SqlException) { }
            catch (Exception exception)
            {
                if (exception is FormatException || 
                    exception is CampoVacioException ||
                    exception is ValorNegativoException) Error.show(exception.Message);
                else throw;
            } 
        }

        private void validar()
        {
            if (string.IsNullOrWhiteSpace(NombreDeUsuario)) throw new CampoVacioException("Nombre de Usuario");
            if (string.IsNullOrWhiteSpace(textBoxContrasenia.Text)) throw new CampoVacioException("Contraseña");
            if (string.IsNullOrWhiteSpace(Nombre)) throw new CampoVacioException("Nombre");
            if (string.IsNullOrWhiteSpace(Apellido)) throw new CampoVacioException("Apellido");
            if (string.IsNullOrWhiteSpace(textBoxDNI.Text)) throw new CampoVacioException("DNI");
            if (DNI <= 0) throw new ValorNegativoException("DNI");
            if (string.IsNullOrWhiteSpace(Domicilio)) throw new CampoVacioException("Domicilio");
            if (string.IsNullOrWhiteSpace(textBoxTelefono.Text)) throw new CampoVacioException("Telefono");
            if (Telefono <= 0) throw new ValorNegativoException("Telefono");

            if (dateTimePickerFechaNac.Value == null) throw new CampoVacioException("Fecha de Nacimiento");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
