using Music_Player_Project_IT008N13.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TagLib;

namespace Music_Player_Project_IT008N13
{
    public partial class mainForm : Form
    {
        private bool is_Play = true;
        private bool is_Muted = true;
        private Button currentButton;
        private Pen pen = new Pen(Color.FromArgb(50, 50, 50), 2);
        private ImageButtonMenuBar imageMenuBar = new ImageButtonMenuBar();
        private imagebuttonExit_Max_Min imageButtonControlApp = new imagebuttonExit_Max_Min();
        public mainForm()
        {
            
            InitializeComponent();
            Graphics g = CreateGraphics();
            g.DrawLine(pen, new Point(0, 216), new Point(316, 216));
            Active_Button(btnHome);

        }
        private void Active_Button(object sender)
        {
            CustomButton button = (CustomButton)sender;
            button.BackColor = Color.FromArgb(45, 45, 45);
        }
        private void Disable_Button(object sender)
        {
            foreach(object button in panelMenuBar.Controls)
            {
                if (button.GetType() == typeof(CustomButton))
                {
                    CustomButton currentButton = (CustomButton)button;
                    currentButton.BackColor = Color.Transparent;
                }
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Active_Button(sender);
            addHomeForm1.Show();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }

        private void bbtnMusicLibrary_Click(object sender, EventArgs e)
        {
            Active_Button(sender);
            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Show();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }

        private void btnVideoLibrary_Click(object sender, EventArgs e)
        {
            Active_Button(sender);
            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Show();
            addSettingForm1.Hide();
        }

        private void btnPlayQueue_Click(object sender, EventArgs e)
        {
            Active_Button(sender);
            addHomeForm1.Hide();
            addMediaQueueForm1.Show();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            Active_Button(sender);
            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Show();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Active_Button(sender); 
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
                player.Ctlcontrols.pause();
            }
            else
            {
                btn.Image = global::Music_Player_Project_IT008N13.Properties.Resources.play;
                is_Play = true;
                player.Ctlcontrols.play();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void slider1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void player_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            lbVolumn.Text = trackBar1.Value.ToString();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;
            if (is_Muted)
            {
                is_Muted = !is_Muted;
                btn.Image = global::Music_Player_Project_IT008N13.Properties.Resources.mute;
                trackBar1.Value = 0;
                player.settings.volume = trackBar1.Value;
                lbVolumn.Text = trackBar1.Value.ToString();
            }
            else
            {
                is_Muted = !is_Muted;
                btn.Image = global::Music_Player_Project_IT008N13.Properties.Resources.speaker_filled_audio_tool;
                trackBar1.Value = 15;
                player.settings.volume = trackBar1.Value;
                lbVolumn.Text = trackBar1.Value.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.next();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.previous();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            //player.Ctlcontrols.Suffer
        }

        private void customButton3_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Load_Image_MenuBar();
            Graphics g = CreateGraphics();
            g.DrawLine(pen, new Point(0, 216), new Point(316, 216));
            Load_Image_Minimize_Maximize_Exit();
        }
        private void Load_Image_MenuBar()
        {
            // btnHome
            btnHome.Image = imageMenuBar.ImagebtnHome;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;

            //btn Music Library
            btnMusicLibrary.Image = imageMenuBar.ImagebtnMusicLibrary;
            btnMusicLibrary.ImageAlign = ContentAlignment.MiddleLeft;
            btnMusicLibrary.TextImageRelation = TextImageRelation.ImageBeforeText;

            // btn Video Library
            btnVideoLibrary.Image = imageMenuBar.ImagebtnVideoLibrary;
            btnVideoLibrary.ImageAlign = ContentAlignment.MiddleLeft;
            btnVideoLibrary.TextImageRelation = TextImageRelation.ImageBeforeText;

            // btn Play Queue
            btnPlayQueue.Image = imageMenuBar.ImagebtnPlayQueue;
            btnPlayQueue.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlayQueue.TextImageRelation = TextImageRelation.ImageBeforeText;

            // btn Play Lists Main
            btnPlayListsMain.Image = imageMenuBar.ImagebtnPlayListsMain;
            btnPlayListsMain.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlayListsMain.TextImageRelation = TextImageRelation.ImageBeforeText;

            // btn Play Lists Child 1 -- Example
            btnPlayListChild1.Image = imageMenuBar.ImagebtnPlayListsChild;
            btnPlayListChild1.ImageAlign = ContentAlignment.MiddleCenter;
            btnPlayListChild1.TextImageRelation = TextImageRelation.ImageBeforeText;

            // btn Play Lists Child 2 -- Example
            btnPlayListChild2.Image = imageMenuBar.ImagebtnPlayListsChild;
            btnPlayListChild2.ImageAlign = ContentAlignment.MiddleCenter;   
            btnPlayListChild2.TextImageRelation = TextImageRelation.ImageBeforeText;

            // btn Setting
            btnSetting.Image = imageMenuBar.ImagebtnSetting;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
        private void Load_Image_Minimize_Maximize_Exit()
        {
            // btn Exit
            btnExit.BackgroundImage = imageButtonControlApp.ImageButtonExit;
            btnExit.BackgroundImageLayout = ImageLayout.Center;

            // btn Minimize
            btnMinimize.BackgroundImage = imageButtonControlApp.ImageButtonMinimize;
            btnMinimize.BackgroundImageLayout = ImageLayout.Center;

            // btn Maximize 
            btnMaximize.BackgroundImage = imageButtonControlApp.ImageButtonMaximize;
            btnMaximize.BackgroundImageLayout = ImageLayout.Center;

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            // maximize app
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            // minimize app 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}