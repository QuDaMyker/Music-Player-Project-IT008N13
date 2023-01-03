namespace Music_Player_Project_IT008N13
{
    partial class Square
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameSong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_play_pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameSong
            // 
            this.labelNameSong.BackColor = System.Drawing.Color.MintCream;
            this.labelNameSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSong.Location = new System.Drawing.Point(0, 150);
            this.labelNameSong.Name = "labelNameSong";
            this.labelNameSong.Size = new System.Drawing.Size(160, 20);
            this.labelNameSong.TabIndex = 2;
            this.labelNameSong.Text = "Song 1";
            this.labelNameSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.spotify;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 150);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_play_pause
            // 
            this.btn_play_pause.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_play_pause.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.playdisplay;
            this.btn_play_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play_pause.Location = new System.Drawing.Point(120, 110);
            this.btn_play_pause.Name = "btn_play_pause";
            this.btn_play_pause.Size = new System.Drawing.Size(40, 40);
            this.btn_play_pause.TabIndex = 4;
            this.btn_play_pause.UseVisualStyleBackColor = false;
            this.btn_play_pause.Click += new System.EventHandler(this.btn_play_pause_Click_1);
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_play_pause);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNameSong);
            this.DoubleBuffered = true;
            this.Name = "Square";
            this.Size = new System.Drawing.Size(160, 170);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNameSong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_play_pause;
    }
}
