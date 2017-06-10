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
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Automovil
{
    public partial class EditarAutomovilForm : Form
    {
        private Boolean edicion = false;
        private Automovil autoAEditar = null;

        private Chofer chofer;
        private String patente;
        private int licencia;
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

        public int Licencia
        {
            get
            {
                return Int32.Parse(textBoxLicencia.Text);
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

        public EditarAutomovilForm(Automovil autoAEditar)
        {
            if(autoAEditar != null)
            {
                edicion = true;
                Chofer = Chofer.get(autoAEditar.chofer.id);
                Patente = autoAEditar.patente;
                Licencia = autoAEditar.licencia;
                Rodado = autoAEditar.rodado;
                Modelo = autoAEditar.modelo;
                Marca = autoAEditar.marca;
            }
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                autoAEditar = new Automovil(chofer, patente, licencia, rodado, modelo, marca);
                object[] parametros = { "chofer", Chofer.id,
                                        "patente", Patente,
                                        "licencia", Licencia,
                                        "rodado", Rodado,
                                        "modelo", Modelo,
                                        "marca", Marca};
                if (edicion)
                {
                    DB.correrProcedimiento("AUTOMOVIL_UPDATE", parametros);
                }
                else
                {
                    DB.correrProcedimiento("AUTOMOVIL_NUEVO", parametros);
                }
            }catch (CampoVacioException exception)
            {
                Error.show(exception.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
