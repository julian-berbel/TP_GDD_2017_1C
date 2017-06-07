using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String usuario = textBoxUsuario.Text;

            byte[] contrasenia = getHashSha256(textBoxContrasenia.Text);

            if (DB.correrProcedimiento("SPLOGIN", "usuario", usuario, "contrasenia", contrasenia))
            {
                Usuario.cargar(usuario);

                int cantidadDeRoles = Usuario.cantidadDeRoles();

                if (cantidadDeRoles == 0) Error.show("El usuario seleccionado no tiene ningún rol asignado!");
                else if (cantidadDeRoles > 1){
                    Error.show("mas de uno!");
                }else{
                    Error.show("uno!");
                }
            }
        }

        private byte[] getHashSha256(string texto)
        {
            return new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(texto), 0, Encoding.UTF8.GetByteCount(texto));
        }
    }
}
