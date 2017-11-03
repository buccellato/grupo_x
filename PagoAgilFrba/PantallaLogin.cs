using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PagoAgilFrba.Login
{



    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PantallaLogin_Load(object sender, EventArgs e)
        {

        }

        private void ingresarButton_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "w23e";
            if (userTextBox.Text == user && passTextBox.Text == pass)
            {
                MenuPrincipal.PantallaPrincipal aux = new MenuPrincipal.PantallaPrincipal();
                aux.Show();
                this.Hide();
            }
                    }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
