using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Timer : Form
    {

        private int _h, _m, _s, _ms = 0;

        public Timer()
        {
            InitializeComponent();
            this.AllowTransparency = true;
        }

        private void coOptions_Click(object sender, EventArgs e)
        {
            if (PanelContainer.Panel1Collapsed)
            {
                coOptions.Text =  "«";
                PanelContainer.Panel1Collapsed = false;
                this.Width = this.Width + PanelContainer.Panel1.Width;
            }
            else
            {
                coOptions.Text = "»";
                this.Width = this.Width-PanelContainer.Panel1.Width;
                PanelContainer.Panel1Collapsed = true;
            }
            label6.Location = new Point(((splitContainer1.Panel1.Width - label6.Width) / 2), label6.Location.Y);
            timeLabel.Location = new Point(((splitContainer1.Panel1.Width - timeLabel.Width) / 2), timeLabel.Location.Y);
        } 

        private void setTimer_Click(object sender, EventArgs e)
        {
            if (numHours.Value == 0 && numMinutes.Value == 0 && numSeconds.Value == 0)
            {
                MessageBox.Show("I can't wait for 0 hours, 0 minutes and 0 seconds.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _h = (int)numHours.Value;
                _m = (int)numMinutes.Value;
                _s = (int)numSeconds.Value;
                
                timeLabel.Text = (_h + ":" + _m + ":" + _s + ":" + ":00");

            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            //Pauses or starts the timer
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = (double)trackBar1.Value/100;
        }

        private void opt_alwaysontop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = opt_alwaysontop.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
