using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public class Chofer
    {
        public String nombre;
        public String apellido;
        public decimal dni;
        public int id;

        public Chofer(String nombre, String apellido, decimal dni, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.id = id;
        }

        public static Chofer get(int id)
        {
            DataTable data = DB.correrFuncionDeTabla("USUARIO_GET",
                                    "usuarioId", id);

            return data.AsEnumerable()
                    .Select(fila => new Chofer( fila.Field<String>("usua_nombre"),
                                                fila.Field<String>("usua_apellido"),
                                                fila.Field<decimal>("usua_dni"),
                                                id))
                    .First();
        }
    }
}
