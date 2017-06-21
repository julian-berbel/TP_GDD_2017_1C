using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio.Exceptions
{
    public class KilometrosNegativosException : Exception
    {
        public KilometrosNegativosException()
            : base("La cantidad de kilómetros debe ser mayor a 0!")
        { }
    }
}
