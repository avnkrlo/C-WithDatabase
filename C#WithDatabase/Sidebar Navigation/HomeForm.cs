using System;
using System.Timers;
using System.Windows.Forms;

namespace C_WithDatabase.Sidebar_Navigation
{
    public partial class HomeForm : Form
    {
        DashboardForm PForm;
        System.Timers.Timer timer;
        int hours, mins, secs;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            SetLanguage();
            TimeSpan time = TimeSpan.FromSeconds(Utilities.BreakTime);
            lblBreakCounter.Text = time.ToString(@"mm\:ss");
            SetButtons();
            StyleButtons();
            PForm = (DashboardForm)this.ParentForm;

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                secs++;

                if (secs == 60)
                {
                    secs = 0;
                    mins += 1;
                }
            }));
        }

        private void btn1stBreak_Click(object sender, EventArgs e)
        {

        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            if (Utilities.Lunch == (int)Utilities.BreakStatus.INPROGRESS)
            {
                if (Utilities.ITTS)
            }
        }

        public void SetButtons()
        {
            if (Utilities.Lunch == (int)Utilities.BreakStatus.TAKEN)
            {
                btnLunch.Enabled = false;
            }
            else if (Utilities.Lunch == (int)Utilities.BreakStatus.INPROGRESS)
            {
                btn1stBreak.Enabled = false;
                btnLunch.Enabled = true;
                btn2ndBreak.Enabled = false;
                return;
            }
            else
            {
                btnLunch.Enabled = true;
            }

            if (Utilities.Break1 == (int)Utilities.BreakStatus.TAKEN)
            {
                btn1stBreak.Enabled = false;
            }
            else if (Utilities.Break1 == (int)Utilities.BreakStatus.INPROGRESS)
            {
                btn1stBreak.Enabled = true;
                btnLunch.Enabled = false;
                btn2ndBreak.Enabled = false;
                return;
            }
            else
            {
                btn1stBreak.Enabled = true;
            }

            if (Utilities.Break2 == (int)Utilities.BreakStatus.TAKEN)
            {
                btn2ndBreak.Enabled = false;
            }
            else if (Utilities.Break2 == (int)Utilities.BreakStatus.INPROGRESS)
            {
                btn1stBreak.Enabled = false;
                btnLunch.Enabled = false;
                btn2ndBreak.Enabled = true;
                return;
            }
            else
            {
                btn2ndBreak.Enabled = true;
            }
        }

        public void StyleButtons()
        {
            throw new NotImplementedException();
        }

        public void SetLanguage()
        {
            labelStatusText.Text = StringsResources.Status;
            labelBreaksText.Text = StringsResources.Breaks;
            btn1stBreak.Text = StringsResources.Break + " 1";
            btnLunch.Text = StringsResources.Lunch;
            btn2ndBreak.Text = StringsResources.Break + " 2";
            labelSummaryText.Text = StringsResources.TodaySummary;
            labelSummaryStatusText.Text = StringsResources.Status;
            labelSummaryMinutesText.Text = StringsResources.Minutes;
            labelSummaryIdle.Text = StringsResources.Idle;
            labelSummaryActive.Text = StringsResources.Active;
            labelSummaryUnauthorized.Text = StringsResources.Unauthorized;
            labelSummaryBreak.Text = StringsResources.Break;
        }
    }
}
