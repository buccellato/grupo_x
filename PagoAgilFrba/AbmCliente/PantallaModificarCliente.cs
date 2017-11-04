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
    public partial class PantallaModificarCliente : Form
    {
        public PantallaModificarCliente()
        {
            InitializeComponent();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            AbmCliente.PantallaPrincipalAbmCliente pantalla_principal_cliente = new AbmCliente.PantallaPrincipalAbmCliente();
            pantalla_principal_cliente.Show();
            this.Hide();
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            //Completa los datos del cliente seleccionado en ModificacionesCliente
            //Te deja editar el dato que quieras y guardarlo
            AbmCliente.PantallaModificaciones pantalla_modificaciones_cliente = new AbmCliente.PantallaModificaciones();
            pantalla_modificaciones_cliente.Show();
            this.Hide();
        }
    }
}
