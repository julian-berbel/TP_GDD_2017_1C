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

namespace UberFrba.SeleccionarFuncionalidad
{
    public partial class SeleccionarFuncionalidadForm : ReturningForm
    {
        public SeleccionarFuncionalidadForm(Form caller)
        {
            this.caller = caller;
            InitializeComponent();
        }
    }
}
