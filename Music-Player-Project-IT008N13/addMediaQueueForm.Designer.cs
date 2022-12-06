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
            this.labelNamePlayQueue = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNamePlayQueue
            // 
            this.labelNamePlayQueue.AutoSize = true;
            this.labelNamePlayQueue.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamePlayQueue.Location = new System.Drawing.Point(38, 26);
            this.labelNamePlayQueue.Name = "labelNamePlayQueue";
            this.labelNamePlayQueue.Size = new System.Drawing.Size(433, 87);
            this.labelNamePlayQueue.TabIndex = 2;
            this.labelNamePlayQueue.Text = "Play Queue";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(125, 183);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // addMediaQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.labelNamePlayQueue);
            this.Name = "addMediaQueueForm";
            this.Size = new System.Drawing.Size(1358, 797);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
