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
    public partial class PantallaDarBajaCliente : Form
    {
        public PantallaDarBajaCliente()
        {
            InitializeComponent();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            AbmCliente.PantallaPrincipalAbmCliente pantalla_principal_cliente = new AbmCliente.PantallaPrincipalAbmCliente();
            pantalla_principal_cliente.Show();
            this.Hide();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            AbmCliente.PantallaPrincipalAbmCliente pantalla_principal_cliente = new AbmCliente.PantallaPrincipalAbmCliente();
            pantalla_principal_cliente.Show();
            this.Hide();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            //Pone al cliente seleccionado Inhabilitado para realizar pagos
        }
    }
    /*
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        const string message =
            "Are you sure that you would like to close the form?";
        const string caption = "Form Closing";
        var result = MessageBox.Show(message, caption,
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

        // If the no button was pressed ...
        if (result == DialogResult.No)
        {
            // cancel the closure of the form.
            e.Cancel = true;
        }
    }
    */
}
