using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;

namespace Dominio
{
    public class CD_Productos
    {
        public CAD_Productos objectoCAD = new CAD_Productos();//instanciar capa de accesodatos, para utilizar sus metodos
        public DataTable MostrarProductos()//creacion de tabla
        {
            DataTable tabla = new DataTable();//instanciando la tabla
            tabla = objectoCAD.Mostrar();
            return tabla;
        }
        public void InsertarProd(string nomProd, string nomCat, string nomMarc, string nomProv)
        {
            objectoCAD.Insertar(nomProd, nomCat,nomMarc, nomProv);
        }

        public void EditarProd(string nomProd, string nomCat, string nomMarc, string nomProv)
        {
            objectoCAD.Editar(nomProd, nomCat, nomMarc, nomProv);
        }
    }
}
