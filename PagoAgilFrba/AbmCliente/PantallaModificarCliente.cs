﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class PantallaModificarCliente : Form
    {
        public PantallaModificarCliente()
        {
            InitializeComponent();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            AbmCliente.PantallaPrincipalAbmCliente pantalla_principal = new AbmCliente.PantallaPrincipalAbmCliente();
            pantalla_principal.Show();
            this.Hide();
        }
    }
}
