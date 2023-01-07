using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_Project_IT008N13.InitialUI
{
    public partial class MeetTheNewMediaPlayer : UserControl
    {
        private Image image;
        private Bitmap bitmap;
        public MeetTheNewMediaPlayer()
        {
            InitializeComponent();
            Load_Image();
        }
        private void Load_Image()
        {
            bitmap = new Bitmap(global::Music_Player_Project_IT008N13.Properties.Resources.add_folder, new Size(25, 25));
            buttonAddFolder.Image = bitmap;
            buttonAddFolder.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void buttonAddFolder_Click(object sender, EventArgs e)
        {

        }
    }
}
