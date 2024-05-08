using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReports.Model
{
    public class Model_EmployeeTimesheetReport
    {
        public string Date { get; set; }
        public string TimeIn { get; set; }
        public string Timeout { get; set; }
        public string WorkMins { get; set; }
        public string DeductMins { get; set; }
        public string Break1TimeIn { get; set; }
        public string Break1Timeout { get; set; }
        public string Break1Mins { get; set; }
        public string LunchTimeIn { get; set; }
        public string LunchTimeout { get; set; }
        public string LunchMins { get; set; }
        public string Break2TimeIn { get; set; }
        public string Break2Timeout { get; set; }
        public string Break2Mins { get; set; }
    }
}
