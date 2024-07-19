using NAudio.Wave;
using System.Drawing;
using System.Windows.Forms;

namespace MP3_player
{
    partial class MP3Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3Player));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarProgress = new ColorSlider.ColorSlider();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.trackBarVolume = new ColorSlider.ColorSlider();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSongTitleSample = new System.Windows.Forms.Label();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSongDurationSample = new System.Windows.Forms.Label();
            this.lblSongDuration = new System.Windows.Forms.Label();
            this.listBoxTracks = new System.Windows.Forms.ListBox();
            this.playbackTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxTracks, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSelectDirectory);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxLanguage);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnSelectDirectory
            // 
            resources.ApplyResources(this.btnSelectDirectory, "btnSelectDirectory");
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.trackBarProgress, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxCover, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.trackBarVolume, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // trackBarProgress
            // 
            this.trackBarProgress.BackColor = System.Drawing.Color.Pink;
            this.trackBarProgress.BarInnerColor = System.Drawing.Color.Violet;
            this.trackBarProgress.BarPenColorBottom = System.Drawing.Color.MediumVioletRed;
            this.trackBarProgress.BarPenColorTop = System.Drawing.Color.MediumVioletRed;
            this.trackBarProgress.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.trackBarProgress.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.trackBarProgress.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.trackBarProgress.ElapsedPenColorTop = System.Drawing.Color.MediumPurple;
            resources.ApplyResources(this.trackBarProgress, "trackBarProgress");
            this.trackBarProgress.ForeColor = System.Drawing.Color.Pink;
            this.trackBarProgress.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.trackBarProgress.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.trackBarProgress.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Padding = 10;
            this.trackBarProgress.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.trackBarProgress.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.trackBarProgress.ShowDivisionsText = true;
            this.trackBarProgress.ShowSmallScale = false;
            this.trackBarProgress.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trackBarProgress.ThumbInnerColor = System.Drawing.Color.Turquoise;
            this.trackBarProgress.ThumbPenColor = System.Drawing.Color.Aqua;
            this.trackBarProgress.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.trackBarProgress.ThumbSize = new System.Drawing.Size(16, 16);
            this.trackBarProgress.TickAdd = 0F;
            this.trackBarProgress.TickColor = System.Drawing.Color.Pink;
            this.trackBarProgress.TickDivide = 0F;
            this.trackBarProgress.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trackBarProgress.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarProgress_Scroll);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnPrevious);
            this.flowLayoutPanel4.Controls.Add(this.btnPlayPause);
            this.flowLayoutPanel4.Controls.Add(this.btnNext);
            this.flowLayoutPanel4.Controls.Add(this.btnStop);
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.LightBlue;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.Image = ResizeImage(Properties.Resources.prev, new Size(32, 32));
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.LightBlue;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPlayPause, "btnPlayPause");
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            this.btnPlayPause.Image = ResizeImage(Properties.Resources.pause, new Size(32, 32));
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightBlue;
            this.btnNext.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.Image = ResizeImage(Properties.Resources.next, new Size(32, 32));
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightBlue;
            this.btnStop.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.Image = ResizeImage(Properties.Resources.close, new Size(32, 32));
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBoxCover, "pictureBoxCover");
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.TabStop = false;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.Pink;
            this.trackBarVolume.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.trackBarVolume.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.trackBarVolume.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.trackBarVolume.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.trackBarVolume.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.trackBarVolume.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            resources.ApplyResources(this.trackBarVolume, "trackBarVolume");
            this.trackBarVolume.ForeColor = System.Drawing.Color.Black;
            this.trackBarVolume.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.trackBarVolume.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.trackBarVolume.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Padding = 10;
            this.trackBarVolume.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.trackBarVolume.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.trackBarVolume.ShowDivisionsText = true;
            this.trackBarVolume.ShowSmallScale = false;
            this.trackBarVolume.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trackBarVolume.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.trackBarVolume.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.trackBarVolume.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.trackBarVolume.ThumbSize = new System.Drawing.Size(16, 16);
            this.trackBarVolume.TickAdd = 0F;
            this.trackBarVolume.TickColor = System.Drawing.Color.Black;
            this.trackBarVolume.TickDivide = 0F;
            this.trackBarVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.trackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarVolume_Scroll);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblSongTitleSample);
            this.flowLayoutPanel2.Controls.Add(this.lblSongTitle);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // lblSongTitleSample
            // 
            resources.ApplyResources(this.lblSongTitleSample, "lblSongTitleSample");
            this.lblSongTitleSample.Name = "lblSongTitleSample";
            // 
            // lblSongTitle
            // 
            resources.ApplyResources(this.lblSongTitle, "lblSongTitle");
            this.lblSongTitle.Name = "lblSongTitle";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblSongDurationSample);
            this.flowLayoutPanel3.Controls.Add(this.lblSongDuration);
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // lblSongDurationSample
            // 
            resources.ApplyResources(this.lblSongDurationSample, "lblSongDurationSample");
            this.lblSongDurationSample.Name = "lblSongDurationSample";
            // 
            // lblSongDuration
            // 
            resources.ApplyResources(this.lblSongDuration, "lblSongDuration");
            this.lblSongDuration.Name = "lblSongDuration";
            // 
            // listBoxTracks
            // 
            this.listBoxTracks.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxTracks, "listBoxTracks");
            this.listBoxTracks.Name = "listBoxTracks";
            this.listBoxTracks.SelectedIndexChanged += new System.EventHandler(this.listBoxTracks_SelectedIndexChanged);
            // 
            // playbackTimer
            // 
            this.playbackTimer.Interval = 1000;
            this.playbackTimer.Tick += new System.EventHandler(this.playbackTimer_Tick);
            // 
            // MP3Player
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MP3Player";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxTracks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label lblSongTitleSample;
        private System.Windows.Forms.Label lblSongDurationSample;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStop;
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private string currentDirectory;
        private System.Windows.Forms.Timer playbackTimer;
        private string currentTrack;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblSongTitle;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblSongDuration;
        private ColorSlider.ColorSlider trackBarVolume;
        private ColorSlider.ColorSlider trackBarProgress;
        private float currentVolume = 1f;

    }
}

