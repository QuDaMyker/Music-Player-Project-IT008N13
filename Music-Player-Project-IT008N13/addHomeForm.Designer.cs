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
            this.labelNameHome = new System.Windows.Forms.Label();
            this.labelRecentMedia = new System.Windows.Forms.Label();
            this.btnOpenFIle = new System.Windows.Forms.Button();
            this.comboBoxOpenFile = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelHomeForm = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelNameHome
            // 
            this.labelNameHome.AutoSize = true;
            this.labelNameHome.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameHome.Location = new System.Drawing.Point(36, 30);
            this.labelNameHome.Name = "labelNameHome";
            this.labelNameHome.Size = new System.Drawing.Size(236, 87);
            this.labelNameHome.TabIndex = 0;
            this.labelNameHome.Text = "Home";
            // 
            // labelRecentMedia
            // 
            this.labelRecentMedia.AutoSize = true;
            this.labelRecentMedia.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecentMedia.Location = new System.Drawing.Point(45, 135);
            this.labelRecentMedia.Name = "labelRecentMedia";
            this.labelRecentMedia.Size = new System.Drawing.Size(178, 31);
            this.labelRecentMedia.TabIndex = 0;
            this.labelRecentMedia.Text = "Recent Media";
            // 
            // btnOpenFIle
            // 
            this.btnOpenFIle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFIle.Location = new System.Drawing.Point(1174, 71);
            this.btnOpenFIle.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnOpenFIle.Name = "btnOpenFIle";
            this.btnOpenFIle.Size = new System.Drawing.Size(122, 47);
            this.btnOpenFIle.TabIndex = 1;
            this.btnOpenFIle.Text = "Open FIle(s)";
            this.btnOpenFIle.UseVisualStyleBackColor = true;
            // 
            // comboBoxOpenFile
            // 
            this.comboBoxOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOpenFile.FormattingEnabled = true;
            this.comboBoxOpenFile.Location = new System.Drawing.Point(1309, 74);
            this.comboBoxOpenFile.Name = "comboBoxOpenFile";
            this.comboBoxOpenFile.Size = new System.Drawing.Size(20, 44);
            this.comboBoxOpenFile.TabIndex = 2;
            // 
            // flowLayoutPanelHomeForm
            // 
            this.flowLayoutPanelHomeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flowLayoutPanelHomeForm.Location = new System.Drawing.Point(36, 207);
            this.flowLayoutPanelHomeForm.Name = "flowLayoutPanelHomeForm";
            this.flowLayoutPanelHomeForm.Size = new System.Drawing.Size(1287, 585);
            this.flowLayoutPanelHomeForm.TabIndex = 3;
            // 
            // addHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flowLayoutPanelHomeForm);
            this.Controls.Add(this.comboBoxOpenFile);
            this.Controls.Add(this.btnOpenFIle);
            this.Controls.Add(this.labelRecentMedia);
            this.Controls.Add(this.labelNameHome);
            this.Name = "addHomeForm";
            this.Size = new System.Drawing.Size(1358, 797);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameHome;
        private System.Windows.Forms.Label labelRecentMedia;
        private System.Windows.Forms.Button btnOpenFIle;
        private System.Windows.Forms.ComboBox comboBoxOpenFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHomeForm;
    }
}
