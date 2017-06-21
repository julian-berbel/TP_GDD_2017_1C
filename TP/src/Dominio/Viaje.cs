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
        public static void registrar(   int chofer, 
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

        public static DataTable getDeCliente(int idCliente, DateTime fecha)
        {
            return DB.correrFuncionDeTabla( "VIAJES_GET_DE_CLIENTE",
                                            "idCliente", idCliente,
                                            "fecha", fecha);
        }

        public static DataTable getDeChofer(int idChofer, DateTime fecha, byte idturno)
        {
            return DB.correrFuncionDeTabla("VIAJES_GET_DE_CHOFER",
                                            "idChofer", idChofer,
                                            "fecha", fecha,
                                            "turno", idturno);
        }
    }
}
