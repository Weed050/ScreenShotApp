using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Configuration;
using System.Net.Http.Json;  // add the NuGet package


namespace ScreenShotApp
{

    public partial class Form1 : Form
    {
        public static string? directory { get; set; }
        public static int inc;
        int x = 0;

        private HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
           // Form1 data = client.GetFromJsonAsync<Form1>(api);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("i.json")) 
            {
                string json = r.ReadToEnd();
                Class1 source = JsonSerializer.Deserialize<Class1>(json);
            }
            x += 1;
            //string jsonString = JsonSerializer.Serialize(destination, new JsonSerializerOptions() { WriteIndented = true });
            //using (StreamWriter outputFile = new StreamWriter("dataReady.json")) { outputFile.WriteLine(jsonString);
            //}



            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                textBoxDisplay.Text = diag.SelectedPath;
                directory = diag.SelectedPath;
            }
            else
            {
                textBoxDisplay.Text = "You didn't choose a folder";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // reading variable from .txt file =>


            //Open the File
            //   StreamReader sr = new StreamReader("c:\\ScreenShotApp\\i.txt");
            //  StreamWriter sw = new StreamReader("\\ScreenShotApp\\i.txt", true, Encoding.ASCII);

            //    x = (char)sr.Read();
            string path = @"i.txt";
          //  int z = 0;
            try
            {
                //if (File.Exists(path))
                //{
                //    File.Delete(path);
                //}
                using (StreamReader sr = new StreamReader(path))
                {
                    x = sr.Read();
                   // x = z.Parse();
                }
            }
            catch (Exception d)
            {
                Console.WriteLine("The process failed: {0}", d.ToString());
            }

            // end of reading from file <=

            this.Hide();
            // System.Threading.Thread.Sleep(200);
            SendKeys.Send("{PRTSC}");


            if (Clipboard.GetImage() != null)
            {
                Image myImage = Clipboard.GetImage();
                pictureBox1.Image = myImage;

            }

            Image copy = pictureBox1.Image;

            //int inc = 0;
            x += 1;
            string inc2 = "";
            inc2 = x.ToString();
            //  copy.Save("D:\\pictures\\ScreenShot_" + inc2 + ".png");
            this.Show();
            if (directory != null)
            {
                string directory2 = "";
                directory2 = directory.ToString();
                textBoxTest.Text = directory;
                copy.Save(directory + "\\ScreenShot_" + inc2 + ".png");

                //string jsonString = JsonSerializer.Serialize(destination, new JsonSerializerOptions() { WriteIndented = true });
                //using (StreamWriter outputFile = new StreamWriter("dataReady.json")) { outputFile.WriteLine(jsonString);
                //}

                // opening file and saving variable
                //   StreamWriter sw = new StreamWriter("i.txt", true, Encoding.ASCII);

                // sw.Write(inc2);

                //  sw.Close();
                // closing
            }


        }
    }
}