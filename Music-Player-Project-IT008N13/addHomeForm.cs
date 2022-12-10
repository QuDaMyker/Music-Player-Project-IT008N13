using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Music_Player_Project_IT008N13
{
    public partial class addHomeForm : UserControl
    {
        private string _FolderContainMedia = String.Empty;
        public string FolderContainMedia
        {
            get
            {
                return _FolderContainMedia;
            }
            set
            {
                _FolderContainMedia = value;
            }
        }
        public addHomeForm()
        {
            InitializeComponent();
        }
        private void btnOpenFIle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();
            dg.Filter = "|*.mp3| |*.mp4| |*.mkv| |*.m3u8| |All files (*.*)|*.*|";
            dg.FilterIndex = 0;
            dg.ShowDialog(this);
        }

        private void toolStripButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "|*.mp3| |*.mp4| |*.mkv| |*.m3u8| |All files (*.*)|*.*|";
            fileOpen.FilterIndex = 0;
            fileOpen.ShowDialog(this);
        }

        private void toolStripButtonOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderOpen = new FolderBrowserDialog();
            _FolderContainMedia = folderOpen.SelectedPath;
            folderOpen.ShowDialog(this);
        }
    }
}
