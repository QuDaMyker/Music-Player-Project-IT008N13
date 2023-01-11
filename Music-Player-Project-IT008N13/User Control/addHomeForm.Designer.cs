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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addHomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelLibraries = new System.Windows.Forms.Label();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customButton1 = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customButton3 = new Music_Player_Project_IT008N13.Controls.CustomButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Home";
            // 
            // labelLibraries
            // 
            this.labelLibraries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibraries.ForeColor = System.Drawing.Color.White;
            this.labelLibraries.Location = new System.Drawing.Point(50, 125);
            this.labelLibraries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLibraries.Name = "labelLibraries";
            this.labelLibraries.Size = new System.Drawing.Size(150, 27);
            this.labelLibraries.TabIndex = 6;
            this.labelLibraries.Text = "Recent media";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFile,
            this.toolStripSeparator,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(581, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(170, 45);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenFile.Image")));
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(89, 42);
            this.toolStripButtonOpenFile.Text = "Open File    ";
            this.toolStripButtonOpenFile.Click += new System.EventHandler(this.toolStripButtonOpenFile_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.openURLToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Music_Player_Project_IT008N13.Properties.Resources.down_arrow;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(36, 42);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = global::Music_Player_Project_IT008N13.Properties.Resources.add_folder;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = global::Music_Player_Project_IT008N13.Properties.Resources.folder;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // openURLToolStripMenuItem
            // 
            this.openURLToolStripMenuItem.Image = global::Music_Player_Project_IT008N13.Properties.Resources.www1;
            this.openURLToolStripMenuItem.Name = "openURLToolStripMenuItem";
            this.openURLToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.openURLToolStripMenuItem.Text = "Open URL";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(55, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(956, 323);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 2;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(0, 0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(112, 28);
            this.customButton1.TabIndex = 8;
            this.customButton1.Text = "Open files()";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.customButton3);
            this.panel1.Location = new System.Drawing.Point(857, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 31);
            this.panel1.TabIndex = 11;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.customButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.customButton3.BorderRadius = 0;
            this.customButton3.BorderSize = 2;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(111, 0);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(43, 28);
            this.customButton3.TabIndex = 10;
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // addHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelLibraries);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addHomeForm";
            this.Size = new System.Drawing.Size(1084, 790);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLibraries;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openURLToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private Controls.CustomButton customButton1;
        private Controls.CustomButton customButton3;
        private System.Windows.Forms.Panel panel1;
    }
}
