namespace WordClockTwo
{
    partial class ClockForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockForm));
            lblTime = new Label();
            lblDate = new Label();
            btnStart = new Button();
            btnStop = new Button();
            lblStopWatch = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.Font = new Font("Impact", 70F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(12, 34);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(1819, 587);
            lblTime.TabIndex = 0;
            lblTime.Text = "WORD CLOCK TWO";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(12, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(383, 25);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(758, 232);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(142, 61);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            btnStart.MouseEnter += btnStart_MouseEnter;
            btnStart.MouseLeave += btnStart_MouseLeave;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(919, 232);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(142, 61);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            btnStop.MouseEnter += btnStop_MouseEnter;
            btnStop.MouseLeave += btnStop_MouseLeave;
            // 
            // lblStopWatch
            // 
            lblStopWatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStopWatch.Font = new Font("Impact", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblStopWatch.ForeColor = Color.White;
            lblStopWatch.Location = new Point(0, 123);
            lblStopWatch.Name = "lblStopWatch";
            lblStopWatch.Size = new Size(1813, 106);
            lblStopWatch.TabIndex = 3;
            lblStopWatch.Text = "Press Start";
            lblStopWatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblStopWatch);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnStart);
            panel1.Location = new Point(12, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(1819, 368);
            panel1.TabIndex = 4;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1843, 907);
            Controls.Add(panel1);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WordClockTwo";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTime;
        private Label lblDate;
        private Button btnStart;
        private Button btnStop;
        private Label lblStopWatch;
        private Panel panel1;
    }
}