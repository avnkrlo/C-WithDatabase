using System;
using System.Windows.Forms;

namespace C_WithDatabase.Sidebar_Navigation
{
    public partial class TimesheetForm : Form
    {
        public TimesheetForm()
        {
            InitializeComponent();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
