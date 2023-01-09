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
    public class imagebuttonExit_Max_Min
    {
        private Bitmap imageButtonMinimize;
        private Bitmap imageButtonMaximize;
        private Bitmap imageButtonExit;
        public imagebuttonExit_Max_Min()
        {
            imageButtonExit = new Bitmap(Properties.Resources.exit, new Size(8, 8));
            imageButtonMaximize = new Bitmap(Properties.Resources.full_screen, new Size(8, 8));  
            imageButtonMinimize = new Bitmap(Properties.Resources.minus, new Size(8, 1));
        }

        public Bitmap ImageButtonMinimize { get => imageButtonMinimize; }
        public Bitmap ImageButtonMaximize { get => imageButtonMaximize;  }
        public Bitmap ImageButtonExit { get => imageButtonExit; }
    }
}
