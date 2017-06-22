﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_Chofer;
using UberFrba.Abm_Cliente;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Registro_Viajes
{
    public partial class RegistroViajeForm : ReturningForm
    {
        public RegistroViajeForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
            dateTimePickerFechaHoraInicio.Value = Program.FechaEjecucion.AddMinutes(-10);
            dateTimePickerFechaHoraFin.Value = Program.FechaEjecucion;
            dateTimePickerFechaHoraFin.MaxDate = Program.FechaEjecucion;
            dateTimePickerFechaHoraInicio.MaxDate = Program.FechaEjecucion;
        }

        private Chofer chofer;
        private Cliente cliente;
        private Automovil automovil;
        private Turno turno;

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

        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
                textBoxCliente.Text = cliente.apellido + ", " + cliente.nombre;
            }
        }

        internal Automovil Automovil
        {
            get
            {
                return automovil;
            }
            
            set
            {
                automovil = value;
                textBoxAutomovil.Text = automovil.patente;
            }
        }

        internal Turno Turno
        {
            get
            {
                return turno;
            }

            set
            {
                turno = value;
                textBoxTurno.Text = turno.descripcion;
            }
        }

        internal decimal CantidadKms
        {
            get
            {
                return decimal.Parse(textBoxCantidadKms.Text);
            }
        }

        internal DateTime FechaHoraInicio
        {
            get
            {
                return dateTimePickerFechaHoraInicio.Value;
            }
        }

        internal DateTime FechaHoraFin
        {
            get
            {
                return dateTimePickerFechaHoraFin.Value;
            }
        }

        private void buttonSeleccionarChofer_Click(object sender, EventArgs e)
        {
            Chofer seleccionado = new SeleccionarChoferForm(this).getChofer();
            if (seleccionado != null)
            {
                try {
                    Automovil = Automovil.getAutomovilDe(seleccionado.id);
                    Chofer = seleccionado;
                    Turno = automovil.turno;
                }
                catch (IndexOutOfRangeException)
                {
                    Error.show("El chofer seleccionado no tiene ningún automovil habilitado asignado.");
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionarCliente_Click(object sender, EventArgs e)
        {
            Cliente seleccionado = new SeleccionarClienteForm(this).getCliente();
            if (seleccionado != null) Cliente = seleccionado;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();
                Viaje.registrar(Chofer.id, Automovil.id, Cliente.id, Turno.id, CantidadKms, FechaHoraInicio, FechaHoraFin);

                this.Close();
            }
            catch (SqlException) { }
            catch (Exception exception)
            {
                if (exception is FormatException ||
                    exception is CampoVacioException ||
                    exception is ValorNegativoException ||
                    exception is HorarioSeleccionadoFueraDeTurnoException ||
                    exception is ViajeTerminaEnFechaDistintaException ||
                    exception is FechaDeFinAnteriorAFechaDeInicioException) Error.show(exception.Message);
                else throw;
            }
        }

        private void validar()
        {
            if (Chofer == null) throw new CampoVacioException("Chofer");
            if (string.IsNullOrWhiteSpace(textBoxCantidadKms.Text)) throw new CampoVacioException("Cantidad de Kilómetros");
            if (CantidadKms <= 0) throw new ValorNegativoException("Cantidad de Kilómetros");
            if (Cliente == null) throw new CampoVacioException("Cliente");
            if (dateTimePickerFechaHoraInicio.Value.Date != dateTimePickerFechaHoraFin.Value.Date) throw new ViajeTerminaEnFechaDistintaException();
            if (dateTimePickerFechaHoraFin.Value.CompareTo(dateTimePickerFechaHoraInicio.Value) <= 0) throw new FechaDeFinAnteriorAFechaDeInicioException();
            if (dateTimePickerFechaHoraInicio.Value.Hour < Turno.horaInicio || dateTimePickerFechaHoraFin.Value.AddSeconds(-1).Hour >= Turno.horaFin) throw new HorarioSeleccionadoFueraDeTurnoException(Turno);
        }

        private void dateTimePickerFechaHoraInicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
