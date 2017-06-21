using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Rol
{
    public partial class AsignarRolForm : UberFrba.Usuarios.TablaUsuarioForm
    {
        private Rol rolAAsignar;
        public AsignarRolForm(ReturningForm caller, Rol rolAAsignar) : base(caller)
        {
            InitializeComponent();
            DataGridViewUsuario.ReadOnly = false;
            this.rolAAsignar = rolAAsignar;
            DataGridViewUsuario.CellValueChanged += new DataGridViewCellEventHandler(this.cellValueChanged);

            switch (rolAAsignar.id)
            {
                case 2:
                    _usuariosABuscar = "CLIENTES";
                    break;
                case 3:
                    _usuariosABuscar = "CHOFERES";
                    break;
                default:
                    _usuariosABuscar = "USUARIOS";
                    break;
            }
        }

        protected override void CargarTabla()
        {
            DataGridViewUsuario.DataSource = Usuario.getTablaRolXs(usuariosABuscar(),
                                                                    Nombre,
                                                                    Apellido,
                                                                    DNI,
                                                                    rolAAsignar.id);
            DataGridViewUsuario.Columns["Nombre"].ReadOnly = true;
            DataGridViewUsuario.Columns["Apellido"].ReadOnly = true;
            DataGridViewUsuario.Columns["DNI"].ReadOnly = true;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void cellValueChanged(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)DataGridViewUsuario.SelectedRows[0].DataBoundItem).Row;
            Usuario.rolUpdate((int) fila["usua_id"], rolAAsignar.id, (Boolean) fila["Habilitado"]);
        }
    }
}
