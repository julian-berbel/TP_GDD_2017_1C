using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public class Rendicion
    {
        public int numero;
        public DateTime fecha;
        public Turno turno;
        public decimal importeTotal;
        public decimal porcentaje;

        public Rendicion(DataRow data)
        {
            numero = (int)data["rend_numero"];
            fecha = (DateTime)data["rend_fecha"];
            turno = Turno.get((byte) data["rend_turno"]);
            importeTotal = (decimal)data["rend_importe_total"];
            porcentaje = (decimal)data["rend_porcentaje"];
        }

        public static DataTable get(int idCliente, DateTime fecha, byte turno)
        {
            return DB.correrFuncionDeTabla( "RENDICION_GET",
                                            "idCliente", idCliente,
                                            "fecha", fecha,
                                            "turno", turno);
        }

        public static DataTable getItems(int idRendicion)
        {
            return DB.correrFuncionDeTabla( "RENDICION_GET_VIAJES",
                                            "idRendicion", idRendicion);
        }

        public static void generar(int idChofer, DateTime fecha, byte turno, decimal importeTotal, decimal porcentaje)
        {
            DB.correrProcedimiento( "RENDICION_GENERAR",
                                    "idChofer", idChofer,
                                    "fecha", fecha,
                                    "turno", turno,
                                    "importeTotal", importeTotal,
                                    "porcentaje", porcentaje);
        }
    }
}
