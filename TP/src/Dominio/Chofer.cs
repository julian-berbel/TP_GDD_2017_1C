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
        public int dni;
        public int id;

        public Chofer(String nombre, String apellido, int dni, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.id = id;
        }

        public static Chofer get(int id)
        {
            DataTable data = DB.correrFuncionDeTabla("CHOFER_GET",
                                    "id", id);

            return data.AsEnumerable()
                    .Select(fila => new Chofer( fila.Field<String>("usua_nombre"),
                                                fila.Field<String>("chof_nombre"),
                                                fila.Field<int>("usua_dni"),
                                                id))
                    .First();
        }
    }
}
