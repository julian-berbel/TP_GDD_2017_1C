using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public static class RepoFuncionalidades
    {
        public static List<Funcionalidad> repoFuncionalidades = new List<Funcionalidad>() {
            new Funcionalidad(1, typeof(Abm_Rol.ABMRolForm)),
            new Funcionalidad(2, typeof(Abm_Cliente.ABMClienteForm)),
            new Funcionalidad(3, typeof(Abm_Automovil.ABMAutomovilForm)),
            new Funcionalidad(4, typeof(Abm_Turno.ABMTurnoForm)),
            new Funcionalidad(5, typeof(Abm_Chofer.ABMChoferForm)),
            new Funcionalidad(6, typeof(Registro_Viajes.RegistroViajeForm)),
            new Funcionalidad(7, typeof(Facturacion.FacturacionForm)),
            new Funcionalidad(8, typeof(Listado_Estadistico.ListadoEstadisticoForm))};

        public static Funcionalidad get(byte idFuncionalidad)
        {
            return repoFuncionalidades.Find(f => f.id == idFuncionalidad);
        }
    }
}
