﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Dominio
{
    public class Cliente : Usuario
    {
        public decimal codigoPostal;

        public Cliente(DataRow data) : base(data)
        {
            codigoPostal = (decimal)data["Codigo_Postal"];
        }

        new public static Cliente get(int id)
        {
            return new Cliente(DB.correrFuncionDeTabla("CLIENTE_GET",
                                                        "id", id).Rows[0]);
        }

        public void editar()
        {
            DB.correrProcedimiento("Cliente_UPDATE",
                                        "id", id,
                                         "nombre", nombre,
                                         "apellido", apellido,
                                         "dni", dni,
                                         "mail", mail,
                                         "telefono", telefono,
                                         "domicilio", domicilio,
                                         "fechaNac", fechaNac,
                                         "codigoPostal", codigoPostal,
                                         "habilitado", habilitado);
        }

        public static void nuevo(int id, decimal codigoPostal, Boolean habilitado)
        {
            DB.correrProcedimiento("Cliente_NUEVO",
                                         "id", id,
                                         "codigoPostal", codigoPostal,
                                         "habilitado", habilitado);
        }
    }
}