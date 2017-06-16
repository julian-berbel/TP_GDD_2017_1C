﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Chofer
{
    public partial class EditarChoferForm : ReturningForm
    {
        public EditarChoferForm(ReturningForm caller, Chofer choferAEditar) : base(caller)
        {
            this.choferAEditar = choferAEditar;
            InitializeComponent();

            Nombre = choferAEditar.nombre;
            Apellido = choferAEditar.apellido;
            DNI = choferAEditar.dni;
            Domicilio = choferAEditar.domicilio;
            Telefono = choferAEditar.telefono;
            Mail = choferAEditar.mail;
            FechaNac = choferAEditar.fechaNac;
            Habilitado = choferAEditar.habilitado;
        }
        
        private Chofer choferAEditar = null;

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
                if (string.IsNullOrWhiteSpace(textBoxTelefono.Text)) return 0;
                decimal resultado = 0;
                try
                {
                    resultado = decimal.Parse(textBoxTelefono.Text);
                }
                catch (Exception e)
                {
                    Error.show(e.Message);
                }
                return resultado;
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
                choferAEditar.nombre = Nombre;
                choferAEditar.apellido = Apellido;
                choferAEditar.dni = DNI;
                choferAEditar.domicilio = Domicilio;
                choferAEditar.telefono = Telefono;
                choferAEditar.mail = Mail;
                choferAEditar.fechaNac = FechaNac;
                choferAEditar.habilitado = Habilitado;

                choferAEditar.editar();

                this.Close();
            }
            catch (CampoVacioException exception)
            {
                Error.show(exception.Message);
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
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}