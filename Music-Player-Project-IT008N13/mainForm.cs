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
        private Point mouseLocation;
        private bool is_Play = true;
        private bool is_Muted = true;
        private Pen pen = new Pen(Color.FromArgb(50, 50, 50), 2);
        private ImageButtonMenuBar imageMenuBar = new ImageButtonMenuBar();
        private imagebuttonExit_Max_Min imageButtonControlApp = new imagebuttonExit_Max_Min();
        private ImageSoureControlPlayer imageSoureControlPlayer = new ImageSoureControlPlayer();
        private CustomButton previousButton;
        private CustomButton currentButton;
        private bool is_shuffle = false;
        private bool is_Collapsed;
        private int is_loop = 0; // 0_enable_loop; 1_loop_one; 2_disable_loop
        public mainForm()
        {
            
            InitializeComponent();
            Active_Button(btnHome);
            currentButton = btnHome;
            
        }
        
        private void Active_Button(object sender)
        {
            CustomButton button = (CustomButton)sender;
            button.BackColor = Color.FromArgb(45, 45, 45);
        }
        private void Disable_Button(object sender)
        {
            CustomButton button = (CustomButton)sender;
            button.BackColor = Color.FromArgb(32, 32, 32);
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Handle_Click(sender, addHomeForm1);
        }

        private void bbtnMusicLibrary_Click(object sender, EventArgs e)
        {
            Handle_Click(sender, addMusicForm1);
        }

        private void btnVideoLibrary_Click(object sender, EventArgs e)
        {
            Handle_Click(sender, addVideoForm1);
        }

        private void btnPlayQueue_Click(object sender, EventArgs e)
        {
            Handle_Click(sender, addMediaQueueForm1);
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            Handle_Click(sender, addPlaylistForm1);
            timer1.Start();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Handle_Click(sender, addSettingForm1);
        }
        private void Handle_Click(object sender, UserControl userControl)
        {
            previousButton = currentButton;
            currentButton = (CustomButton)sender;
            Disable_Button(previousButton);
            Active_Button(sender);
            userControl.BringToFront();
            panelControlSizeExitApp.BringToFront();
        }
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            CustomButton btn = sender as CustomButton;
            if (is_Play == true)
            {
                btnPlayPause.BackgroundImage = imageSoureControlPlayer.ImagebtnPause;
                btnPlayPause.BackgroundImageLayout = ImageLayout.Center;
                is_Play = false;
                player.Ctlcontrols.pause();
            }
            else
            {
                btnPlayPause.BackgroundImage = imageSoureControlPlayer.ImagebtnPlay;
                btnPlayPause.BackgroundImageLayout = ImageLayout.Center;
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
            CustomButton btn = sender as CustomButton;
            if (is_Muted)
            {
                is_Muted = !is_Muted;
                btn.BackgroundImage = imageSoureControlPlayer.ImagebtnMute;
                btn.BackgroundImageLayout = ImageLayout.Center;
                trackBar1.Value = 0;
                player.settings.volume = trackBar1.Value;
                lbVolumn.Text = trackBar1.Value.ToString();
            }
            else
            {
                is_Muted = !is_Muted;
                btn.BackgroundImage = imageSoureControlPlayer.ImagebtnVolume;
                btn.BackgroundImageLayout = ImageLayout.Center;
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
            if(is_shuffle == false)
            {
                btnShuffle.BackgroundImage = imageSoureControlPlayer.ImagebtnShuffle_Disable;
                btnShuffle.BackgroundImageLayout = ImageLayout.Center;
                is_shuffle = true;
            }
            else
            {
                btnShuffle.BackgroundImage = imageSoureControlPlayer.ImagebtnShuffle_Enable;
                btnShuffle.BackgroundImageLayout = ImageLayout.Center;
                is_shuffle = false;
            }
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            Load_Image_MenuBar();
            Load_Image_Minimize_Maximize_Exit();
            Load_Image_Buttons_Control_Player();
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
        private void Load_Image_Buttons_Control_Player()
        {
            // btn Shuffle
            btnShuffle.BackgroundImage = imageSoureControlPlayer.ImagebtnShuffle_Enable;
            btnShuffle.BackgroundImageLayout = ImageLayout.Center;

            // btn Previous
            btnPrevious.BackgroundImage = imageSoureControlPlayer.ImagebtnPrevious;
            btnPrevious.BackgroundImageLayout = ImageLayout.Center;

            // btn Play 
            btnPlayPause.BackgroundImage = imageSoureControlPlayer.ImagebtnPlay;
            btnPlayPause.BackgroundImageLayout = ImageLayout.Center;

            // btn Next 
            btnNext.BackgroundImage = imageSoureControlPlayer.ImagebtnNext;
            btnNext.BackgroundImageLayout = ImageLayout.Center;

            // btn Loop
            btnLoop.BackgroundImage = imageSoureControlPlayer.ImagebtnLoop_Enable;
            btnLoop.BackgroundImageLayout = ImageLayout.Center;
            // btn Volume
            btnVolume.BackgroundImage = imageSoureControlPlayer.ImagebtnVolume;
            btnVolume.BackgroundImageLayout = ImageLayout.Center;

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelDragForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelDragForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if(is_loop == 0)
            {
                btnLoop.BackgroundImage = imageSoureControlPlayer.ImagebtnLoop_One;
                btnLoop.BackgroundImageLayout = ImageLayout.Center;
                is_loop = 1;
            }
            else if (is_loop == 1)
            {
                btnLoop.BackgroundImage = imageSoureControlPlayer.ImagebtnLoop_Disable;
                btnLoop.BackgroundImageLayout = ImageLayout.Center;
                is_loop = 2;
            }
            else
            {
                btnLoop.BackgroundImage = imageSoureControlPlayer.ImagebtnLoop_Enable;
                btnLoop.BackgroundImageLayout = ImageLayout.Center;
                is_loop = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(is_Collapsed)
            {
                panelDropDownPlayLists.Height += 120;
                if (panelDropDownPlayLists.Size == panelDropDownPlayLists.MaximumSize)
                {
                    timer1.Stop();
                    is_Collapsed = false;
                }
            }
            else
            {
                panelDropDownPlayLists.Height -= 120;
                if (panelDropDownPlayLists.Size == panelDropDownPlayLists.MinimumSize)
                {
                    timer1.Stop();
                    is_Collapsed = true;
                }
            }
        }


    }
}