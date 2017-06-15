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
        protected ReturningForm caller;

        public ReturningForm(ReturningForm caller)
        {
            this.caller = caller;
        }

        public ReturningForm() { }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            caller.Show();
        }

        public void abrir()
        {
            caller.Hide();
            Refrescar();
            ShowDialog();
            caller.Show();
            caller.Refrescar();
        }

        public virtual void Refrescar()
        {
        }

    }
}
