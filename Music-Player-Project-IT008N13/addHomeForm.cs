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
        public addHomeForm()
        {
            InitializeComponent();
        }
        private void btnOpenFIle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();
            dg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dg.ShowDialog(this);
        }
    }
}
