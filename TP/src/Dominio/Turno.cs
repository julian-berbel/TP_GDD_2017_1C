using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public class Turno
    {
        public byte id;
        public decimal horaInicio;
        public decimal horaFin;
        public String descripcion;
        public decimal valorKilometro;
        public decimal precioBase;
        public Boolean habilitado;

        public Turno(DataRow data)
        {
            id = (byte)data["turn_id"];
            horaInicio = (decimal)data["Hora_Inicio"];
            horaFin = (decimal)data["Hora_Fin"];
            descripcion = (String)data["Descripcion"];
            valorKilometro = (decimal)data["Valor_Km"];
            precioBase = (decimal)data["Precio_Base"];
            habilitado = (Boolean)data["Habilitado"];
        }

        public Turno() { }

        public static DataTable getTurnosConFiltros(String descripcion)
        {
            return DB.correrFuncionDeTabla("GET_TURNOS_CON_FILTROS",
                                            "descripcion", descripcion);
        }

        public static List<Turno> getListaTurnos()
        {
            return getTurnosConFiltros("")
                .AsEnumerable()
                .Select(fila => new Turno(fila))
                .ToList();
        }

        public static void inhabilitar(byte id)
        {
            DB.correrProcedimiento("Turno_INHABILITAR",
                                    "id", id);
        }

        public void editar()
        {
            DB.correrProcedimiento( "TURNO_UPDATE",
                                    "id", id,
                                    "horaInicio", horaInicio,
                                    "horaFin", horaFin,
                                    "descripcion", descripcion,
                                    "valorKilometro", valorKilometro,
                                    "precioBase", precioBase,
                                    "habilitado", habilitado);
        }

        public void nuevo()
        {
            DB.correrProcedimiento( "TURNO_NUEVO",
                                    "horaInicio", horaInicio,
                                    "horaFin", horaFin,
                                    "descripcion", descripcion,
                                    "valorKilometro", valorKilometro,
                                    "precioBase", precioBase,
                                    "habilitado", habilitado);
        }

        public static Turno get(byte id)
        {
            DataRow fila = DB.correrFuncionDeTabla( "TURNO_GET",
                                                    "id", id).Rows[0];
            return new Turno(fila);
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
