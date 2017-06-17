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
using UberFrba.SeleccionarFuncionalidad;
using UberFrba.SeleccionarRol;
using UberFrba.Usuarios;

namespace UberFrba.Login
{
    public partial class LoginForm : ReturningForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String usuario = textBoxUsuario.Text;

            byte[] contrasenia = Usuario.encriptar(textBoxContrasenia.Text);

            try {
                DB.correrProcedimiento("SPLOGIN", "usuario", usuario, "contrasenia", contrasenia);

                Usuario.cargar(usuario);

                int cantidadDeRoles = Usuario.cantidadDeRoles();

                if (cantidadDeRoles == 0) Error.show("El usuario seleccionado no tiene ningún rol asignado!");
                else if (cantidadDeRoles > 1)
                {
                    new SeleccionarRolForm(this).abrir();
                }
                else {
                    Rol.rolSeleccionado = Usuario.getRoles().First();
                    new SeleccionarFuncionalidadForm(this).abrir();
                }
            }
            catch (SqlException) { }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            new NuevoUsuarioForm(this).abrir();
        }
    }
}
