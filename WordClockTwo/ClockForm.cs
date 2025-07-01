using System.Diagnostics;
using System.Windows.Forms;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace WordClockTwo
{
    public partial class ClockForm : Form
    {

        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Timer _secondsTimer;
        private System.Timers.Timer StopTimer = new System.Timers.Timer();

        private Stopwatch stopwatch = new Stopwatch();
        public int mode = 1;

        public ClockForm()
        {
            InitializeComponent();

            StopTimer.Interval = 100; // 1 second
            StopTimer.Elapsed += timer_Tick;
            UpdateTime();
            StartTimer();

        }

        // Start Timer----------------------------------------------------------------------------------
        private void StartTimer()
        {
            // Create a timer that ticks every second
            _timer = new System.Windows.Forms.Timer();
            _secondsTimer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000; // 1 second
            _secondsTimer.Interval = 15;
            _secondsTimer.Tick += (s, e) => UpdateSecondsBar();

            _timer.Tick += (s, e) =>
            {
                if (DateTime.Now.Second == 0) // only update on new minute
                {
                    UpdateTime();
                }
            };

            _timer.Start();
            _secondsTimer.Start();
        }

        // Update Seconds ----------------------------------------------------------------------------------
        private void UpdateSecondsBar()
        {
            int milliseconds = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            int totalMilliseconds = 60 * 1000;

            double percent = milliseconds / (double)totalMilliseconds;

            int containerWidth = panelSecondsContainer.Width;
            int newWidth = (int)(containerWidth * percent);

            // Optional: add a clamp
            newWidth = Math.Min(newWidth, containerWidth);

            panelSecondsBar.Width = newWidth;
        }

        // Update Time Label ----------------------------------------------------------------------------------
        private async void UpdateTime()
        {
            string newTime = ConvertTimeToWords(DateTime.Now);
            await FadeLabelAsync(lblTime, newTime);
            lblDate.Text = ConvertDateToWords(DateTime.Now);
        }

        // Fade Method 1/2----------------------------------------------------------------------------------
        private async Task FadeLabelAsync(Label label, string newText, int steps = 20, int interval = 25)
        {
            Color startColor = Color.White;
            Color endColor = Color.FromArgb(0, 0, 0, 0); // Transparent color

            // Fade out
            for (int i = 0; i < steps; i++)
            {
                float fraction = (float)i / (steps - 1);
                label.ForeColor = InterpolateColor(startColor, endColor, fraction);
                await Task.Delay(interval);
            }

            label.Text = newText;


            // Fade in
            for (int i = 0; i < steps; i++)
            {
                float fraction = (float)i / (steps - 1);
                label.ForeColor = InterpolateColor(endColor, startColor, fraction);
                await Task.Delay(interval);
            }
        }

        // Fade Method 2/2----------------------------------------------------------------------------------
        private Color InterpolateColor(Color start, Color end, float fraction)
        {
            int r = (int)(start.R + (end.R - start.R) * fraction);
            int g = (int)(start.G + (end.G - start.G) * fraction);
            int b = (int)(start.B + (end.B - start.B) * fraction);
            return Color.FromArgb(r, g, b);
        }

        // Convert time to words ----------------------------------------------------------------------------------
        private string ConvertTimeToWords(DateTime time)
        {
            string timeString = "";

            var numbersToWords = new Dictionary<int, string>
            {
                [0] = "Twelve",
                [1] = "One",
                [2] = "Two",
                [3] = "Three",
                [4] = "Four",
                [5] = "Five",
                [6] = "Six",
                [7] = "Seven",
                [8] = "Eight",
                [9] = "Nine",
                [10] = "Ten",
                [11] = "Eleven",
                [12] = "Twelve",
                [13] = "Thirteen",
                [14] = "Fourteen",
                [15] = "Fifteen",
                [16] = "Sixteen",
                [17] = "Seventeen",
                [18] = "Eighteen",
                [19] = "Nineteen",
                [20] = "Twenty",
                [30] = "Thirty",
                [40] = "Forty",
                [50] = "Fifty"
            };

            string NumberToWords(int num)
            {
                if (numbersToWords.ContainsKey(num)) return numbersToWords[num];
                return numbersToWords[num / 10 * 10] + "-" + numbersToWords[num % 10];
            }

            string TimePeriod(int hour)
            {
                if (hour < 12) return "In The Morning";
                else if (hour < 17) return "In The Afternoon";
                else if (hour < 20) return "In The Evening";
                else return "At Night";
            }

            int hour = time.Hour;
            int minute = time.Minute;
            string period = TimePeriod(hour);

            if (mode == 1)
            {
                if (minute == 0)
                {
                    timeString = $"{NumberToWords(hour % 12 == 0 ? 12 : hour % 12)} O'Clock {period}";
                }
                else if (minute == 1)
                {
                    timeString =
                        $"{NumberToWords(minute)} Minute Past {NumberToWords(hour % 12 == 0 ? 12 : hour % 12)} {period}";
                }
                else if (minute == 59)
                {
                    timeString =
                        $"{NumberToWords(60 - minute)} Minute To {NumberToWords((hour + 1) % 12 == 0 ? 12 : (hour + 1) % 12)} {period}";
                }
                else if (minute == 15)
                {
                    timeString = $"Quarter Past {NumberToWords(hour % 12 == 0 ? 12 : hour % 12)} {period}";
                }
                else if (minute == 30)
                {
                    timeString = $"Half Past {NumberToWords(hour % 12 == 0 ? 12 : hour % 12)} {period}";
                }
                else if (minute == 45)
                {
                    timeString = $"Quarter To {NumberToWords((hour + 1) % 12 == 0 ? 12 : (hour + 1) % 12)} {period}";
                }
                else if (minute < 30)
                {
                    timeString =
                        $"{NumberToWords(minute)} Minutes Past {NumberToWords(hour % 12 == 0 ? 12 : hour % 12)} {period}";
                }
                else // minute > 30
                {
                    timeString =
                        $"{NumberToWords(60 - minute)} Minutes To {NumberToWords((hour + 1) % 12 == 0 ? 12 : (hour + 1) % 12)} {period}";
                }
            }
            return timeString;
        }

        // Convert Date to Words ----------------------------------------------------------------------------------
        private string ConvertDateToWords(DateTime date)
        {
            string dateString = "";

            var numbersToWords = new Dictionary<int, string>
            {
                [1] = "First",
                [2] = "Second",
                [3] = "Third",
                [4] = "Fourth",
                [5] = "Fifth",
                [6] = "Sixth",
                [7] = "Seventh",
                [8] = "Eighth",
                [9] = "Ninth",
                [10] = "Tenth",
                [11] = "Eleventh",
                [12] = "Twelfth",
                [13] = "Thirteenth",
                [14] = "Fourteenth",
                [15] = "Fifteenth",
                [16] = "Sixteenth",
                [17] = "Seventeenth",
                [18] = "Eighteenth",
                [19] = "Nineteenth",
                [20] = "Twentieth",
                [21] = "Twenty-First",
                [22] = "Twenty-Second",
                [23] = "Twenty-Third",
                [24] = "Twenty-Fourth",
                [25] = "Twenty-Fifth",
                [26] = "Twenty-Sixth",
                [27] = "Twenty-Seventh",
                [28] = "Twenty-Eighth",
                [29] = "Twenty-Ninth",
                [30] = "Thirtieth",
                [31] = "Thirty-First"
            };

            string dayWord = date.ToString("dddd");
            string dayNumber = numbersToWords[date.Day];
            string dayNumberNow = date.ToString("dd");
            string month = date.ToString("MMMM");
            string year = date.ToString("yyyy");

            dateString = $"{dayWord} The {dayNumber} of {month}, {year}"; // Full Date String

            return dateString;
        }

        // Timer event handler for updating the elapsed time label ----------------------------------------------------
        private void timer_Tick(object sender, EventArgs e)
        {
            // Update the elapsed time label
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            TimeSpan elapsedTime = TimeSpan.FromMilliseconds(elapsedMilliseconds);

            string elapsedTimeText = elapsedTime.ToString("hh\\:mm\\:ss");
            lblStopWatch.Invoke(new Action(() => lblStopWatch.Text = elapsedTimeText));
        }

        //==========================================================================================================
        // Mouse Enter/Leave Events
        //==========================================================================================================

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                btnStart.BackColor = Color.LimeGreen;
                btnStart.ForeColor = Color.Black;
                Cursor = Cursors.Hand;
            }
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                btnStart.BackColor = Color.Black;
                btnStart.ForeColor = Color.White;
                Cursor = Cursors.Default;
            }
        }

        private void btnStop_MouseEnter(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                btnStop.BackColor = Color.Red;
                btnStop.ForeColor = Color.Black;
                Cursor = Cursors.Hand;
            }
        }

        private void btnStop_MouseLeave(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                btnStop.BackColor = Color.Black;
                btnStop.ForeColor = Color.White;
                Cursor = Cursors.Default;
            }
        }

        //==========================================================================================================
        // Buttons Clicked
        //==========================================================================================================

        // Start button Clicked --------------------------------------------------------------------------------------------
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                // Start the stopwatch and the timer
                stopwatch.Start();
                StopTimer.Start();

                // Update button colors for visual feedback
                btnStart.BackColor = Color.LimeGreen;
                btnStart.ForeColor = Color.Black;
                btnStop.BackColor = Color.Black;
                btnStop.ForeColor = Color.White;
                btnStop.Text = "Stop";
                Cursor = Cursors.Default;
            }
        }

        // Stop button Clicked --------------------------------------------------------------------------------------------
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                // Stop the stopwatch and the timer
                stopwatch.Stop();
                StopTimer.Stop();
                btnStop.BackColor = Color.Red;
                btnStop.ForeColor = Color.Black;
                btnStop.Text = "Reset";
                btnStart.BackColor = Color.Black;
                btnStart.ForeColor = Color.White;
                Cursor = Cursors.Default;
            }
            else
            {
                // Reset the stopwatch and the timer
                stopwatch.Reset();
                lblStopWatch.Text = "00:00:00";
                btnStop.BackColor = Color.Black;
                btnStop.ForeColor = Color.White;
                btnStop.Text = "Stop";
                btnStart.BackColor = Color.Black;
                btnStart.ForeColor = Color.White;
                Cursor = Cursors.Default;
            }
        }
    }
}