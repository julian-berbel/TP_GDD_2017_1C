using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Dominio
{
    public class Chofer
    {
        public String nombre;
        public String apellido;
        public decimal dni;
        public int id;

        public Chofer(DataRow data)
        {
            nombre = (String)data["usua_nombre"];
            apellido = (String)data["usua_apellido"];
            dni = (decimal)data["usua_dni"];
            id = (int)data["usua_id"];
        }

        public static Chofer get(int id)
        {
            DataRow data = DB.correrFuncionDeTabla("USUARIO_GET",
                                    "usuarioId", id).Rows[0];

            return new Chofer(data);
        }

        public static DataTable getChoferes()
        {
            return DB.correrQuery(@"SELECT * 
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Chofer
                                        JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario ON chof_id = usua_id");
        }
    }
}
