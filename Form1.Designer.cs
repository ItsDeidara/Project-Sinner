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
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.Browse = new MetroFramework.Controls.MetroButton();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
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
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.Halo.Controls.Add(this.metroButton7);
            this.Halo.Controls.Add(this.metroButton5);
            this.Halo.Controls.Add(this.metroButton4);
            this.Halo.Controls.Add(this.metroButton3);
            this.Halo.Controls.Add(this.metroButton2);
            this.Halo.Controls.Add(this.metroButton1);
            this.Halo.HorizontalScrollbarBarColor = true;
            this.Halo.HorizontalScrollbarHighlightOnWheel = false;
            this.Halo.HorizontalScrollbarSize = 19;
            this.Halo.Location = new System.Drawing.Point(8, 41);
            this.Halo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Halo.Name = "Halo";
            this.Halo.Size = new System.Drawing.Size(732, 489);
            this.Halo.TabIndex = 0;
            this.Halo.Text = "Emulators";
            this.Halo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Halo.VerticalScrollbarBarColor = true;
            this.Halo.VerticalScrollbarHighlightOnWheel = false;
            this.Halo.VerticalScrollbarSize = 20;
            this.Halo.Click += new System.EventHandler(this.Halo_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(6, 304);
            this.metroButton7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(334, 96);
            this.metroButton7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton7.TabIndex = 6;
            this.metroButton7.Text = "VBA 10 (GBA)";
            this.metroButton7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(384, 304);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(334, 96);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton5.TabIndex = 5;
            this.metroButton5.Text = "Win64e10 (N64)";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(384, 193);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(334, 96);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton4.TabIndex = 4;
            this.metroButton4.Text = "PPSSPP (PSP)";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(384, 83);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(334, 96);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "NesBOX (NES)";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(6, 193);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(334, 96);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "PSX-BOX (PS1)";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(6, 83);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(334, 96);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Chip8 (Chip8)";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton6);
            this.metroTabPage1.Controls.Add(this.metroButton8);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 19;
            this.metroTabPage1.Location = new System.Drawing.Point(8, 41);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(732, 489);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Indie Games";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 20;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(392, 44);
            this.metroButton6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(334, 96);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton6.TabIndex = 7;
            this.metroButton6.Text = "2D Zelda";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(6, 44);
            this.metroButton8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(334, 96);
            this.metroButton8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton8.TabIndex = 5;
            this.metroButton8.Text = "Dungeon Run";
            this.metroButton8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton8.UseSelectable = true;
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLink1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 19;
            this.metroTabPage2.Location = new System.Drawing.Point(8, 41);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.metroLink1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.metroButton9.Location = new System.Drawing.Point(278, 788);
            this.metroButton9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(708, 87);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressBar1.TabIndex = 8;
            this.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.FolderTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 993);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroButton9);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton Browse;
        private System.Windows.Forms.TextBox FolderTextBox;
    }
}

