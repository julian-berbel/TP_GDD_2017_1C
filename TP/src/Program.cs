using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio;
using UberFrba.Login;
using System.Configuration;
using System.Data.SqlClient;

namespace UberFrba
{
    static class Program
    {
        public static DateTime FechaEjecucion = DateTime.Parse(ConfigurationManager.AppSettings["FechaEjecucion"]);
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DB.miConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["UberFrba.Properties.Settings.GD1C2017ConnectionString"].ConnectionString);    // preparo conexion a base de datos
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());   // abro la ventana de login
        }
    }
}
