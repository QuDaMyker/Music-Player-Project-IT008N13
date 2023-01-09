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
            this.labelSetting = new System.Windows.Forms.Label();
            this.weCantFindAnyMusic1 = new Music_Player_Project_IT008N13.WeCantFindAnyMusic();
            this.SuspendLayout();
            // 
            // labelSetting
            // 
            this.labelSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetting.ForeColor = System.Drawing.Color.White;
            this.labelSetting.Location = new System.Drawing.Point(50, 50);
            this.labelSetting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(146, 46);
            this.labelSetting.TabIndex = 5;
            this.labelSetting.Text = "Music";
            // 
            // weCantFindAnyMusic1
            // 
            this.weCantFindAnyMusic1.BackColor = System.Drawing.Color.Transparent;
            this.weCantFindAnyMusic1.Location = new System.Drawing.Point(200, 180);
            this.weCantFindAnyMusic1.Name = "weCantFindAnyMusic1";
            this.weCantFindAnyMusic1.Size = new System.Drawing.Size(692, 393);
            this.weCantFindAnyMusic1.TabIndex = 6;
            // 
            // addMusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.weCantFindAnyMusic1);
            this.Controls.Add(this.labelSetting);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addMusicForm";
            this.Size = new System.Drawing.Size(1084, 790);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSetting;
        private WeCantFindAnyMusic weCantFindAnyMusic1;
    }
}
