using System;
using System.Windows.Forms;

namespace C_WithDatabase.Sidebar_Navigation
{
    public partial class OverrideForm : Form
    {
        public OverrideForm()
        {
            InitializeComponent();
        }

        private void OverrideForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
