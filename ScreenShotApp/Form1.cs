using System.Windows.Forms;
using System.IO;
using System.Text;
namespace ScreenShotApp
{
    public partial class Form1 : Form
    {
        public static string? directory{ get; set; }
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
            // reading variable from .txt file =>

            char x;

                //Open the File
             //   StreamReader sr = new StreamReader("c:\\ScreenShotApp\\i.txt");
                //  StreamWriter sw = new StreamReader("\\ScreenShotApp\\i.txt", true, Encoding.ASCII);

            //    x = (char)sr.Read();
            string path = @"c:\\ScreenShotApp\\i.txt";

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (StreamReader sr = new StreamReader(path))
                {
                    x = (char)sr.Read();
                }
            }
            catch (Exception d)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            // end of reading from file <=

            this.Hide();
          //  System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image copy = pictureBox1.Image;
            if (Clipboard.GetImage() != null)
            {
                Image myImage = Clipboard.GetImage();
                pictureBox1.Image = myImage;

            }

            //int inc = 0;
            x += 1;
            string inc2 = "";
            inc2 = x.ToString();
          //  copy.Save("D:\\pictures\\ScreenShot_" + inc2 + ".png");
            this.Show();
            if(directory != null)
            {
                string directory2 = "";
                directory2 = directory.ToString(); 
                textBoxTest.Text = directory;
                copy.Save(directory+"\\ScreenShot_" + inc2 + ".png");

                // opening file and saving variable
                StreamWriter sw = new StreamWriter("\\ScreenShotApp\\i.txt", true, Encoding.ASCII);

                sw.Write(inc2);

                sw.Close();
                // closing
            }
            
           
        }
    }
}