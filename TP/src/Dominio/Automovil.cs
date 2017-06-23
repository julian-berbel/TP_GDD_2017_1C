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
        public Turno turno;
        public Boolean habilitado;

        public Automovil(DataRow data){
            id = (int)data["vehi_id"];
            chofer = Chofer.get((int)data["vehi_chofer"]);
            patente = (String)data["Patente"];
            licencia = (String)data["Licencia"];
            rodado = (String)data["Rodado"];
            modelo = (String)data["Modelo"];
            marca = (String)data["Marca"];
            turno = Turno.get((byte)data["vehi_turno"]);
            habilitado = (Boolean)data["Habilitado"];
        }

        public Automovil(){ }

        public static List<String> getMarcas()                                  // obtengo las marcas
        {
            return DB.correrQuery(@"SELECT marc_nombre
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Marca")
                    .AsEnumerable()
                    .Select(fila => fila.Field<string>("marc_nombre"))
                    .ToList();
        }

        public static DataTable getAutomovilesConFiltro(int choferId,           // obtengo los automoviles que cumplen con los filtros
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

        public void editar()                                                    // persisto los cambios
        {
            DB.correrProcedimiento("AUTOMOVIL_UPDATE",
                                        "automovilId", id,
                                        "chofer", chofer.id,
                                        "patente", patente,
                                        "licencia", licencia,
                                        "rodado", rodado,
                                        "modelo", modelo,
                                        "marca", marca,
                                        "turno", turno.id,
                                        "habilitado", habilitado);
        }

        public void nuevo()                                                     // persisto automovil nuevo
        {
            DB.correrProcedimiento("AUTOMOVIL_NUEVO",
                                        "chofer", chofer.id,
                                        "patente", patente,
                                        "licencia", licencia,
                                        "rodado", rodado,
                                        "modelo", modelo,
                                        "marca", marca,
                                        "turno", turno.id,
                                        "habilitado", habilitado);
        }

        public static void inhabilitar (int idAutomovil)                        // inhabilito automovil
        {
            DB.correrProcedimiento("AUTOMOVIL_INHABILITAR",
                                   "idAutomovil", idAutomovil);
        }

        public static Automovil getAutomovilDe(int idChofer)                    // obtengo el automovil de un chofer
        {
            DataRow fila = DB.correrFuncionDeTabla("AUTOMOVIL_GET_DE",
                                                    "idChofer", idChofer).Rows[0];

            return new Automovil(fila);
        }

    }
}
