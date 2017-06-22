using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio.Exceptions
{
    public class FechaDeFinAnteriorAFechaDeInicioException : Exception
    {
        public FechaDeFinAnteriorAFechaDeInicioException()
            : base("La hora de fin debe ser posterior a la hora de inicio!")
        { }
    }
}
