using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Dominio {
  public class ReturningForm : Form {
    protected ReturningForm caller;

    public ReturningForm(ReturningForm caller) {
      this.caller = caller;
    }

    public ReturningForm() { }

    protected override void OnFormClosing(FormClosingEventArgs e) {
      base.OnFormClosing(e);
      caller.Show();
    }

    public void abrir() { // abro una ventana
      caller.Hide();  // oculta la que la llama
      Refrescar();  // actualizo la ventana
      ShowDialog();   // muestro la ventana y bloqueo la ejecución hasta que se cierra
      caller.Show();  // muesto la ventana que la llama
      caller.Refrescar(); // actualizo la ventana que la llama
    }

    public virtual void Refrescar() { // accion a ejecutar cada vez que muestro una ventana. No es abstract porque sino el visual studio no me cargaba bien las ventanas                 // para hacer override en ventanas que heredan
    }

  }
}
