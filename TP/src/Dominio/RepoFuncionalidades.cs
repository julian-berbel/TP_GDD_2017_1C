using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public static class RepoFuncionalidades
    {
        public static List<Funcionalidad> repoFuncionalidades = new List<Funcionalidad>() { new Funcionalidad(1, typeof(Abm_Rol.ABMRolForm)) };

        public static Funcionalidad get(byte idFuncionalidad)
        {
            return repoFuncionalidades.Find(f => f.id == idFuncionalidad);
        }
    }
}
