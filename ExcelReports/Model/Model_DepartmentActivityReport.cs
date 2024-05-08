using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReports.Model
{
    public class Model_DepartmentActivityReport
    {
        public string Date { get; set; }
        public string Department { get; set; }
        public string Idle { get; set; }
        public string Active { get; set; }
        public string Unauthorized { get; set; }
        public string Break { get; set; }
        public string Total { get; set; }
    }
}
