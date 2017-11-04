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
    public partial class PantallaPrincipalAbmEmpresa : Form
    {
        public PantallaPrincipalAbmEmpresa()
        {
            InitializeComponent();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            MenuPrincipal.PantallaPrincipal pantalla_principal_view = new MenuPrincipal.PantallaPrincipal();
            pantalla_principal_view.Show();
            this.Hide();
        }

        private void PantallaAbmEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            AbmEmpresa.PantallaCrearEmpresa pantalla_crear = new AbmEmpresa.PantallaCrearEmpresa();
            pantalla_crear.Show();
            this.Hide();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            AbmEmpresa.PantallaModificarEmpresa pantalla_modificar = new AbmEmpresa.PantallaModificarEmpresa();
            pantalla_modificar.Show();
            this.Hide();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            AbmEmpresa.PantallaEliminarEmpresa pantalla_eliminar = new AbmEmpresa.PantallaEliminarEmpresa();
            pantalla_eliminar.Show();
            this.Hide();
        }
    }
}
