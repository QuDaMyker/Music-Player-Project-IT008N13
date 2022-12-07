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
            this.btnOpenFIle = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenURL = new System.Windows.Forms.ToolStripButton();
            this.panelButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
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
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonOpenFolder
            // 
            this.toolStripButtonOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenFolder.Image")));
            this.toolStripButtonOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFolder.Name = "toolStripButtonOpenFolder";
            this.toolStripButtonOpenFolder.Size = new System.Drawing.Size(147, 34);
            this.toolStripButtonOpenFolder.Text = "Open Folder";
            // 
            // toolStripButtonOpenURL
            // 
            this.toolStripButtonOpenURL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenURL.Image")));
            this.toolStripButtonOpenURL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenURL.Name = "toolStripButtonOpenURL";
            this.toolStripButtonOpenURL.Size = new System.Drawing.Size(145, 34);
            this.toolStripButtonOpenURL.Text = "Open URL   ";
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Settings";
            // 
            // addHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFIle);
            this.Controls.Add(this.panelButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addHomeForm";
            this.Size = new System.Drawing.Size(1018, 648);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenFIle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFolder;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenURL;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Label label1;
    }
}
