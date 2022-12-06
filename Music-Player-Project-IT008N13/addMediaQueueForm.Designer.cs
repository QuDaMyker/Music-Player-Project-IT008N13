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
            this.labelNamePlayQueue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddTo = new System.Windows.Forms.ToolStripButton();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddFileQueue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddFolderQueue = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddURLQueue = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNamePlayQueue
            // 
            this.labelNamePlayQueue.AutoSize = true;
            this.labelNamePlayQueue.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamePlayQueue.Location = new System.Drawing.Point(28, 21);
            this.labelNamePlayQueue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamePlayQueue.Name = "labelNamePlayQueue";
            this.labelNamePlayQueue.Size = new System.Drawing.Size(346, 70);
            this.labelNamePlayQueue.TabIndex = 2;
            this.labelNamePlayQueue.Text = "Play Queue";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(45, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 36);
            this.panel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClear,
            this.toolStripButtonAddTo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(238, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(91, 29);
            this.toolStripButtonClear.Text = "   Clear";
            // 
            // toolStripButtonAddTo
            // 
            this.toolStripButtonAddTo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonAddTo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddTo.Image")));
            this.toolStripButtonAddTo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddTo.Name = "toolStripButtonAddTo";
            this.toolStripButtonAddTo.Size = new System.Drawing.Size(100, 29);
            this.toolStripButtonAddTo.Text = "  Add To";
            // 
            // btnAddFile
            // 
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.Location = new System.Drawing.Point(882, 33);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(92, 38);
            this.btnAddFile.TabIndex = 5;
            this.btnAddFile.Text = "Add File(s)";
            this.btnAddFile.UseVisualStyleBackColor = true;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.toolStrip2);
            this.panelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButton.Location = new System.Drawing.Point(947, 34);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(44, 37);
            this.panelButton.TabIndex = 6;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddFileQueue,
            this.toolStripSeparator,
            this.toolStripButtonAddFolderQueue,
            this.toolStripButtonAddURLQueue});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(44, 37);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonAddFileQueue
            // 
            this.toolStripButtonAddFileQueue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddFileQueue.Image")));
            this.toolStripButtonAddFileQueue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddFileQueue.Name = "toolStripButtonAddFileQueue";
            this.toolStripButtonAddFileQueue.Size = new System.Drawing.Size(370, 34);
            this.toolStripButtonAddFileQueue.Text = "Add File(s) To Play Queue                 ";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAddFolderQueue
            // 
            this.toolStripButtonAddFolderQueue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddFolderQueue.Image")));
            this.toolStripButtonAddFolderQueue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddFolderQueue.Name = "toolStripButtonAddFolderQueue";
            this.toolStripButtonAddFolderQueue.Size = new System.Drawing.Size(369, 34);
            this.toolStripButtonAddFolderQueue.Text = "Add Folder To Play Queue                ";
            // 
            // toolStripButtonAddURLQueue
            // 
            this.toolStripButtonAddURLQueue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddURLQueue.Image")));
            this.toolStripButtonAddURLQueue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddURLQueue.Name = "toolStripButtonAddURLQueue";
            this.toolStripButtonAddURLQueue.Size = new System.Drawing.Size(370, 34);
            this.toolStripButtonAddURLQueue.Text = "Add Media From URL To Play Queue";
            // 
            // addMediaQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNamePlayQueue);
            this.Margin = new System.Windows.Forms.Padding(2, 41, 2, 2);
            this.Name = "addMediaQueueForm";
            this.Size = new System.Drawing.Size(1018, 648);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamePlayQueue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddTo;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddFileQueue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddFolderQueue;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddURLQueue;
    }
}
