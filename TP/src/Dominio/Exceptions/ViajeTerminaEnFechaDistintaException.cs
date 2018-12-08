using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio.Exceptions {
  public class ViajeTerminaEnFechaDistintaException : Exception {
    public ViajeTerminaEnFechaDistintaException()
      : base("El viaje debe empezar y finalizar en la misma fecha") { }
  }
}
