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

namespace UberFrba.SeleccionarRol
{
    public partial class SeleccionarRolForm : Form
    {
        private List<String> roles = new List<String>();

        public SeleccionarRolForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SeleccionarRolForm_Load(object sender, EventArgs e)
        {
            Usuario.getRoles().ForEach(r => comboBoxRoles.Items.Add(r));
        }
    }
}
