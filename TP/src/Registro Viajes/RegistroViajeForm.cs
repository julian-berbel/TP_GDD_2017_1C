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

namespace UberFrba.Registro_Viajes
{
    public partial class RegistroViajeForm : ReturningForm
    {
        public RegistroViajeForm(ReturningForm caller) : base(caller)
        {
            InitializeComponent();
        }
    }
}
