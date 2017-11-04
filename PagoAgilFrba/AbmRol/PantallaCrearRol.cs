using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmRol
{
    public partial class PantallaCrearRol : Form
    {
        public PantallaCrearRol()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {

        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            AbmRol.PantallaPrincipalAbmRol pantalla_principal = new AbmRol.PantallaPrincipalAbmRol();
            pantalla_principal.Show();
            this.Hide();
        }
    }
}
