using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class AdminModel
    {
        AdminDAO adminDAO = new AdminDAO();
        public ArrayList GetAssetsList()
        {
            return adminDAO.getAssetsList();
        }

        public ArrayList GetEmployedIDList()
        {
            return adminDAO.getemployeeidlist();
        }

        public ArrayList GetDepartmentList()
        {
            return adminDAO.getDepartmentList();
        }

        public ArrayList GetRoleList()
        {
            return adminDAO.getrolelist();
        }
    }
}
