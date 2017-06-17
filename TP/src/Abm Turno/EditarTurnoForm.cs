using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_Chofer;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Turno
{
    public partial class EditarTurnoForm : ReturningForm
    {
        private Boolean edicion = false;
        private Turno turnoAEditar = null;

        public decimal HoraInicio
        {
            get
            {
                return decimal.Parse(textBoxHoraInicio.Text);
            }

            set
            {
                textBoxHoraInicio.Text = value.ToString();
            }
        }

        public decimal HoraFin
        {
            get
            {
                return decimal.Parse(textBoxHoraFin.Text);
            }

            set
            {
                textBoxHoraFin.Text = value.ToString();
            }
        }

        public string Descripcion
        {
            get
            {
                return textBoxDescripcion.Text;
            }

            set
            {
                textBoxDescripcion.Text = value;
            }
        }

        public decimal ValorKilometro
        {
            get
            {
                return decimal.Parse(textBoxValorKilometro.Text);
            }

            set
            {
                textBoxValorKilometro.Text = value.ToString();
            }
        }

        public decimal PrecioBase
        {
            get
            {
                return decimal.Parse(textBoxPrecioBase.Text);
            }

            set
            {
                textBoxPrecioBase.Text = value.ToString();
            }
        }

        public Boolean Habilitado
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

        public EditarTurnoForm(ReturningForm caller) : base(caller)
        {
            edicion = false;
            turnoAEditar = new Turno();
            InitializeComponent();
        }

        public EditarTurnoForm(ReturningForm caller, Turno turnoAEditar) : base(caller)
        {
            edicion = true;
            this.turnoAEditar = turnoAEditar;
            InitializeComponent();

            HoraInicio = turnoAEditar.horaInicio;
            HoraFin = turnoAEditar.horaFin;
            Descripcion = turnoAEditar.descripcion;
            ValorKilometro = turnoAEditar.valorKilometro;
            PrecioBase = turnoAEditar.precioBase;
            Habilitado = turnoAEditar.habilitado;
        }
        
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();
                turnoAEditar.horaInicio = HoraInicio;
                turnoAEditar.horaFin = HoraFin;
                turnoAEditar.descripcion = Descripcion;
                turnoAEditar.valorKilometro = ValorKilometro;
                turnoAEditar.precioBase = PrecioBase;
                turnoAEditar.habilitado = Habilitado;

                if (edicion)
                {
                    turnoAEditar.editar();
                }
                else
                {
                    turnoAEditar.nuevo();
                }
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
            if (string.IsNullOrWhiteSpace(textBoxHoraInicio.Text)) throw new CampoVacioException("Hora Inicio");
            if (string.IsNullOrWhiteSpace(textBoxHoraFin.Text)) throw new CampoVacioException("Hora Fin");
            if (string.IsNullOrWhiteSpace(Descripcion)) throw new CampoVacioException("Descripcion");
            if (string.IsNullOrWhiteSpace(textBoxValorKilometro.Text)) throw new CampoVacioException("Valor Kilometro");
            if (string.IsNullOrWhiteSpace(textBoxPrecioBase.Text)) throw new CampoVacioException("Precio Base");
    }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
