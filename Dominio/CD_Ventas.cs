using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;

namespace Dominio
{
    public class CD_Ventas //capa dominio
    {
        public CAD_Ventas objectoCAD = new CAD_Ventas();//instanciar capa de accesodatos, para utilizar sus metodos //observacion objectoCAD
        public DataTable MostrarVentas()//creacion de tabla
        {
            DataTable tabla = new DataTable();//instanciando la tabla
            tabla = objectoCAD.Mostrar();
            return tabla;
        }
    }
}
