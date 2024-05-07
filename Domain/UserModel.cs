using System;
using System.Collections;
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

        public bool ChangePassword(string username, string newpassword)
        {
            return userDAO.changePassword(username, newpassword);
        }

        public bool UpdateProfile(string last_name, string first_name, string middle_name)
        {
            return userDAO.updateProfile(last_name, first_name, middle_name);
        }

        public ArrayList LoadUserUnauthorizedSites(string username)
        {
            return userDAO.loadUnauthorizedSites(username);
        }

        public bool SoftwareOverride(string asset_number, string department, string employee_id, string password, string reason)
        {
            return userDAO.softwareOverride(asset_number, department, employee_id, password, reason);
        }
    }
}
