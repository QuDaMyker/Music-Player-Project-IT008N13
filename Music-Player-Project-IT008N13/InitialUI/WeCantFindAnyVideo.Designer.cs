namespace Music_Player_Project_IT008N13
{
    partial class WeCantFindAnyVideo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddFolder = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.video_tape;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(77, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 205);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddFolder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(251, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 184);
            this.panel1.TabIndex = 2;
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(128)))), ((int)(((byte)(66)))));
            this.buttonAddFolder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(128)))), ((int)(((byte)(66)))));
            this.buttonAddFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(128)))), ((int)(((byte)(66)))));
            this.buttonAddFolder.BorderRadius = 10;
            this.buttonAddFolder.BorderSize = 0;
            this.buttonAddFolder.FlatAppearance.BorderSize = 0;
            this.buttonAddFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonAddFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(121)))), ((int)(((byte)(49)))));
            this.buttonAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFolder.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddFolder.Location = new System.Drawing.Point(12, 125);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(121, 31);
            this.buttonAddFolder.TabIndex = 2;
            this.buttonAddFolder.Text = "Add folder";
            this.buttonAddFolder.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddFolder.UseVisualStyleBackColor = false;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your video library doesn\'t content any video content.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "We couldn\'t find any video";
            // 
            // WeCantFindAnyVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WeCantFindAnyVideo";
            this.Size = new System.Drawing.Size(660, 273);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Controls.CustomButton buttonAddFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
