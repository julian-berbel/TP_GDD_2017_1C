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

        new public static Chofer get(int id)
        {
            return new Chofer(Usuario.get(id));
        }

        public static DataTable getChoferes()
        {
            return DB.correrQuery(@"SELECT * 
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Chofer
                                        JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario ON chof_id = usua_id");
        }
        
    }
}

