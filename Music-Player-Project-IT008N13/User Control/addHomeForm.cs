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
using System.Runtime.InteropServices.ComTypes;
using System.Security.Principal;
using System.Reflection;
using System.Windows.Media;
using Music_Player_Project_IT008N13.Music_design_User_Control;


namespace Music_Player_Project_IT008N13
{
    public partial class addHomeForm : UserControl
    {
        private string _FolderContainMedia = String.Empty;
        private string _FileContainMedia = String.Empty;
        static string[] FileInFolder;
        static string[] Files;
        public static Square[] squares;
        //
        //
        DataGridView dataRecentHomePage;
        
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
            _initDataGridViewCurrentSong();
            //global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.pause();
        }
        public void _initDataGridViewCurrentSong()
        {
            dataRecentHomePage = new DataGridView();
            dataRecentHomePage.ColumnCount = 3;
            dataRecentHomePage.Columns[0].ValueType = typeof(string);
            dataRecentHomePage.Columns[0].Name = "STT";
            dataRecentHomePage.Columns[1].ValueType = typeof(string);
            dataRecentHomePage.Columns[1].Name = "Name Song";
            dataRecentHomePage.Columns[2].ValueType = typeof(string);
            dataRecentHomePage.Columns[2].Name = "URL Song";
            try
            {
                _importFormFileHistoryCurrentSong();
                squares = new Square[dataRecentHomePage.RowCount - 1];
                for (int i = 0; i < dataRecentHomePage.RowCount - 1; i++)
                {
                    squares[i] = new Square();
                    string nameSong = String.Empty;
                    string UrlPictureBox = String.Empty;
                    var tfile = TagLib.File.Create($@"{dataRecentHomePage.Rows[i].Cells[2].Value}");
                    if (String.IsNullOrEmpty(tfile.Tag.Title))
                    {
                        nameSong = dataRecentHomePage.Rows[i].Cells[2].Value.ToString().Substring(dataRecentHomePage.Rows[i].Cells[2].Value.ToString().LastIndexOf("\\") + 1).Replace(".mp3", "").ToUpper();
                    }
                    else
                    {
                        nameSong = tfile.Tag.Title;
                    }
                    squares[i]._Title = nameSong;
                    squares[i]._URL = dataRecentHomePage.Rows[i].Cells[2].Value.ToString();
                    var mStream = new MemoryStream();
                    var firstPicture = tfile.Tag.Pictures.FirstOrDefault();
                    if (firstPicture != null)
                    {
                        byte[] pData = firstPicture.Data.Data;
                        mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                        Bitmap bm = new Bitmap(mStream, false);
                        mStream.Dispose();
                        squares[i]._Thumbnail = bm;
                    }
                    else
                    {
                        squares[i]._Thumbnail = null;
                    }
                    squares[i].onAction += new EventHandler(square_onAction);
                    //timer1.Start();
                    flowLayoutPanel1.Controls.Add(squares[i]);
                }
            }
            catch
            {

            }

            //var myPlayList = global::Music_Player_Project_IT008N13.mainForm.player.playlistCollection.newPlaylist("MyPlayList");
            //addToMediaPlayer(Music_Player_Project_IT008N13.mainForm.player);


        }
        private void addToMediaPlayer(AxWMPLib.AxWindowsMediaPlayer player)
        {
            var pl = player.playlistCollection.newPlaylist("plList");
            string[] lines = File.ReadAllLines($@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Music-Player-Project-IT008N13\Database\historyCurrentSong.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];
                pl.appendItem(player.newMedia($@"{values[2]}"));
            }
            player.currentPlaylist = pl;
        }
        private void _importFormFileHistoryCurrentSong()
        {
            string[] lines = File.ReadAllLines($@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Music-Player-Project-IT008N13\Database\historyCurrentSong.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                if (File.Exists(values[2])) 
                {
                    string[] row = new string[values.Length];
                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    dataRecentHomePage.Rows.Add(row);
                }
                else
                {
                    continue;
                }    
                
            }
        }
        private void _exportToFileFileHistoryCurrentSong()
        {
            TextWriter writer = new StreamWriter($@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Music-Player-Project-IT008N13\Database\historyCurrentSong.txt");
            for (int i = 0; i < squares.Length; i++)
            {
                writer.Write(dataRecentHomePage.Rows[i].Cells[0].Value.ToString() + "|");
                writer.Write(dataRecentHomePage.Rows[i].Cells[1].Value.ToString() + "|");
                writer.Write(dataRecentHomePage.Rows[i].Cells[2].Value.ToString());
                writer.WriteLine("");
            }
            writer.Close();
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
                squares = new Square[Files.Length];
                //var playlist = Music_Player_Project_IT008N13.mainForm.player.playlistCollection.newPlaylist("myplaylist");
                var myPlayList = global::Music_Player_Project_IT008N13.mainForm.player.playlistCollection.newPlaylist("MyPlayList");

                foreach (string file in fileOpen.FileNames)
                {
                    var mediaItem = Music_Player_Project_IT008N13.mainForm.player.newMedia(file);
                    myPlayList.appendItem(mediaItem);
                }
                Music_Player_Project_IT008N13.mainForm.player.currentPlaylist = myPlayList;
                for (int i = 0; i < squares.Length; i++)
                {
                    squares[i] = new Square();
                    string nameSong = String.Empty;
                    string UrlPictureBox = String.Empty;
                    var tfile = TagLib.File.Create($@"{Files[i]}");
                    if (String.IsNullOrEmpty(tfile.Tag.Title))
                    {
                        nameSong = Files[i].Substring(Files[i].LastIndexOf("\\") + 1).Replace(".mp3", "").ToUpper();
                    }
                    else
                    {
                        nameSong = tfile.Tag.Title;
                    }
                    squares[i]._Title = nameSong;
                    var mStream = new MemoryStream();
                    var firstPicture = tfile.Tag.Pictures.FirstOrDefault();
                    if (firstPicture != null)
                    {
                        byte[] pData = firstPicture.Data.Data;
                        mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                        Bitmap bm = new Bitmap(mStream, false);
                        mStream.Dispose();
                        squares[i]._Thumbnail = bm;
                    }
                    else
                    {
                        squares[i]._Thumbnail = null;
                    }
                    squares[i].onAction += new EventHandler(square_onAction);
                    //timer1.Start();
                    string[] dataAddToDataRecentHomePage = { $"{i}", $"{nameSong}", $"{Files[i]}" };
                    dataRecentHomePage.Rows.Add(dataAddToDataRecentHomePage);
                    flowLayoutPanel1.Controls.Add(squares[i]);
                }
            }
            Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.stop();
            _exportToFileFileHistoryCurrentSong();
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
        public event EventHandler ItemSelected = null;

        private void square_onAction(object sender, EventArgs e)
        {
            if(((Square)sender)._URL != Music_Player_Project_IT008N13.mainForm.player.URL)
            {
                //MessageBox.Show(squares.Length.ToString());
                for (int i = 0; i < squares.Length - 1; i++)
                {
                    squares[i]._isPlaying = false;
                }
            //
            //
                ((Square)sender)._isPlaying = true;
                MessageBox.Show(((Square)sender)._isPlaying.ToString());
                //MessageBox.Show(((Square)sender)._URL);
                Music_Player_Project_IT008N13.mainForm.player.URL = ((Square)sender)._URL;
                Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.play();
                string song = (string)(((Square)sender).Tag);
                //timer1.Start();
                //
                //
            }
            else
            {
                //MessageBox.Show(((Square)sender)._isPlaying.ToString());
                if(((Square)sender)._isPlaying == true)
                {
                    ((Square)sender)._isPlaying = false;
                    Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.pause();
                    //Music_Player_Project_IT008N13.mainForm.btnPlayPause.Image = Properties.Resources.pausedisplay;
                }
                else
                {
                    ((Square)sender)._isPlaying = true;
                    Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.play();
                    //Music_Player_Project_IT008N13.mainForm.btnPlayPause.Image = Properties.Resources.pausedisplay;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            global::Music_Player_Project_IT008N13.mainForm.slider1.Maximum = (int)global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentItem.duration;
            global::Music_Player_Project_IT008N13.mainForm.slider1.Value = (int)global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentPosition;
            //MessageBox.Show(global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentPosition.ToString());
            global::Music_Player_Project_IT008N13.mainForm.lbCurrentDuration.Text = global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentPositionString;
            global::Music_Player_Project_IT008N13.mainForm.lbDurationItem.Text = global::Music_Player_Project_IT008N13.mainForm.player.Ctlcontrols.currentItem.durationString;

            if(Music_Player_Project_IT008N13.mainForm.player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                for (int i = 0; i < squares.Length; i++)
                {
                    if (squares[i]._URL == Music_Player_Project_IT008N13.mainForm.player.URL)
                    {
                        if (i == squares.Length - 1)
                        {
                            Music_Player_Project_IT008N13.mainForm.player.URL = squares[0]._URL;
                        }
                        else
                        {
                            Music_Player_Project_IT008N13.mainForm.player.URL = squares[i + 1]._URL;
                        }
                    }
                }
            }

        }
    }
}
