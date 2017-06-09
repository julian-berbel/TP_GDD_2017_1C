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
        
        private static String queryFuncion(String prefijo, String nombre, params object[] args)
        {
            String query = prefijo + esquema + nombre + "(";

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

        private static SqlCommand nuevaFuncion(String prefijo, String nombre, params object[] args)
        {
            String query = queryFuncion(prefijo, nombre, args);

            return nuevoComando(query, args);
        }

        public static Boolean correrProcedimiento(String nombre, params object[] args)
        {
            SqlCommand comando = nuevoProcedimiento(nombre, args);

            return ejecutarProcedimiento(comando);
        }

        public static object correrFuncion(String nombre, params object[] args)
        {
            SqlCommand comando = nuevaFuncion("SELECT ", nombre, args);

            return ejecutarFuncion(comando);
        }

        public static DataTable correrFuncionDeTabla(String nombre, params object[] args)
        {
            SqlCommand comando = nuevaFuncion("SELECT * FROM ", nombre, args);

            return ejecutarFuncionDeTabla(comando);
        }

        private static Boolean ejecutarProcedimiento(SqlCommand comando)
        {
            Boolean salioBien = true;
            try{
                miConexion.Open();
                comando.ExecuteNonQuery();
            } catch (SqlException exception){
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
                miConexion.Close();
            }
            catch (SqlException exception)
            {
                Error.show(exception.Message);
            }

            return resultado;
        }

        private static DataTable ejecutarFuncionDeTabla(SqlCommand comando)
        {
            DataTable tabla = new DataTable();

            try
            {
                using(SqlDataAdapter adapter = new SqlDataAdapter(comando))
                {
                    miConexion.Open();
                    adapter.Fill(tabla);
                    miConexion.Close();
                }
            }
            catch (SqlException exception)
            {
                Error.show(exception.Message);
            }

            return tabla;
        }

        /*probando funciones*/

        public static DataTable realizarSelectComunacho(String nombre, params object[] campos)
        {
            String query = querySelect("SELECT ", nombre, campos);
            SqlCommand comando = new SqlCommand(query, miConexion);

            return ejecutarFuncionDeTabla(comando);
        }

        private static String querySelect(String prefijo, String nombreTabla, params object[] campos)
        {
            String query = prefijo;

            for(int i = 0; i < campos.Length; i++)
            {
                query += (string)campos[i] + (i == campos.Length - 1 ? " " : ", ");
            }

            return query += "FROM "+ esquema + nombreTabla;
        }
    }
}
