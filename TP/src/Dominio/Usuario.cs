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
        public int id;
        public String nombre;
        public String apellido;
        public decimal dni;
        public String mail;
        public decimal telefono;
        public String domicilio;
        public DateTime fechaNac;
        public Boolean habilitado;

        public Usuario(DataRow data)
        {
            id = (int)data["usua_id"];
            nombre = (String)data["Nombre"];
            apellido = (String)data["Apellido"];
            dni = (decimal)data["DNI"];
            mail = (String)data["Mail"];
            telefono = (decimal)data["Telefono"];
            domicilio = (String)data["Domicilio"];
            fechaNac = (DateTime)data["Fecha_Nac"];
            habilitado = (Boolean)data["Habilitado"];
        }

        public Usuario() { }

        public static Usuario get(int id)
        {
            return new Usuario(DB.correrFuncionDeTabla("USUARIO_GET",
                                                        "id", id).Rows[0]);
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
                                                decimal DNI,
                                                byte rolAFiltrar)
        {
            return DB.correrFuncionDeTabla("GET_"+ X +"_CON_FILTROS",
                                            "nombre", nombre,
                                            "apellido", apellido,
                                            "DNI", DNI,
                                            "rolAFiltrar", rolAFiltrar);
        }
    }
}