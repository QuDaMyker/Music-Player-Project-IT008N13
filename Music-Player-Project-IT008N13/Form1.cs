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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.Location = new Point(209, 0);
            childForm.Size = new Size(1047, 647);
            childForm.ShowDialog();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new addHomeForm(), sender);
        }

        private void bbtnMusicLibrary_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new addMusicForm, sender);

        }

        private void btnVideoLibrary_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new addVideoForm, sender);

        }

        private void btnPlayQueue_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new addMediaQueueForm, sender);

        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new addPlaylistForm, sender);

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new addSettingForm, sender);
        }
    }
}
