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

namespace UberFrba.Listado_Estadistico
{
    public partial class ListadoEstadisticoForm : ReturningForm
    {
        public ListadoEstadisticoForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
            comboBoxEstadisticas.Items.Add("Chofer con Mayor Recaudacion");
            comboBoxEstadisticas.Items.Add("Chofer con Viaje Más Largo");
            comboBoxEstadisticas.Items.Add("Cliente con Mayor Consumo");
            comboBoxEstadisticas.Items.Add("Cliente con Mayor Uso del Mismo Vehiculo");
        }

        internal int Anio
        {
            get
            {
                return (int) numericUpDownAnio.Value;
            }
        }

        internal byte Trimestre
        {
            get
            {
                return (byte)numericUpDownTrimestre.Value;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEstadisticas.SelectedItem == null) throw new CampoVacioException("Estadistica Seleccionada");

                dataGridViewEstadistica.DataSource = getEstadistica();
            }
            catch (SqlException) { }
            catch (Exception exception)
            {
                if (exception is FormatException || exception is CampoVacioException) Error.show(exception.Message);
                else throw;
            }
        }

        private DataTable getEstadistica()
        {
            String estadistica = String.Empty;

            switch (comboBoxEstadisticas.SelectedIndex)
            {
                case 0:
                    estadistica = "ESTADISTICA_CHOFER_MAYOR_RECAUDACION";
                    break;
                case 1:
                    estadistica = "ESTADISTICA_CHOFER_VIAJE_MAS_LARGO";
                    break;
                case 2:
                    estadistica = "ESTADISTICA_CLIENTE_MAYOR_CONSUMO";
                    break;
                case 3:
                    estadistica = "ESTADISTICA_CLIENTE_MAYOR_USO_MISMO_VEHICULO";
                    break;
            }

            return DB.correrFuncionDeTabla(estadistica,
                                            "anio", Anio,
                                            "trimestre", Trimestre);
        }
    }
}
