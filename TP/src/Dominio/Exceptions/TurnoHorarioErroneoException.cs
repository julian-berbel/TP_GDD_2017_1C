using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio.Exceptions
{
    public class TurnoHorarioErroneoException : Exception
    {
        public TurnoHorarioErroneoException()
            : base("La hora de inicio debe ser menor a la hora de fin!")
        { }
    }
}
