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
using System.IO;
using AxWMPLib;
using HXV;
using WMPLib;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Principal;
using System.Reflection;

namespace Music_Player_Project_IT008N13
{
    public partial class mainForm : Form
    {
        private bool is_Play = true;
        private bool is_Muted = true;
        private Button currentButton;

        DataGridView dataMainForm;
        
        public mainForm()
        {
            InitializeComponent();
            _initdataMainForm();
            ActiveButton(btnHome);
            //<name of your media player control here>.Ctlcontrols.currentPositionString;
            player.Ctlcontrols.pause();
            player.IsAccessible = true;
        }
        private void _initdataMainForm()
        {
            dataMainForm = new DataGridView();
            dataMainForm.ColumnCount = 3;
            dataMainForm.Columns[0].ValueType = typeof(string);
            dataMainForm.Columns[0].Name = "STT";
            dataMainForm.Columns[1].ValueType = typeof(string);
            dataMainForm.Columns[1].Name = "Name Song";
            dataMainForm.Columns[2].ValueType = typeof(string);
            dataMainForm.Columns[2].Name = "URL Song";
            try
            {
                _importFormFileHistoryCurrentSong();
                for (int i = 0; i < dataMainForm.RowCount - 1; i++)
                {
                    var myPlayList = player.playlistCollection.newPlaylist("MyPlayList");

                    var mediaItem = player.newMedia(dataMainForm.Rows[i].Cells[2].Value.ToString());
                    myPlayList.appendItem(mediaItem);

                    player.currentPlaylist = myPlayList;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void _importFormFileHistoryCurrentSong()
        {
            string[] lines =  File.ReadAllLines($@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Music-Player-Project-IT008N13\Database\historyCurretnSong.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataMainForm.Rows.Add(row);
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.Location = new Point(209, 0);
            childForm.Size = new Size(1047, 647);
            childForm.ShowDialog();
        }
        private void ActiveButton(object btnSender)
        {
            ToolStripButton btn = (ToolStripButton)btnSender;
            DisableButton(btn, btn.Tag);
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular);
            btn.BackColor = Color.Coral;
            btn.ForeColor = Color.White;
        }
        private void DisableButton(object btnSender, object tagButton)
        {
            foreach (Object previousButton in toolStripControl.Items)
            {
                if (previousButton.GetType() == typeof(ToolStripButton))
                {
                    ToolStripButton btn = previousButton as ToolStripButton;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
                    btn.ForeColor = Color.Black;
                    btn.BackColor = System.Drawing.Color.LightSalmon;
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            addHomeForm1.Show();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }
        private void bbtnMusicLibrary_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Show();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }
        private void btnVideoLibrary_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Show();
            addSettingForm1.Hide();
        }
        private void btnPlayQueue_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            addHomeForm1.Hide();
            addMediaQueueForm1.Show();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }
        private void btnPlaylists_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);
            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Show();
            addVideoForm1.Hide();
            addSettingForm1.Hide();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            addHomeForm1.Hide();
            addMediaQueueForm1.Hide();
            addMusicForm1.Hide();
            addPlaylistForm1.Hide();
            addVideoForm1.Hide();
            addSettingForm1.Show();
        }
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;
            if (is_Play == true)
            {
                btn.Image = global::Music_Player_Project_IT008N13.Properties.Resources.pause;
                is_Play = false;
                player.Ctlcontrols.pause();
            }
            else
            {
                btn.Image = global::Music_Player_Project_IT008N13.Properties.Resources.play;
                is_Play = true;
                player.Ctlcontrols.play();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void slider1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void player_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            lbVolumn.Text = trackBar1.Value.ToString();
        }
        private void btnVolume_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;
            if (is_Muted)
            {
                is_Muted = !is_Muted;
                btn.Image = global::Music_Player_Project_IT008N13.Properties.Resources.mute;
                trackBar1.Value = 0;
                player.settings.volume = trackBar1.Value;
                lbVolumn.Text = trackBar1.Value.ToString();
            }
            else
            {
                is_Muted = !is_Muted;
                btn.Image = global::Music_Player_Project_IT008N13.Properties.Resources.speaker_filled_audio_tool;
                trackBar1.Value = 15;
                player.settings.volume = trackBar1.Value;
                lbVolumn.Text = trackBar1.Value.ToString();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataMainForm.RowCount - 1; i++)
            {
                if (dataMainForm.Rows[i].Cells[2].Value.ToString() == player.URL)
                {
                    if(i == dataMainForm.RowCount - 2)
                    {
                        player.URL = dataMainForm.Rows[0].Cells[2].Value.ToString();
                        break;
                    }
                    else
                    {
                        player.URL = dataMainForm.Rows[i + 1].Cells[2].Value.ToString();
                        break;
                    }
                }
            }
            player.Ctlcontrols.next();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataMainForm.RowCount - 1; i++)
            {
                if (dataMainForm.Rows[i].Cells[2].Value.ToString() == player.URL)
                {
                    if (i == 0)
                    {
                        player.URL = dataMainForm.Rows[dataMainForm.RowCount - 2].Cells[2].Value.ToString();
                        break;
                    }
                    else
                    {
                        player.URL = dataMainForm.Rows[i - 1].Cells[2].Value.ToString();
                        break;
                    }
                }
            }
            player.Ctlcontrols.previous();
        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            player.URL = dataMainForm.Rows[rnd.Next(dataMainForm.RowCount - 1)].Cells[2].Value.ToString();
        }
        

        private void nextSongWhenFullValueSlider(object sender, EventArgs e)
        {
            if((int)slider1.Value == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                for (int i = 0; i < dataMainForm.RowCount - 1; i++)
                {
                    if (dataMainForm.Rows[i].Cells[2].Value.ToString() == player.URL)
                    {
                        if (i == dataMainForm.RowCount - 2)
                        {
                            player.URL = dataMainForm.Rows[0].Cells[2].Value.ToString();
                            break;
                        }
                        else
                        {
                            player.URL = dataMainForm.Rows[i + 1].Cells[2].Value.ToString();
                            break;
                        }
                    }
                }
                player.Ctlcontrols.next();
            }

            /*if ((int)slider1.Value == (int)slider1.Maximum)
            {
                for (int i = 0; i < dataMainForm.RowCount - 1; i++)
                {
                    if (dataMainForm.Rows[i].Cells[2].Value.ToString() == player.URL)
                    {
                        if (i == dataMainForm.RowCount - 2)
                        {
                            player.URL = dataMainForm.Rows[0].Cells[2].Value.ToString();
                            break;
                        }
                        else
                        {
                            player.URL = dataMainForm.Rows[i + 1].Cells[2].Value.ToString();
                            break;
                        }
                    }
                }
                player.Ctlcontrols.next();
            }*/
        }
    }
}