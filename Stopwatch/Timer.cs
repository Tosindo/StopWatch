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
            trackBar1.Value = (int)(Properties.Settings.Default.Opacity * 100);
            this.Opacity = Properties.Settings.Default.Opacity;
            this.TopMost = opt_alwaysontop.Checked = Properties.Settings.Default.AlwaysOnTop;
        }

        


        private string formatTime()
        {
            string format = ((_h < 10) ? ("0" + _h) : Convert.ToString(_h)) + ":"
                + ((_m < 10) ? ("0" + _m) : Convert.ToString(_m)) + ":"
                + ((_s < 10) ? ("0" + _s) : Convert.ToString(_s)) + ":"
                + ((_ms < 10) ? ("0" + _ms) : Convert.ToString(_ms));
            return format;
        }

        private void toggleOptions()
        {
            if (PanelContainer.Panel1Collapsed)
            {
                coOptions.Text = "«";
                PanelContainer.Panel1Collapsed = false;
                this.Width = this.Width + PanelContainer.Panel1.Width;
            }
            else
            {
                coOptions.Text = "»";
                this.Width = this.Width - PanelContainer.Panel1.Width;
                PanelContainer.Panel1Collapsed = true;
            }
            label6.Location = new Point(((splitContainer1.Panel1.Width - timeLabel.Width) / 2), label6.Location.Y);
            timeLabel.Location = new Point(((splitContainer1.Panel1.Width - timeLabel.Width) / 2), timeLabel.Location.Y);
        }

        private void coOptions_Click(object sender, EventArgs e)
        {
            toggleOptions();
        } 

        private void setTimer_Click(object sender, EventArgs e)
        {
            if (numHours.Value == 0 && numMinutes.Value == 0 && numSeconds.Value == 0)
            {
                MessageBox.Show("I can't wait for 0 hours, 0 minutes and 0 seconds.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pauseButton.Enabled = false;
            }
            else
            {
                toggleOptions();
                timer1.Enabled = false;
                pauseButton.Text = "Start";
                _h = (int)numHours.Value;
                _m = (int)numMinutes.Value;
                _s = (int)numSeconds.Value;
                _ms = 0;
                string format = formatTime();
                timeLabel.Text = (format);

                pauseButton.Enabled = true;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                pauseButton.Text = "Continue";
            }
            else
            {
                timer1.Enabled = true;
                pauseButton.Text = "Pause";
            }
        }

        private void Timer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult _close = MessageBox.Show("Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_close == DialogResult.Yes)
            {
                Properties.Settings.Default.Opacity = this.Opacity;
                Properties.Settings.Default.AlwaysOnTop = this.TopMost;
                Properties.Settings.Default.Save();

                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
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
            if (_ms>0)
            {
                _ms -= 1;
            }
            else if (_s>0)
            {
                _ms = 60;
                _s -= 1;
            } 
            else if (_m>0)
            {
                _s = 60;
                _m -= 1;
            }
            else if (_h>0)
            {
                _m = 60;
                _h -= 1;
            }
            else
            {
                timer1.Enabled = false;
                pauseButton.Enabled = false;
                MessageBox.Show("Finished!");
                toggleOptions();
            }

            string format = formatTime();
            timeLabel.Text = (format);
        }
    }
}
