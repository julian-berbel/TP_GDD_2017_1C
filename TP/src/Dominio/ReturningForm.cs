using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Dominio
{
    public class ReturningForm : Form
    {
        protected Form caller;

        public ReturningForm(Form caller)
        {
            this.caller = caller;
        }

        public ReturningForm() { }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            caller.Show();
        }

        public virtual void Mostrar()
        {
            this.Show();
        }

    }
}
