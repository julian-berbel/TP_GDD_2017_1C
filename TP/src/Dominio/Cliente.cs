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
        public Cliente(DataRow data) : base(data)
        {
        }

        new public static Chofer get(int id)
        {
            return new Chofer(Usuario.get(id));
        }

        public static DataTable getClientes()
        {
            return DB.correrQuery(@"SELECT * 
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Cliente
                                        JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario ON clie_id = usua_id");
        }
        
    }
}
