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

namespace UberFrba.Abm_Cliente
{
    public partial class EditarClienteForm : ReturningForm
    {
        public EditarClienteForm(ReturningForm caller, Cliente clienteAEditar) : base(caller)
        {
            this.clienteAEditar = clienteAEditar;
            InitializeComponent();

            Nombre = clienteAEditar.nombre;
            Apellido = clienteAEditar.apellido;
            DNI = clienteAEditar.dni;
            Domicilio = clienteAEditar.domicilio;
            Telefono = clienteAEditar.telefono;
            Mail = clienteAEditar.mail;
            FechaNac = clienteAEditar.fechaNac;
            CodigoPostal = clienteAEditar.codigoPostal;
            Habilitado = clienteAEditar.habilitado;
        }

        private Cliente clienteAEditar = null;

        public string Nombre
        {
            get
            {
                return textBoxNombre.Text;
            }

            set
            {
                textBoxNombre.Text = value;
            }
        }

        public string Apellido
        {
            get
            {
                return textBoxApellido.Text;
            }

            set
            {
                textBoxApellido.Text = value;
            }
        }

        public decimal DNI
        {
            get
            {
                return decimal.Parse(textBoxDNI.Text);
            }

            set
            {
                textBoxDNI.Text = value.ToString();
            }
        }

        public string Domicilio
        {
            get
            {
                return textBoxDomicilio.Text;
            }

            set
            {
                textBoxDomicilio.Text = value;
            }
        }

        public decimal Telefono
        {
            get
            {
                return decimal.Parse(textBoxTelefono.Text);
            }

            set
            {
                textBoxTelefono.Text = value.ToString();
            }
        }

        public string Mail
        {
            get
            {
                return textBoxMail.Text;
            }

            set
            {
                textBoxMail.Text = value;
            }
        }

        public DateTime FechaNac
        {
            get
            {
                return dateTimePickerFechaNac.Value;
            }

            set
            {
                dateTimePickerFechaNac.Value = value;
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

        public bool Habilitado
        {
            get
            {
                return checkBoxHabilitado.Checked;
            }

            set
            {
                checkBoxHabilitado.Checked = value;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();
                clienteAEditar.nombre = Nombre;
                clienteAEditar.apellido = Apellido;
                clienteAEditar.dni = DNI;
                clienteAEditar.domicilio = Domicilio;
                clienteAEditar.telefono = Telefono;
                clienteAEditar.mail = Mail;
                clienteAEditar.fechaNac = FechaNac;
                clienteAEditar.codigoPostal = CodigoPostal;
                clienteAEditar.habilitado = Habilitado;

                clienteAEditar.editar();

                this.Close();
            }
            catch (SqlException) { }
            catch (Exception exception)
            {
                if (exception is FormatException || exception is CampoVacioException) Error.show(exception.Message);
                else throw;
            }
        }

        private void validar()
        {
            if (string.IsNullOrWhiteSpace(Nombre)) throw new CampoVacioException("Nombre");
            if (string.IsNullOrWhiteSpace(Apellido)) throw new CampoVacioException("Apellido");
            if (DNI == 0) throw new CampoVacioException("DNI");
            if (string.IsNullOrWhiteSpace(Domicilio)) throw new CampoVacioException("Domicilio");
            if (Telefono == 0) throw new CampoVacioException("Telefono");
            if (FechaNac == null) throw new CampoVacioException("FechaNac");
            if (CodigoPostal == 0) throw new CampoVacioException("Codigo Postal");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
