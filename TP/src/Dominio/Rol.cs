using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public class Rol
    {
        public static Rol rolSeleccionado;
        public String nombre;
        public byte id;

        public Rol(String nombre, byte id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public override String ToString()
        {
            return nombre;
        }
    }
}
