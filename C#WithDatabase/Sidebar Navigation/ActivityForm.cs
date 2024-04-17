using System;
using System.Windows.Forms;

namespace C_WithDatabase.Sidebar_Navigation
{
    public partial class ActivityForm : Form
    {
        public ActivityForm()
        {
            InitializeComponent();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
