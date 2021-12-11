using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class CAD_Productos:ConecctionToSql
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
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT C.nom_categoria, M.nom_marca, P.nom_proveedor, R.talla, R.precio_venta, R.cantidad_venta FROM Categoria C, Marca M, Proveedor P, Productos R Where R.id_productos = C.id_categoria AND R.id_productos = M.id_marca AND R.id_productos = P.id_proveedor;";//sentencia sql
                    leer = command.ExecuteReader();//ejecuta la sentencia
                    tabla.Load(leer);//cargue los datos dentro de la tabla
                    return tabla;//retorna la tabla
                }
            }
        }
        public void Insertar(string nomProd, string nomCat, string nomMarc, string nomProv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Productos, Categoria, Marca, Proveedores values(@nomR, @nomC, @nomM, @nomP)";
                    command.Parameters.AddWithValue("@nomR", nomProd);
                    command.Parameters.AddWithValue("@nomC", nomCat);
                    command.Parameters.AddWithValue("@nomM", nomMarc);
                    command.Parameters.AddWithValue("@nomP", nomProv);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public void Editar(string nomProd, string nomCat, string nomMarc, string nomProv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Productos SET =@nom WHERE id_Proveedor=@id";
                    command.Parameters.AddWithValue("@nomR", nomProd);
                    command.Parameters.AddWithValue("@nomC", nomCat);
                    command.Parameters.AddWithValue("@nomM", nomMarc);
                    command.Parameters.AddWithValue("@nomP", nomProv);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
