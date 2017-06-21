using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio;
using UberFrba.Dominio.Exceptions;

namespace UberFrba.Abm_Rol
{
    public partial class EditarRolForm : ReturningForm
    {

        private Boolean edicion = false;
        private Rol rolAEditar = null;
        private DataTable funcionalidades;

        public EditarRolForm(ReturningForm caller) : base(caller)
        {
            rolAEditar = new Rol();
            InitializeComponent();
            funcionalidades = Funcionalidad.getTablaDe(0);
            dataGridViewFuncionalidades.DataSource = funcionalidades;
            dataGridViewFuncionalidades.Columns["Descripcion"].ReadOnly = true;
        }

        public EditarRolForm(ReturningForm caller, Rol rolAEditar) : base(caller)
        {
            edicion = true;
            this.rolAEditar = rolAEditar;
            InitializeComponent();
            funcionalidades = Funcionalidad.getTablaDe(rolAEditar.id);
            dataGridViewFuncionalidades.DataSource = funcionalidades;
            dataGridViewFuncionalidades.Columns["func_id"].Visible = false;
            dataGridViewFuncionalidades.Columns["Descripcion"].ReadOnly = true;

            Nombre = rolAEditar.nombre;
            Descripcion = rolAEditar.detalle;
            Habilitado = rolAEditar.habilitado;
        }


        internal String Nombre
        {
            get
            {
                return textBoxNombre.Text;
            }

            set
            {
                textBoxNombre.Text = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return textBoxDescripcion.Text;
            }

            set
            {
                textBoxDescripcion.Text = value;
            }
        }

        public Boolean Habilitado
        {
            get
            {
                return checkBoxHabilitado.Checked;
            }

            set
            {
                checkBoxHabilitado.Checked = value;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();
                rolAEditar.nombre = Nombre;
                rolAEditar.detalle = Descripcion;
                rolAEditar.habilitado = Habilitado;

                if (edicion)
                {
                    rolAEditar.editar(funcionalidades);
                }
                else
                {
                    rolAEditar.nuevo(funcionalidades);
                }
                this.Close();
            }
            catch (CampoVacioException exception)
            {
                Error.show(exception.Message);
            }
        }

        private void validar()
        {
            if (string.IsNullOrWhiteSpace(Nombre)) throw new CampoVacioException("Nombre");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
