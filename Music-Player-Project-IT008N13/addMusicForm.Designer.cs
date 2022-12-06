namespace Music_Player_Project_IT008N13
{
    partial class addMusicForm
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
            this.labelNameMusicLibrary = new System.Windows.Forms.Label();
            this.weCantFindAnyMusic1 = new Music_Player_Project_IT008N13.WeCantFindAnyMusic();
            this.SuspendLayout();
            // 
            // labelNameMusicLibrary
            // 
            this.labelNameMusicLibrary.AutoSize = true;
            this.labelNameMusicLibrary.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameMusicLibrary.Location = new System.Drawing.Point(21, 19);
            this.labelNameMusicLibrary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameMusicLibrary.Name = "labelNameMusicLibrary";
            this.labelNameMusicLibrary.Size = new System.Drawing.Size(203, 70);
            this.labelNameMusicLibrary.TabIndex = 3;
            this.labelNameMusicLibrary.Text = "Music";
            // 
            // weCantFindAnyMusic1
            // 
            this.weCantFindAnyMusic1.BackColor = System.Drawing.Color.Transparent;
            this.weCantFindAnyMusic1.Location = new System.Drawing.Point(202, 190);
            this.weCantFindAnyMusic1.Name = "weCantFindAnyMusic1";
            this.weCantFindAnyMusic1.Size = new System.Drawing.Size(618, 270);
            this.weCantFindAnyMusic1.TabIndex = 4;
            // 
            // addMusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.weCantFindAnyMusic1);
            this.Controls.Add(this.labelNameMusicLibrary);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addMusicForm";
            this.Size = new System.Drawing.Size(1018, 648);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameMusicLibrary;
        private WeCantFindAnyMusic weCantFindAnyMusic1;
    }
}
