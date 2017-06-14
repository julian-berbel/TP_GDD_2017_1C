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

namespace UberFrba.Abm_Chofer
{
    public partial class TablaChoferForm : ReturningForm
    {
        public TablaChoferForm(Form caller) : base(caller)
        {
            InitializeComponent();
        }

        public TablaChoferForm()
        {
            InitializeComponent();
        }
    }
}
