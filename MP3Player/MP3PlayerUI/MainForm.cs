using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace MP3Player
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        BackgroundWorker btncolorDelay = new BackgroundWorker();
        public MainForm()
        {
            InitializeComponent();
            MainCtrl.Link = this;
            MainCtrl.SetInputFormats();
            BassCtrl.InitBass(BassCtrl.hz);
            btncolorDelay.DoWork += new System.ComponentModel.DoWorkEventHandler(btncolorDelay_DoWork);
            btncolorDelay.WorkerSupportsCancellation = true;
        }

        public void btncolorDelay_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string btnName = (string)e.Argument;
            int delay = 75;

            switch (btnName)
            {
                case "playBtn":
                    playBtn.Image = global::MP3Player.Properties.Resources.play_arrow;
                    Thread.Sleep(delay);
                    playBtn.Image = global::MP3Player.Properties.Resources.play_arrow__1_;
                    break;
                case "pauseBtn":
                    pauseBtn.Image = global::MP3Player.Properties.Resources.pause;
                    Thread.Sleep(delay);
                    pauseBtn.Image = global::MP3Player.Properties.Resources.pause__1_;
                    break;
                case "stopBtn":
                    stopBtn.Image = global::MP3Player.Properties.Resources.stop_button;
                    Thread.Sleep(delay);
                    stopBtn.Image = global::MP3Player.Properties.Resources.stop_button__1_;
                    break;
                case "openBtn":
                    openBtn.Image = global::MP3Player.Properties.Resources.add_plus_button;
                    Thread.Sleep(delay);
                    openBtn.Image = global::MP3Player.Properties.Resources.add_plus_button__1_;
                    break;
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {

            if (!btncolorDelay.IsBusy)
            {
                btncolorDelay.RunWorkerAsync("playBtn");
            }
            if ((playlist.Items.Count != 0) && (playlist.SelectedIndex != -1))
            {
                string curr = MainCtrl.Files[playlist.SelectedIndex];
                MainCtrl.CurrTrackNumber = playlist.SelectedIndex;
                BassCtrl.Play(curr, BassCtrl.volume);
                soundcurposLabel.Text = TimeSpan.FromSeconds(BassCtrl.GetPosStream(BassCtrl.Stream)).ToString();
                soundalltimeLabel.Text = TimeSpan.FromSeconds(BassCtrl.GetTimeStream(BassCtrl.Stream)).ToString();
                soundprogressBar.Maximum = BassCtrl.GetTimeStream(BassCtrl.Stream);
                soundprogressBar.Value = BassCtrl.GetPosStream(BassCtrl.Stream);
                soundTimer.Enabled = true;
            }
            else if ((playlist.Items.Count != 0) && (playlist.SelectedIndex == -1))
            {
                playlist.SelectedIndex = 0;
                string curr = MainCtrl.Files[playlist.SelectedIndex];
                MainCtrl.CurrTrackNumber = playlist.SelectedIndex;
                BassCtrl.Play(curr, BassCtrl.volume);
                soundcurposLabel.Text = TimeSpan.FromSeconds(BassCtrl.GetPosStream(BassCtrl.Stream)).ToString();
                soundalltimeLabel.Text = TimeSpan.FromSeconds(BassCtrl.GetTimeStream(BassCtrl.Stream)).ToString();
                soundprogressBar.Maximum = BassCtrl.GetTimeStream(BassCtrl.Stream);
                soundprogressBar.Value = BassCtrl.GetPosStream(BassCtrl.Stream);
                soundTimer.Enabled = true;
            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (!btncolorDelay.IsBusy)
            {
                btncolorDelay.RunWorkerAsync("pauseBtn");
            }
            BassCtrl.Pause();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (!btncolorDelay.IsBusy)
            {
                btncolorDelay.RunWorkerAsync("stopBtn");
            }
            BassCtrl.Stop();
            soundTimer.Enabled = false;
            soundprogressBar.Value = 0;
            soundcurposLabel.Text = "00:00:00";
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (!btncolorDelay.IsBusy)
            {
                btncolorDelay.RunWorkerAsync("openBtn");
            }
            ofd.ShowDialog();
        }

        private void soundprogressBar_Click(object sender, EventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - soundprogressBar.Bounds.X);
            float calcFactor = soundprogressBar.Width / (float)soundprogressBar.Maximum;
            float relativeMouse = absoluteMouse / calcFactor;
            soundprogressBar.Value = Convert.ToInt32(relativeMouse);
            BassCtrl.SetPosBar(BassCtrl.Stream, soundprogressBar.Value);
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            string[] tmp = ofd.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                MainCtrl.Files.Add(tmp[i]);
                Tags tag = new Tags(tmp[i]);
                if (tag.Artist != null && tag.Title != null)
                    if (tag.Artist != "")
                        playlist.Items.Add(tag.Artist + " - " + tag.Title);
                    else
                        playlist.Items.Add(tag.Title);
                else
                    playlist.Items.Add(MainCtrl.GetFile(tmp[i]));
            }
        }

        private void soundTimer_Tick(object sender, EventArgs e)
        {
            soundcurposLabel.Text = TimeSpan.FromSeconds(BassCtrl.GetPosStream(BassCtrl.Stream)).ToString();
            soundprogressBar.Value = BassCtrl.GetPosStream(BassCtrl.Stream);

            if (BassCtrl.ToNext())
            {
                playlist.SelectedIndex = MainCtrl.CurrTrackNumber;
                soundcurposLabel.Text = TimeSpan.FromSeconds(BassCtrl.GetPosStream(BassCtrl.Stream)).ToString();
                soundalltimeLabel.Text = TimeSpan.FromSeconds(BassCtrl.GetTimeStream(BassCtrl.Stream)).ToString();
                soundprogressBar.Maximum = BassCtrl.GetTimeStream(BassCtrl.Stream);
                soundprogressBar.Value = BassCtrl.GetPosStream(BassCtrl.Stream);
            }

            if (BassCtrl.EndPlaylist)
            {
                stopBtn_Click(this, new EventArgs());
                playlist.SelectedIndex = MainCtrl.CurrTrackNumber = 0;
                BassCtrl.EndPlaylist = false;
            }
        }

        private void volumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            BassCtrl.SetVolume(BassCtrl.Stream, volumeBar.Value);
            volumeLabel.Text = volumeBar.Value.ToString();
        }
    }
}
