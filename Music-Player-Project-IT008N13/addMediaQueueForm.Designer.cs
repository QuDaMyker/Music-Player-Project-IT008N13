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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnAddto = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnAddFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddFiletoQueue = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddFoldertoQueue = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddMediaformUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlayQueue
            // 
            this.labelPlayQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayQueue.Location = new System.Drawing.Point(68, 26);
            this.labelPlayQueue.Name = "labelPlayQueue";
            this.labelPlayQueue.Size = new System.Drawing.Size(271, 57);
            this.labelPlayQueue.TabIndex = 7;
            this.labelPlayQueue.Text = "Play queue";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClear,
            this.btnAddto});
            this.toolStrip1.Location = new System.Drawing.Point(95, 82);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(255, 39);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnClear.Size = new System.Drawing.Size(73, 36);
            this.btnClear.Text = "Clear";
            // 
            // btnAddto
            // 
            this.btnAddto.BackColor = System.Drawing.Color.White;
            this.btnAddto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddto.Image")));
            this.btnAddto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddto.Name = "btnAddto";
            this.btnAddto.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAddto.Size = new System.Drawing.Size(87, 36);
            this.btnAddto.Text = "Add to";
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFile,
            this.toolStripSeparator1,
            this.btnDropDown});
            this.toolStrip3.Location = new System.Drawing.Point(953, 26);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(169, 38);
            this.toolStrip3.TabIndex = 9;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.White;
            this.btnAddFile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFile.Image")));
            this.btnAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(85, 35);
            this.btnAddFile.Text = "Add file(s)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnDropDown
            // 
            this.btnDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFiletoQueue,
            this.btnAddFoldertoQueue,
            this.btnAddMediaformUrl});
            this.btnDropDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDropDown.Image")));
            this.btnDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDropDown.Name = "btnDropDown";
            this.btnDropDown.Size = new System.Drawing.Size(33, 35);
            this.btnDropDown.Text = "toolStripDropDownButton1";
            // 
            // btnAddFiletoQueue
            // 
            this.btnAddFiletoQueue.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFiletoQueue.Image")));
            this.btnAddFiletoQueue.Name = "btnAddFiletoQueue";
            this.btnAddFiletoQueue.Size = new System.Drawing.Size(266, 26);
            this.btnAddFiletoQueue.Text = "Add File to play queue";
            // 
            // btnAddFoldertoQueue
            // 
            this.btnAddFoldertoQueue.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFoldertoQueue.Image")));
            this.btnAddFoldertoQueue.Name = "btnAddFoldertoQueue";
            this.btnAddFoldertoQueue.Size = new System.Drawing.Size(266, 26);
            this.btnAddFoldertoQueue.Text = "Add Folder to Play queue";
            // 
            // btnAddMediaformUrl
            // 
            this.btnAddMediaformUrl.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMediaformUrl.Image")));
            this.btnAddMediaformUrl.Name = "btnAddMediaformUrl";
            this.btnAddMediaformUrl.Size = new System.Drawing.Size(266, 26);
            this.btnAddMediaformUrl.Text = "Add Media From URL to Play queue";
            // 
            // addMediaQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelPlayQueue);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "addMediaQueueForm";
            this.Size = new System.Drawing.Size(1396, 796);
            this.Load += new System.EventHandler(this.addMediaQueueForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelPlayQueue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripButton btnAddto;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnAddFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton btnDropDown;
        private System.Windows.Forms.ToolStripMenuItem btnAddFiletoQueue;
        private System.Windows.Forms.ToolStripMenuItem btnAddFoldertoQueue;
        private System.Windows.Forms.ToolStripMenuItem btnAddMediaformUrl;
    }
}
