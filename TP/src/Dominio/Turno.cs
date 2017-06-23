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

        public static DataTable getTurnosConFiltros(String descripcion)     // obtengo los turnos que cumplen con los filtros
        {
            return DB.correrFuncionDeTabla("GET_TURNOS_CON_FILTROS",
                                            "descripcion", descripcion);
        }

        public static List<Turno> getListaTurnos()                          // obtengo todos los turnos
        {
            return getTurnosConFiltros("")
                .AsEnumerable()
                .Select(fila => new Turno(fila))
                .ToList();
        }

        public static void inhabilitar(byte id)                             // inhabilito un turno
        {
            DB.correrProcedimiento("Turno_INHABILITAR",
                                    "id", id);
        }

        public void editar()                                                // persisto los cambios
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

        public void nuevo()                                                 // persisto un nuevo turno
        {
            DB.correrProcedimiento( "TURNO_NUEVO",
                                    "horaInicio", horaInicio,
                                    "horaFin", horaFin,
                                    "descripcion", descripcion,
                                    "valorKilometro", valorKilometro,
                                    "precioBase", precioBase,
                                    "habilitado", habilitado);
        }

        public static Turno get(byte id)                                    // obtengo un turno por id
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
