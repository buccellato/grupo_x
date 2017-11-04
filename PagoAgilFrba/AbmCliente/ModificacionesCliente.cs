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
    public partial class ModificacionesCliente : Form
    {
        public ModificacionesCliente()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            AbmCliente.PantallaModificarCliente pantalla_modificar_cliente = new AbmCliente.PantallaModificarCliente();
            pantalla_modificar_cliente.Show();
            this.Hide();
        }
    }
}
