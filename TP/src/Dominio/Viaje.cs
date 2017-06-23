using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public static class Viaje
    {
        public static void registrar(   int chofer,     // registro un viaje
                                        int vehiculo, 
                                        int cliente, 
                                        int turno, 
                                        decimal kms,
                                        DateTime inicio,
                                        DateTime fin)
        {
            DB.correrProcedimiento( "REGISTRAR_VIAJE",
                                    "chofer", chofer,
                                    "vehiculo",  vehiculo,
                                    "cliente",  cliente,
                                    "turno",  turno,
                                    "kms", kms,
                                    "inicio", inicio,
                                    "fin", fin);
        }

        public static DataTable getDeCliente(int idCliente, DateTime fecha) // obtengo los viajes de un cliente en un mes determinado
        {
            return DB.correrFuncionDeTabla( "VIAJES_GET_DE_CLIENTE",
                                            "idCliente", idCliente,
                                            "fecha", fecha);
        }

        public static DataTable getDeChofer(int idChofer, DateTime fecha, byte idturno, decimal porcentaje) // obtengo los viajes de un chofer en una fecha y turno determinados
        {
            return DB.correrFuncionDeTabla("VIAJES_GET_DE_CHOFER",
                                            "idChofer", idChofer,
                                            "fecha", fecha,
                                            "turno", idturno,
                                            "porcentaje", porcentaje);
        }
    }
}
