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
        public byte id;
        public String nombre;
        public String detalle;
        public Boolean habilitado;

        public Rol(DataRow data)
        {
            id = (byte)data["rol_id"];
            nombre = (String)data["Nombre"];
            detalle = (String)data["Descripcion"];
            habilitado = (Boolean)data["Habilitado"];
        }

        public Rol() { }

        public override String ToString()
        {
            return nombre;
        }

        public List<Funcionalidad> getFuncionalidades()
        {
            DataTable data = DB.correrFuncionDeTabla("ROL_GET_FUNCIONALIDADES", "rolId", id);

            return data.AsEnumerable()
                        .Select(fila => RepoFuncionalidades.get((byte)fila["cod_func"]))
                        .ToList();
        }

        public static DataTable getRoles()
        {
            return DB.correrQuery(@"SELECT  rol_id,
                                            rol_nombre AS Nombre,
                                            rol_detalle AS Descripcion, 
                                            rol_habilitado AS Habilitado
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Rol");
        }

        public static void inhabilitar(byte id)
        {
            DB.correrProcedimiento("ROL_INHABILITAR",
                                    "rol", id);
        }

        public void editar()
        {
            DB.correrProcedimiento( "ROL_UPDATE",
                                    "id", id,
                                    "nombre", nombre,
                                    "detalle", detalle,
                                    "habilitado", habilitado);
        }

        public void nuevo()
        {
            DB.correrProcedimiento( "ROL_NUEVO",
                                    "nombre", nombre,
                                    "detalle", detalle,
                                    "habilitado", habilitado);
        }
    }
}
