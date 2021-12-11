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
    public partial class FormProveedores : Form
    {
        CD_Proveedores objectoCD = new CD_Proveedores();//instanciar capa 
        private string idProv = null;
        private bool editar = false;

        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedor();
        }
        private void MostrarProveedor()
        {
            CD_Proveedores objectoCD = new CD_Proveedores();
            dgv_proveedor.DataSource = objectoCD.MostrarProveedores();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objectoCD.InsertarProv(txtproveedor.Text);
                    objectoCD.InsertarProv(txtcontacto.Text);
                    objectoCD.InsertarProv(txttelefono.Text);
                    objectoCD.InsertarProv(txtdireccion.Text);
                    objectoCD.InsertarProv(txtciudad.Text);
                    objectoCD.InsertarProv(txtpais.Text);
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
                    objectoCD.EditarProv(txtcontacto.Text, idProv);
                    objectoCD.EditarProv(txttelefono.Text, idProv);
                    objectoCD.EditarProv(txtdireccion.Text, idProv);
                    objectoCD.EditarProv(txtciudad.Text, idProv);
                    objectoCD.EditarProv(txtpais.Text, idProv);
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
            txtproveedor.Text = "";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_proveedor.SelectedRows.Count > 0)
            {
                editar = true;
                txtproveedor.Text = dgv_proveedor.CurrentRow.Cells["nom_Proveedor"].Value.ToString();
                txtcontacto.Text = dgv_proveedor.CurrentRow.Cells["nomContacto"].Value.ToString();
                txttelefono.Text = dgv_proveedor.CurrentRow.Cells["Telefono"].Value.ToString();
                txtdireccion.Text = dgv_proveedor.CurrentRow.Cells["Direccion"].Value.ToString();
                txtciudad.Text = dgv_proveedor.CurrentRow.Cells["Ciudad"].Value.ToString();
                txtpais.Text = dgv_proveedor.CurrentRow.Cells["Pais"].Value.ToString();
                idProv = dgv_proveedor.CurrentRow.Cells["id_Proveedor"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");

        }
    }

}
