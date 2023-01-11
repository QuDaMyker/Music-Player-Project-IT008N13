using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_Project_IT008N13.Music_design_User_Control
{
    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }

        private void Playlist_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Playlist_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
