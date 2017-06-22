using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio.Exceptions
{
    public class HorarioSeleccionadoFueraDeTurnoException : Exception
    {
        public HorarioSeleccionadoFueraDeTurnoException(Turno turno)
            : base("El horario seleccionado se encuentra fuera del horario del turno. El turno seleccionado es de " 
                  + turno.horaInicio + " a " + turno.horaFin + "hs.")
        { }
    }
}
