using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UberFrba.Dominio
{
    static class DB
    {
        private static SqlConnection miConexion = new SqlConnection("user id=sa;" +
                                       "password=gestiondedatos;server=localhost\\SQLSERVER2012;" +
                                       "Trusted_Connection=yes;" +
                                       "database=GD1C2017; " +
                                       "connection timeout=10");

        private static String esquema = "[LOS_MODERADAMENTE_ADECUADOS].";
        
        private static String queryFuncion(String nombre, params object[] args)
        {
            String query = "SELECT " + esquema + nombre + "(";

            for (int i = 0; i < args.Length; i += 2)
            {
                query += (i == 0 ? "":",") + "@" + (string)args[i];
            }

            return query += ")";
        }

        private static String queryProcedimiento(String nombre)
        {
            return esquema + nombre;
        }

        private static SqlCommand nuevoComando(String query, params object[] args)
        {
            SqlCommand comando = new SqlCommand(query, miConexion);

            for (int i = 0; i < args.Length; i += 2)
            {
                comando.Parameters.AddWithValue("@" + (string)args[i], args[i + 1]);
            }

            return comando;
        }
        
        private static SqlCommand nuevoProcedimiento(String nombre, params object[] args)
        {
            String query = queryProcedimiento(nombre);

            SqlCommand comando = nuevoComando(query, args);

            comando.CommandType = CommandType.StoredProcedure;

            return comando;
        }

        private static SqlCommand nuevaFuncion(String nombre, params object[] args)
        {
            String query = queryFuncion(nombre, args);

            return nuevoComando(query, args);
        }

        public static Boolean correrProcedimiento(String nombre, params object[] args)
        {
            SqlCommand comando = nuevoProcedimiento(nombre, args);

            return ejecutarProcedimiento(comando);
        }

        public static object correrFuncion(String nombre, params object[] args)
        {
            SqlCommand comando = nuevaFuncion(nombre, args);

            return ejecutarFuncion(comando);
        }

        private static Boolean ejecutarProcedimiento(SqlCommand comando)
        {
            Boolean salioBien = true;
            try{
                miConexion.Open();
                comando.ExecuteNonQuery();
            } catch(SqlException exception){
                Error.show(exception.Message);
                salioBien = false;
            }
            miConexion.Close();
            return salioBien;
        }

        private static object ejecutarFuncion(SqlCommand comando)
        {
            object resultado = null;

            try
            {
                miConexion.Open();
                resultado = comando.ExecuteScalar();
            }
            catch (SqlException exception)
            {
                Error.show(exception.Message);
            }
            miConexion.Close();

            return resultado;
        }
    }
}
