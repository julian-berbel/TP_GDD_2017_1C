﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public class Usuario
    {
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

        public Usuario(DataRow data)
        {
            id = (int)data["usua_id"];
            nombre = (String)data["Nombre"];
            apellido = (String)data["Apellido"];
            dni = (decimal)data["DNI"];
            mail = (String)data["Mail"];
            telefono = (decimal)data["Telefono"];
            domicilio = (String)data["Domicilio"];
            fechaNac = (DateTime)data["Fecha_Nac"];
            habilitado = (Boolean)data["Habilitado"];
        }

        public Usuario() { }

        public static Usuario get(int id)
        {
            return new Usuario(DB.correrFuncionDeTabla("USUARIO_GET",
                                                        "id", id).Rows[0]);
        }

        public static int? usuarioSeleccionado;

        public static byte cantidadDeRoles()
        {
            return (byte) DB.correrFuncion("USUARIO_CANTIDAD_DE_ROLES", "usuario", usuarioSeleccionado);
        }

        public static byte[] encriptar(string texto)
        {
            return new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(texto), 0, Encoding.UTF8.GetByteCount(texto));
        }

        public static void cargar(String username)
        {
            usuarioSeleccionado = (int)DB.correrFuncion("USUARIO_GET_ID", "usuario", username);
        }

        public static List<Rol> getRoles()
        {
            DataTable data = DB.correrFuncionDeTabla("USUARIO_GET_ROLES", "usuarioId", usuarioSeleccionado);

            return data.AsEnumerable()
                        .Select(fila => new Rol(fila))
                        .ToList();
        }

        public static DataTable getXsConFiltros( String X, // "CLIENTES" / "CHOFERES" / "USUARIOS" / "NO_CLIENTES" / "NO_CHOFERES"
                                                String nombre,
                                                String apellido,
                                                decimal DNI)
        {
            return DB.correrFuncionDeTabla("GET_"+ X +"_CON_FILTROS",
                                            "nombre", nombre,
                                            "apellido", apellido,
                                            "DNI", DNI);
        }

        public static void inhabilitar(String tipoDeUsuario, int id)
        {
            DB.correrProcedimiento(tipoDeUsuario + "_INHABILITAR",
                                            "id", id);
        }

        public void nuevo()
        {
            DB.correrProcedimiento("USUARIO_NUEVO",
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
    }
}