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
    public partial class PantallaModificarRol : Form
    {
        public PantallaModificarRol()
        {
            InitializeComponent();
        }

        private void atrsaButton_Click(object sender, EventArgs e)
        {
            AbmRol.PantallaPrincipalAbmRol pantalla_principal = new AbmRol.PantallaPrincipalAbmRol();
            pantalla_principal.Show();
            this.Hide();
        }
    }
}
