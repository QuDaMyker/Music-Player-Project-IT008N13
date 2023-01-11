namespace Music_Player_Project_IT008N13
{
    partial class addSettingForm
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
            this.labelSetting = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelSetting
            // 
            this.labelSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetting.ForeColor = System.Drawing.Color.White;
            this.labelSetting.Location = new System.Drawing.Point(50, 50);
            this.labelSetting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(146, 46);
            this.labelSetting.TabIndex = 0;
            this.labelSetting.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(57, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 420);
            this.panel1.TabIndex = 1;
            // 
            // addSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSetting);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "addSettingForm";
            this.Size = new System.Drawing.Size(1084, 790);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}
