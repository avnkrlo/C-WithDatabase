﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReports.Model
{
    public class Header_ActivityReport
    {
        public string Pctag_Activity_label { get; set; }
        public string Pctag_Activity_value { get; set; }
        public string Department_value { get; set; }
        public string DateRange_value { get; set; }

        public string Summary_col1_header { get; set; }
        public string Summary_row1_header { get; set; }
        public string Summary_row1_value { get; set; }
        public string Summary_row2_header { get; set; }
        public string Summary_row2_value { get; set; }
        public string Summary_row3_header { get; set; }
        public string Summary_row3_value { get; set; }
        public string Summary_row4_value { get; set; }
    }
}
