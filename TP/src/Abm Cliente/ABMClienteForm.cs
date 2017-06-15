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

namespace UberFrba.Abm_Cliente
{
    public partial class ABMClienteForm : ReturningForm
    {
        public ABMClienteForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }
    }
}
