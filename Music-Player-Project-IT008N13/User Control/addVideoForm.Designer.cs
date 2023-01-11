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
            this.label1 = new System.Windows.Forms.Label();
            this.weCantFindAnyVideo1 = new Music_Player_Project_IT008N13.WeCantFindAnyVideo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Video";
            // 
            // weCantFindAnyVideo1
            // 
            this.weCantFindAnyVideo1.BackColor = System.Drawing.Color.Transparent;
            this.weCantFindAnyVideo1.Location = new System.Drawing.Point(150, 183);
            this.weCantFindAnyVideo1.Name = "weCantFindAnyVideo1";
            this.weCantFindAnyVideo1.Size = new System.Drawing.Size(669, 251);
            this.weCantFindAnyVideo1.TabIndex = 9;
            // 
            // addVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.weCantFindAnyVideo1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addVideoForm";
            this.Size = new System.Drawing.Size(1047, 647);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private WeCantFindAnyVideo weCantFindAnyVideo1;
    }
}
