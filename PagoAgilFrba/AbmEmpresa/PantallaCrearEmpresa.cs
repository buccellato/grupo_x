﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class PantallaCrearEmpresa : Form
    {
        public PantallaCrearEmpresa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ingresarClienteButton_Click(object sender, EventArgs e)
        {

        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            AbmEmpresa.PantallaPrincipalAbmEmpresa pantalla_principal = new AbmEmpresa.PantallaPrincipalAbmEmpresa();
            pantalla_principal.Show();
            this.Hide();
        }
    }
}
