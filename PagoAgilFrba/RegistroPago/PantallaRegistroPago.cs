﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.RegistroPago
{
    public partial class PantallaRegistroPago : Form
    {
        public PantallaRegistroPago()
        {
            InitializeComponent();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            MenuPrincipal.PantallaPrincipal pantalla_principal_view = new MenuPrincipal.PantallaPrincipal();
            pantalla_principal_view.Show();
            this.Hide();
        }
    }
}