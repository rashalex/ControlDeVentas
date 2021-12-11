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
using Common.Cache;

namespace ControlDeVentas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas segur@ de cerrar sesión?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            lblnombre.Text = UserLoginCache.Nombre + " " + UserLoginCache.Appaterno;
            lblusuario.Text = UserLoginCache.Usuario; 
        }
        private void AbrirFormhijo(object formhijo)//abre contenido de formulario en panel 
        {
            if (this.Pnl_contenidos.Controls.Count > 0)
            
                this.Pnl_contenidos.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.Pnl_contenidos.Controls.Add(fh);
                this.Pnl_contenidos.Tag = fh;
                fh.Show(); 
            
        }

        private void Pnl_contenidos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FrmProductos());
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new Ventas());
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormProveedores());
        }
    }
}
