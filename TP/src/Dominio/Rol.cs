using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio {
  public class Rol {
    public static Rol rolSeleccionado;
    public byte id;
    public String nombre;
    public String detalle;
    public Boolean habilitado;

    public Rol(DataRow data) {
      id = (byte)data["rol_id"];
      nombre = (String)data["Nombre"];
      detalle = (String)data["Descripcion"];
      habilitado = (Boolean)data["Habilitado"];
    }

    public Rol() { }

    public override String ToString() {
      return nombre;
    }

    public List<Funcionalidad> getFuncionalidades() { // obtengo las funcionalidades de un rol
      DataTable data = DB.correrFuncionDeTabla("ROL_GET_FUNCIONALIDADES", "rolId", id);

      return data.AsEnumerable()
            .Select(fila => RepoFuncionalidades.get((byte)fila["cod_func"]))
            .ToList();
    }

    public static DataTable getRoles() {        // obtengo todos los roles
      return DB.correrQuery(@"SELECT  rol_id,
                                      rol_nombre AS Nombre,
                                      rol_detalle AS Descripcion, 
                                      rol_habilitado AS Habilitado
                              FROM LOS_MODERADAMENTE_ADECUADOS.Rol");
    }

    public static void inhabilitar(byte id) {     // inhabilito un rol
      DB.correrProcedimiento("ROL_INHABILITAR",
                  "rol", id);
    }

    public void editar(DataTable funcionalidades) {                       // persisto los cambios

      SqlCommand comando = DB.nuevoProcedimiento( "ROL_UPDATE",
                                                  "id", id,
                                                  "nombre", nombre,
                                                  "detalle", detalle,
                                                  "habilitado", habilitado);
      SqlParameter parametroFuncionalidades = new SqlParameter("@funcionalidades", SqlDbType.Structured); // dado que uno de los parametros es una tabla tengo que hacer un poco de magia
      parametroFuncionalidades.TypeName = "LOS_MODERADAMENTE_ADECUADOS.TABLA_ROL_X_FUNCIONALIDAD";
      parametroFuncionalidades.Value = funcionalidades;
      comando.Parameters.Add(parametroFuncionalidades);
      DB.ejecutarProcedimiento(comando);
    }

    public void nuevo(DataTable funcionalidades) {                       // persisto el nuevo rol
      SqlCommand comando = DB.nuevoProcedimiento( "ROL_NUEVO",
                                                  "nombre", nombre,
                                                  "detalle", detalle,
                                                  "habilitado", habilitado);
      SqlParameter parametroFuncionalidades = new SqlParameter("@funcionalidades", SqlDbType.Structured); // dado que uno de los parametros es una tabla tengo que hacer un poco de magia
      parametroFuncionalidades.TypeName = "LOS_MODERADAMENTE_ADECUADOS.TABLA_ROL_X_FUNCIONALIDAD";
      parametroFuncionalidades.Value = funcionalidades;
      comando.Parameters.Add(parametroFuncionalidades);
      DB.ejecutarProcedimiento(comando);
    }
  }
}
