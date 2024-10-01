using ChurchTimer.Helpers;
using System;
using System.Configuration;

namespace ChurchTimer
{
    public partial class MainForm : Form
    {
        private int totalSeconds = 0;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer countdownTimer;
        private bool countdownended = false;
        private bool countdownPaused = false;
        private ExtendedDisplay countdownExtendedScreen;
        private bool showClock = false;
        private bool blink = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeTimer();

            countdownExtendedScreen = new ExtendedDisplay();
            countdownExtendedScreen.FormBorderStyle = FormBorderStyle.None;
            countdownExtendedScreen.StartPosition = FormStartPosition.CenterScreen;
            countdownExtendedScreen.Text = "";

            remainingTimeLb.ForeColor = Color.DarkGreen;
            countdownExtendedScreen.UpdateLabelColor(Color.DarkGreen);

            if (Screen.AllScreens.Length > 1)
            {
                Screen extendedScreen = Screen.AllScreens[1];
                countdownExtendedScreen.StartPosition = FormStartPosition.Manual;
                countdownExtendedScreen.WindowState = FormWindowState.Maximized;
                countdownExtendedScreen.Location = extendedScreen.WorkingArea.Location;
                countdownExtendedScreen.Show();
            }
            else
                countdownExtendedScreen.Show();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            var hours = Convert.ToInt32(hoursInput.Value);
            var minutes = Convert.ToInt32(minutesInput.Value);
            var seconds = Convert.ToInt32(secondsInput.Value);

            if (!countdownPaused) totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            if (startBtn.Text == "Pause")
            {
                countdownTimer?.Stop();
                startBtn.Text = "Start";
                countdownPaused = true;
            }
            else
            {
                InitializeCountDown();
                startBtn.Text = "Pause";
            }
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
            currentTimelb.Text = currentTime.ToString("HH:mm:ss tt");
            if (showClock)
            {
                countdownExtendedScreen.UpdateLabel(currentTime.ToString("HH:mm:ss"));
            }
        }

        private void InitializeCountDown()
        {
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += Countdown_Tick;
            countdownTimer.Start();
        }

        private void Countdown_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0 && !countdownended)
            {
                totalSeconds--;
                if (totalSeconds < 60)
                {
                    remainingTimeLb.ForeColor = Color.Red;
                    countdownExtendedScreen.UpdateLabelColor(Color.Red);
                }
                else if (totalSeconds < (60 * 5))
                {
                    remainingTimeLb.ForeColor = Color.SaddleBrown;
                    countdownExtendedScreen.UpdateLabelColor(Color.SaddleBrown);
                }
                UpdateCountdownLabel();
            }
            else
            {
                remainingTimeLb.ForeColor = Color.Red;
                countdownExtendedScreen.UpdateLabelColor(Color.Red);

                countdownended = true;
                totalSeconds++;
                UpdateCountdownLabel();
            }
        }

        private void UpdateCountdownLabel()
        {
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;
            if (!countdownended)
            {
                remainingTimeLb.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            }
            else
            {
                if (hours == 0 && minutes == 0 && seconds == 1)
                {
                    messageTxtbox.Text = "Time Up";
                }
                remainingTimeLb.Text = $"-{hours:D2}:{minutes:D2}:{seconds:D2}";

                if (blink)
                {
                    countdownExtendedScreen.UpdateMessageLabel(messageTxtbox.Text, Color.White);
                    countdownExtendedScreen.ChangeExtendedScreenBackgroundColor(Color.Red);
                    countdownExtendedScreen.UpdateLabelColor(Color.White);
                    blink = !blink;
                }
                else
                {
                    countdownExtendedScreen.UpdateMessageLabel(messageTxtbox.Text, Color.Red);
                    countdownExtendedScreen.ChangeExtendedScreenBackgroundColor(Color.White);
                    countdownExtendedScreen.UpdateLabelColor(Color.Red);
                    blink = !blink;
                }
            }
            countdownExtendedScreen.UpdateLabel(remainingTimeLb.Text);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            countdownTimer?.Stop();
            remainingTimeLb.Text = "00:00:00";
            startBtn.Text = "Start";
            countdownPaused = false;
            countdownended = false;
            countdownExtendedScreen.UpdateMessageLabel("", Color.Transparent);
            countdownExtendedScreen.ChangeExtendedScreenBackgroundColor(Color.White);
            countdownExtendedScreen.UpdateLabel(remainingTimeLb.Text);

            remainingTimeLb.ForeColor = Color.DarkGreen;
            countdownExtendedScreen.UpdateLabelColor(Color.DarkGreen);
        }

        private void messageBtn_Click(object sender, EventArgs e)
        {
            if (messageBtn.Text == "Show")
            {
                countdownExtendedScreen.UpdateMessageLabel(messageTxtbox.Text, Color.DarkOliveGreen);
                messageBtn.Text = "Clear";
            }
            else
            {
                countdownExtendedScreen.UpdateMessageLabel("", Color.White);
                messageBtn.Text = "Show";
            }
        }

        private void showClockBtn_Click(object sender, EventArgs e)
        {
            if (startBtn.Text != "Start")
            {
                return;
            }
            if (showClockBtn.Text == "Hide Clock")
            {
                showClock = false;
                showClockBtn.Text = "Show Clock";
            }
            else
            {
                showClock = true;
                showClockBtn.Text = "Hide Clock";
            }
        }
    }
}