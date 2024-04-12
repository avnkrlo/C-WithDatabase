using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace C_WithDatabase.Sidebar_Navigation
{
    public partial class HomeForm : Form
    {
        System.Timers.Timer timer;
        int hours, mins, secs;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                secs++;

                if (secs == 60) {
                    secs = 0;
                    mins += 1;
                }
            }));
        }

        private void btn1stBreak_Click(object sender, EventArgs e)
        {

        }
    }
}
