using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;

namespace MP3_player
{
    public partial class MP3Player : Form
    {
        public MP3Player()
        {
            InitializeComponent();
            InitializeLocalization();
        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void InitializeLocalization()
        {
            comboBoxLanguage.Items.Add("Русский");
            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.SelectedIndex = 0;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();
            switch (selectedLanguage)
            {
                case "English":
                    setCulture("en");
                    break;
                case "Русский":
                    setCulture("ru");
                    break;
            }
        }

        private void setCulture(string culture)
        {
            CultureInfo ci = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = ci;
            ApplyResourceToControl(this, new ComponentResourceManager(this.GetType()), ci);
        }

        private void ApplyResourceToControl(Control control, ComponentResourceManager resourceManager, CultureInfo culture)
        {
            foreach (Control c in control.Controls)
            {
                resourceManager.ApplyResources(c, c.Name, culture);
                ApplyResourceToControl(c, resourceManager, culture);
            }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    currentDirectory = folderBrowserDialog.SelectedPath;
                    LoadMp3Files(currentDirectory);
                }
            }
        }

        private void LoadMp3Files(string directory)
        {
            listBoxTracks.Items.Clear();
            string[] files = Directory.GetFiles(directory, "*.mp3");
            foreach (var file in files)
            {
                listBoxTracks.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void listBoxTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTracks.SelectedItem != null)
            {
                string selectedFile = Path.Combine(currentDirectory, listBoxTracks.SelectedItem.ToString() + ".mp3");
                PlayMp3File(selectedFile);
            }
        }

        private void PlayMp3File(string filePath)
        {
            if (audioFileReader != null)
            {
                waveOutDevice.Stop();
                audioFileReader.Dispose();
            }

            audioFileReader = new AudioFileReader(filePath);
            waveOutDevice = new WaveOut();
            waveOutDevice.Init(audioFileReader);
            audioFileReader.Volume = currentVolume;
            waveOutDevice.Play();

            lblSongTitle.Text = $"{Path.GetFileNameWithoutExtension(filePath)}";
            lblSongDuration.Text = $"{audioFileReader.TotalTime.ToString(@"mm\:ss")}";

            trackBarProgress.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
            playbackTimer.Start();

            DisplayTrackCover(filePath);
        }


        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (waveOutDevice == null) return;

            if (waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                waveOutDevice.Pause();
                playbackTimer.Stop();
                btnPlayPause.Image = ResizeImage(Properties.Resources.play, new Size(32, 32));
            }
            else
            {
                waveOutDevice.Play();
                playbackTimer.Start();
                btnPlayPause.Image = ResizeImage(Properties.Resources.pause, new Size(32, 32));
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                audioFileReader.Position = 0;
                playbackTimer.Stop();
                trackBarProgress.Value = 0;
                lblSongDuration.Text = $"{audioFileReader.TotalTime.ToString(@"mm\:ss")}";
                btnPlayPause.Image = ResizeImage(Properties.Resources.play, new Size(32, 32));
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int currentIndex = listBoxTracks.SelectedIndex;
            if (currentIndex > 0)
            {
                listBoxTracks.SelectedIndex = currentIndex - 1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentIndex = listBoxTracks.SelectedIndex;
            if (currentIndex < listBoxTracks.Items.Count - 1)
            {
                listBoxTracks.SelectedIndex = currentIndex + 1;
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                currentVolume = (float)trackBarVolume.Value / 100f;
                audioFileReader.Volume = currentVolume;
            }
        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds((double)trackBarProgress.Value);
            }
        }

        private void playbackTimer_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                trackBarProgress.Value = (int)audioFileReader.CurrentTime.TotalSeconds;
                lblSongDuration.Text = $"{audioFileReader.CurrentTime.ToString(@"mm\:ss")} / {audioFileReader.TotalTime.ToString(@"mm\:ss")}";

                if (audioFileReader.CurrentTime >= audioFileReader.TotalTime)
                {
                    playbackTimer.Stop();
                }
            }
        }

        private void DisplayTrackCover(string filePath)
        {
            try
            {
                var file = TagLib.File.Create(filePath);
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    pictureBoxCover.Image = Image.FromStream(new MemoryStream(bin));
                }
                else
                {
                    pictureBoxCover.Image = null;
                }
            }
            catch
            {
                pictureBoxCover.Image = null;
            }
        }
    }
}
