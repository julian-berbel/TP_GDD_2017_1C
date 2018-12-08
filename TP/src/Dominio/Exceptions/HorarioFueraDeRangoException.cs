using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio.Exceptions {
  public class HorarioFueraDeRangoException : Exception {
    public HorarioFueraDeRangoException()
      : base("Las horas de inicio y de fin deben estar entre 0 y 24!") { }
  }
}
