using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public static class Usuario
    {
        public static int? id = null;

        public static byte cantidadDeRoles()
        {
            return (byte) DB.correrFuncion("USUARIO_CANTIDAD_DE_ROLES", "usuario", id);
        }

        public static void cargar(String username)
        {
            id = (int)DB.correrFuncion("GET_ID_USUARIO", "usuario", username);
        }
    }
}
