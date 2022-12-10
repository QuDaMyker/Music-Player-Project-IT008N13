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

namespace Music_Player_Project_IT008N13
{
    public partial class addHomeForm : UserControl
    {
        private string _FolderContainMedia = String.Empty;
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
        public addHomeForm()
        {
            InitializeComponent();
        }
        
    }
}
