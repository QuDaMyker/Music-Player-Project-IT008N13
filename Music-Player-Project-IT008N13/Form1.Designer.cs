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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.toolStripControl = new System.Windows.Forms.ToolStrip();
            this.txtBSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.bbtnMusicLibrary = new System.Windows.Forms.ToolStripButton();
            this.btnVideoLibrary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPlayQueue = new System.Windows.Forms.ToolStripButton();
            this.btnPlaylists = new System.Windows.Forms.ToolStripButton();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnShuffle = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnPlayPause = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLoop = new System.Windows.Forms.ToolStripButton();
            this.panelControl = new System.Windows.Forms.Panel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnVolume = new System.Windows.Forms.ToolStripButton();
            this.addHomeForm1 = new Music_Player_Project_IT008N13.addHomeForm();
            this.addMediaQueueForm1 = new Music_Player_Project_IT008N13.addMediaQueueForm();
            this.addMusicForm1 = new Music_Player_Project_IT008N13.addMusicForm();
            this.addPlaylistForm1 = new Music_Player_Project_IT008N13.addPlaylistForm();
            this.addSettingForm1 = new Music_Player_Project_IT008N13.addSettingForm();
            this.addVideoForm1 = new Music_Player_Project_IT008N13.addVideoForm();
            this.Silder = new Music_Player_Project_IT008N13.Controls.Slider();
            this.toolStripControl.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripControl
            // 
            this.toolStripControl.AutoSize = false;
            this.toolStripControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBSearch,
            this.btnHome,
            this.bbtnMusicLibrary,
            this.btnVideoLibrary,
            this.toolStripSeparator1,
            this.btnPlayQueue,
            this.btnPlaylists,
            this.btnSetting});
            this.toolStripControl.Location = new System.Drawing.Point(0, 0);
            this.toolStripControl.Name = "toolStripControl";
            this.toolStripControl.Size = new System.Drawing.Size(288, 934);
            this.toolStripControl.TabIndex = 0;
            this.toolStripControl.Text = "toolStrip1";
            // 
            // txtBSearch
            // 
            this.txtBSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBSearch.Name = "txtBSearch";
            this.txtBSearch.Size = new System.Drawing.Size(282, 27);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10);
            this.btnHome.Size = new System.Drawing.Size(266, 47);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // bbtnMusicLibrary
            // 
            this.bbtnMusicLibrary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnMusicLibrary.Image = ((System.Drawing.Image)(resources.GetObject("bbtnMusicLibrary.Image")));
            this.bbtnMusicLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbtnMusicLibrary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bbtnMusicLibrary.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bbtnMusicLibrary.Name = "bbtnMusicLibrary";
            this.bbtnMusicLibrary.Padding = new System.Windows.Forms.Padding(10);
            this.bbtnMusicLibrary.Size = new System.Drawing.Size(266, 47);
            this.bbtnMusicLibrary.Text = "Music library";
            this.bbtnMusicLibrary.Click += new System.EventHandler(this.bbtnMusicLibrary_Click);
            // 
            // btnVideoLibrary
            // 
            this.btnVideoLibrary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoLibrary.Image = ((System.Drawing.Image)(resources.GetObject("btnVideoLibrary.Image")));
            this.btnVideoLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideoLibrary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVideoLibrary.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnVideoLibrary.Name = "btnVideoLibrary";
            this.btnVideoLibrary.Padding = new System.Windows.Forms.Padding(10);
            this.btnVideoLibrary.Size = new System.Drawing.Size(266, 47);
            this.btnVideoLibrary.Text = "Video library";
            this.btnVideoLibrary.Click += new System.EventHandler(this.btnVideoLibrary_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(286, 6);
            // 
            // btnPlayQueue
            // 
            this.btnPlayQueue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayQueue.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayQueue.Image")));
            this.btnPlayQueue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayQueue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlayQueue.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnPlayQueue.Name = "btnPlayQueue";
            this.btnPlayQueue.Padding = new System.Windows.Forms.Padding(10);
            this.btnPlayQueue.Size = new System.Drawing.Size(266, 47);
            this.btnPlayQueue.Text = "Play queue";
            this.btnPlayQueue.Click += new System.EventHandler(this.btnPlayQueue_Click);
            // 
            // btnPlaylists
            // 
            this.btnPlaylists.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylists.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylists.Image")));
            this.btnPlaylists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylists.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlaylists.Margin = new System.Windows.Forms.Padding(10, 0, 10, 200);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.Padding = new System.Windows.Forms.Padding(10);
            this.btnPlaylists.Size = new System.Drawing.Size(266, 47);
            this.btnPlaylists.Text = "Playlists";
            this.btnPlaylists.Click += new System.EventHandler(this.btnPlaylists_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10);
            this.btnSetting.Size = new System.Drawing.Size(276, 47);
            this.btnSetting.Text = "Setting";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShuffle,
            this.btnPrevious,
            this.btnPlayPause,
            this.btnNext,
            this.btnLoop});
            this.toolStrip2.Location = new System.Drawing.Point(708, 36);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(321, 58);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnShuffle
            // 
            this.btnShuffle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Padding = new System.Windows.Forms.Padding(10);
            this.btnShuffle.Size = new System.Drawing.Size(44, 55);
            this.btnShuffle.Text = "toolStripButton7";
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Padding = new System.Windows.Forms.Padding(10);
            this.btnPrevious.Size = new System.Drawing.Size(44, 55);
            this.btnPrevious.Text = "toolStripButton8";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayPause.Image")));
            this.btnPlayPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Padding = new System.Windows.Forms.Padding(20);
            this.btnPlayPause.Size = new System.Drawing.Size(64, 55);
            this.btnPlayPause.Text = "toolStripButton9";
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(10);
            this.btnNext.Size = new System.Drawing.Size(44, 55);
            this.btnNext.Text = "toolStripButton10";
            // 
            // btnLoop
            // 
            this.btnLoop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoop.Image = ((System.Drawing.Image)(resources.GetObject("btnLoop.Image")));
            this.btnLoop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Padding = new System.Windows.Forms.Padding(10);
            this.btnLoop.Size = new System.Drawing.Size(44, 55);
            this.btnLoop.Text = "toolStripButton11";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.Control;
            this.panelControl.Controls.Add(this.toolStrip3);
            this.panelControl.Controls.Add(this.Silder);
            this.panelControl.Controls.Add(this.toolStrip2);
            this.panelControl.Location = new System.Drawing.Point(0, 799);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1675, 135);
            this.panelControl.TabIndex = 4;
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVolume});
            this.toolStrip3.Location = new System.Drawing.Point(1453, 36);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.toolStrip3.Size = new System.Drawing.Size(113, 58);
            this.toolStrip3.TabIndex = 5;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnVolume
            // 
            this.btnVolume.AutoSize = false;
            this.btnVolume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVolume.Image = ((System.Drawing.Image)(resources.GetObject("btnVolume.Image")));
            this.btnVolume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(40, 44);
            this.btnVolume.Text = "toolStripButton12";
            // 
            // addHomeForm1
            // 
            this.addHomeForm1.BackColor = System.Drawing.SystemColors.Control;
            this.addHomeForm1.FolderContainMedia = "";
            this.addHomeForm1.Location = new System.Drawing.Point(279, 3);
            this.addHomeForm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addHomeForm1.Name = "addHomeForm1";
            this.addHomeForm1.Size = new System.Drawing.Size(1396, 796);
            this.addHomeForm1.TabIndex = 10;
            // 
            // addMediaQueueForm1
            // 
            this.addMediaQueueForm1.BackColor = System.Drawing.SystemColors.Control;
            this.addMediaQueueForm1.Location = new System.Drawing.Point(279, 3);
            this.addMediaQueueForm1.Margin = new System.Windows.Forms.Padding(0);
            this.addMediaQueueForm1.Name = "addMediaQueueForm1";
            this.addMediaQueueForm1.Size = new System.Drawing.Size(1396, 796);
            this.addMediaQueueForm1.TabIndex = 9;
            // 
            // addMusicForm1
            // 
            this.addMusicForm1.BackColor = System.Drawing.SystemColors.Control;
            this.addMusicForm1.Location = new System.Drawing.Point(279, 1);
            this.addMusicForm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMusicForm1.Name = "addMusicForm1";
            this.addMusicForm1.Size = new System.Drawing.Size(1396, 796);
            this.addMusicForm1.TabIndex = 8;
            // 
            // addPlaylistForm1
            // 
            this.addPlaylistForm1.BackColor = System.Drawing.SystemColors.Control;
            this.addPlaylistForm1.Location = new System.Drawing.Point(279, 1);
            this.addPlaylistForm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPlaylistForm1.Name = "addPlaylistForm1";
            this.addPlaylistForm1.Size = new System.Drawing.Size(1396, 796);
            this.addPlaylistForm1.TabIndex = 7;
            // 
            // addSettingForm1
            // 
            this.addSettingForm1.BackColor = System.Drawing.SystemColors.Control;
            this.addSettingForm1.Location = new System.Drawing.Point(279, 0);
            this.addSettingForm1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.addSettingForm1.Name = "addSettingForm1";
            this.addSettingForm1.Size = new System.Drawing.Size(1396, 796);
            this.addSettingForm1.TabIndex = 6;
            // 
            // addVideoForm1
            // 
            this.addVideoForm1.BackColor = System.Drawing.Color.White;
            this.addVideoForm1.Location = new System.Drawing.Point(279, 0);
            this.addVideoForm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVideoForm1.Name = "addVideoForm1";
            this.addVideoForm1.Size = new System.Drawing.Size(1396, 796);
            this.addVideoForm1.TabIndex = 5;
            // 
            // Silder
            // 
            this.Silder.ChannelColor = System.Drawing.Color.Salmon;
            this.Silder.ChannelHeight = 6;
            this.Silder.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.Silder.ForeColor = System.Drawing.Color.White;
            this.Silder.Location = new System.Drawing.Point(72, 4);
            this.Silder.Margin = new System.Windows.Forms.Padding(4);
            this.Silder.Name = "Silder";
            this.Silder.ShowMaximum = false;
            this.Silder.ShowValue = Music_Player_Project_IT008N13.Controls.TextPosition.Right;
            this.Silder.Size = new System.Drawing.Size(1537, 28);
            this.Silder.SliderColor = System.Drawing.Color.RoyalBlue;
            this.Silder.SliderHeight = 6;
            this.Silder.SymbolAfter = "";
            this.Silder.SymbolBefore = "";
            this.Silder.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 934);
            this.Controls.Add(this.addHomeForm1);
            this.Controls.Add(this.addMediaQueueForm1);
            this.Controls.Add(this.addMusicForm1);
            this.Controls.Add(this.addPlaylistForm1);
            this.Controls.Add(this.addSettingForm1);
            this.Controls.Add(this.addVideoForm1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.toolStripControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Media Player Project";
            this.toolStripControl.ResumeLayout(false);
            this.toolStripControl.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripControl;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton bbtnMusicLibrary;
        private System.Windows.Forms.ToolStripButton btnVideoLibrary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPlayQueue;
        private System.Windows.Forms.ToolStripButton btnPlaylists;
        private System.Windows.Forms.ToolStripTextBox txtBSearch;
        private System.Windows.Forms.ToolStripButton btnSetting;
        private Controls.Slider Silder;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnShuffle;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripButton btnPlayPause;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLoop;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnVolume;
        private addVideoForm addVideoForm1;
        private addSettingForm addSettingForm1;
        private addPlaylistForm addPlaylistForm1;
        private addMusicForm addMusicForm1;
        private addMediaQueueForm addMediaQueueForm1;
        private addHomeForm addHomeForm1;
    }
}