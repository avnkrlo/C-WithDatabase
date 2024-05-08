using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReports.Model
{
    public class Model_DepartmentTimesheetReport
    {
        public string PCTag { get; set; }
        public string WorkMins { get; set; }
        public string DeductMins { get; set; }
        public string WorkHrs { get; set; }
        public string DeductHrs { get; set; }
    }
}
