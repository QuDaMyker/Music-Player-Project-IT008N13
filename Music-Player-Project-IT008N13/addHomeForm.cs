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
using HXV;
using WMPLib;

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
        public addHomeForm()
        {
            InitializeComponent();
        }
        private void addSongs()
        {
            //flowLayoutPanelSongs.AutoScroll = true;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Ten Bai Hat";
            dataGridView1.Columns[1].Name = "Ca Si";
            dataGridView1.Columns[2].Name = "Thoi Luong";

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
                    //Button song = new Button();
                    //song.Text = Files[i].Substring(Files[i].LastIndexOf("\\") + 1).Replace(".mp3", "").ToUpper();
                    string nameSong = Files[i].Substring(Files[i].LastIndexOf("\\") + 1).Replace(".mp3", "").ToUpper();
                    //song.Height = dataGridView1.Height / 10;
                    //listBox1.Controls.Add(song);
                    Mp3Tag readerMp3 = new Mp3Tag();
                    if(readerMp3.Title == null)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = nameSong;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[0].Value = readerMp3.Title;
                    }
                    if (readerMp3.Artist == null)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = "Unknown";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[1].Value = readerMp3.Artist;
                    }
                    /*WindowsMediaPlayerClass wmp = new WindowsMediaPlayerClass();
                    IWMPMedia mediaInformation = wmp.newMedia(Files[i]);
                    MessageBox.Show(mediaInformation.durationString);*/
                    //MessageBox.Show(readerMp3.Artist);
                    

                    //song.Dock = DockStyle.Top;
                    //song.BringToFront();
                    //track_list
                    /*song.Width = flowLayoutPanelSongs.Width;
                    song.Height = flowLayoutPanelSongs.Height / 10;
                    song.Text = Files[i].Substring(Files[i].LastIndexOf("\\") + 1).Replace(".mp3","").ToUpper();
                    flowLayoutPanelSongs.Controls.Add(song);*/
                }
            }
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
            if (folderOpen.ShowDialog() == DialogResult.OK)
            {
                _FolderContainMedia = folderOpen.SelectedPath;
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSongs();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderOpen = new FolderBrowserDialog();
            if (folderOpen.ShowDialog() == DialogResult.OK)
            {
                _FolderContainMedia = folderOpen.SelectedPath;
            }
        }
    }
}
