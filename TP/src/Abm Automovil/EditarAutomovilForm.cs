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
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Automovil
{
    public partial class EditarAutomovilForm : Form
    {
        private Boolean edicion = false;
        private int? autoAEditar = null;

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

        public EditarAutomovilForm()
        {
            InitializeComponent();
        }

        public EditarAutomovilForm(DataGridViewCellCollection autoAEditar)
        {
            InitializeComponent();

            this.autoAEditar = (int) autoAEditar["vehi_id"].Value;
            edicion = true;
            Chofer = Chofer.get((int)autoAEditar["vehi_chofer"].Value);
            Patente = (String)autoAEditar["vehi_patente"].Value;
            Licencia = (String)autoAEditar["vehi_licencia"].Value;
            Rodado = (String)autoAEditar["vehi_rodado"].Value;
            Modelo = (String)autoAEditar["mode_codigo"].Value;
            Marca = (String)autoAEditar["marc_nombre"].Value;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (edicion)
                {
                    DB.correrProcedimiento("AUTOMOVIL_UPDATE",
                                        "automovilId", autoAEditar,
                                        "chofer", Chofer.id,
                                        "patente", Patente,
                                        "licencia", Licencia,
                                        "rodado", Rodado,
                                        "modelo", Modelo,
                                        "marca", Marca);
                }
                else
                {
                    DB.correrProcedimiento("AUTOMOVIL_NUEVO", 
                                        "chofer", Chofer.id,
                                        "patente", Patente,
                                        "licencia", Licencia,
                                        "rodado", Rodado,
                                        "modelo", Modelo,
                                        "marca", Marca);
                }
                this.Close();
            }catch (CampoVacioException exception)
            {
                Error.show(exception.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionarChofer_Click(object sender, EventArgs e)
        {

        }
    }
}
