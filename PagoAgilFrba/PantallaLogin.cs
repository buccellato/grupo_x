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
        int intentos = 0;
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
            
            if (intentos <= 3)
            {
               
                //Compararlo contra uno de los usuarios de la BD
                string user = "admin";
                //Compararlo contra la contraseña del usuario obtenido de la BD
                string pass = "w23e";
                //Permisos del usuario para analizar que vistas puede ver
                //int permiso;
                
                if (userTextBox.Text == "" && passTextBox.Text == "")
                {
                    MessageBox.Show("Los campos se encuentran vacios");
                }
                else if (userTextBox.Text == "")
                {
                    MessageBox.Show("Ingrese el Usuario");
                }
                else if (passTextBox.Text == "")
                {
                    MessageBox.Show("Ingrese la Contraseña");
                }
                else if (userTextBox.Text == user && passTextBox.Text == pass && adminBox.Checked == false)
                {
                    intentos = 0;
                    MenuPrincipal.PantallaPrincipal aux = new MenuPrincipal.PantallaPrincipal();
                    aux.Show();
                    this.Hide();
                }
                else if (userTextBox.Text == user && passTextBox.Text == pass && adminBox.Checked == true)
                                    {
                    intentos = 0;

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario y/o la contraseña son incorrecto. Intentelo Nuevamente");
                    userTextBox.Clear();
                    passTextBox.Clear();
                    intentos++;
                }
            }
            else
            {
                //Bloquear al usuario
                MessageBox.Show("Usuario bloqueado");
                this.Close();
            }
    }
    private void userTextBox_TextChanged(object sender, EventArgs e)
    {

    }
    }
}