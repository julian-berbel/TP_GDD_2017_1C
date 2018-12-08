using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UberFrba.Dominio {
  static class DB {
    public static SqlConnection miConexion;

    private static String esquema = "[LOS_MODERADAMENTE_ADECUADOS].";
    
    private static String queryFuncion(String prefijo, String nombre, params object[] args) { // creo el query de una funcion
      String query = prefijo + esquema + nombre + "(";

      for (int i = 0; i < args.Length; i += 2) {
        query += (i == 0 ? "":",") + "@" + (string)args[i];
      }

      return query += ")";
    }

    private static String queryProcedimiento(String nombre) {                 // creo el query de un procedimiento
      return esquema + nombre;
    }

    private static SqlCommand nuevoComando(String query, params object[] args) {        // creo el comando y agrego los parametros
      SqlCommand comando = new SqlCommand(query, miConexion);

      for (int i = 0; i < args.Length; i += 2) {
        comando.Parameters.AddWithValue("@" + (string)args[i], args[i + 1]);
      }

      return comando;
    }
    
    public static SqlCommand nuevoProcedimiento(String nombre, params object[] args) {    // creo un comando de procedimiento
      String query = queryProcedimiento(nombre);

      SqlCommand comando = nuevoComando(query, args);

      comando.CommandType = CommandType.StoredProcedure;

      return comando;
    }

    private static SqlCommand nuevaFuncion(String prefijo, String nombre, params object[] args) { // creo un comando de funcion
      String query = queryFuncion(prefijo, nombre, args);

      return nuevoComando(query, args);
    }

    public static void correrProcedimiento(String nombre, params object[] args) {         // creo y ejecuto un procedimiento
      SqlCommand comando = nuevoProcedimiento(nombre, args);

      ejecutarProcedimiento(comando);
    }

    public static object correrFuncion(String nombre, params object[] args) {           // creo y ejecuto una funcion escalar
      SqlCommand comando = nuevaFuncion("SELECT ", nombre, args);

      return ejecutarFuncion(comando);
    }

    public static DataTable correrFuncionDeTabla(String nombre, params object[] args) {       // creo y ejecuto una funcion de tabla
      SqlCommand comando = nuevaFuncion("SELECT * FROM ", nombre, args);

      return ejecutarComandoDeTabla(comando);
    }

    public static DataTable correrQuery(String query) {                       // creo y ejecuto un query
      SqlCommand comando = new SqlCommand(query, miConexion);

      return ejecutarComandoDeTabla(comando);
    }

    public static void ejecutarProcedimiento(SqlCommand comando) {  // ejecuto un procedimiento
      try{
        miConexion.Open();
        comando.ExecuteNonQuery();
      } catch (SqlException exception){
        miConexion.Close();
        Error.show(exception.Message);
        throw;
      }

      miConexion.Close();
    }

    private static object ejecutarFuncion(SqlCommand comando) {   // ejecuto una funcion
      object resultado = null;

      try {
        miConexion.Open();
        resultado = comando.ExecuteScalar();
      }
      catch (SqlException exception) {
        miConexion.Close();
        Error.show(exception.Message);
        throw;
      }

      miConexion.Close();
      return resultado;
    }
    
    private static DataTable ejecutarComandoDeTabla(SqlCommand comando) { // ejecuto una funcion de tabla o un query
      DataTable tabla = new DataTable();

      try {
        using(SqlDataAdapter adapter = new SqlDataAdapter(comando)) {
          miConexion.Open();
          adapter.Fill(tabla);
        }
      }
      catch (SqlException exception) {
        miConexion.Close();
        Error.show(exception.Message);
        throw;
      }

      miConexion.Close();
      return tabla;
    }

  }
}
