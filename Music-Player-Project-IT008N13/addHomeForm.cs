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
using AxWMPLib;

namespace Music_Player_Project_IT008N13
{
    public partial class addHomeForm : UserControl
    {
        private string _FolderContainMedia = String.Empty;
        private string _FileContainMedia = String.Empty;
        static string[] FileInFolder;
        static string[] Files;
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
        public string FileContainMedia
        {
            get { return _FileContainMedia; }
            set { _FileContainMedia = value; }
        }
        mainForm fgrid;
        public addHomeForm()
        {
            InitializeComponent();
        }
        private void addSongs()
        {
            flowLayoutPanelSongs.AutoScroll = true;
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "MP3 File |*.mp3|" +
                "MP4 File |*.mp4|" +
                "MKV File |*.mkv|" +
                "M3U8 File |*.m3u8|" +
                "FLAC File |*.flac|" +
                "All files (*.*)|*.*";
            fileOpen.FilterIndex = 0;
            fileOpen.Multiselect = true;
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                Files = fileOpen.FileNames;

                for (int i = 0; i < Files.Length; i++)
                {
                    Button song = new Button();
                    song.Width = flowLayoutPanelSongs.Width;
                    song.Height = flowLayoutPanelSongs.Height / 10;
                    song.Text = Files[i].Substring(Files[i].LastIndexOf("\\") + 1).Replace(".mp3","").ToUpper();
                    flowLayoutPanelSongs.Controls.Add(song);
                    song.Click += (click_Song);
                }
            }
        }
        private void click_Song(object sender, EventArgs e)
        {
            mainForm.axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void btnOpenFIle_Click(object sender, EventArgs e)
        {
            addSongs();
        }

        private void toolStripButtonOpenFile_Click(object sender, EventArgs e)
        {
            addSongs();
        }

        private void toolStripButtonOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderOpen = new FolderBrowserDialog();
            if(folderOpen.ShowDialog() == DialogResult.OK)
            {
                _FolderContainMedia = folderOpen.SelectedPath;
            }
        }

    }
}
