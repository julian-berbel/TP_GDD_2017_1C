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
            funcionalidades = Funcionalidad.getTablaDe(0);                      // ninguna funcionalidad asignada
            dataGridViewFuncionalidades.DataSource = funcionalidades;           
            dataGridViewFuncionalidades.Columns["func_id"].Visible = false;     // oculto columna que no quiero mostrar
            dataGridViewFuncionalidades.Columns["Descripcion"].ReadOnly = true; // seteo columna que no quiero que sea editable como de solo lectura
        }

        public EditarRolForm(ReturningForm caller, Rol rolAEditar) : base(caller)
        {
            edicion = true;
            this.rolAEditar = rolAEditar;
            InitializeComponent();
            funcionalidades = Funcionalidad.getTablaDe(rolAEditar.id);          // cargo la tabla de funcionalidades del rol
            dataGridViewFuncionalidades.DataSource = funcionalidades;
            dataGridViewFuncionalidades.Columns["func_id"].Visible = false;     // oculto columna que no quiero mostrar
            dataGridViewFuncionalidades.Columns["Descripcion"].ReadOnly = true; // seteo columna que no quiero que sea editable como de solo lectura

            Nombre = rolAEditar.nombre;                                         // cargo los campos con los datos del rol
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
                validar();                                              // valido los datos ingresados
                rolAEditar.nombre = Nombre;                             // edito el rol
                rolAEditar.detalle = Descripcion;
                rolAEditar.habilitado = Habilitado;

                if (edicion)
                {
                    rolAEditar.editar(funcionalidades);                 // persisto los cambios
                }
                else
                {
                    rolAEditar.nuevo(funcionalidades);                  // persisto el nuevo rol
                }
                this.Close();
            }
            catch (CampoVacioException exception)
            {
                Error.show(exception.Message);
            }
        }

        private void validar()                                          // valido los datos ingresados
        {
            if (string.IsNullOrWhiteSpace(Nombre)) throw new CampoVacioException("Nombre");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
