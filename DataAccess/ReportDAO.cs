using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ReportDAO : DatabaseConnection
    {

        public ArrayList getActivityList()
        {
            ArrayList arrActivities= new ArrayList();

            string[] all = { "0", "" };
            arrActivities.Add(all);
        }
    }
}
