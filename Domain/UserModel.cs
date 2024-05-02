using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDAO userDAO = new UserDAO();

        public bool CheckConnection()
        {
            return userDAO.checkConnection();
        }

        public bool LoginUser(string username, string password)
        {
            return userDAO.login(username, password);
        }
    }
}
