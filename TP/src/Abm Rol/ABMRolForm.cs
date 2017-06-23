using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Rol
{
    public partial class ABMRolForm : ReturningForm
    {
        public ABMRolForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        public ABMRolForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            new EditarRolForm(this).abrir();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)dataGridViewRol.SelectedRows[0].DataBoundItem).Row;    // obtengo fila seleccionada
            new EditarRolForm(this, new Rol(fila)).abrir();                                     // creo rol a partir de la fila y se lo paso a la ventana de edicion
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            Rol.inhabilitar((byte)dataGridViewRol.SelectedRows[0].Cells["rol_id"].Value);       // obtengo id del rol seleccionado y lo inhabilito
            CargarTabla();
        }

        public override void Refrescar()
        {
            CargarTabla();
            dataGridViewRol.Columns["rol_id"].Visible = false;                                  // oculto columna que no quiero mostrar
        }

        protected void CargarTabla()
        {
            dataGridViewRol.DataSource = Rol.getRoles();
        }

        private void buttonAsignar_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataRowView)dataGridViewRol.SelectedRows[0].DataBoundItem).Row;        // obtengo fila seleccionada
            Rol rol = new Rol(fila);                                                                // creo rol a partir de la fila
            if (!rol.habilitado) {                                                                  // si esta deshabilitado...
                Error.show("No se puede asignar usuarios a un rol inhabilitado!");
                return;
            }
            new AsignarRolForm(this, rol).abrir();                                                  // se lo paso a la ventana de asignar rol
        }
    }
}
