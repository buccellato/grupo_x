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
    public partial class PantallaEliminarEmpresa : Form
    {
        public PantallaEliminarEmpresa()
        {
            InitializeComponent();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            AbmEmpresa.PantallaModificaciones pantalla_modificaciones = new AbmEmpresa.PantallaModificaciones();
            pantalla_modificaciones.Show();
            this.Hide();
        }
    }
}
