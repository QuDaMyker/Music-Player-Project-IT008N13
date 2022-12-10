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
            this.labelMusic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMusic
            // 
            this.labelMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusic.Location = new System.Drawing.Point(68, 26);
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size(195, 57);
            this.labelMusic.TabIndex = 5;
            this.labelMusic.Text = "Music";
            // 
            // addMusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelMusic);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addMusicForm";
            this.Size = new System.Drawing.Size(1396, 796);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMusic;
    }
}
