using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Project_Sinner
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private FolderBrowserDialog myPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myPath = new FolderBrowserDialog();
            myPath.RootFolder = Environment.SpecialFolder.MyComputer;
            myPath.Description = "Choose folder to install Project Sinner";
        }

        public void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        public void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete!");
        }

        public void Client_Download(string dlLink, string dlName)
        {
            if (myPath.SelectedPath != "")
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri(dlLink), myPath.SelectedPath + "\\" + dlName);
            }
            else

            {
                var DefaultDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Project Sinner");
                Directory.CreateDirectory(DefaultDirectory);
                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri(dlLink), DefaultDirectory + "\\" + dlName);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            {
                Client_Download("https://www.dropbox.com/s/yh5bh4l566t8q77/CHIP8_XBOX_ONE_V3.rar?dl=1", "CHIP8.rar");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            {
                Client_Download("https://www.dropbox.com/s/ut124gswux57acs/NESBOX%20RELEASE2%20APPX%20PKG.rar?dl=1", "NesBOX.rar");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            {
                Client_Download("https://www.dropbox.com/s/inxv8t8o0ov4g5x/psx-box-master.zip?dl=1", "psxbox.rar");
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            {
                Client_Download("https://www.dropbox.com/s/nqgzpu8s311v6li/PPSSPP%20Release%20APPX%20PKG.rar?dl=1", "ppsspp.rar");
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            {
                Client_Download("https://www.dropbox.com/s/wv82732vzc1c7xb/VBA10_1.22.197.0_Test.rar?dl=1", "VBA10.rar");
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            {
                Client_Download("https://www.dropbox.com/s/4eom5r6wgcx5gbu/Win64e10%20PKG.rar?dl=1", "Win64e10.rar");
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            {
                Client_Download("https://www.dropbox.com/s/ny2bqesif910fuy/DungeonRUN.rar?dl=1", "DungeonRUN.rar");
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            {
                Client_Download("https://www.dropbox.com/s/ny2bqesif910fuy/DungeonRUN.rar?dl=1", "2DZelda.rar");
            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            string Version = "1.0.0.1";
            WebClient request = new WebClient();
            string Update = request.DownloadString("https://pastebin.com/raw/Qj09Y1Ea");
            if (Update.Contains(Version))
            {
                MessageBox.Show("Your software is up to date.");
            }
            else
            {
                MessageBox.Show("There is a new update, click OK to view the update.");
                Process.Start("https://www.se7ensins.com/forums/threads/release-project-sinner-an-xbox-one-homebrew-utility-v1-0.1645782/");
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Red7s");
        }

        private void Halo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = myPath.ShowDialog();
            if (result == DialogResult.OK)
            {                
                myPath.SelectedPath = myPath.SelectedPath + "\\Project Sinner";
                Directory.CreateDirectory(myPath.SelectedPath);
                FolderTextBox.Text = myPath.SelectedPath;
                return;
            }
        }
    }
}
