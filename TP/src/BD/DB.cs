using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using UberFrba.Dominio;

namespace UberFrba.BD
{
    static class DB
    {
        public static SqlConnection miConexion = new SqlConnection("user id=sa;" +
                                       "password=gestiondedatos;server=localhost\\SQLSERVER2012;" +
                                       "Trusted_Connection=yes;" +
                                       "database=GD1C2017; " +
                                       "connection timeout=10");

        public static void correrProcedimiento(String nombre, params object[] args)
        {
            SqlCommand comando = new SqlCommand("LOS_MODERADAMENTE_ADECUADOS." + nombre, miConexion);

            comando.CommandType = CommandType.StoredProcedure;

            for(int i = 0; i < args.Length; i += 2)
            {
                comando.Parameters.AddWithValue("@" + (string)args[i], args[i+1]);
            }

            ejecutarComando(comando);
        }

        public static void ejecutarComando(SqlCommand comando)
        {
            try{
                miConexion.Open();
                comando.ExecuteNonQuery();
            } catch(SqlException exception){
                Error.show(exception.Message);
                miConexion.Close();
                throw exception;
            }
            miConexion.Close();
        }
    }
}
