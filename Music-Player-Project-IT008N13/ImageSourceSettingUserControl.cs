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
    public class ImageSourceSettingUserControl
    {
        private Bitmap imageFolder;
        private Bitmap imageAddFolder;
        private Bitmap imageDrop;
        private Bitmap imageDelete;
        private Bitmap imageUp;
        public ImageSourceSettingUserControl()
        {
            imageFolder = new Bitmap(Properties.Resources.imageFolder, new Size(16, 16));
            imageAddFolder = new Bitmap(Properties.Resources.imagenewFolder, new Size(16, 16));
            imageDrop = new Bitmap(Properties.Resources.imagearrow_down, new Size(10, 6));
            imageDelete = new Bitmap(Properties.Resources.exit, new Size(12, 12));
            imageUp = new Bitmap(Properties.Resources.image_up, new Size(10, 6));
        }

        public Bitmap ImageFolder { get => imageFolder;  }
        public Bitmap ImageAddFolder { get => imageAddFolder; }
        public Bitmap ImageDrop { get => imageDrop;  }
        public Bitmap ImageDelete { get => imageDelete;  }
        public Bitmap ImageUp { get => imageUp;  }
    }
}
