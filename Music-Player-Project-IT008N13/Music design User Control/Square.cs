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
        public Square()
        {
            InitializeComponent();
        }
        public Image _Thumbnail
        {
            get { return thumbnail.Image; }
            set { thumbnail.Image = value; }
        }
        private bool havingSong = false;
        public bool _havingSong
        {
            get { return havingSong; }
            set { havingSong = value; }
        }
        private bool isPlaying = false;
        public bool _isPlaying
        {
            get { return isPlaying; }
            set
            {
                isPlaying = value;
                if (isPlaying == true)
                {
                    btn_play_pause.BackgroundImage = Music_Player_Project_IT008N13.Properties.Resources.pausedisplay;
                }
                else
                {
                    btn_play_pause.BackgroundImage = Music_Player_Project_IT008N13.Properties.Resources.playdisplay;
                }



            }
        }
        
        public string _Title
        {
            get { return Title.Text; }
            set { Title.Text = value; }
        }
        private string Artist;
        public string _Artist
        {
            get { return Artist; }
            set { Artist = value; }
        }
        private string URL;
        public string _URL
        {
            get { return URL; }
            set { URL = value; }
        }
        private string Duration;
        public string _Duration
        {
            get { return Duration; }
            set { Duration = value; }
        }
        public event EventHandler onAction = null;
        /*private void actionPlay_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            if(onAction!= null)
            {
                onAction.Invoke(this, e);
            }
        }*/

        private void btn_play_pause_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            if (onAction != null)
            {
                onAction.Invoke(this, e);
            }
        }
    }
}
