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
        private bool is_Play = true;
        private Button currentButton;
        public mainForm()
        {
            InitializeComponent();
            ActiveButton(btnHome);
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.Location = new Point(209, 0);
            childForm.Size = new Size(1047, 647);
            childForm.ShowDialog();
        }
        private void ActiveButton(object btnSender)
        {
            ToolStripButton btn = (ToolStripButton)btnSender;
            DisableButton(btn, btn.Tag);
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular);
            btn.BackColor = Color.Coral;
            btn.ForeColor = Color.White;
        }

        private void DisableButton(object btnSender, object tagButton)
        {
            foreach (Object previousButton in toolStripControl.Items)
            {
                if (previousButton.GetType() == typeof(ToolStripButton))
                {
                    ToolStripButton btn = previousButton as ToolStripButton;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
                    btn.ForeColor = Color.Black;
                    btn.BackColor = System.Drawing.Color.LightSalmon;
                }
            }

        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            addHomeForm1.Show();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }

        private void bbtnMusicLibrary_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Show();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }

        private void btnVideoLibrary_Click(object sender, EventArgs e)
        {


            ActiveButton(sender);


            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Show();
            addSettingForm1.Hide();
        }

        private void btnPlayQueue_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            addHomeForm1.Hide();
            addMediaQueueForm1.Show();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);

            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Show();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);


            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Show();
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;
            if (is_Play == true)
            {
                btn.Image = global::Music_Player_Project_IT008N13.Properties.Resources.pause;
                is_Play = false;
            }
            else
            {
                btn.Image = global::Music_Player_Project_IT008N13.Properties.Resources.play;
                is_Play = true;
            }
                
                
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void slider1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}