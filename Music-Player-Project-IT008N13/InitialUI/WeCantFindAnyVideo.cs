using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_Project_IT008N13
{
    public partial class WeCantFindAnyVideo : UserControl
    {
        private Image image;
        private Bitmap bitmap;
        public WeCantFindAnyVideo()
        {
            InitializeComponent();
            Load_Image();
        }
        private void Load_Image()
        {
            bitmap = new Bitmap(global::Music_Player_Project_IT008N13.Properties.Resources.add_Folder_control, new Size(16, 16));
            buttonAddFolder.Image = bitmap;
            buttonAddFolder.ImageAlign = ContentAlignment.MiddleCenter;
            buttonAddFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void buttonAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
