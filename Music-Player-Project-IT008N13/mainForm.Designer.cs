using Music_Player_Project_IT008N13.Controls;
using System.Windows.Forms;

namespace Music_Player_Project_IT008N13
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelSlider = new System.Windows.Forms.Panel();
            slider1 = new Music_Player_Project_IT008N13.Controls.Slider();
            lbDurationItem = new System.Windows.Forms.Label();
            lbCurrentDuration = new System.Windows.Forms.Label();
            this.panelControlPlayer = new System.Windows.Forms.Panel();
            this.btnShuffle = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.panelVolume = new System.Windows.Forms.Panel();
            this.btnVolume = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVolumn = new System.Windows.Forms.Label();
            this.btnLoop = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnPrevious = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnNext = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnPlayPause = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnHome = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnMusicLibrary = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnVideoLibrary = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnPlayQueue = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnPlayListChild2 = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnPlayListChild1 = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnPlayListsMain = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnSetting = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelNameApp = new System.Windows.Forms.Label();
            this.ptBImageApp = new System.Windows.Forms.PictureBox();
            this.backBtn = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.txtBSearch = new System.Windows.Forms.TextBox();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.paneltopMenuBar = new System.Windows.Forms.Panel();
            this.panelDropDownPlayLists = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUserControl = new System.Windows.Forms.Panel();
            this.panelControlSizeExitApp = new System.Windows.Forms.Panel();
            this.btnMinimize = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnExit = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnMaximize = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.addHomeForm1 = new Music_Player_Project_IT008N13.addHomeForm();
            this.addMusicForm1 = new Music_Player_Project_IT008N13.addMusicForm();
            this.addVideoForm1 = new Music_Player_Project_IT008N13.addVideoForm();
            this.addMediaQueueForm1 = new Music_Player_Project_IT008N13.addMediaQueueForm();
            this.addPlaylistForm1 = new Music_Player_Project_IT008N13.addPlaylistForm();
            this.addSettingForm1 = new Music_Player_Project_IT008N13.addSettingForm();
            player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelControl.SuspendLayout();
            this.panelSlider.SuspendLayout();
            this.panelControlPlayer.SuspendLayout();
            this.panelVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBImageApp)).BeginInit();
            this.panelMenuBar.SuspendLayout();
            this.paneltopMenuBar.SuspendLayout();
            this.panelDropDownPlayLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUserControl.SuspendLayout();
            this.panelControlSizeExitApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(player)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl.Controls.Add(this.panelSlider);
            this.panelControl.Controls.Add(this.panelControlPlayer);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 790);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1400, 110);
            this.panelControl.TabIndex = 4;
            // 
            // panelSlider
            // 
            this.panelSlider.Controls.Add(slider1);
            this.panelSlider.Controls.Add(lbDurationItem);
            this.panelSlider.Controls.Add(lbCurrentDuration);
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSlider.Location = new System.Drawing.Point(0, 0);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(1398, 31);
            this.panelSlider.TabIndex = 10;
            // 
            // slider1
            // 
            slider1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            slider1.ChannelHeight = 6;
            slider1.Dock = System.Windows.Forms.DockStyle.Top;
            slider1.ForeBackColor = System.Drawing.Color.Transparent;
            slider1.ForeColor = System.Drawing.Color.Transparent;
            slider1.Location = new System.Drawing.Point(34, 0);
            slider1.Name = "slider1";
            slider1.ShowMaximum = false;
            slider1.ShowValue = Music_Player_Project_IT008N13.Controls.TextPosition.Right;
            slider1.Size = new System.Drawing.Size(1330, 10);
            slider1.SliderColor = System.Drawing.Color.RoyalBlue;
            slider1.SliderHeight = 6;
            slider1.SymbolAfter = "";
            slider1.SymbolBefore = "";
            slider1.TabIndex = 2;
            // 
            // lbDurationItem
            // 
            lbDurationItem.AutoSize = true;
            lbDurationItem.Dock = System.Windows.Forms.DockStyle.Right;
            lbDurationItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbDurationItem.ForeColor = System.Drawing.Color.White;
            lbDurationItem.Location = new System.Drawing.Point(1364, 0);
            lbDurationItem.Name = "lbDurationItem";
            lbDurationItem.Size = new System.Drawing.Size(34, 13);
            lbDurationItem.TabIndex = 14;
            lbDurationItem.Text = "00:00";
            // 
            // lbCurrentDuration
            // 
            lbCurrentDuration.AutoSize = true;
            lbCurrentDuration.Dock = System.Windows.Forms.DockStyle.Left;
            lbCurrentDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbCurrentDuration.ForeColor = System.Drawing.Color.White;
            lbCurrentDuration.Location = new System.Drawing.Point(0, 0);
            lbCurrentDuration.Name = "lbCurrentDuration";
            lbCurrentDuration.Size = new System.Drawing.Size(34, 13);
            lbCurrentDuration.TabIndex = 13;
            lbCurrentDuration.Text = "00:00";
            // 
            // panelControlPlayer
            // 
            this.panelControlPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlPlayer.Controls.Add(this.btnShuffle);
            this.panelControlPlayer.Controls.Add(this.panelVolume);
            this.panelControlPlayer.Controls.Add(this.btnLoop);
            this.panelControlPlayer.Controls.Add(this.btnPrevious);
            this.panelControlPlayer.Controls.Add(this.btnNext);
            this.panelControlPlayer.Controls.Add(this.btnPlayPause);
            this.panelControlPlayer.Location = new System.Drawing.Point(0, 38);
            this.panelControlPlayer.Name = "panelControlPlayer";
            this.panelControlPlayer.Size = new System.Drawing.Size(1398, 70);
            this.panelControlPlayer.TabIndex = 15;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnShuffle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShuffle.BorderRadius = 2;
            this.btnShuffle.BorderSize = 0;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.ForeColor = System.Drawing.Color.White;
            this.btnShuffle.Location = new System.Drawing.Point(581, 20);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(35, 35);
            this.btnShuffle.TabIndex = 10;
            this.btnShuffle.TextColor = System.Drawing.Color.White;
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // panelVolume
            // 
            this.panelVolume.Controls.Add(this.btnVolume);
            this.panelVolume.Controls.Add(this.trackBar1);
            this.panelVolume.Controls.Add(this.label1);
            this.panelVolume.Controls.Add(this.lbVolumn);
            this.panelVolume.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelVolume.Location = new System.Drawing.Point(1249, 0);
            this.panelVolume.Name = "panelVolume";
            this.panelVolume.Size = new System.Drawing.Size(149, 70);
            this.panelVolume.TabIndex = 16;
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolume.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolume.BorderRadius = 2;
            this.btnVolume.BorderSize = 0;
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.ForeColor = System.Drawing.Color.White;
            this.btnVolume.Location = new System.Drawing.Point(3, 20);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(35, 35);
            this.btnVolume.TabIndex = 15;
            this.btnVolume.TextColor = System.Drawing.Color.White;
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.trackBar1.Location = new System.Drawing.Point(43, 20);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(94, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "%";
            // 
            // lbVolumn
            // 
            this.lbVolumn.AutoSize = true;
            this.lbVolumn.ForeColor = System.Drawing.Color.White;
            this.lbVolumn.Location = new System.Drawing.Point(54, 5);
            this.lbVolumn.Name = "lbVolumn";
            this.lbVolumn.Size = new System.Drawing.Size(19, 13);
            this.lbVolumn.TabIndex = 13;
            this.lbVolumn.Text = "15";
            // 
            // btnLoop
            // 
            this.btnLoop.BackColor = System.Drawing.Color.Transparent;
            this.btnLoop.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLoop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoop.BorderRadius = 2;
            this.btnLoop.BorderSize = 0;
            this.btnLoop.FlatAppearance.BorderSize = 0;
            this.btnLoop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnLoop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoop.ForeColor = System.Drawing.Color.White;
            this.btnLoop.Location = new System.Drawing.Point(775, 20);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(35, 35);
            this.btnLoop.TabIndex = 14;
            this.btnLoop.TextColor = System.Drawing.Color.White;
            this.btnLoop.UseVisualStyleBackColor = false;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrevious.BorderRadius = 2;
            this.btnPrevious.BorderSize = 0;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(622, 20);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.TextColor = System.Drawing.Color.White;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 2;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(734, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 13;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlayPause.BorderRadius = 60;
            this.btnPlayPause.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Location = new System.Drawing.Point(663, 2);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(65, 65);
            this.btnPlayPause.TabIndex = 12;
            this.btnPlayPause.TextColor = System.Drawing.Color.White;
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 8;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(4, 93);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(304, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Tag = "home";
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMusicLibrary
            // 
            this.btnMusicLibrary.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicLibrary.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMusicLibrary.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMusicLibrary.BorderRadius = 8;
            this.btnMusicLibrary.BorderSize = 0;
            this.btnMusicLibrary.FlatAppearance.BorderSize = 0;
            this.btnMusicLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnMusicLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMusicLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicLibrary.ForeColor = System.Drawing.Color.White;
            this.btnMusicLibrary.Location = new System.Drawing.Point(4, 131);
            this.btnMusicLibrary.Name = "btnMusicLibrary";
            this.btnMusicLibrary.Size = new System.Drawing.Size(304, 36);
            this.btnMusicLibrary.TabIndex = 1;
            this.btnMusicLibrary.Tag = "music library";
            this.btnMusicLibrary.Text = "Music library";
            this.btnMusicLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusicLibrary.TextColor = System.Drawing.Color.White;
            this.btnMusicLibrary.UseVisualStyleBackColor = false;
            this.btnMusicLibrary.Click += new System.EventHandler(this.bbtnMusicLibrary_Click);
            // 
            // btnVideoLibrary
            // 
            this.btnVideoLibrary.BackColor = System.Drawing.Color.Transparent;
            this.btnVideoLibrary.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnVideoLibrary.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVideoLibrary.BorderRadius = 8;
            this.btnVideoLibrary.BorderSize = 0;
            this.btnVideoLibrary.FlatAppearance.BorderSize = 0;
            this.btnVideoLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnVideoLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnVideoLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoLibrary.ForeColor = System.Drawing.Color.White;
            this.btnVideoLibrary.Location = new System.Drawing.Point(4, 169);
            this.btnVideoLibrary.Name = "btnVideoLibrary";
            this.btnVideoLibrary.Size = new System.Drawing.Size(304, 36);
            this.btnVideoLibrary.TabIndex = 2;
            this.btnVideoLibrary.Tag = "video library";
            this.btnVideoLibrary.Text = "Video library";
            this.btnVideoLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideoLibrary.TextColor = System.Drawing.Color.White;
            this.btnVideoLibrary.UseVisualStyleBackColor = false;
            this.btnVideoLibrary.Click += new System.EventHandler(this.btnVideoLibrary_Click);
            // 
            // btnPlayQueue
            // 
            this.btnPlayQueue.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayQueue.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlayQueue.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlayQueue.BorderRadius = 8;
            this.btnPlayQueue.BorderSize = 0;
            this.btnPlayQueue.FlatAppearance.BorderSize = 0;
            this.btnPlayQueue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnPlayQueue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPlayQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayQueue.ForeColor = System.Drawing.Color.White;
            this.btnPlayQueue.Location = new System.Drawing.Point(4, 218);
            this.btnPlayQueue.Name = "btnPlayQueue";
            this.btnPlayQueue.Size = new System.Drawing.Size(304, 36);
            this.btnPlayQueue.TabIndex = 3;
            this.btnPlayQueue.Tag = "play queue";
            this.btnPlayQueue.Text = "Play queue";
            this.btnPlayQueue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayQueue.TextColor = System.Drawing.Color.White;
            this.btnPlayQueue.UseVisualStyleBackColor = false;
            this.btnPlayQueue.Click += new System.EventHandler(this.btnPlayQueue_Click);
            // 
            // btnPlayListChild2
            // 
            this.btnPlayListChild2.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayListChild2.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlayListChild2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlayListChild2.BorderRadius = 8;
            this.btnPlayListChild2.BorderSize = 0;
            this.btnPlayListChild2.FlatAppearance.BorderSize = 0;
            this.btnPlayListChild2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnPlayListChild2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPlayListChild2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayListChild2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayListChild2.ForeColor = System.Drawing.Color.White;
            this.btnPlayListChild2.Location = new System.Drawing.Point(4, 76);
            this.btnPlayListChild2.Name = "btnPlayListChild2";
            this.btnPlayListChild2.Size = new System.Drawing.Size(304, 36);
            this.btnPlayListChild2.TabIndex = 7;
            this.btnPlayListChild2.Tag = "playlists2";
            this.btnPlayListChild2.Text = "Playlist2";
            this.btnPlayListChild2.TextColor = System.Drawing.Color.White;
            this.btnPlayListChild2.UseVisualStyleBackColor = false;
            // 
            // btnPlayListChild1
            // 
            this.btnPlayListChild1.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayListChild1.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlayListChild1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlayListChild1.BorderRadius = 8;
            this.btnPlayListChild1.BorderSize = 0;
            this.btnPlayListChild1.FlatAppearance.BorderSize = 0;
            this.btnPlayListChild1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnPlayListChild1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPlayListChild1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayListChild1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayListChild1.ForeColor = System.Drawing.Color.White;
            this.btnPlayListChild1.Location = new System.Drawing.Point(4, 38);
            this.btnPlayListChild1.Name = "btnPlayListChild1";
            this.btnPlayListChild1.Size = new System.Drawing.Size(304, 36);
            this.btnPlayListChild1.TabIndex = 6;
            this.btnPlayListChild1.Tag = "playlists1";
            this.btnPlayListChild1.Text = "Playlist1";
            this.btnPlayListChild1.TextColor = System.Drawing.Color.White;
            this.btnPlayListChild1.UseVisualStyleBackColor = false;
            // 
            // btnPlayListsMain
            // 
            this.btnPlayListsMain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayListsMain.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlayListsMain.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlayListsMain.BorderRadius = 8;
            this.btnPlayListsMain.BorderSize = 0;
            this.btnPlayListsMain.FlatAppearance.BorderSize = 0;
            this.btnPlayListsMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnPlayListsMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPlayListsMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayListsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayListsMain.ForeColor = System.Drawing.Color.White;
            this.btnPlayListsMain.Location = new System.Drawing.Point(4, 0);
            this.btnPlayListsMain.Name = "btnPlayListsMain";
            this.btnPlayListsMain.Size = new System.Drawing.Size(304, 36);
            this.btnPlayListsMain.TabIndex = 5;
            this.btnPlayListsMain.Tag = "playlists";
            this.btnPlayListsMain.Text = "Playlists";
            this.btnPlayListsMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayListsMain.TextColor = System.Drawing.Color.White;
            this.btnPlayListsMain.UseVisualStyleBackColor = false;
            this.btnPlayListsMain.Click += new System.EventHandler(this.btnPlaylists_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSetting.BorderRadius = 8;
            this.btnSetting.BorderSize = 0;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(0, 752);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(314, 36);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Tag = "setting";
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextColor = System.Drawing.Color.White;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelNameApp);
            this.panelTitle.Controls.Add(this.ptBImageApp);
            this.panelTitle.Controls.Add(this.backBtn);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(316, 48);
            this.panelTitle.TabIndex = 6;
            // 
            // labelNameApp
            // 
            this.labelNameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameApp.ForeColor = System.Drawing.Color.White;
            this.labelNameApp.Location = new System.Drawing.Point(104, 16);
            this.labelNameApp.Name = "labelNameApp";
            this.labelNameApp.Size = new System.Drawing.Size(100, 23);
            this.labelNameApp.TabIndex = 2;
            this.labelNameApp.Text = "Media player";
            // 
            // ptBImageApp
            // 
            this.ptBImageApp.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.imageApp;
            this.ptBImageApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptBImageApp.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptBImageApp.InitialImage")));
            this.ptBImageApp.Location = new System.Drawing.Point(78, 14);
            this.ptBImageApp.Name = "ptBImageApp";
            this.ptBImageApp.Size = new System.Drawing.Size(20, 20);
            this.ptBImageApp.TabIndex = 1;
            this.ptBImageApp.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.backBtn.BorderRadius = 7;
            this.backBtn.BorderSize = 0;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 14);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(23, 20);
            this.backBtn.TabIndex = 0;
            this.backBtn.TextColor = System.Drawing.Color.White;
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // txtBSearch
            // 
            this.txtBSearch.Location = new System.Drawing.Point(12, 48);
            this.txtBSearch.Multiline = true;
            this.txtBSearch.Name = "txtBSearch";
            this.txtBSearch.Size = new System.Drawing.Size(288, 31);
            this.txtBSearch.TabIndex = 7;
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelMenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuBar.Controls.Add(this.paneltopMenuBar);
            this.panelMenuBar.Controls.Add(this.btnSetting);
            this.panelMenuBar.Controls.Add(this.panelDropDownPlayLists);
            this.panelMenuBar.Controls.Add(this.btnPlayQueue);
            this.panelMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(316, 790);
            this.panelMenuBar.TabIndex = 12;
            // 
            // paneltopMenuBar
            // 
            this.paneltopMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.paneltopMenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltopMenuBar.Controls.Add(this.txtBSearch);
            this.paneltopMenuBar.Controls.Add(this.panelTitle);
            this.paneltopMenuBar.Controls.Add(this.btnHome);
            this.paneltopMenuBar.Controls.Add(this.btnVideoLibrary);
            this.paneltopMenuBar.Controls.Add(this.btnMusicLibrary);
            this.paneltopMenuBar.Location = new System.Drawing.Point(0, 0);
            this.paneltopMenuBar.Name = "paneltopMenuBar";
            this.paneltopMenuBar.Size = new System.Drawing.Size(316, 209);
            this.paneltopMenuBar.TabIndex = 10;
            // 
            // panelDropDownPlayLists
            // 
            this.panelDropDownPlayLists.Controls.Add(this.pictureBox1);
            this.panelDropDownPlayLists.Controls.Add(this.btnPlayListChild2);
            this.panelDropDownPlayLists.Controls.Add(this.btnPlayListChild1);
            this.panelDropDownPlayLists.Controls.Add(this.btnPlayListsMain);
            this.panelDropDownPlayLists.Location = new System.Drawing.Point(0, 256);
            this.panelDropDownPlayLists.MaximumSize = new System.Drawing.Size(316, 156);
            this.panelDropDownPlayLists.MinimumSize = new System.Drawing.Size(316, 36);
            this.panelDropDownPlayLists.Name = "panelDropDownPlayLists";
            this.panelDropDownPlayLists.Size = new System.Drawing.Size(316, 36);
            this.panelDropDownPlayLists.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.imagearrow_down;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(286, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 6);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panelUserControl
            // 
            this.panelUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserControl.Controls.Add(this.panelControlSizeExitApp);
            this.panelUserControl.Controls.Add(this.addHomeForm1);
            this.panelUserControl.Controls.Add(this.addMusicForm1);
            this.panelUserControl.Controls.Add(this.addVideoForm1);
            this.panelUserControl.Controls.Add(this.addMediaQueueForm1);
            this.panelUserControl.Controls.Add(this.addPlaylistForm1);
            this.panelUserControl.Controls.Add(this.addSettingForm1);
            this.panelUserControl.Location = new System.Drawing.Point(316, 0);
            this.panelUserControl.Name = "panelUserControl";
            this.panelUserControl.Size = new System.Drawing.Size(1084, 790);
            this.panelUserControl.TabIndex = 13;
            // 
            // panelControlSizeExitApp
            // 
            this.panelControlSizeExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlSizeExitApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControlSizeExitApp.Controls.Add(this.btnMinimize);
            this.panelControlSizeExitApp.Controls.Add(this.btnExit);
            this.panelControlSizeExitApp.Controls.Add(this.btnMaximize);
            this.panelControlSizeExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControlSizeExitApp.Location = new System.Drawing.Point(966, 0);
            this.panelControlSizeExitApp.Name = "panelControlSizeExitApp";
            this.panelControlSizeExitApp.Size = new System.Drawing.Size(117, 34);
            this.panelControlSizeExitApp.TabIndex = 9;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnMinimize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnMinimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimize.BorderRadius = 1;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 34);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 1;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(78, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnMaximize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnMaximize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMaximize.BorderRadius = 1;
            this.btnMaximize.BorderSize = 0;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(39, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(39, 34);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.TextColor = System.Drawing.Color.White;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // addHomeForm1
            // 
            this.addHomeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.addHomeForm1.FileContainMedia = "";
            this.addHomeForm1.FolderContainMedia = "";
            this.addHomeForm1.Location = new System.Drawing.Point(0, 0);
            this.addHomeForm1.Margin = new System.Windows.Forms.Padding(2);
            this.addHomeForm1.Name = "addHomeForm1";
            this.addHomeForm1.Size = new System.Drawing.Size(1082, 788);
            this.addHomeForm1.TabIndex = 5;
            // 
            // addMusicForm1
            // 
            this.addMusicForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.addMusicForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMusicForm1.Location = new System.Drawing.Point(0, 0);
            this.addMusicForm1.Margin = new System.Windows.Forms.Padding(2);
            this.addMusicForm1.Name = "addMusicForm1";
            this.addMusicForm1.Size = new System.Drawing.Size(1082, 788);
            this.addMusicForm1.TabIndex = 4;
            // 
            // addVideoForm1
            // 
            this.addVideoForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.addVideoForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addVideoForm1.Location = new System.Drawing.Point(0, 0);
            this.addVideoForm1.Margin = new System.Windows.Forms.Padding(2);
            this.addVideoForm1.Name = "addVideoForm1";
            this.addVideoForm1.Size = new System.Drawing.Size(1082, 788);
            this.addVideoForm1.TabIndex = 3;
            // 
            // addMediaQueueForm1
            // 
            this.addMediaQueueForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.addMediaQueueForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMediaQueueForm1.Location = new System.Drawing.Point(0, 0);
            this.addMediaQueueForm1.Margin = new System.Windows.Forms.Padding(0);
            this.addMediaQueueForm1.Name = "addMediaQueueForm1";
            this.addMediaQueueForm1.Size = new System.Drawing.Size(1082, 788);
            this.addMediaQueueForm1.TabIndex = 2;
            // 
            // addPlaylistForm1
            // 
            this.addPlaylistForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.addPlaylistForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPlaylistForm1.Location = new System.Drawing.Point(0, 0);
            this.addPlaylistForm1.Margin = new System.Windows.Forms.Padding(2);
            this.addPlaylistForm1.Name = "addPlaylistForm1";
            this.addPlaylistForm1.Size = new System.Drawing.Size(1082, 788);
            this.addPlaylistForm1.TabIndex = 1;
            // 
            // addSettingForm1
            // 
            this.addSettingForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.addSettingForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSettingForm1.Location = new System.Drawing.Point(0, 0);
            this.addSettingForm1.Margin = new System.Windows.Forms.Padding(8);
            this.addSettingForm1.Name = "addSettingForm1";
            this.addSettingForm1.Size = new System.Drawing.Size(1082, 788);
            this.addSettingForm1.TabIndex = 0;
            // 
            // player
            // 
            player.Enabled = true;
            player.Location = new System.Drawing.Point(374, 362);
            player.Name = "player";
            player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            player.Size = new System.Drawing.Size(135, 117);
            player.TabIndex = 11;
            player.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panelUserControl);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(  player);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player Project";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelControl.ResumeLayout(false);
            this.panelSlider.ResumeLayout(false);
            this.panelSlider.PerformLayout();
            this.panelControlPlayer.ResumeLayout(false);
            this.panelVolume.ResumeLayout(false);
            this.panelVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptBImageApp)).EndInit();
            this.panelMenuBar.ResumeLayout(false);
            this.paneltopMenuBar.ResumeLayout(false);
            this.paneltopMenuBar.PerformLayout();
            this.panelDropDownPlayLists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUserControl.ResumeLayout(false);
            this.panelControlSizeExitApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVolumn;
        private CustomButton btnHome;
        private CustomButton btnMusicLibrary;
        private CustomButton btnVideoLibrary;
        private CustomButton btnPlayQueue;
        private CustomButton btnPlayListChild2;
        private CustomButton btnPlayListChild1;
        private CustomButton btnPlayListsMain;
        private CustomButton btnSetting;
        private Panel panelTitle;
        private Label labelNameApp;
        private PictureBox ptBImageApp;
        private CustomButton backBtn;
        private TextBox txtBSearch;
        private Panel panelMenuBar;
        private Panel panelUserControl;
        private Panel panelControlSizeExitApp;
        private CustomButton btnMinimize;
        private CustomButton btnExit;
        private CustomButton btnMaximize;
        private Panel paneltopMenuBar;
        private addHomeForm addHomeForm1;
        private addMusicForm addMusicForm1;
        private addVideoForm addVideoForm1;
        private addMediaQueueForm addMediaQueueForm1;
        private addPlaylistForm addPlaylistForm1;
        private addSettingForm addSettingForm1;
        private Panel panelControlPlayer;
        private CustomButton btnShuffle;
        private CustomButton btnLoop;
        private CustomButton btnPrevious;
        private CustomButton btnNext;
        private CustomButton btnPlayPause;
        private Panel panelVolume;
        private CustomButton btnVolume;
        private Panel panelDropDownPlayLists;
        private Timer timer2;
        private PictureBox pictureBox1;
        private Panel panelSlider;
        public static Label lbCurrentDuration;
        public static Label lbDurationItem;
        public static Slider slider1;
        public static AxWMPLib.AxWindowsMediaPlayer player;
    }
}