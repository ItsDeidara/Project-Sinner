using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Project_Sinner
{
    public partial class Form1 : MetroForm
    {
        private FolderBrowserDialog _myPath;
        private ToolTip _myToolTip;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _myPath = new FolderBrowserDialog();
            _myPath.RootFolder = Environment.SpecialFolder.MyComputer;
            _myPath.Description = "Choose folder to install Project Sinner";
            _myToolTip = new ToolTip();
        }

        public void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = (int) e.TotalBytesToReceive / 100;
            metroProgressBar1.Value = (int) e.BytesReceived / 100;
        }

        public void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete!");
        }

        public void Client_Download(string dlLink, string dlName)
        {
            if (_myPath.SelectedPath != "")
            {
                Directory.CreateDirectory(_myPath.SelectedPath);
                var client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri(dlLink), _myPath.SelectedPath + "\\" + dlName);
            }
            else
            {
                var DefaultDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "Project Sinner");
                Directory.CreateDirectory(DefaultDirectory);
                var client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri(dlLink), DefaultDirectory + "\\" + dlName);
            }
        }

        private void Chip8Download_Click(object sender, EventArgs e)
        {
            Client_Download("https://www.dropbox.com/s/yh5bh4l566t8q77/CHIP8_XBOX_ONE_V3.rar?dl=1", "CHIP8.rar");
        }

        private void Chip8Download_MouseEnter(object sender, EventArgs e)
        {
            _myToolTip.Show("Chip8 is a virtual machine that was developed in the 1970\'s to play small games. \n" +
                            "Games like Space Invaders, Pong, Tetris, etc. This is a Chip 8 Emulator for Xbox One. ", 
                            Chip8Download);
        }

        private void Chip8Download_MouseLeave(object sender, EventArgs e)
        {
            _myToolTip.Hide(Chip8Download);
        }

        private void NesButton_Click(object sender, EventArgs e)
        {
            Client_Download("https://www.dropbox.com/s/ut124gswux57acs/NESBOX%20RELEASE2%20APPX%20PKG.rar?dl=1",
                    "NesBOX.rar");
        }
        private void NesButton_MouseEnter(object sender, EventArgs e)
        {
            _myToolTip.Show("NESBox is a XBox One emulater that allows you to play NES, SNES, GENESIS, GB, GBC, and GBA games.",
                NesButton);
        }

        private void NesButton_MouseLeave(object sender, EventArgs e)
        {
            _myToolTip.Hide(NesButton);
        }

        private void PSXboxButton_Click(object sender, EventArgs e)
        {
            Client_Download("https://www.dropbox.com/s/inxv8t8o0ov4g5x/psx-box-master.zip?dl=1", "psxbox.rar");
            
        }

        private void PSPButton_Click(object sender, EventArgs e)
        {
            Client_Download("https://www.dropbox.com/s/nqgzpu8s311v6li/PPSSPP%20Release%20APPX%20PKG.rar?dl=1",
                    "ppsspp.rar");
        }

        private void PSPButton_MouseEnter(object sender, EventArgs e)
        {
            _myToolTip.Show("This is a PSP emulator for the Xbox one. It can play PSP backups off usb or hard drive.", PSPButton);
        }

        private void PSPButton_MouseLeave(object sender, EventArgs e)
        {
            _myToolTip.Hide(PSPButton);
        }

        private void VBA10Button_Click(object sender, EventArgs e)
        {
            Client_Download("https://www.dropbox.com/s/wv82732vzc1c7xb/VBA10_1.22.197.0_Test.rar?dl=1",
                    "VBA10.rar");
        }

        private void VBA10Button_MouseEnter(object sender, EventArgs e)
        {
            _myToolTip.Show("VBA10 is a GameBoy, GameBoy Colour and GameBoy Advance emulator, this is a UWP port for the \n " +
                            "Xbox One, which can be installed on any Xbox One with Dev Mode Enabled.", VBA10Button);
        }

        private void VBA10Button_MouseLeave(object sender, EventArgs e)
        {
            _myToolTip.Hide(VBA10Button);
        }

        private void Win64eButton_Click(object sender, EventArgs e)
        {
            Client_Download("https://www.dropbox.com/s/4eom5r6wgcx5gbu/Win64e10%20PKG.rar?dl=1", "Win64e10.rar");
        }

        private void Win64eButton_MouseEnter(object sender, EventArgs e)
        {
            _myToolTip.Show("Win64E is a Nintendo 64 Emulator for the Xbox One.", Win64eButton);
        }

        private void Win64eButton_MouseLeave(object sender, EventArgs e)
        {
            _myToolTip.Hide(Win64eButton);
        }

        private void DungeonRunButton_Click(object sender, EventArgs e)
        {
            Client_Download("https://www.dropbox.com/s/ny2bqesif910fuy/DungeonRUN.rar?dl=1", "DungeonRUN.rar");
        }

        private void DungeonRunButton_MouseEnter(object sender, EventArgs e)
        {
            _myToolTip.Show("Dungeon Run is a 2D Zelda clone made to run on Xbox One.", DungeonRunButton);
        }

        private void DungeonRunButton_MouseLeave(object sender, EventArgs e)
        {
            _myToolTip.Hide(DungeonRunButton);
        }

        private void ZeldaButton_Click(object sender, EventArgs e)
        {
            Client_Download("https://www.dropbox.com/s/ny2bqesif910fuy/DungeonRUN.rar?dl=1", "2DZelda.rar");
        }

        private void ZeldaButton_MouseEnter(object sender, EventArgs e)
        {
            _myToolTip.Show(
                "What the hell Red, this is the exact same link as Dungeon Run. Need to add more links.......",
                ZeldaButton);
        }

        private void ZeldaButton_MouseLeave(object sender, EventArgs e)
        {
            _myToolTip.Hide(ZeldaButton);
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            var open = "/select, " + _myPath.SelectedPath;
            Process.Start("explorer.exe", open);
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            var version = "1.0.1.1";
            var request = new WebClient();
            var update = request.DownloadString("https://pastebin.com/raw/Qj09Y1Ea");
            if (update.Contains(version))
            {
                MessageBox.Show("Your software is up to date.");
            }
            else
            {
                MessageBox.Show("There is a new update, click OK to view the update.");
                Process.Start(
                    "https://www.se7ensins.com/forums/threads/release-project-sinner-an-xbox-one-homebrew-utility-v1-0.1645782/");
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Red7s");
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var result = _myPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                _myPath.SelectedPath = _myPath.SelectedPath + "\\Project Sinner";
                FolderTextBox.Text = _myPath.SelectedPath;
            }
        }
    }
}