namespace Music_Player_Project_IT008N13
{
    partial class addSettingForm
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
            this.labelSetting = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelMusicLibraryLocation = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMusicLibraryLocation = new System.Windows.Forms.Label();
            this.btnAddFolder = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.btnDropMusicLibrary = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.panelDropDownMusicLibraryLocation = new System.Windows.Forms.Panel();
            this.panelMusicLibraryLocationChild = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMusicLibraryLocation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDropDownMusicLibraryLocation.SuspendLayout();
            this.panelMusicLibraryLocationChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.labelSetting.TabIndex = 0;
            this.labelSetting.Text = "Settings";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libraries";
            // 
            // panelMusicLibraryLocation
            // 
            this.panelMusicLibraryLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMusicLibraryLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelMusicLibraryLocation.Controls.Add(this.pictureBox1);
            this.panelMusicLibraryLocation.Controls.Add(this.btnDropMusicLibrary);
            this.panelMusicLibraryLocation.Controls.Add(this.btnAddFolder);
            this.panelMusicLibraryLocation.Controls.Add(this.lbMusicLibraryLocation);
            this.panelMusicLibraryLocation.Location = new System.Drawing.Point(0, 0);
            this.panelMusicLibraryLocation.MinimumSize = new System.Drawing.Size(963, 50);
            this.panelMusicLibraryLocation.Name = "panelMusicLibraryLocation";
            this.panelMusicLibraryLocation.Size = new System.Drawing.Size(964, 50);
            this.panelMusicLibraryLocation.TabIndex = 3;
            this.panelMusicLibraryLocation.Click += new System.EventHandler(this.panelMusicLibraryLocation_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panelDropDownMusicLibraryLocation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(57, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 581);
            this.panel1.TabIndex = 1;
            // 
            // lbMusicLibraryLocation
            // 
            this.lbMusicLibraryLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMusicLibraryLocation.AutoSize = true;
            this.lbMusicLibraryLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMusicLibraryLocation.ForeColor = System.Drawing.Color.White;
            this.lbMusicLibraryLocation.Location = new System.Drawing.Point(65, 17);
            this.lbMusicLibraryLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMusicLibraryLocation.Name = "lbMusicLibraryLocation";
            this.lbMusicLibraryLocation.Size = new System.Drawing.Size(140, 17);
            this.lbMusicLibraryLocation.TabIndex = 4;
            this.lbMusicLibraryLocation.Text = "Music library location";
            this.lbMusicLibraryLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnAddFolder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnAddFolder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddFolder.BorderRadius = 10;
            this.btnAddFolder.BorderSize = 0;
            this.btnAddFolder.FlatAppearance.BorderSize = 0;
            this.btnAddFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnAddFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.ForeColor = System.Drawing.Color.White;
            this.btnAddFolder.Location = new System.Drawing.Point(714, 6);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(115, 38);
            this.btnAddFolder.TabIndex = 5;
            this.btnAddFolder.Text = "Add folder";
            this.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolder.TextColor = System.Drawing.Color.White;
            this.btnAddFolder.UseVisualStyleBackColor = false;
            // 
            // btnDropMusicLibrary
            // 
            this.btnDropMusicLibrary.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDropMusicLibrary.BackColor = System.Drawing.Color.Transparent;
            this.btnDropMusicLibrary.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDropMusicLibrary.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDropMusicLibrary.BorderRadius = 10;
            this.btnDropMusicLibrary.BorderSize = 0;
            this.btnDropMusicLibrary.FlatAppearance.BorderSize = 0;
            this.btnDropMusicLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnDropMusicLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnDropMusicLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropMusicLibrary.ForeColor = System.Drawing.Color.White;
            this.btnDropMusicLibrary.Location = new System.Drawing.Point(907, 6);
            this.btnDropMusicLibrary.Name = "btnDropMusicLibrary";
            this.btnDropMusicLibrary.Size = new System.Drawing.Size(43, 38);
            this.btnDropMusicLibrary.TabIndex = 6;
            this.btnDropMusicLibrary.TextColor = System.Drawing.Color.White;
            this.btnDropMusicLibrary.UseVisualStyleBackColor = false;
            this.btnDropMusicLibrary.Click += new System.EventHandler(this.panelMusicLibraryLocation_Click);
            // 
            // panelDropDownMusicLibraryLocation
            // 
            this.panelDropDownMusicLibraryLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDropDownMusicLibraryLocation.Controls.Add(this.panelMusicLibraryLocationChild);
            this.panelDropDownMusicLibraryLocation.Controls.Add(this.panelMusicLibraryLocation);
            this.panelDropDownMusicLibraryLocation.Location = new System.Drawing.Point(17, 32);
            this.panelDropDownMusicLibraryLocation.MaximumSize = new System.Drawing.Size(963, 225);
            this.panelDropDownMusicLibraryLocation.MinimumSize = new System.Drawing.Size(963, 50);
            this.panelDropDownMusicLibraryLocation.Name = "panelDropDownMusicLibraryLocation";
            this.panelDropDownMusicLibraryLocation.Size = new System.Drawing.Size(963, 50);
            this.panelDropDownMusicLibraryLocation.TabIndex = 4;
            // 
            // panelMusicLibraryLocationChild
            // 
            this.panelMusicLibraryLocationChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelMusicLibraryLocationChild.Controls.Add(this.btnDelete);
            this.panelMusicLibraryLocationChild.Controls.Add(this.label2);
            this.panelMusicLibraryLocationChild.Location = new System.Drawing.Point(0, 52);
            this.panelMusicLibraryLocationChild.Name = "panelMusicLibraryLocationChild";
            this.panelMusicLibraryLocationChild.Size = new System.Drawing.Size(963, 50);
            this.panelMusicLibraryLocationChild.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "C:\\Users\\KaoWai\\Music";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(785, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(43, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // addSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSetting);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "addSettingForm";
            this.Size = new System.Drawing.Size(1084, 790);
            this.Load += new System.EventHandler(this.addSettingForm_Load);
            this.panelMusicLibraryLocation.ResumeLayout(false);
            this.panelMusicLibraryLocation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelDropDownMusicLibraryLocation.ResumeLayout(false);
            this.panelMusicLibraryLocationChild.ResumeLayout(false);
            this.panelMusicLibraryLocationChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMusicLibraryLocation;
        private System.Windows.Forms.Label lbMusicLibraryLocation;
        private System.Windows.Forms.Panel panel1;
        private Controls.CustomButton btnDropMusicLibrary;
        private Controls.CustomButton btnAddFolder;
        private System.Windows.Forms.Panel panelDropDownMusicLibraryLocation;
        private System.Windows.Forms.Panel panelMusicLibraryLocationChild;
        private Controls.CustomButton btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
