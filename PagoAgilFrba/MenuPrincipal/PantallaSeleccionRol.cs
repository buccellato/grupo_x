﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.MenuPrincipal
{
    public partial class PantallaSeleccionRol : Form
    {
        public PantallaSeleccionRol()
        {
            InitializeComponent();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            MenuPrincipal.PantallaPrincipal pantalla_principal = new MenuPrincipal.PantallaPrincipal();
            pantalla_principal.Show();
            this.Hide();
        }
    }
}
