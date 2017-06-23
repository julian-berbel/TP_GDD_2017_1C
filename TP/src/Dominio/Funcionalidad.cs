using System;
using System.Collections.Generic;
using System.Data;
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

        public void elegir(Form caller) // elijo una funcionalidad y abro su ventana correspondiente
        {
            ReturningForm ventana = (ReturningForm) Activator.CreateInstance(ventanaAAbrir, caller);
            ventana.abrir();
        }

        public override string ToString()
        {
            return descripcion;
        }

        public static DataTable getTablaDe(byte idRol)  // obtengo la tabla de funcionalidades de un rol
        {
            return DB.correrFuncionDeTabla( "FUNCIONALIDADES_GET_TABLA_DE_ROL",
                                            "idRol", idRol);
        }
    }
}
