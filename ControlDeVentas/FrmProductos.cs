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
    public partial class FrmProductos : Form
    {
        CD_Productos objectoCD = new CD_Productos();
        private string idProv = null;//
        private bool editar = false;//instanciar capa 
        public FrmProductos()
        {
            InitializeComponent();
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            MostrarProducto();
            cmbproductos.Items.Add("JEANS");
            cmbproductos.Items.Add("SUDADERAS");
            cmbproductos.Items.Add("POLERAS");
            cmbproductos.Items.Add("BLUSAS");
            cmbproductos.Items.Add("CHAMARRAS");
            cmbproductos.Items.Add("CAMISAS");

            cmbmarca.Items.Add("BERSHKA");
            cmbmarca.Items.Add("ZARA");
            cmbmarca.Items.Add("FOREVER21");
            cmbmarca.Items.Add("HyM");
            cmbmarca.Items.Add("PINKY");
            cmbmarca.Items.Add("ABERCROMBIE");
                


        }
        private void MostrarProducto()
        {
            CD_Productos objectCD = new CD_Productos();
            dgb_Productos.DataSource = objectoCD.MostrarProductos();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)//boton guardar
        {
            /* if (editar == false)
             {
                 try
                 {
                     objectoCD.InsertarProd (cmbproductos.Text); //cambiar a opciones varias
                     MessageBox.Show("Se inserto correctamente");
                     MostrarProducto();
                     LimpiarForm();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("No se pudo agregar el Proveedor por " + ex);
                 }
             }
             if (editar == true)
             {
                 try
                 {
                     objectoCD.EditarProd(cmbproductos.Text);
                     MessageBox.Show("Se edito Correctamente");
                     MostrarProducto();
                     LimpiarForm();
                     editar = false;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("No se pudo editar el Proveedor por " + ex);
                 }
             }*/
            /*if (editar == false)
            {
                try
                {
                    objectoCD.InsertarProd(cmbproductos.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarProveedor();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el Proveedor por " + ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    objectoCD.EditarProv(txtproveedor.Text, idProv);
                    MessageBox.Show("Se edito Correctamente");
                    MostrarProveedor();
                    LimpiarForm();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el Proveedor por " + ex);
                }
            }
        }
        private void LimpiarForm()
        {
            cmbproductos.Text = "";
        }
        

        
        

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgb_Productos.SelectedRows.Count > 0)
            {
                editar = true;
                cmbproductos.Text = dgb_Productos.CurrentRow.Cells["nom_Producto"].Value.ToString();
                //idProd = dgb_Productos.CurrentRow.Cells["id_Proveedor"].Value.ToString();//
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }*/
        }
    }
}
