namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int greenLightCountdown = 45;
        private int yellowLightCountdown = 5;
        private int redLightCountdown = 45;

        public Form1()
        {
            InitializeComponent();

            // Setup the timer
            timerCountdown.Interval = 1000; // Timer will tick every 1 second
            timerCountdown.Tick += new EventHandler(timerCountdown_Tick);

            // Show the initial countdown value
            labelGreen.Text = greenLightCountdown.ToString();
            labelYellow.Visible = false;
            labelRed.Visible = false;

            // Start the countdown
            timerCountdown.Start();
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (greenLightCountdown > 0)
            {
                greenLightCountdown--;
                labelGreen.Text = greenLightCountdown.ToString();
            }
            else if (yellowLightCountdown > 0)
            {
                labelGreen.Visible = false;
                labelYellow.Visible = true;
                yellowLightCountdown--;
                labelYellow.Text = yellowLightCountdown.ToString();
            }
            else if (redLightCountdown > 0)
            {
                labelYellow.Visible = false;
                labelRed.Visible = true;
                redLightCountdown--;
                labelRed.Text = redLightCountdown.ToString();
            }
            else
            {
                labelRed.Visible = false;

                // Reset the countdown values
                greenLightCountdown = 45;
                yellowLightCountdown = 5;
                redLightCountdown = 45;

                // Make the green label visible again
                labelGreen.Visible = true;
                labelGreen.Text = greenLightCountdown.ToString();
            }
        }
    }
}
