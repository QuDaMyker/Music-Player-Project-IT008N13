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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMusicLibrary = new System.Windows.Forms.Button();
            this.btnVideoLibrary = new System.Windows.Forms.Button();
            this.btnPlayQueue = new System.Windows.Forms.Button();
            this.btnPlaylists = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnPlaylists);
            this.panel1.Controls.Add(this.btnPlayQueue);
            this.panel1.Controls.Add(this.btnVideoLibrary);
            this.panel1.Controls.Add(this.btnMusicLibrary);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 834);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(26, 71);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(237, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 41);
            this.textBox1.TabIndex = 1;
            // 
            // btnMusicLibrary
            // 
            this.btnMusicLibrary.Location = new System.Drawing.Point(26, 127);
            this.btnMusicLibrary.Name = "btnMusicLibrary";
            this.btnMusicLibrary.Size = new System.Drawing.Size(237, 50);
            this.btnMusicLibrary.TabIndex = 0;
            this.btnMusicLibrary.Text = "Music Library";
            this.btnMusicLibrary.UseVisualStyleBackColor = true;
            // 
            // btnVideoLibrary
            // 
            this.btnVideoLibrary.Location = new System.Drawing.Point(26, 183);
            this.btnVideoLibrary.Name = "btnVideoLibrary";
            this.btnVideoLibrary.Size = new System.Drawing.Size(237, 50);
            this.btnVideoLibrary.TabIndex = 0;
            this.btnVideoLibrary.Text = "Video Library";
            this.btnVideoLibrary.UseVisualStyleBackColor = true;
            // 
            // btnPlayQueue
            // 
            this.btnPlayQueue.Location = new System.Drawing.Point(26, 239);
            this.btnPlayQueue.Name = "btnPlayQueue";
            this.btnPlayQueue.Size = new System.Drawing.Size(237, 50);
            this.btnPlayQueue.TabIndex = 0;
            this.btnPlayQueue.Text = "Play Queue";
            this.btnPlayQueue.UseVisualStyleBackColor = true;
            // 
            // btnPlaylists
            // 
            this.btnPlaylists.Location = new System.Drawing.Point(26, 295);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.Size = new System.Drawing.Size(237, 50);
            this.btnPlaylists.TabIndex = 0;
            this.btnPlaylists.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 834);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "Media Player Project";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPlayQueue;
        private System.Windows.Forms.Button btnVideoLibrary;
        private System.Windows.Forms.Button btnMusicLibrary;
        private System.Windows.Forms.Button btnPlaylists;
    }
}

