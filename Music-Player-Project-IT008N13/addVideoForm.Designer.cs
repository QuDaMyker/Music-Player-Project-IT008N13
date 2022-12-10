namespace Music_Player_Project_IT008N13
{
    partial class addVideoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addVideoForm));
            this.labelVideo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.labelSortBy = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemAtoZ = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemZtoA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVideo
            // 
            this.labelVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVideo.Location = new System.Drawing.Point(68, 26);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(195, 57);
            this.labelVideo.TabIndex = 8;
            this.labelVideo.Text = "Video";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFolder});
            this.toolStrip1.Location = new System.Drawing.Point(1142, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(129, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFolder.Image")));
            this.btnAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(87, 32);
            this.btnAddFolder.Text = "Add folder";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelSortBy,
            this.toolStripSeparator1,
            this.labelDropDown});
            this.toolStrip2.Location = new System.Drawing.Point(1149, 115);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(122, 34);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // labelSortBy
            // 
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(50, 31);
            this.labelSortBy.Text = "Sort by: ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // labelDropDown
            // 
            this.labelDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.labelDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAtoZ,
            this.MenuItemZtoA});
            this.labelDropDown.ForeColor = System.Drawing.Color.IndianRed;
            this.labelDropDown.Image = ((System.Drawing.Image)(resources.GetObject("labelDropDown.Image")));
            this.labelDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.labelDropDown.Name = "labelDropDown";
            this.labelDropDown.Size = new System.Drawing.Size(33, 31);
            this.labelDropDown.Text = "toolStripDropDownButton1";
            // 
            // menuItemAtoZ
            // 
            this.menuItemAtoZ.ForeColor = System.Drawing.Color.Red;
            this.menuItemAtoZ.Name = "menuItemAtoZ";
            this.menuItemAtoZ.Size = new System.Drawing.Size(180, 22);
            this.menuItemAtoZ.Text = "A - Z";
            // 
            // MenuItemZtoA
            // 
            this.MenuItemZtoA.ForeColor = System.Drawing.Color.Red;
            this.MenuItemZtoA.Name = "MenuItemZtoA";
            this.MenuItemZtoA.Size = new System.Drawing.Size(180, 22);
            this.MenuItemZtoA.Text = "Z - A";
            // 
            // addVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelVideo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addVideoForm";
            this.Size = new System.Drawing.Size(1396, 796);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddFolder;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel labelSortBy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton labelDropDown;
        private System.Windows.Forms.ToolStripMenuItem menuItemAtoZ;
        private System.Windows.Forms.ToolStripMenuItem MenuItemZtoA;
    }
}
