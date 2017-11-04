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
    public partial class PantallaCrearCliente : Form
    {
        public PantallaCrearCliente()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            AbmCliente.PantallaPrincipalAbmCliente pantalla_principal_cliente = new AbmCliente.PantallaPrincipalAbmCliente();
            pantalla_principal_cliente.Show();
            this.Hide();
        }
    }
}
