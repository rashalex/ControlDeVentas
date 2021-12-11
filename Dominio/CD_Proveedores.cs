using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;

namespace Dominio
{
    public class CD_Proveedores
    {
        public CAD_Proveedores objectoCAD = new CAD_Proveedores();//instanciar capa de accesodatos, para utilizar sus metodos
        public DataTable MostrarProveedores()//creacion de tabla
        {
            DataTable tabla = new DataTable();//instanciando la tabla
            tabla = objectoCAD.Mostrar();
            return tabla;
        }
        public void InsertarProv(string nomProv, string nomCon, string nomTel, string nomDir, string nomCiu, string nomPais)
        {
            objectoCAD.Insertar(nomProv, nomCon, nomTel, nomDir, nomCiu, nomPais);
        }

        public void EditarProv(string nomProv, string idProv, string nomCon, string nomTel, string nomDir, string nomCiu, string nomPais)
        {
            objectoCAD.Editar(nomProv, Convert.ToInt32(idProv), nomCon, nomTel, nomDir, nomCiu, nomPais);
        }

    }

}
