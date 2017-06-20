﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Dominio
{
    public static class Viaje
    {
        public static void registrar(   int chofer, 
                                        int vehiculo, 
                                        int cliente, 
                                        int turno, 
                                        decimal kms,
                                        DateTime inicio,
                                        DateTime fin)
        {
            DB.correrProcedimiento( "REGISTRAR_VIAJE",
                                    "chofer", chofer,
                                    "vehiculo",  vehiculo,
                                    "cliente",  cliente,
                                    "turno",  turno,
                                    "kms", kms,
                                    "inicio", inicio,
                                    "fin", fin);
        }
    }
}