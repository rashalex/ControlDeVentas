using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace ControlDeVentas
{
    public partial class Login : Form
    {
       //constructor, 
        public Login()
        {
            InitializeComponent();
            txtpassword._TextBox.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void pbox_login_Click(object sender, EventArgs e)
        {
        }
        

        //despues de los datos de usuario y contraseña, para ingresar a menú
        private void pbox_login_Click_1(object sender, EventArgs e)
        {
            if (txtuser.text != "")
            {
                if (txtpassword.text != "")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.text, txtpassword.text);
                    if (validLogin == true)
                    {
                        //entra a menú
                        Menu mainMenu = new Menu();
                        this.Hide();
                        mainMenu.FormClosed += Logout;
                        mainMenu.Show();

                        MessageBox.Show("Ususario correcto");
                    }
                    else
                    {
                        MessageBox.Show("Ususario incorrecto");
                        msgerror("Datos Incorrectos \n Intente de nuevo");
                        txtpassword.text = "";
                        txtuser.Focus();
                    }
                }
                else
                {
                    msgerror("Ingrese la contraseña");
                }
            }
            else
            {
                msgerror("Ingrese usuario");
            }
        }
        //Mensaje para saber si los datos son incorrectos
        private void msgerror(string msg)
        {
            lblerror.Text = "" + msg;
            lblerror.Visible = true;
        }
        //metodo para cerrar sesion, se vacien los datos
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpassword.text = "";
            txtuser.text = "";
            lblerror.Visible = false;
            this.Show();
            txtuser.Focus();
        }
    }
}
