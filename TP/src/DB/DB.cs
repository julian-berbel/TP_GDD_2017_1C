using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UberFrba.DB
{
    static class DB
    {
        public static SqlConnection myConnection = new SqlConnection("user id=sa;" +
                                       "password=gestiondedatos;server=localhost\\SQLSERVER2012;" +
                                       "Trusted_Connection=yes;" +
                                       "database=GD1C2017; " +
                                       "connection timeout=10");

        public static SqlDataReader ejecutarComando(SqlCommand comando)
        {
            myConnection.Open();
            SqlDataReader resultado = comando.ExecuteReader();
            myConnection.Close();
            return resultado;


        }

        public static object test()
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 usua_dni FROM [LOS_MODERADAMENTE_ADECUADOS].Usuario", myConnection);
            SqlDataReader resultado = ejecutarComando(command);
            return resultado;
        }
    }
}
