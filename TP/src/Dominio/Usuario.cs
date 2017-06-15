using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public class Usuario
    {
        public String nombre;
        public String apellido;
        public decimal dni;
        public int id;

        public Usuario(DataRow data)
        {
            nombre = (String)data["usua_nombre"];
            apellido = (String)data["usua_apellido"];
            dni = (decimal)data["usua_dni"];
            usuarioSeleccionadoId = (int)data["usua_id"];
        }

        public static DataRow get(int id)
        {
            return DB.correrFuncionDeTabla("USUARIO_GET",
                                    "usuarioId", id).Rows[0];
        }

        public static int? usuarioSeleccionadoId = null;

        public static byte cantidadDeRoles()
        {
            return (byte) DB.correrFuncion("USUARIO_CANTIDAD_DE_ROLES", "usuario", usuarioSeleccionadoId);
        }

        public static void cargar(String username)
        {
            usuarioSeleccionadoId = (int)DB.correrFuncion("GET_ID_USUARIO", "usuario", username);
        }

        public static List<Rol> getRoles()
        {
            DataTable data = DB.correrFuncionDeTabla("USUARIO_GET_ROLES", "usuarioId", usuarioSeleccionadoId);

            return data.AsEnumerable()
                        .Select(r => new Rol(r.Field<String>("rol_nombre"), r.Field<byte>("rol_id")))
                        .ToList();
        }

        public static DataTable getXsConFiltro( String X, // "CLIENTES" / "CHOFERES"
                                                String nombre,
                                                String apellido,
                                                decimal DNI)
        {
            return DB.correrFuncionDeTabla("GET_"+ X +"_CON_FILTROS",
                                            "nombre", nombre,
                                            "apellido", apellido,
                                            "DNI", DNI);
        }
    }
}