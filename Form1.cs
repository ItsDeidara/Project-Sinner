using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Project_Sinner
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private string test;
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Project Sinner"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/yh5bh4l566t8q77/CHIP8_XBOX_ONE_V3.rar?dl=1"), System.IO.Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.MyDoc‌​uments), "Project Sinner", "CHIP8.rar"));

            }
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete!");
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged1;
                client.DownloadFileCompleted += Client_DownloadFileCompleted1;
                client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/ut124gswux57acs/NESBOX%20RELEASE2%20APPX%20PKG.rar?dl=1"), System.IO.Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.MyDoc‌​uments), "Project Sinner", "NesBOX.rar"));
            }
        }

        private void Client_DownloadFileCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        private void Client_DownloadProgressChanged1(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged2;
                client.DownloadFileCompleted += Client_DownloadFileCompleted2;
                client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/inxv8t8o0ov4g5x/psx-box-master.zip?dl=1"), System.IO.Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.MyDoc‌​uments), "Project Sinner", "psxbox.rar"));

            }
        }

        private void Client_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        private void Client_DownloadProgressChanged2(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged3;
                client.DownloadFileCompleted += Client_DownloadFileCompleted3;
                client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/nqgzpu8s311v6li/PPSSPP%20Release%20APPX%20PKG.rar?dl=1"), System.IO.Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.MyDoc‌​uments), "Project Sinner", "ppsspp.rar"));


            }
        }

        private void Client_DownloadFileCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        private void Client_DownloadProgressChanged3(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            {

                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged4;
                client.DownloadFileCompleted += Client_DownloadFileCompleted4;
                client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/wv82732vzc1c7xb/VBA10_1.22.197.0_Test.rar?dl=1"), System.IO.Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.MyDoc‌​uments), "Project Sinner", "VBA10.rar"));


            }
        }

        private void Client_DownloadFileCompleted4(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        private void Client_DownloadProgressChanged4(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            {

                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged5;
                client.DownloadFileCompleted += Client_DownloadFileCompleted5;
                client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/4eom5r6wgcx5gbu/Win64e10%20PKG.rar?dl=1"), System.IO.Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.MyDoc‌​uments), "Project Sinner", "Win64e10.rar"));


            }
        }

        private void Client_DownloadFileCompleted5(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        private void Client_DownloadProgressChanged5(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            {
                
                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged6;
                client.DownloadFileCompleted += Client_DownloadFileCompleted6;
                client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/ny2bqesif910fuy/DungeonRUN.rar?dl=1"), System.IO.Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.MyDoc‌​uments), "Project Sinner", "DungeonRUN.rar"));

            }
        }

        private void Client_DownloadFileCompleted6(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        private void Client_DownloadProgressChanged6(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            {

                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged7;
                client.DownloadFileCompleted += Client_DownloadFileCompleted7;
                client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/ny2bqesif910fuy/DungeonRUN.rar?dl=1"), System.IO.Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.MyDoc‌​uments), "Project Sinner", "2DZelda.rar"));


            }
        }

        private void Client_DownloadFileCompleted7(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        private void Client_DownloadProgressChanged7(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            string Version = "1.0.0.1";
            string NewVersion = "1.0.0.2";
            System.Net.WebClient request = new System.Net.WebClient();
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
    }
}
