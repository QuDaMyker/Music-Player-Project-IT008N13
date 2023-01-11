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
        public addSettingForm()
        {
            InitializeComponent();
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExpand1_Click(object sender, EventArgs e)
        {

        }

        private void btnExpand2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddfolder1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();

        }

        private void btnAddfolder2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
        }
    }
}
