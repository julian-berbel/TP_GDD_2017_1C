﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Dominio;

namespace UberFrba.Listado_Estadistico
{
    public partial class ListadoEstadisticoForm : ReturningForm
    {
        public ListadoEstadisticoForm(Form caller)
        {
            this.caller = caller;
            InitializeComponent();
        }
    }
}