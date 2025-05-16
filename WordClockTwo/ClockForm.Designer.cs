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
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.Font = new Font("Impact", 70F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(12, 34);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(1819, 864);
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
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1843, 907);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClockForm";
            Text = "WordClockTwo";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTime;
        private Label lblDate;
    }
}