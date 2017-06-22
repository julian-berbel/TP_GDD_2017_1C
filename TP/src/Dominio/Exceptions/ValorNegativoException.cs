using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio.Exceptions
{
    public class ValorNegativoException : Exception
    {
        public ValorNegativoException(String valor)
            : base(valor + " debe ser un numero positivo!")
        { }
    }
}
