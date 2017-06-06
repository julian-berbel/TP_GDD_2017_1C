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
using UberFrba.BD;

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

            try
            {
                DB.correrProcedimiento("SPLOGIN", "usuario", usuario, "contrasenia", contrasenia);

                Debug.WriteLine("Login Exitoso!");
            }
            catch (Exception) { }
        }

        private byte[] getHashSha256(string texto)
        {
            SHA256Managed crypt = new SHA256Managed();
            return crypt.ComputeHash(Encoding.UTF8.GetBytes(texto), 0, Encoding.UTF8.GetByteCount(texto));
        }
    }
}
