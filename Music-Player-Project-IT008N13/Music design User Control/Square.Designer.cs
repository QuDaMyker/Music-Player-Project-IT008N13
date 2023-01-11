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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.btn_play_pause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.MintCream;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 150);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(160, 20);
            this.Title.TabIndex = 2;
            this.Title.Text = "Song 1";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thumbnail
            // 
            this.thumbnail.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.spotify;
            this.thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thumbnail.Location = new System.Drawing.Point(0, 0);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(160, 150);
            this.thumbnail.TabIndex = 3;
            this.thumbnail.TabStop = false;
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
            this.btn_play_pause.Click += new System.EventHandler(this.btn_play_pause_Click);
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_play_pause);
            this.Controls.Add(this.thumbnail);
            this.Controls.Add(this.Title);
            this.DoubleBuffered = true;
            this.Name = "Square";
            this.Size = new System.Drawing.Size(160, 170);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Button btn_play_pause;
        private System.Windows.Forms.Timer timer1;
    }
}
