using ExcelReports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReports.Model_List
{
    public class ModelList_Timesheet
    {
        public List<Model_EmployeeTimesheetReport> EmployeeTimesheetData { get; set; }
        public List<Model_DepartmentTimesheetReport> DepartmentTimesheetData { get; set; }
    }
}
