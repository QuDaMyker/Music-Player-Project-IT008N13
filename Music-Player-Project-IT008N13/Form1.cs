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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addHomeForm1.Show();
            addMediaQueueForm1.Hide();
            addPlaylistForm1.Hide();
            addMusicForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }
    }
}
