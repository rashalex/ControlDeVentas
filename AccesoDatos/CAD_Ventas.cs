using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class CAD_Ventas:ConecctionToSql //capa de acceso a datos -->ventas
    {
        //lectura sql
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        //tabla de datos publica --> mostrar
        public DataTable Mostrar()
        {
            //abrir conexion 
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Ventas";//comando tipo texto = sentencia sql; mostrar datos de tabla
                    leer = command.ExecuteReader();//ejecuta la sentencia
                    tabla.Load(leer);//cargue los datos dentro de la tabla
                    return tabla;//retorna la tabla
                }
            }
        }
    }
}
