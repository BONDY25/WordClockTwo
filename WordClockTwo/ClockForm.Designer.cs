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
            panelSecondsBar = new Panel();
            panelSecondsContainer = new Panel();
            lblWeek = new Label();
            panelSecondsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.Font = new Font("Impact", 69.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(12, 34);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(1819, 587);
            lblTime.TabIndex = 0;
            lblTime.Text = "Hello There!";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(12, 43);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(383, 28);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Left;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(12, 758);
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
            btnStop.Anchor = AnchorStyles.Left;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(12, 834);
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
            lblStopWatch.Anchor = AnchorStyles.Left;
            lblStopWatch.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblStopWatch.ForeColor = Color.White;
            lblStopWatch.Location = new Point(12, 686);
            lblStopWatch.Name = "lblStopWatch";
            lblStopWatch.Size = new Size(380, 69);
            lblStopWatch.TabIndex = 3;
            lblStopWatch.Text = "Press Start";
            lblStopWatch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelSecondsBar
            // 
            panelSecondsBar.Anchor = AnchorStyles.Left;
            panelSecondsBar.BackColor = Color.White;
            panelSecondsBar.Location = new Point(3, 6);
            panelSecondsBar.Name = "panelSecondsBar";
            panelSecondsBar.Size = new Size(200, 13);
            panelSecondsBar.TabIndex = 5;
            // 
            // panelSecondsContainer
            // 
            panelSecondsContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSecondsContainer.Controls.Add(panelSecondsBar);
            panelSecondsContainer.Location = new Point(12, 12);
            panelSecondsContainer.Name = "panelSecondsContainer";
            panelSecondsContainer.Size = new Size(1819, 28);
            panelSecondsContainer.TabIndex = 6;
            // 
            // lblWeek
            // 
            lblWeek.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeek.ForeColor = Color.White;
            lblWeek.Location = new Point(12, 71);
            lblWeek.Name = "lblWeek";
            lblWeek.Size = new Size(383, 28);
            lblWeek.TabIndex = 7;
            lblWeek.Text = "Week";
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1843, 907);
            Controls.Add(lblWeek);
            Controls.Add(panelSecondsContainer);
            Controls.Add(btnStop);
            Controls.Add(lblStopWatch);
            Controls.Add(btnStart);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WordClockTwo";
            WindowState = FormWindowState.Maximized;
            panelSecondsContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTime;
        private Label lblDate;
        private Button btnStart;
        private Button btnStop;
        private Label lblStopWatch;
        private Panel panelSecondsBar;
        private Panel panelSecondsContainer;
        private Label lblWeek;
    }
}