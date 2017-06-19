namespace Project_Sinner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Halo = new MetroFramework.Controls.MetroTabPage();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.Browse = new MetroFramework.Controls.MetroButton();
            this.VBA10Button = new MetroFramework.Controls.MetroButton();
            this.Win64eButton = new MetroFramework.Controls.MetroButton();
            this.PSPButton = new MetroFramework.Controls.MetroButton();
            this.NesButton = new MetroFramework.Controls.MetroButton();
            this.PSXboxButton = new MetroFramework.Controls.MetroButton();
            this.Chip8Download = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ZeldaButton = new MetroFramework.Controls.MetroButton();
            this.DungeonRunButton = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.OpenFolder = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.Halo.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Halo);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(30, 100);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(748, 538);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Halo
            // 
            this.Halo.Controls.Add(this.FolderTextBox);
            this.Halo.Controls.Add(this.Browse);
            this.Halo.Controls.Add(this.VBA10Button);
            this.Halo.Controls.Add(this.Win64eButton);
            this.Halo.Controls.Add(this.PSPButton);
            this.Halo.Controls.Add(this.NesButton);
            this.Halo.Controls.Add(this.PSXboxButton);
            this.Halo.Controls.Add(this.Chip8Download);
            this.Halo.HorizontalScrollbarBarColor = true;
            this.Halo.HorizontalScrollbarHighlightOnWheel = false;
            this.Halo.HorizontalScrollbarSize = 19;
            this.Halo.Location = new System.Drawing.Point(8, 41);
            this.Halo.Margin = new System.Windows.Forms.Padding(6);
            this.Halo.Name = "Halo";
            this.Halo.Size = new System.Drawing.Size(732, 489);
            this.Halo.TabIndex = 0;
            this.Halo.Text = "Emulators";
            this.Halo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Halo.VerticalScrollbarBarColor = true;
            this.Halo.VerticalScrollbarHighlightOnWheel = false;
            this.Halo.VerticalScrollbarSize = 20;
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.FolderTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.FolderTextBox.Location = new System.Drawing.Point(205, 23);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.ReadOnly = true;
            this.FolderTextBox.Size = new System.Drawing.Size(511, 31);
            this.FolderTextBox.TabIndex = 8;
            this.FolderTextBox.Text = "Default Install Directory is MyDocuments";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(6, 23);
            this.Browse.Margin = new System.Windows.Forms.Padding(6);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(158, 31);
            this.Browse.Style = MetroFramework.MetroColorStyle.Green;
            this.Browse.TabIndex = 7;
            this.Browse.Text = "Browse";
            this.Browse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Browse.UseSelectable = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // VBA10Button
            // 
            this.VBA10Button.Location = new System.Drawing.Point(6, 304);
            this.VBA10Button.Margin = new System.Windows.Forms.Padding(6);
            this.VBA10Button.Name = "VBA10Button";
            this.VBA10Button.Size = new System.Drawing.Size(334, 96);
            this.VBA10Button.Style = MetroFramework.MetroColorStyle.Green;
            this.VBA10Button.TabIndex = 6;
            this.VBA10Button.Text = "VBA 10 (GBA)";
            this.VBA10Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VBA10Button.UseSelectable = true;
            this.VBA10Button.Click += new System.EventHandler(this.VBA10Button_Click);
            this.VBA10Button.MouseEnter += new System.EventHandler(this.VBA10Button_MouseEnter);
            this.VBA10Button.MouseLeave += new System.EventHandler(this.VBA10Button_MouseLeave);
            // 
            // Win64eButton
            // 
            this.Win64eButton.Location = new System.Drawing.Point(384, 304);
            this.Win64eButton.Margin = new System.Windows.Forms.Padding(6);
            this.Win64eButton.Name = "Win64eButton";
            this.Win64eButton.Size = new System.Drawing.Size(334, 96);
            this.Win64eButton.Style = MetroFramework.MetroColorStyle.Green;
            this.Win64eButton.TabIndex = 5;
            this.Win64eButton.Text = "Win64e10 (N64)";
            this.Win64eButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Win64eButton.UseSelectable = true;
            this.Win64eButton.Click += new System.EventHandler(this.Win64eButton_Click);
            this.Win64eButton.MouseEnter += new System.EventHandler(this.Win64eButton_MouseEnter);
            this.Win64eButton.MouseLeave += new System.EventHandler(this.Win64eButton_MouseLeave);
            // 
            // PSPButton
            // 
            this.PSPButton.Location = new System.Drawing.Point(384, 193);
            this.PSPButton.Margin = new System.Windows.Forms.Padding(6);
            this.PSPButton.Name = "PSPButton";
            this.PSPButton.Size = new System.Drawing.Size(334, 96);
            this.PSPButton.Style = MetroFramework.MetroColorStyle.Green;
            this.PSPButton.TabIndex = 4;
            this.PSPButton.Text = "PPSSPP (PSP)";
            this.PSPButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PSPButton.UseSelectable = true;
            this.PSPButton.Click += new System.EventHandler(this.PSPButton_Click);
            this.PSPButton.MouseEnter += new System.EventHandler(this.PSPButton_MouseEnter);
            this.PSPButton.MouseLeave += new System.EventHandler(this.PSPButton_MouseLeave);
            // 
            // NesButton
            // 
            this.NesButton.Location = new System.Drawing.Point(384, 83);
            this.NesButton.Margin = new System.Windows.Forms.Padding(6);
            this.NesButton.Name = "NesButton";
            this.NesButton.Size = new System.Drawing.Size(334, 96);
            this.NesButton.Style = MetroFramework.MetroColorStyle.Green;
            this.NesButton.TabIndex = 3;
            this.NesButton.Text = "NesBOX (NES)";
            this.NesButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NesButton.UseSelectable = true;
            this.NesButton.Click += new System.EventHandler(this.NesButton_Click);
            this.NesButton.MouseEnter += new System.EventHandler(this.NesButton_MouseEnter);
            this.NesButton.MouseLeave += new System.EventHandler(this.NesButton_MouseLeave);
            // 
            // PSXboxButton
            // 
            this.PSXboxButton.Location = new System.Drawing.Point(6, 193);
            this.PSXboxButton.Margin = new System.Windows.Forms.Padding(6);
            this.PSXboxButton.Name = "PSXboxButton";
            this.PSXboxButton.Size = new System.Drawing.Size(334, 96);
            this.PSXboxButton.Style = MetroFramework.MetroColorStyle.Green;
            this.PSXboxButton.TabIndex = 2;
            this.PSXboxButton.Text = "PSX-BOX (PS1)";
            this.PSXboxButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PSXboxButton.UseSelectable = true;
            this.PSXboxButton.Click += new System.EventHandler(this.PSXboxButton_Click);
            // 
            // Chip8Download
            // 
            this.Chip8Download.Location = new System.Drawing.Point(6, 83);
            this.Chip8Download.Margin = new System.Windows.Forms.Padding(6);
            this.Chip8Download.Name = "Chip8Download";
            this.Chip8Download.Size = new System.Drawing.Size(334, 96);
            this.Chip8Download.Style = MetroFramework.MetroColorStyle.Green;
            this.Chip8Download.TabIndex = 0;
            this.Chip8Download.Text = "Chip8 (Chip8)";
            this.Chip8Download.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chip8Download.UseSelectable = true;
            this.Chip8Download.Click += new System.EventHandler(this.Chip8Download_Click);
            this.Chip8Download.MouseEnter += new System.EventHandler(this.Chip8Download_MouseEnter);
            this.Chip8Download.MouseLeave += new System.EventHandler(this.Chip8Download_MouseLeave);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.ZeldaButton);
            this.metroTabPage1.Controls.Add(this.DungeonRunButton);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 19;
            this.metroTabPage1.Location = new System.Drawing.Point(8, 41);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(732, 489);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Indie Games";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 20;
            // 
            // ZeldaButton
            // 
            this.ZeldaButton.Location = new System.Drawing.Point(392, 44);
            this.ZeldaButton.Margin = new System.Windows.Forms.Padding(6);
            this.ZeldaButton.Name = "ZeldaButton";
            this.ZeldaButton.Size = new System.Drawing.Size(334, 96);
            this.ZeldaButton.Style = MetroFramework.MetroColorStyle.Green;
            this.ZeldaButton.TabIndex = 7;
            this.ZeldaButton.Text = "2D Zelda";
            this.ZeldaButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ZeldaButton.UseSelectable = true;
            this.ZeldaButton.Click += new System.EventHandler(this.ZeldaButton_Click);
            this.ZeldaButton.MouseEnter += new System.EventHandler(this.ZeldaButton_MouseEnter);
            this.ZeldaButton.MouseLeave += new System.EventHandler(this.ZeldaButton_MouseLeave);
            // 
            // DungeonRunButton
            // 
            this.DungeonRunButton.Location = new System.Drawing.Point(6, 44);
            this.DungeonRunButton.Margin = new System.Windows.Forms.Padding(6);
            this.DungeonRunButton.Name = "DungeonRunButton";
            this.DungeonRunButton.Size = new System.Drawing.Size(334, 96);
            this.DungeonRunButton.Style = MetroFramework.MetroColorStyle.Green;
            this.DungeonRunButton.TabIndex = 5;
            this.DungeonRunButton.Text = "Dungeon Run";
            this.DungeonRunButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DungeonRunButton.UseSelectable = true;
            this.DungeonRunButton.Click += new System.EventHandler(this.DungeonRunButton_Click);
            this.DungeonRunButton.MouseEnter += new System.EventHandler(this.DungeonRunButton_MouseEnter);
            this.DungeonRunButton.MouseLeave += new System.EventHandler(this.DungeonRunButton_MouseLeave);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLink1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 19;
            this.metroTabPage2.Location = new System.Drawing.Point(8, 41);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(732, 489);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "About";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 20;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(240, 60);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(6);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(244, 44);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "Created by @Red7s";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroButton9
            // 
            this.metroButton9.Location = new System.Drawing.Point(532, 799);
            this.metroButton9.Margin = new System.Windows.Forms.Padding(6);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(222, 77);
            this.metroButton9.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton9.TabIndex = 7;
            this.metroButton9.Text = "Check for updates";
            this.metroButton9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton9.UseSelectable = true;
            this.metroButton9.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.FontSize = MetroFramework.MetroProgressBarSize.Tall;
            this.metroProgressBar1.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.metroProgressBar1.HideProgressText = false;
            this.metroProgressBar1.Location = new System.Drawing.Point(46, 645);
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(708, 87);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressBar1.TabIndex = 8;
            this.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // OpenFolder
            // 
            this.OpenFolder.Location = new System.Drawing.Point(46, 799);
            this.OpenFolder.Margin = new System.Windows.Forms.Padding(6);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(295, 77);
            this.OpenFolder.Style = MetroFramework.MetroColorStyle.Green;
            this.OpenFolder.TabIndex = 9;
            this.OpenFolder.Text = "Open Download Directory";
            this.OpenFolder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OpenFolder.UseSelectable = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 993);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroButton9);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Project Sinner";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.Halo.ResumeLayout(false);
            this.Halo.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Halo;
        private MetroFramework.Controls.MetroButton VBA10Button;
        private MetroFramework.Controls.MetroButton Win64eButton;
        private MetroFramework.Controls.MetroButton PSPButton;
        private MetroFramework.Controls.MetroButton NesButton;
        private MetroFramework.Controls.MetroButton PSXboxButton;
        private MetroFramework.Controls.MetroButton Chip8Download;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton ZeldaButton;
        private MetroFramework.Controls.MetroButton DungeonRunButton;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton Browse;
        private System.Windows.Forms.TextBox FolderTextBox;
        private MetroFramework.Controls.MetroButton OpenFolder;
    }
}

