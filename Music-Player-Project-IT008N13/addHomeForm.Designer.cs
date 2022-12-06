namespace Music_Player_Project_IT008N13
{
    partial class addHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addHomeForm));
            this.labelNameHome = new System.Windows.Forms.Label();
            this.labelRecentMedia = new System.Windows.Forms.Label();
            this.btnOpenFIle = new System.Windows.Forms.Button();
            this.flowLayoutPanelHomeForm = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.panelButton = new System.Windows.Forms.Panel();
            this.toolStripButtonOpenURL = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameHome
            // 
            this.labelNameHome.AutoSize = true;
            this.labelNameHome.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameHome.Location = new System.Drawing.Point(27, 24);
            this.labelNameHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameHome.Name = "labelNameHome";
            this.labelNameHome.Size = new System.Drawing.Size(189, 70);
            this.labelNameHome.TabIndex = 0;
            this.labelNameHome.Text = "Home";
            // 
            // labelRecentMedia
            // 
            this.labelRecentMedia.AutoSize = true;
            this.labelRecentMedia.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecentMedia.Location = new System.Drawing.Point(34, 110);
            this.labelRecentMedia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecentMedia.Name = "labelRecentMedia";
            this.labelRecentMedia.Size = new System.Drawing.Size(139, 24);
            this.labelRecentMedia.TabIndex = 0;
            this.labelRecentMedia.Text = "Recent Media";
            // 
            // btnOpenFIle
            // 
            this.btnOpenFIle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFIle.Location = new System.Drawing.Point(883, 43);
            this.btnOpenFIle.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnOpenFIle.Name = "btnOpenFIle";
            this.btnOpenFIle.Size = new System.Drawing.Size(92, 38);
            this.btnOpenFIle.TabIndex = 1;
            this.btnOpenFIle.Text = "Open FIle(s)";
            this.btnOpenFIle.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelHomeForm
            // 
            this.flowLayoutPanelHomeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flowLayoutPanelHomeForm.Location = new System.Drawing.Point(27, 168);
            this.flowLayoutPanelHomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelHomeForm.Name = "flowLayoutPanelHomeForm";
            this.flowLayoutPanelHomeForm.Size = new System.Drawing.Size(965, 475);
            this.flowLayoutPanelHomeForm.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFile,
            this.toolStripSeparator,
            this.toolStripButtonOpenFolder,
            this.toolStripButtonOpenURL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(44, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenFile.Image")));
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(145, 34);
            this.toolStripButtonOpenFile.Text = "Open File    ";
            // 
            // toolStripButtonOpenFolder
            // 
            this.toolStripButtonOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenFolder.Image")));
            this.toolStripButtonOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFolder.Name = "toolStripButtonOpenFolder";
            this.toolStripButtonOpenFolder.Size = new System.Drawing.Size(147, 34);
            this.toolStripButtonOpenFolder.Text = "Open Folder";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.toolStrip1);
            this.panelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButton.Location = new System.Drawing.Point(948, 44);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(44, 37);
            this.panelButton.TabIndex = 4;
            // 
            // toolStripButtonOpenURL
            // 
            this.toolStripButtonOpenURL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenURL.Image")));
            this.toolStripButtonOpenURL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenURL.Name = "toolStripButtonOpenURL";
            this.toolStripButtonOpenURL.Size = new System.Drawing.Size(145, 34);
            this.toolStripButtonOpenURL.Text = "Open URL   ";
            // 
            // addHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnOpenFIle);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.flowLayoutPanelHomeForm);
            this.Controls.Add(this.labelRecentMedia);
            this.Controls.Add(this.labelNameHome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addHomeForm";
            this.Size = new System.Drawing.Size(1018, 648);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameHome;
        private System.Windows.Forms.Label labelRecentMedia;
        private System.Windows.Forms.Button btnOpenFIle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHomeForm;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFolder;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenURL;
        private System.Windows.Forms.Panel panelButton;
    }
}
