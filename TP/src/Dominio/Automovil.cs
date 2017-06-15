using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Dominio
{
    public class Automovil
    {
        public int id;
        public Chofer chofer;
        public String patente;
        public String licencia;
        public String rodado;
        public String modelo;
        public String marca;

        public Automovil(DataRow data){
            id = (int)data["vehi_id"];
            chofer = Chofer.get((int)data["vehi_chofer"]);
            patente = (String)data["vehi_patente"];
            licencia = (String)data["vehi_licencia"];
            rodado = (String)data["vehi_rodado"];
            modelo = (String)data["mode_codigo"];
            marca = (String)data["marc_nombre"];
        }

        public Automovil(){ }

        public static DataTable getAutomoviles()
        {
            return DB.correrQuery(@"SELECT  vehi_id, 
                                            vehi_chofer, 
                                            vehi_patente,
                                            vehi_licencia,
                                            vehi_rodado,
                                            vehi_habilitado,
                                            mode_codigo,
                                            marc_nombre
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Vehiculo
                                        JOIN LOS_MODERADAMENTE_ADECUADOS.Modelo ON mode_id = vehi_modelo
                                        JOIN LOS_MODERADAMENTE_ADECUADOS.Marca ON marc_id = mode_marca");
        }

        public static List<String> getMarcas()
        {
            return DB.correrQuery(@"SELECT marc_nombre
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Marca")
                    .AsEnumerable()
                    .Select(fila => fila.Field<string>("marc_nombre"))
                    .ToList();
        }

        public static DataTable getAutomovilesConFiltro(int choferId,
                                                String modelo,
                                                String patente,
                                                String marca)
        {
            return DB.correrFuncionDeTabla("GET_AUTOS_CON_FILTROS",
                                            "modelo", modelo,
                                            "patente", patente,
                                            "marca", marca,
                                            "choferID", choferId);
        }

        public void editar()
        {
            DB.correrProcedimiento("AUTOMOVIL_UPDATE",
                                        "automovilId", id,
                                        "chofer", chofer.id,
                                        "patente", patente,
                                        "licencia", licencia,
                                        "rodado", rodado,
                                        "modelo", modelo,
                                        "marca", marca);
        }

        public void nuevo()
        {
            DB.correrProcedimiento("AUTOMOVIL_NUEVO",
                                        "chofer", chofer.id,
                                        "patente", patente,
                                        "licencia", licencia,
                                        "rodado", rodado,
                                        "modelo", modelo,
                                        "marca", marca);
        }

    }
}
