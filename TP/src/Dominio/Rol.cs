using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public class Rol
    {
        public static Rol rolSeleccionado;
        public String nombre;
        public byte id;

        public Rol(String nombre, byte id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public override String ToString()
        {
            return nombre;
        }

        public List<Funcionalidad> getFuncionalidades()
        {
            DataTable data = DB.correrFuncionDeTabla("ROL_GET_FUNCIONALIDADES", "rolId", id);

            return data.AsEnumerable()
                        .Select(fila => RepoFuncionalidades.get(fila.Field<byte>("cod_func")))
                        .ToList();
        }
    }
}
