using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Dominio
{
    public class Funcionalidad
    {
        public byte id;
        public String descripcion;
        public Type ventanaAAbrir;

        public Funcionalidad(byte id, Type ventanaAAbrir)
        {
            this.id = id;
            this.descripcion = (String)DB.correrFuncion("FUNCIONALIDAD_GET_DESCRIPCION", "funcionalidadId", id);
            this.ventanaAAbrir = ventanaAAbrir;
        }

        public void elegir(Form caller)
        {
            ReturningForm ventana = (ReturningForm) Activator.CreateInstance(ventanaAAbrir, caller);
            ventana.Mostrar();
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
