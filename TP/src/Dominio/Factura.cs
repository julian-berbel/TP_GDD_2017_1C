using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public class Factura
    {
        public int numero;
        public DateTime fechaInicio;
        public DateTime fechaFin;
        public decimal importeTotal;

        public Factura(DataRow data)
        {
            numero = (int)data["fact_numero"];
            fechaInicio = (DateTime)data["fact_fecha_inicio"];
            fechaFin = (DateTime)data["fact_fecha_fin"];
            importeTotal = (decimal)data["fact_importe_total"];
        }

        public static DataTable get(int idCliente, DateTime fecha)  // obtengo una factura
        {
            return DB.correrFuncionDeTabla( "FACTURA_GET",
                                            "idCliente", idCliente,
                                            "fecha", fecha);
        }

        public static DataTable getItems(int idFactura)             // obtengo los viajes de una factura
        {
            return DB.correrFuncionDeTabla( "FACTURA_GET_VIAJES",
                                            "idFactura", idFactura);
        }

        public static void generar(int idCliente, DateTime fechaInicio, DateTime fechaFin, decimal importeTotal)    // genero una factura
        {
            DB.correrProcedimiento( "FACTURA_GENERAR",
                                    "idCliente", idCliente,
                                    "fechaInicio", fechaInicio,
                                    "fechaFin", fechaFin,
                                    "importeTotal", importeTotal);
        }
    }
}
