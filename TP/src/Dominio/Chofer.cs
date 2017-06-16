using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Dominio
{
    public class Chofer : Usuario
    {
        public Chofer(DataRow data): base(data)
        {
        }

        public Chofer() {}

        new public static Chofer get(int id)
        {
            return new Chofer(DB.correrFuncionDeTabla("CHOFER_GET",
                                                        "id", id).Rows[0]);
        }

        public void editar()
        {
            DB.correrProcedimiento("CHOFER_UPDATE",
                                        "id", id,
                                         "nombre", nombre,
                                         "apellido", apellido,
                                         "dni", dni,
                                         "mail", mail,
                                         "telefono", telefono,
                                         "domicilio", domicilio,
                                         "fechaNac", fechaNac,
                                         "habilitado", habilitado);
        }

        public static void nuevo(int id, Boolean habilitado)
        {
            DB.correrProcedimiento("CHOFER_NUEVO",
                                         "id", id,
                                         "habilitado", habilitado);
        }
    }
}

