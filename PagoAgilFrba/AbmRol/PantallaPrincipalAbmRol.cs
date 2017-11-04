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
    public partial class PantallaPrincipalAbmRol : Form
    {
        public PantallaPrincipalAbmRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal.PantallaPrincipal pantalla_principal_view = new MenuPrincipal.PantallaPrincipal();
            pantalla_principal_view.Show();
            this.Hide();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            AbmRol.PantallaCrearRol pantalla_crear_Rol = new AbmRol.PantallaCrearRol();
            pantalla_crear_Rol.Show();
            this.Hide();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            AbmRol.PantallaModificarRol pantalla_modificar_Rol = new AbmRol.PantallaModificarRol();
            pantalla_modificar_Rol.Show();
            this.Hide();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            AbmRol.PantallaInhabilitarRol pantalla_inhabilitar_Rol = new AbmRol.PantallaInhabilitarRol();
            pantalla_inhabilitar_Rol.Show();
            this.Hide();
        }
    }
}
