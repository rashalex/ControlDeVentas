using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class CAD_Proveedores:ConecctionToSql
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
                    command.CommandText = "SELECT * FROM Proveedor";//sentencia sql
                    leer = command.ExecuteReader();//ejecuta la sentencia
                    tabla.Load(leer);//cargue los datos dentro de la tabla
                    return tabla;//retorna la tabla
                }
            }
        }
        public void Insertar(string nomProv, string nomCon, string nomTel, string nomDir, string nomCiu, string nomPais)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Proveedor values(@nomP, @nomC, @nomT, @nomD, @nomCI, @nomPA )";
                    command.Parameters.AddWithValue("@nomP", nomProv);
                    command.Parameters.AddWithValue("@nomC", nomCon);
                    command.Parameters.AddWithValue("@nomT", nomTel);
                    command.Parameters.AddWithValue("@nomD", nomDir);
                    command.Parameters.AddWithValue("@nomCI", nomCiu);
                    command.Parameters.AddWithValue("@nomPA", nomPais);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public void Editar(string nomProv, int id, string nomCon, string nomTel, string nomDir, string nomCiu, string nomPais)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Proveedor SET nom_Proveedor=@nomP WHERE id_Proveedor=@id";
                    command.Parameters.AddWithValue("@nomP", nomProv);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nomC", nomCon);
                    command.Parameters.AddWithValue("@nomT", nomTel);
                    command.Parameters.AddWithValue("@nomD", nomDir);
                    command.Parameters.AddWithValue("@nomCI", nomCiu);
                    command.Parameters.AddWithValue("@nomPA", nomPais);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }





    }
}
