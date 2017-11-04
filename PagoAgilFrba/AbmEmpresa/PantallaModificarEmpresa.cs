using System;
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
    public partial class PantallaModificarEmpresa : Form
    {
        public PantallaModificarEmpresa()
        {
            InitializeComponent();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            AbmEmpresa.PantallaPrincipalAbmEmpresa pantalla_principal = new AbmEmpresa.PantallaPrincipalAbmEmpresa();
            pantalla_principal.Show();
            this.Hide();
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            //Cargar los datos de esa empresa en PantallaModificaciones
            AbmEmpresa.PantallaModificaciones pantalla_modificaciones = new AbmEmpresa.PantallaModificaciones();
            pantalla_modificaciones.Show();
            this.Hide();
        }
    }
}
