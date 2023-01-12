namespace Music_Player_Project_IT008N13
{
    partial class addPlaylistForm
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
            this.labelPlaylist = new System.Windows.Forms.Label();
            this.customButton1 = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.SuspendLayout();
            // 
            // labelPlaylist
            // 
            this.labelPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaylist.ForeColor = System.Drawing.Color.White;
            this.labelPlaylist.Location = new System.Drawing.Point(50, 50);
            this.labelPlaylist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlaylist.Name = "labelPlaylist";
            this.labelPlaylist.Size = new System.Drawing.Size(157, 46);
            this.labelPlaylist.TabIndex = 1;
            this.labelPlaylist.Text = "Playlists";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(53)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(53)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(115)))), ((int)(((byte)(42)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.customButton1.Location = new System.Drawing.Point(57, 115);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(119, 31);
            this.customButton1.TabIndex = 3;
            this.customButton1.Text = "New playlist";
            this.customButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // addPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.labelPlaylist);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addPlaylistForm";
            this.Size = new System.Drawing.Size(1084, 790);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlaylist;
        private Controls.CustomButton customButton1;
    }
}
