namespace Catch_Ball_WinFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
