using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Dominio
{
    public class Automovil
    {
        public Chofer chofer;
        public String patente;
        public int licencia;
        public String rodado;
        public String modelo;
        public String marca;

        public Automovil(Chofer chofer,
                        String patente,
                        int licencia,
                        String rodado,
                        String modelo,
                        String marca){

            if (chofer == null) throw new CampoVacioException("Chofer");
            this.chofer = chofer;

            if (patente == null) throw new CampoVacioException("Patente");
            this.patente = patente;

            if (licencia == -1) throw new CampoVacioException("Licencia");
            this.licencia = licencia;

            if (rodado == null) throw new CampoVacioException("Rodado");
            this.rodado = rodado;

            if (modelo == null) throw new CampoVacioException("Modelo");
            this.modelo = modelo;

            if (marca == null) throw new CampoVacioException("Marca");
            this.marca = marca;
        }

        public static DataTable getAutomoviles()
        {
            return DB.correrQuery(@"SELECT *
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Vehiculo
                                        JOIN LOS_MODERADAMENTE_ADECUADOS.Modelo ON mode_id = vehi_modelo
                                        JOIN LOS_MODERADAMENTE_ADECUADOS.Marca ON marc_id = mode_marca");
        }

    }
}
