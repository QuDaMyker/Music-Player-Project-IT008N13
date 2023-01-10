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
    public class ImageSoureControlPlayer
    {
        private Bitmap imagebtnShuffle_Enable;
        private Bitmap imagebtnShuffle_Disable;
        private Bitmap imagebtnPrevious;
        private Bitmap imagebtnNext;
        private Bitmap imagebtnPlay;
        private Bitmap imagebtnPause;
        private Bitmap imagebtnLoop_Enable;
        private Bitmap imagebtnLoop_One;
        private Bitmap imagebtnLoop_Disable;
        private Bitmap imagebtnVolume;
        private Bitmap imagebtnMute;
        public ImageSoureControlPlayer()
        {
            imagebtnShuffle_Enable = new Bitmap(Properties.Resources.shuffle_able, new Size(16, 16));
            imagebtnShuffle_Disable = new Bitmap(Properties.Resources.shuffle_disable, new Size(16, 16));
            imagebtnPrevious = new Bitmap(Properties.Resources.previous_image, new Size(16, 16));
            imagebtnNext = new Bitmap(Properties.Resources.next_image, new Size(16, 16));
            imagebtnPlay = new Bitmap(Properties.Resources.imageApp, new Size(68, 68));
            imagebtnPause = new Bitmap(Properties.Resources.imagebtnPause, new Size(68, 68));
            imagebtnLoop_Enable = new Bitmap(Properties.Resources.loop_able, new Size(16, 16)); 
            imagebtnLoop_One = new Bitmap(Properties.Resources.loop_one, new Size(16, 16));
            imagebtnLoop_Disable = new Bitmap(Properties.Resources.loop_disable, new Size(16, 16));
            imagebtnVolume = new Bitmap(Properties.Resources.volume, new Size(16, 16));
            imagebtnMute = new Bitmap(Properties.Resources.mute_volume, new Size(16, 16));
        }

        public Bitmap ImagebtnShuffle_Enable { get => imagebtnShuffle_Enable; }
        public Bitmap ImagebtnShuffle_Disable { get => imagebtnShuffle_Disable;  }
        public Bitmap ImagebtnPrevious { get => imagebtnPrevious;  }
        public Bitmap ImagebtnNext { get => imagebtnNext; }
        public Bitmap ImagebtnPlay { get => imagebtnPlay; }
        public Bitmap ImagebtnPause { get => imagebtnPause; }
        public Bitmap ImagebtnVolume { get => imagebtnVolume; }
        public Bitmap ImagebtnMute { get => imagebtnMute; }
        public Bitmap ImagebtnLoop_Enable { get => imagebtnLoop_Enable; }
        public Bitmap ImagebtnLoop_One { get => imagebtnLoop_One; }
        public Bitmap ImagebtnLoop_Disable { get => imagebtnLoop_Disable;}
    }
}
