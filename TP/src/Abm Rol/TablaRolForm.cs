using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Abm_Rol
{
    public partial class TablaRolForm : ReturningForm
    {
        public TablaRolForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }

        public TablaRolForm() {
            InitializeComponent();
        }

        public DataGridView DataGridViewRol
        {
            get { return dataGridViewRol; }
        }

        public override void Refrescar()
        {
            CargarTabla();
            dataGridViewRol.Columns["rol_id"].Visible = false;
        }

        protected void CargarTabla()
        {
            dataGridViewRol.DataSource = Rol.getRoles();
        }
    }
}
