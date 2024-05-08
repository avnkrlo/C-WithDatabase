using ExcelReports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReports.Model_List
{
    public class ModelList_Activity
    {
        public List<Model_EmployeeActivityReport> EmployeeActivityData { get; set; }

        public List<Model_EmployeeDailyActivityReport> EmployeeDailyActivityData { get; set; }

        public List<Model_DepartmentActivityReport> DepartmentActivityData { get; set; }

        public List<Model_ActivityReport> ActivityData { get; set; }
    }
}
