using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_Chofer;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Automovil
{
    public partial class EditarAutomovilForm : ReturningForm
    {
        private Boolean edicion = false;
        private Automovil autoAEditar = null;

        private Chofer chofer;
        private String patente;
        private String licencia;
        private String rodado;
        private String modelo;
        private String marca;

        internal Chofer Chofer
        {
            get
            {
                return chofer;
            }

            set
            {
                chofer = value;
                textBoxChofer.Text = chofer.apellido + ", " + chofer.nombre;
            }
        }

        public string Patente
        {
            get
            {
                return textBoxPatente.Text;
            }

            set
            {
                patente = value;
                textBoxPatente.Text = value;
            }
        }

        public string Licencia
        {
            get
            {
                return textBoxLicencia.Text;
            }

            set
            {
                licencia = value;
                textBoxLicencia.Text = value.ToString();
            }
        }

        public string Rodado
        {
            get
            {
                return textBoxRodado.Text;
            }

            set
            {
                rodado = value;
                textBoxRodado.Text = value;
            }
        }

        public string Modelo
        {
            get
            {
                return textBoxModelo.Text;
            }

            set
            {
                modelo = value;
                textBoxModelo.Text = value;
            }
        }

        public string Marca
        {
            get
            {
                return textBoxMarca.Text;
            }

            set
            {
                marca = value;
                textBoxMarca.Text = marca;
            }
        }

        public EditarAutomovilForm(ReturningForm caller) : base(caller)
        {
            edicion = false;
            autoAEditar = new Automovil();
            InitializeComponent();
        }

        public EditarAutomovilForm(ReturningForm caller, Automovil autoAEditar) : base(caller)
        {
            edicion = true;
            this.autoAEditar = autoAEditar;
            InitializeComponent();
            
            Chofer = autoAEditar.chofer;
            Patente = autoAEditar.patente;
            Licencia = autoAEditar.licencia;
            Rodado = autoAEditar.rodado;
            Modelo = autoAEditar.modelo;
            Marca = autoAEditar.marca;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();
                autoAEditar.chofer = Chofer;
                autoAEditar.patente = Patente;
                autoAEditar.licencia = Licencia;
                autoAEditar.rodado = Rodado;
                autoAEditar.modelo = Modelo;
                autoAEditar.marca = Marca;

                if (edicion)
                {
                    autoAEditar.editar();
                }
                else
                {
                    autoAEditar.nuevo();
                }
                this.Close();
            }catch (CampoVacioException exception)
            {
                Error.show(exception.Message);
            }
        }

        private void validar()
        {
            if (Chofer == null) throw new CampoVacioException("Chofer");
            if (string.IsNullOrWhiteSpace(Patente)) throw new CampoVacioException("Patente");
            if (string.IsNullOrWhiteSpace(Licencia)) throw new CampoVacioException("Licencia");
            if (string.IsNullOrWhiteSpace(Rodado)) throw new CampoVacioException("Rodado");
            if (string.IsNullOrWhiteSpace(Modelo)) throw new CampoVacioException("Modelo");
            if (string.IsNullOrWhiteSpace(Marca)) throw new CampoVacioException("Marca");
    }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionarChofer_Click(object sender, EventArgs e)
        {
            Chofer seleccionado = new SeleccionarChoferForm(this).getChofer();
            if (seleccionado != null) Chofer = seleccionado;
        }
    }
}
