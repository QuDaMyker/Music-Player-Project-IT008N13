using AxWMPLib;
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

namespace Music_Player_Project_IT008N13
{
    public partial class Square : UserControl
    {
        private bool is_Play = false;
        private string nameSong = String.Empty;
        public string _nameSong
        {
            get
            {
                return nameSong;
            }
            set
            {
                nameSong = value;
            }
        }
        private string urlSong = String.Empty;
        public string _urlSong
        {
            get
            {
                return urlSong;
            }
            set
            {
                urlSong = value;
            }
        }
        public Square() { }
        public Square(string tenSong, string UrlSong)
        {
            InitializeComponent();
            _nameSong = tenSong;
            _urlSong = UrlSong;
            _init();
        }
        private void _init()
        {
            if (nameSong != String.Empty)
            {
                labelNameSong.Text = nameSong;
            }
        }
        private Bitmap btnPlayPause = null;
        public Bitmap _btnPlayPause
        {
            get
            {
                return btnPlayPause;
            }
            set
            {
                btnPlayPause = value;
            }
        }
        private void loadSlider()
        {
            
        }
        private void btn_play_pause_Click_1(object sender, EventArgs e)
        {
            if (is_Play == true)
            {
                btn_play_pause.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.playdisplay;
                is_Play = false;
                global::Music_Player_Project_IT008N13.mainForm.player.URL = String.Empty;
                global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.pause();
            }
            else
            {
                btn_play_pause.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.pausedisplay;
                is_Play = true;
                global::Music_Player_Project_IT008N13.mainForm.player.URL= _urlSong;
                global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.play();
                
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            global::Music_Player_Project_IT008N13.mainForm.slider1.Maximum = (int)global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentItem.duration;
            global::Music_Player_Project_IT008N13.mainForm.slider1.Value = (int)global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentPosition;
            //MessageBox.Show(global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentPosition.ToString());
            global::Music_Player_Project_IT008N13.mainForm.lbCurrentDuration.Text = global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentPositionString;
            global::Music_Player_Project_IT008N13.mainForm.lbDurationItem.Text = global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentItem.durationString;

        }

    }
}
