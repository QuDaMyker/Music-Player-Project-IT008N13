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
    public partial class addSettingForm : UserControl
    {
        private ImageSourceSettingUserControl imageSource = new ImageSourceSettingUserControl();
        private bool isCollapsed;
        public addSettingForm()
        {
            InitializeComponent();
        }
        private void addSettingForm_Load(object sender, EventArgs e)
        {
            Load_Image();
        }

        private void Load_Image()
        {
            // btn add Folder
            btnAddFolder.Image = imageSource.ImageAddFolder;
            btnAddFolder.ImageAlign = ContentAlignment.MiddleCenter;
            btnAddFolder.TextImageRelation = TextImageRelation.ImageBeforeText;

            // label folder
            pictureBox1.Image = imageSource.ImageFolder;

            //button drop 
            btnDropMusicLibrary.Image = imageSource.ImageDrop;
            btnDropMusicLibrary.ImageAlign = ContentAlignment.MiddleCenter;
            // button delete
            btnDelete.Image = imageSource.ImageDelete;
            btnDelete.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            panelDropDownMusicLibraryLocation.Controls.Remove(panelMusicLibraryLocationChild);
            panelDropDownMusicLibraryLocation.Size = MinimumSize;
        }

        private void panelMusicLibraryLocation_Click(object sender, EventArgs e)
        {
            if(isCollapsed == false)
            {
                panelDropDownMusicLibraryLocation.Size = panelDropDownMusicLibraryLocation.MaximumSize;
                btnDropMusicLibrary.Image = imageSource.ImageUp;
                btnDropMusicLibrary.ImageAlign = ContentAlignment.MiddleCenter;
                isCollapsed = true;
            }
            else
            {
                panelDropDownMusicLibraryLocation.Size = panelDropDownMusicLibraryLocation.MinimumSize;
                btnDropMusicLibrary.Image = imageSource.ImageDrop;
                btnDropMusicLibrary.ImageAlign = ContentAlignment.MiddleCenter;
                isCollapsed = false;
            }
        }
    }
}
