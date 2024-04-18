using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_WithDatabase.Sidebar_Navigation
{
    public partial class SitesForm : Form
    {
        public SitesForm()
        {
            InitializeComponent();
        }

        private void SitesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
