using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio.Exceptions
{
    public class UsuarioNoSeleccionadoException : Exception
    {
        public UsuarioNoSeleccionadoException()
            : base("Debe Seleccionar un usuario para dar de alta como chofer!")
        { }
    }
}
