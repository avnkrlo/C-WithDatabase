using System;
using System.Windows.Forms;

namespace C_WithDatabase.Sidebar_Navigation
{
    public partial class ASForm : Form
    {
        public ASForm()
        {
            InitializeComponent();
        }

        private void ASForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        //Change Password
        public void showChangePasswordComponents()
        {
            btnPeekPass.Visible = true;
            btnPeekNewPass.Visible = true;
            btnPeekConfPass.Visible = true;
            btnPasswordSave.Visible = true;
            btnPasswordCancel.Visible = true;
        }

        public void changeStatePassTextbox()
        {
            txtboxPassword.ReadOnly = false;
            txtboxNewPassword.ReadOnly = false;
            txtboxConfirmNewPassword.ReadOnly = false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            showChangePasswordComponents();
            changeStatePassTextbox();
        }

        private void btnPasswordCancel_Click(object sender, EventArgs e)
        {
            btnPeekPass.Visible = false;
            btnPeekNewPass.Visible = false;
            btnPeekConfPass.Visible = false;
            btnPasswordSave.Visible = false;
            btnPasswordCancel.Visible = false;

            txtboxPassword.ReadOnly = true;
            txtboxPassword.Text = "";
            txtboxPassword.Cursor = Cursors.No;
            txtboxPassword.Cursor = Cursors.Arrow;
            txtboxNewPassword.ReadOnly = true;
            txtboxNewPassword.Text = "";
            txtboxNewPassword.Cursor = Cursors.No;
            txtboxNewPassword.Cursor = Cursors.Arrow;
            txtboxConfirmNewPassword.ReadOnly = true;
            txtboxConfirmNewPassword.Text = "";
            txtboxConfirmNewPassword.Cursor = Cursors.No;
            txtboxNewPassword.Cursor = Cursors.Arrow;
        }

        //Edit Profile

        public void showEditProfileTextboxes()
        {
            txtboxDepartment.ReadOnly = false;
            txtboxFirstName.ReadOnly = false;
            txtboxMiddleName.ReadOnly = false;
            txtboxLastName.ReadOnly = false;
        }

        public void showEditProfileButtons()
        {
            btnProfileSave.Visible = true;
            btnProfileCancel.Visible = true;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            showEditProfileTextboxes();
            showEditProfileButtons();
        }

        private void btnProfileCancel_Click(object sender, EventArgs e)
        {
            txtboxDepartment.ReadOnly = true;
            txtboxDepartment.Text = "";
            txtboxDepartment.Cursor = Cursors.No;
            txtboxDepartment.Cursor = Cursors.Arrow;
            txtboxFirstName.ReadOnly = true;
            txtboxFirstName.Text = "";
            txtboxFirstName.Cursor = Cursors.No;
            txtboxFirstName.Cursor = Cursors.Arrow;
            txtboxMiddleName.ReadOnly = true;
            txtboxMiddleName.Text = "";
            txtboxMiddleName.Cursor = Cursors.No;
            txtboxMiddleName.Cursor = Cursors.Arrow;
            txtboxLastName.ReadOnly = true;
            txtboxLastName.Text = "";
            txtboxLastName.Cursor = Cursors.No;
            txtboxLastName.Cursor = Cursors.Arrow;

            btnProfileSave.Visible = false;
            btnProfileCancel.Visible = false;
        }
    }
}
