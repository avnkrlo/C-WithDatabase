using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_WithDatabase
{
    public partial class MessageForm : Form
    {
        string Message;
        string Title;
        int Mode;

        public MessageForm(string message, string title, int mode)
        {
            InitializeComponent();
            Message = message;
            Title = title;
            Mode = mode;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            labelMessage.Text = Message;
            labelTitle.Text = Title;

            if (Mode == 0)
            {
                panelOkOnly.Visible = true;
            }
            else
            {
                panelOkCancel.Visible = true;
            }
        }

        public void SetLanguage()
        {
            btnOk.Text = StringsResources.Save;
            btnOkOnly.Text = StringsResources.OK;
            btnCancel.Text = StringsResources.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
