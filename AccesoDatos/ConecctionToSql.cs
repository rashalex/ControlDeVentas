using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public abstract class ConecctionToSql
    {
        //DESKTOP-GCMTB55\MSSQLSERVERQ
        private readonly string connectionstring; 
        public ConecctionToSql()
        {
            connectionstring = "Server =DESKTOP-GCMTB55\\MSSQLSERVERQ; DataBase = controlventas; integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
    }
}
