using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Dominio
{
    public class UserModel
    {
        UserDAO userDAO = new UserDAO();


        public bool LoginUser(string user, string pass)
        {
            return userDAO.Login(user, pass);
        }
        
    }
}
