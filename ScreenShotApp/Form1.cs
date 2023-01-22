namespace ScreenShotApp
{
    public partial class Form1 : Form
    {
        public string directory{ get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                textBoxDisplay.Text = diag.SelectedPath;
                directory= diag.SelectedPath;
            }
            else
            {
                textBoxDisplay.Text = "You didn't choose a folder";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTest.Text = directory;
        }
    }
}