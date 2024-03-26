using System.Windows.Forms;

namespace C_WithDatabase
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

        }

        private void DashboardForm_Load(object sender, System.EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, System.EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarNavigation.Width -= 10;
                if (sidebarNavigation.Width <= 63)
                    if (sidebarNavigation.Width <= 63)
                    {
                        sidebarExpand = false;
                        sidebarTransition.Stop();
                    }
                    else
                    {
                        sidebarNavigation.Width += 10;
                        if (sidebarNavigation.Width >= 260)
                            if (sidebarNavigation.Width >= 260)
                            {
                                sidebarExpand = true;
                                sidebarTransition.Stop();
                            }
                    }
            }
        }

        private void btnSidebar_Click(object sender, System.EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void nightControlBox1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
