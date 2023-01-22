using System.Windows.Forms;
namespace ScreenShotApp
{
    public partial class Form1 : Form
    {
        public string directory{ get; set; }
        public static int inc;
        
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
          //  System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image myImage = Clipboard.GetImage();
            pictureBox1.Image = myImage;
            Image copy = pictureBox1.Image;
            //int inc = 0;
            inc += 1;
            string inc2 = "";
            inc2 = inc.ToString();
          //  copy.Save("D:\\pictures\\ScreenShot_" + inc2 + ".png");
            this.Show();
            if(directory != null)
            {
                string directory2 = "";
                directory2 = directory.ToString(); 
                textBoxTest.Text = directory;
                copy.Save(directory+"\\ScreenShot_" + inc2 + ".png");
            }
           
        }
    }
}