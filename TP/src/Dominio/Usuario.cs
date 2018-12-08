using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio {
  public class Usuario {
    public int id;
    public String nombre;
    public String apellido;
    public decimal dni;
    public String mail;
    public decimal telefono;
    public String domicilio;
    public DateTime fechaNac;
    public Boolean habilitado;
    public String nombreDeUsuario;
    public byte[] contrasenia;

    public Usuario(DataRow data) {
      New(data);
      habilitado = (Boolean)data["Usuario_Habilitado"];
    }

    public Usuario() { }

    protected void New(DataRow data) {
      id = (int)data["usua_id"];
      nombre = (String)data["Nombre"];
      apellido = (String)data["Apellido"];
      dni = (decimal)data["DNI"];
      mail = (String)data["Mail"];
      telefono = (decimal)data["Telefono"];
      domicilio = (String)data["Domicilio"];
      fechaNac = (DateTime)data["Fecha_Nac"];
    }

    public static int? usuarioSeleccionado;
    
    public static byte[] encriptar(string texto) {  // encripto una contraseña
      return new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(texto), 0, Encoding.UTF8.GetByteCount(texto));
    }

    public static void cargar(String username) {    // cargo usuario seleccionado por username
      usuarioSeleccionado = (int)DB.correrFuncion("USUARIO_GET_ID", "usuario", username);
    }

    public static List<Rol> getRoles() {        // obtengo los roles del usuario seleccionado
      DataTable data = DB.correrFuncionDeTabla("USUARIO_GET_ROLES", "usuarioId", usuarioSeleccionado);

      return data.AsEnumerable()
            .Select(fila => new Rol(fila))
            .ToList();
    }

    public static DataTable getXsConFiltros(String X, // "CLIENTES" / "CHOFERES" / "USUARIOS" / "NO_CLIENTES" / "NO_CHOFERES"
                                            String nombre,
                                            String apellido,
                                            decimal DNI) {    // obtengo un tipo de usuarios que cumplen con los filtros
      return DB.correrFuncionDeTabla( "GET_"+ X +"_CON_FILTROS",
                                      "nombre", nombre,
                                      "apellido", apellido,
                                      "DNI", DNI);
    }

    public static DataTable getTablaRolXs(String X, // "CLIENTES" / "CHOFERES" / "USUARIOS" / "NO_CLIENTES" / "NO_CHOFERES"
                                          String nombre,
                                          String apellido,
                                          decimal DNI,
                                          byte rol) {       // obtengo un tipo de usuarios que cumplen con los filtros y tienen un rol determinado
      return DB.correrFuncionDeTabla( "GET_TABLA_ROL_" + X ,
                                      "nombre", nombre,
                                      "apellido", apellido,
                                      "DNI", DNI,
                                      "rol", rol);
    }
    
    public static void inhabilitar(String tipoDeUsuario, int id) {  // inhabilito un usuario
      DB.correrProcedimiento( tipoDeUsuario + "_INHABILITAR",
                              "id", id);
    }

    public void nuevo() {                       // persisto un usuario nuevo
      DB.correrProcedimiento( "USUARIO_NUEVO",
                              "nombre", nombre,
                              "apellido", apellido,
                              "dni", dni,
                              "mail", mail,
                              "telefono", telefono,
                              "domicilio", domicilio,
                              "fechaNac", fechaNac,
                              "nombreDeUsuario", nombreDeUsuario,
                              "contrasenia", contrasenia);
    }

    public static void rolUpdate(int idUsuario, byte idRol, Boolean habilitado) { // modifico el acceso de un usuario a un rol
      DB.correrProcedimiento( "USUARIO_ROL_UPDATE",
                              "idUsuario", idUsuario,
                              "idRol", idRol,
                              "habilitado", habilitado);
    }
  }
}
