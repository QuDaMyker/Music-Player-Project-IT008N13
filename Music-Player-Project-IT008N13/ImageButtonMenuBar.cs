using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Music_Player_Project_IT008N13
{
    public class ImageButtonMenuBar
    {
        private Bitmap imagebtnHome;
        private Bitmap imagebtnMusicLibrary;
        private Bitmap imagebtnVideoLibrary;
        private Bitmap imagebtnPlayQueue;
        private Bitmap imagebtnPlayListsMain;
        private Bitmap imagebtnPlayListsChild;
        private Bitmap imagebtnSetting;
        public ImageButtonMenuBar()
        {
            imagebtnHome = new Bitmap(Properties.Resources.imagebtnHome, new Size(15, 15));
            imagebtnMusicLibrary = new Bitmap(Properties.Resources.imagebtnMusicLibrary, new Size(16, 16));
            imagebtnVideoLibrary = new Bitmap(Properties.Resources.imagebtnVideoLibrary, new Size(16, 16));
            imagebtnPlayQueue = new Bitmap(Properties.Resources.imagebtnPlayQueue, new Size(16, 16));
            imagebtnPlayListsMain = new Bitmap(Properties.Resources.imagebtnPlayListMain, new Size(16, 16));
            imagebtnPlayListsChild = new Bitmap(Properties.Resources.imagebtnPlayListChild, new Size(16, 16));
            imagebtnSetting = new Bitmap(Properties.Resources.imagebtnSetting, new Size(16, 16));
        }

        public Bitmap ImagebtnHome { get => imagebtnHome; }
        public Bitmap ImagebtnMusicLibrary { get => imagebtnMusicLibrary; }
        public Bitmap ImagebtnVideoLibrary { get => imagebtnVideoLibrary; }
        public Bitmap ImagebtnPlayQueue { get => imagebtnPlayQueue; }
        public Bitmap ImagebtnPlayListsMain { get => imagebtnPlayListsMain; }
        public Bitmap ImagebtnPlayListsChild { get => imagebtnPlayListsChild; }
        public Bitmap ImagebtnSetting { get => imagebtnSetting; }
    }
}
