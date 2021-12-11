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
    public partial class Ventas : Form
    {
        CD_Ventas objectoCD = new CD_Ventas();//instanciar capa 
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            MostrarVenta();
        }
        
        private void MostrarVenta()
        {
            CD_Ventas objectoCD = new CD_Ventas();
            dgv_ventas.DataSource = objectoCD.MostrarVentas();
        }
    }
}
