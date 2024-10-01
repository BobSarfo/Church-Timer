namespace ChurchTimer
{
    public partial class ExtendedDisplay : Form
    {
        public ExtendedDisplay()
        {
            InitializeComponent();
            SetLabelFontSizeAndCenter(5.5);
        }

        private void SetLabelFontSizeAndCenter(double percentage)
        {
            // Calculate the font size based on the screen height
            float fontSize = (float)(Screen.PrimaryScreen.Bounds.Height / percentage);

            // Set the label's font size
            countdownLb.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 80, Screen.PrimaryScreen.Bounds.Height / 5);
            countdownLb.Font = new Font(countdownLb.Font.FontFamily, fontSize, FontStyle.Bold);

            messageLb.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 60, (int)(Screen.PrimaryScreen.Bounds.Height / 1.8));
            messageLb.Font = new Font(countdownLb.Font.FontFamily, (fontSize * (float)0.5), FontStyle.Bold);
        }

        public void UpdateLabel(string text)
        {
            countdownLb.Text = text;
        }

        public void UpdateLabelColor(Color color)
        {
            countdownLb.ForeColor = color;
        }

        public void ChangeExtendedScreenBackgroundColor(Color color)
        {
            this.BackColor = color;
        }

        public void UpdateMessageLabel(string message, Color color)
        {
            messageLb.BackColor = Color.Transparent;
            messageLb.ForeColor = color;
            messageLb.TextAlign = ContentAlignment.BottomCenter;
            messageLb.Text = message;
        }
    }
}