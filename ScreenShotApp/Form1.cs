using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Configuration;
/*using System.Net.Http.Json;*/  // add the NuGet package
using Newtonsoft.Json;
using System.Text.Json.Nodes;


namespace ScreenShotApp
{

    public partial class Form1 : Form
    {
        public static string? directory { get; set; }
        public static int inc;
        public static int x;

        private HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            // Form1 data = client.GetFromJsonAsync<Form1>(api);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////using (StreamReader r = new StreamReader("i.json")) 
            ////{
            ////    string json = r.ReadToEnd();
            ////    Variables1 source = JsonSerializer.Deserialize<Variables1>(json);
            ////}

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

            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();
                
                int x = sr.Read();

            }
      
            //z = z + 1;
            //x = z.ToString();

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

                int z = 0;
                z = Int32.Parse(inc2);
                Variables1 variables = new Variables1()
                {
                    z = 0,
                    directory = "D:\\pictures"
                };

                string strResultJson = JsonConvert.SerializeObject(variables);
                File.WriteAllText(@"variables.json", strResultJson);
               


                // opening file and saving variable
                //  StreamWriter sw = new StreamWriter("i.txt", true, Encoding.ASCII);

                // sw.Write(inc2);

                //  sw.Close();
                // closing
            }


        }
    }
}