namespace Music_Player_Project_IT008N13
{
    partial class addMediaQueueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addMediaQueueForm));
            this.labelPlayQueue = new System.Windows.Forms.Label();
            this.customButton1 = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.customButton2 = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addFileToPlayQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToPlayQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMediaFromURLToPlayQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlayQueue
            // 
            this.labelPlayQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayQueue.ForeColor = System.Drawing.Color.White;
            this.labelPlayQueue.Location = new System.Drawing.Point(50, 50);
            this.labelPlayQueue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayQueue.Name = "labelPlayQueue";
            this.labelPlayQueue.Size = new System.Drawing.Size(203, 46);
            this.labelPlayQueue.TabIndex = 7;
            this.labelPlayQueue.Text = "Play queue";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(57, 116);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(76, 36);
            this.customButton1.TabIndex = 10;
            this.customButton1.Text = "Clear";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 10;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(139, 116);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(86, 36);
            this.customButton2.TabIndex = 11;
            this.customButton2.Text = "Add to";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 35);
            this.toolStripButton1.Text = "Add file(s)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToPlayQueueToolStripMenuItem,
            this.addFolderToPlayQueueToolStripMenuItem,
            this.addMediaFromURLToPlayQueueToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Music_Player_Project_IT008N13.Properties.Resources.down_arrow2;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 35);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // addFileToPlayQueueToolStripMenuItem
            // 
            this.addFileToPlayQueueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addFileToPlayQueueToolStripMenuItem.Image")));
            this.addFileToPlayQueueToolStripMenuItem.Name = "addFileToPlayQueueToolStripMenuItem";
            this.addFileToPlayQueueToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.addFileToPlayQueueToolStripMenuItem.Text = "Add File to play queue";
            // 
            // addFolderToPlayQueueToolStripMenuItem
            // 
            this.addFolderToPlayQueueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addFolderToPlayQueueToolStripMenuItem.Image")));
            this.addFolderToPlayQueueToolStripMenuItem.Name = "addFolderToPlayQueueToolStripMenuItem";
            this.addFolderToPlayQueueToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.addFolderToPlayQueueToolStripMenuItem.Text = "Add Folder to Play queue";
            // 
            // addMediaFromURLToPlayQueueToolStripMenuItem
            // 
            this.addMediaFromURLToPlayQueueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addMediaFromURLToPlayQueueToolStripMenuItem.Image")));
            this.addMediaFromURLToPlayQueueToolStripMenuItem.Name = "addMediaFromURLToPlayQueueToolStripMenuItem";
            this.addMediaFromURLToPlayQueueToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.addMediaFromURLToPlayQueueToolStripMenuItem.Text = "Add Media From URL to Play queue";
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.Color.White;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip3.Location = new System.Drawing.Point(815, 58);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(147, 38);
            this.toolStrip3.TabIndex = 9;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // addMediaQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.labelPlayQueue);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "addMediaQueueForm";
            this.Size = new System.Drawing.Size(1084, 790);
            this.Load += new System.EventHandler(this.addMediaQueueForm_Load);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelPlayQueue;
        private Controls.CustomButton customButton1;
        private Controls.CustomButton customButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addFileToPlayQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToPlayQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMediaFromURLToPlayQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip3;
    }
}
