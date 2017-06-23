using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Dominio
{
    public class Cliente : Usuario
    {
        public decimal codigoPostal;

        public Cliente(DataRow data)
        {
            New(data);
            habilitado = (Boolean)data["Cliente_Habilitado"];
            codigoPostal = (decimal)data["Codigo_Postal"];
        }

        public void editar()                                            // persisto los cambios
        {
            DB.correrProcedimiento("Cliente_UPDATE",
                                        "id", id,
                                         "nombre", nombre,
                                         "apellido", apellido,
                                         "dni", dni,
                                         "mail", mail,
                                         "telefono", telefono,
                                         "domicilio", domicilio,
                                         "fechaNac", fechaNac,
                                         "codigoPostal", codigoPostal,
                                         "habilitado", habilitado);
        }

        public static void nuevo(int id, decimal codigoPostal, Boolean habilitado)  // persisto un cliente nuevo
        {
            DB.correrProcedimiento("Cliente_NUEVO",
                                         "id", id,
                                         "codigoPostal", codigoPostal,
                                         "habilitado", habilitado);
        }

        public static void inhabilitar(int id)                                      // inhabilito el cliente
        {
            Usuario.inhabilitar("CLIENTE", id);
        }
    }
}
