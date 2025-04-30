namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AboutAppBtn_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Marouan-el-yassini";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Hide();
            lf.Show();
            this.Hide();
        }
    }
}
