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
            this.label1 = new System.Windows.Forms.Label();
            this.labelLibraries = new System.Windows.Forms.Label();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.square5 = new Music_Player_Project_IT008N13.Square();
            this.square4 = new Music_Player_Project_IT008N13.Square();
            this.square3 = new Music_Player_Project_IT008N13.Square();
            this.square2 = new Music_Player_Project_IT008N13.Square();
            this.square1 = new Music_Player_Project_IT008N13.Square();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Home";
            // 
            // labelLibraries
            // 
            this.labelLibraries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibraries.Location = new System.Drawing.Point(59, 70);
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
            this.toolStrip1.Location = new System.Drawing.Point(796, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(138, 45);
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
            // square5
            // 
            this.square5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square5.Location = new System.Drawing.Point(734, 100);
            this.square5.Name = "square5";
            this.square5.Size = new System.Drawing.Size(160, 170);
            this.square5.TabIndex = 12;
            // 
            // square4
            // 
            this.square4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square4.Location = new System.Drawing.Point(562, 100);
            this.square4.Name = "square4";
            this.square4.Size = new System.Drawing.Size(160, 170);
            this.square4.TabIndex = 11;
            // 
            // square3
            // 
            this.square3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square3.Location = new System.Drawing.Point(396, 100);
            this.square3.Name = "square3";
            this.square3.Size = new System.Drawing.Size(160, 170);
            this.square3.TabIndex = 10;
            // 
            // square2
            // 
            this.square2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square2.Location = new System.Drawing.Point(230, 100);
            this.square2.Name = "square2";
            this.square2.Size = new System.Drawing.Size(160, 170);
            this.square2.TabIndex = 9;
            // 
            // square1
            // 
            this.square1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square1.Location = new System.Drawing.Point(64, 100);
            this.square1.Name = "square1";
            this.square1.Size = new System.Drawing.Size(160, 170);
            this.square1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(612, 441);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(310, 83);
            this.dataGridView1.TabIndex = 7;
            // 
            // addHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.square5);
            this.Controls.Add(this.square4);
            this.Controls.Add(this.square3);
            this.Controls.Add(this.square2);
            this.Controls.Add(this.square1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelLibraries);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addHomeForm";
            this.Size = new System.Drawing.Size(1018, 648);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Square square1;
        private Square square2;
        private Square square3;
        private Square square4;
        private Square square5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
