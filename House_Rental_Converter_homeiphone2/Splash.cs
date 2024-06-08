namespace House_Rental_Converter_homeiphone2
{
    public partial class Splash : Form
    {
        ProgressBar progressBar;
        CheckRegisterationForm checkRegisterationForm=new CheckRegisterationForm();
        System.Windows.Forms.Timer timer;
        int progressValue = 0;
        public Splash()
        {
            InitializeComponent();
            progressBar = new ProgressBar();
            progressBar.Location = new Point(100, 420);
            progressBar.Size = new Size(300, 16);
            this.Controls.Add(progressBar);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            progressValue += 5;
            progressBar.Value = progressValue;
            if (progressBar.Value >= 100)
            {
                timer.Stop();
                checkRegisterationForm.FormClosed += (s, args) => this.Close();
                this.Hide();
                checkRegisterationForm.Show();
            }
        }
    }
}
