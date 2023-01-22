using System.Windows.Forms;
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
            this.Hide();
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            directory = directory.ToString();
            Image myImage = Clipboard.GetImage();
            pictureBox1.Image = myImage;
            Image copy = pictureBox1.Image;
            copy.Save("D:\\pictures");
            this.Show();
            textBoxTest.Text = directory;
        }
    }
}