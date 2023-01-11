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

namespace Music_Player_Project_IT008N13
{
    public partial class addHomeForm : UserControl
    {
        private string _FolderContainMedia = String.Empty;
        private string _FileContainMedia = String.Empty;
        static string[] FileInFolder;
        static string[] Files;
        public static Square[] squares;

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
            /*dataRecentHomePage.Columns[3].ValueType = typeof(string);
            dataRecentHomePage.Columns[3].Name = "STT";*/
            try
            {
                _importFormFileHistoryCurrentSong();
                //MessageBox.Show(dataRecentHomePage.RowCount.ToString());
                squares = new Square[dataRecentHomePage.RowCount - 1];
                for (int i = 0; i < dataRecentHomePage.RowCount - 1; i++)
                {
                    string nameSong = String.Empty;
                    string UrlPictureBox = String.Empty;
                    //MessageBox.Show(dataRecentHomePage.Rows[i].Cells[2].Value.ToString());
                    var tfile = TagLib.File.Create($@"{dataRecentHomePage.Rows[i].Cells[2].Value}");
                    if (String.IsNullOrEmpty(tfile.Tag.Title))
                    {
                        nameSong = dataRecentHomePage.Rows[i].Cells[2].Value.ToString().Substring(dataRecentHomePage.Rows[i].Cells[2].Value.ToString().LastIndexOf("\\") + 1).Replace(".mp3", "").ToUpper();
                    }
                    else
                    {
                        nameSong = tfile.Tag.Title;
                    }
                    // check url anh, artist...
                    // add database
                    //TagLib.File file = TagLib.File.Create(openFileDialog.FileName);


                    var mStream = new MemoryStream();
                    var firstPicture = tfile.Tag.Pictures.FirstOrDefault();

                    if (firstPicture != null)
                    {
                        byte[] pData = firstPicture.Data.Data;
                        mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                        Bitmap bm = new Bitmap(mStream, false);
                        mStream.Dispose();
                        squares[i] = new Square(nameSong, dataRecentHomePage.Rows[i].Cells[2].Value.ToString(), bm);
                    }
                    else
                    {
                        squares[i] = new Square(nameSong, dataRecentHomePage.Rows[i].Cells[2].Value.ToString());
                    }
                    squares[i].Click += new EventHandler(squares_Click);
                    flowLayoutPanel1.Controls.Add(squares[i]);
                }
            }
            catch
            {

               
            }
        }
        private void _importFormFileHistoryCurrentSong()
        {
            string[] lines = File.ReadAllLines($@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Music-Player-Project-IT008N13\Database\historyCurretnSong.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataRecentHomePage.Rows.Add(row);
            }
        }
        private void _exportToFileFileHistoryCurrentSong()
        {
            TextWriter writer = new StreamWriter($@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Music-Player-Project-IT008N13\Database\historyCurretnSong.txt");
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
                for (int i = 0; i < Files.Length; i++)
                {
                    string nameSong = String.Empty;
                    string UrlPictureBox = String.Empty;
                    var tfile = TagLib.File.Create($@"{Files[i]}");
                    if(String.IsNullOrEmpty(tfile.Tag.Title))
                    {
                        nameSong = Files[i].Substring(Files[i].LastIndexOf("\\") + 1).Replace(".mp3", "").ToUpper();
                    }
                    else
                    {
                        nameSong = tfile.Tag.Title;
                    }
                    // check url anh, artist...
                    // add database
                    //TagLib.File file = TagLib.File.Create(openFileDialog.FileName);

                    
                    var mStream = new MemoryStream();
                    var firstPicture = tfile.Tag.Pictures.FirstOrDefault();
                   
                    if (firstPicture != null)
                    {
                        byte[] pData = firstPicture.Data.Data;
                        mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                        Bitmap bm = new Bitmap(mStream, false);
                        mStream.Dispose();
                        squares[i] = new Square(nameSong, Files[i], bm);
                    }
                    else
                    {
                        squares[i] = new Square(nameSong, Files[i]);
                    }
                    squares[i].Click += new EventHandler(squares_Click);
                    //timer1.Start();
                    string[] dataAddToDataRecentHomePage = { $"{i}", $"{nameSong}", $"{Files[i]}" };
                    dataRecentHomePage.Rows.Add(dataAddToDataRecentHomePage);
                    flowLayoutPanel1.Controls.Add(squares[i]);
                }
                _exportToFileFileHistoryCurrentSong();
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
