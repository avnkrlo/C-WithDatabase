using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReports.Model
{
    public class Model_EmployeeActivityReport
    {
        public string Activity { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string Total { get; set; }
    }
}
