using System;
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
    public partial class PantallaPrincipalAbmCliente : Form
    {
        public PantallaPrincipalAbmCliente()
        {
            InitializeComponent();
        }

        private void atrasButton_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal.PantallaPrincipal pantalla_principal_view = new MenuPrincipal.PantallaPrincipal();
            pantalla_principal_view.Show();
            this.Hide();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            AbmCliente.PantallaModificarCliente pantalla_modificar_cliente = new AbmCliente.PantallaModificarCliente();
            pantalla_modificar_cliente.Show();
            this.Hide();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            AbmCliente.PantallaDarBajaCliente pantalla_eliminar_cliente = new AbmCliente.PantallaDarBajaCliente();
            pantalla_eliminar_cliente.Show();
            this.Hide();
        }

        private void crearButton_Click_1(object sender, EventArgs e)
        {
            AbmCliente.PantallaCrearCliente pantalla_crear_cliente = new AbmCliente.PantallaCrearCliente();
            pantalla_crear_cliente.Show();
            this.Hide();
        }
    }
}
