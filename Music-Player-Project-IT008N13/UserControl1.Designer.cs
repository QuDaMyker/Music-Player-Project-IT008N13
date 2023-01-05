namespace Music_Player_Project_IT008N13
{
    partial class PlaylistMode
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.circleButton1 = new Music_Player_Project_IT008N13.Controls.CircleButton();
            this.circleButton2 = new Music_Player_Project_IT008N13.Controls.CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 163);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(21, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.White;
            this.circleButton1.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.more;
            this.circleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.circleButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Location = new System.Drawing.Point(144, 127);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(30, 30);
            this.circleButton1.TabIndex = 3;
            this.circleButton1.UseVisualStyleBackColor = false;
            // 
            // circleButton2
            // 
            this.circleButton2.BackColor = System.Drawing.Color.White;
            this.circleButton2.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.play;
            this.circleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleButton2.FlatAppearance.BorderSize = 0;
            this.circleButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.circleButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.circleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton2.Location = new System.Drawing.Point(12, 127);
            this.circleButton2.Name = "circleButton2";
            this.circleButton2.Size = new System.Drawing.Size(30, 30);
            this.circleButton2.TabIndex = 2;
            this.circleButton2.UseVisualStyleBackColor = false;
            // 
            // PlaylistMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.circleButton2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PlaylistMode";
            this.Size = new System.Drawing.Size(187, 235);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.CircleButton circleButton2;
        private Controls.CircleButton circleButton1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
