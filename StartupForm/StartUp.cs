namespace StartupForm
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 4;
            }
            else
            {
                timer1.Stop();
                frmMain fm = new frmMain();
                fm.Show();
                this.Hide();
            }

        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //private void StartUp_Load(object sender, EventArgs e)
        //{
        //    //StartUp su = this.StartUp_Load();
        //    //this.timer1.Start();
        //    this.progressBar1.Increment(1);
        //    if (progressBar1.Value == progressBar1.Maximum)
        //    {
        //        timer1.Stop();
        //        this.Hide();
        //        frmMain fm = new frmMain();
        //        fm.Show();
        //    }
        //}
    }
}