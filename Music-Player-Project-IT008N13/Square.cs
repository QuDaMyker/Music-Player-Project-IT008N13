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
        private bool is_Play = true;
        public Square()
        {
            InitializeComponent();
        }
        private void btn_play_pause_Click_1(object sender, EventArgs e)
        {
            if (is_Play == true)
            {
                btn_play_pause.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.pausedisplay;
                is_Play = false;
            }
            else
            {
                btn_play_pause.BackgroundImage = global::Music_Player_Project_IT008N13.Properties.Resources.playdisplay;
                is_Play = true;
            }
        }
    }
}
