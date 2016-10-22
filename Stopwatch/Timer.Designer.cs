namespace Stopwatch
{
    partial class Timer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelContainer = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.opt_alwaysontop = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setTimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.coOptions = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelContainer)).BeginInit();
            this.PanelContainer.Panel1.SuspendLayout();
            this.PanelContainer.Panel2.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PanelContainer.IsSplitterFixed = true;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            // 
            // PanelContainer.Panel1
            // 
            this.PanelContainer.Panel1.Controls.Add(this.label5);
            this.PanelContainer.Panel1.Controls.Add(this.trackBar1);
            this.PanelContainer.Panel1.Controls.Add(this.opt_alwaysontop);
            this.PanelContainer.Panel1.Controls.Add(this.label4);
            this.PanelContainer.Panel1.Controls.Add(this.setTimer);
            this.PanelContainer.Panel1.Controls.Add(this.label3);
            this.PanelContainer.Panel1.Controls.Add(this.label2);
            this.PanelContainer.Panel1.Controls.Add(this.numSeconds);
            this.PanelContainer.Panel1.Controls.Add(this.numMinutes);
            this.PanelContainer.Panel1.Controls.Add(this.label1);
            this.PanelContainer.Panel1.Controls.Add(this.numHours);
            this.PanelContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // PanelContainer.Panel2
            // 
            this.PanelContainer.Panel2.Controls.Add(this.splitContainer1);
            this.PanelContainer.Panel2.Controls.Add(this.coOptions);
            this.PanelContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelContainer.Size = new System.Drawing.Size(443, 223);
            this.PanelContainer.SplitterDistance = 191;
            this.PanelContainer.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Opacity:";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(69, 111);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(106, 20);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // opt_alwaysontop
            // 
            this.opt_alwaysontop.AutoSize = true;
            this.opt_alwaysontop.Location = new System.Drawing.Point(17, 137);
            this.opt_alwaysontop.Name = "opt_alwaysontop";
            this.opt_alwaysontop.Size = new System.Drawing.Size(95, 17);
            this.opt_alwaysontop.TabIndex = 8;
            this.opt_alwaysontop.Text = "Always on top.";
            this.opt_alwaysontop.UseVisualStyleBackColor = true;
            this.opt_alwaysontop.CheckedChanged += new System.EventHandler(this.opt_alwaysontop_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Options";
            // 
            // setTimer
            // 
            this.setTimer.Location = new System.Drawing.Point(48, 189);
            this.setTimer.Name = "setTimer";
            this.setTimer.Size = new System.Drawing.Size(97, 22);
            this.setTimer.TabIndex = 6;
            this.setTimer.Text = "Set Timer";
            this.setTimer.UseVisualStyleBackColor = true;
            this.setTimer.Click += new System.EventHandler(this.setTimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(123, 64);
            this.numSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(31, 20);
            this.numSeconds.TabIndex = 3;
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(81, 64);
            this.numMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(31, 20);
            this.numMinutes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hours : Minutes : Seconds";
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(39, 64);
            this.numHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(31, 20);
            this.numHours.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(24, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.timeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pauseButton);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(224, 223);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(6, 64);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(210, 39);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hours : Minutes : Seconds : Miliseconds";
            // 
            // pauseButton
            // 
            this.pauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(0, 0);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(222, 49);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Start";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // coOptions
            // 
            this.coOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.coOptions.Location = new System.Drawing.Point(0, 0);
            this.coOptions.Name = "coOptions";
            this.coOptions.Size = new System.Drawing.Size(24, 223);
            this.coOptions.TabIndex = 0;
            this.coOptions.Text = "«";
            this.coOptions.UseVisualStyleBackColor = true;
            this.coOptions.Click += new System.EventHandler(this.coOptions_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 223);
            this.Controls.Add(this.PanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Timer";
            this.Text = "Timer";
            this.PanelContainer.Panel1.ResumeLayout(false);
            this.PanelContainer.Panel1.PerformLayout();
            this.PanelContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelContainer)).EndInit();
            this.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer PanelContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Button coOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox opt_alwaysontop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

