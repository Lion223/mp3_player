using System.Drawing;

namespace MP3Player
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.volumeBar = new MetroFramework.Controls.MetroTrackBar();
            this.soundprogressBar = new MetroFramework.Controls.MetroProgressBar();
            this.soundcurposLabel = new MetroFramework.Controls.MetroLabel();
            this.soundalltimeLabel = new MetroFramework.Controls.MetroLabel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.playlist = new System.Windows.Forms.ListBox();
            this.soundTimer = new System.Windows.Forms.Timer(this.components);
            this.volumeLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Image = global::MP3Player.Properties.Resources.play_arrow__1_;
            this.playBtn.Location = new System.Drawing.Point(123, 101);
            this.playBtn.Margin = new System.Windows.Forms.Padding(0);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(32, 32);
            this.playBtn.TabIndex = 1;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pauseBtn.FlatAppearance.BorderSize = 0;
            this.pauseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pauseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseBtn.Image = global::MP3Player.Properties.Resources.pause__1_;
            this.pauseBtn.Location = new System.Drawing.Point(71, 101);
            this.pauseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(32, 32);
            this.pauseBtn.TabIndex = 2;
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.stopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Image = global::MP3Player.Properties.Resources.stop_button__1_;
            this.stopBtn.Location = new System.Drawing.Point(172, 101);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(0);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(32, 32);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openBtn.FlatAppearance.BorderSize = 0;
            this.openBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.openBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Image = global::MP3Player.Properties.Resources.add_plus_button__1_;
            this.openBtn.Location = new System.Drawing.Point(23, 101);
            this.openBtn.Margin = new System.Windows.Forms.Padding(0);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(32, 32);
            this.openBtn.TabIndex = 4;
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.Red;
            this.volumeBar.Location = new System.Drawing.Point(315, 110);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(162, 23);
            this.volumeBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.volumeBar.TabIndex = 6;
            this.volumeBar.Text = "metroTrackBar2";
            this.volumeBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.volumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeBar_Scroll);
            // 
            // soundprogressBar
            // 
            this.soundprogressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundprogressBar.Location = new System.Drawing.Point(23, 178);
            this.soundprogressBar.Name = "soundprogressBar";
            this.soundprogressBar.Size = new System.Drawing.Size(454, 54);
            this.soundprogressBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.soundprogressBar.TabIndex = 7;
            this.soundprogressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.soundprogressBar.Click += new System.EventHandler(this.soundprogressBar_Click);
            // 
            // soundcurposLabel
            // 
            this.soundcurposLabel.Location = new System.Drawing.Point(23, 152);
            this.soundcurposLabel.Name = "soundcurposLabel";
            this.soundcurposLabel.Size = new System.Drawing.Size(67, 23);
            this.soundcurposLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.soundcurposLabel.TabIndex = 8;
            this.soundcurposLabel.Text = "00:00:00";
            this.soundcurposLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.soundcurposLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // soundalltimeLabel
            // 
            this.soundalltimeLabel.Location = new System.Drawing.Point(420, 156);
            this.soundalltimeLabel.Name = "soundalltimeLabel";
            this.soundalltimeLabel.Size = new System.Drawing.Size(57, 19);
            this.soundalltimeLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.soundalltimeLabel.TabIndex = 9;
            this.soundalltimeLabel.Text = "00:00:00";
            this.soundalltimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.soundalltimeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Multiselect = true;
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.playlist.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.playlist.FormattingEnabled = true;
            this.playlist.IntegralHeight = false;
            this.playlist.Location = new System.Drawing.Point(23, 254);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(454, 173);
            this.playlist.TabIndex = 10;
            this.playlist.DoubleClick += new System.EventHandler(this.playBtn_Click);
            // 
            // soundTimer
            // 
            this.soundTimer.Tick += new System.EventHandler(this.soundTimer_Tick);
            // 
            // volumeLabel
            // 
            this.volumeLabel.Location = new System.Drawing.Point(367, 88);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(57, 19);
            this.volumeLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.volumeLabel.TabIndex = 11;
            this.volumeLabel.Text = "50";
            this.volumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.volumeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // playerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.soundalltimeLabel);
            this.Controls.Add(this.soundcurposLabel);
            this.Controls.Add(this.soundprogressBar);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.playBtn);
            this.DisplayHeader = false;
            this.Name = "playerForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button openBtn;
        private MetroFramework.Controls.MetroTrackBar volumeBar;
        private MetroFramework.Controls.MetroProgressBar soundprogressBar;
        private MetroFramework.Controls.MetroLabel soundcurposLabel;
        private MetroFramework.Controls.MetroLabel soundalltimeLabel;
        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.Timer soundTimer;
        public System.Windows.Forms.OpenFileDialog ofd;
        private MetroFramework.Controls.MetroLabel volumeLabel;
    }
}

