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
        public static Square[] squares;
        
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
                if(Files.Length > 10)
                {

                }
                squares = new Square[Files.Length];
                for (int i = 0; i < Files.Length; i++)
                {
                    string nameSong = Files[i].Substring(Files[i].LastIndexOf("\\") + 1).Replace(".mp3", "").ToUpper();
                    squares[i] = new Square(nameSong, Files[i]);
                    squares[i].Click += new EventHandler(squares_Click);
                    timer1.Start();
                    flowLayoutPanel1.Controls.Add(squares[i]);
                }
            }
        }
        private void squares_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
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
