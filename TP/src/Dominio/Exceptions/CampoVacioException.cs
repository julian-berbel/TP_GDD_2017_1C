using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio.Exceptions {
  public class CampoVacioException : Exception {
    public CampoVacioException(String campo)
      : base("El campo " + campo + " no puede estar vacío!"){ }
  }
}
