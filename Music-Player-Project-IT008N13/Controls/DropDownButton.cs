using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace Music_Player_Project_IT008N13.Controls
{
    public class DropDownButton : ContextMenuStrip
    {
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.DimGray;
        private Color primaryColor = Color.MediumSlateBlue;

        private Bitmap menuItemHeaderSize;

        public DropDownButton(IContainer container) : base (container)
        {

        }
        // Properties
        [Browsable(false)]
        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }
        [Browsable(false)]
        public int MenuItemHeight { get => menuItemHeight; set => menuItemHeight = value; }
        [Browsable(false)]
        public Color MenuItemTextColor { get => menuItemTextColor; set => menuItemTextColor = value; }
        [Browsable(false)]
        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }

        // Methods
        private void LoadMenuItemAppearance()
        {
            if (isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.Gainsboro;
            }
            else
            {
                menuItemHeaderSize = new Bitmap(15, menuItemHeight);
            }
            foreach (ToolStripMenuItem menuItemLv1 in this.Items)
            {
                menuItemLv1.ForeColor = menuItemTextColor;
                menuItemLv1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItemLv1.Image == null) menuItemLv1.Image = menuItemHeaderSize;
                foreach (ToolStripMenuItem menuItemLv2 in menuItemLv1.DropDownItems)
                {
                    menuItemLv2.ForeColor = menuItemTextColor;
                    menuItemLv2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemLv2.Image == null) menuItemLv2.Image = menuItemHeaderSize;
                }    
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode == false)
            {
                LoadMenuItemAppearance();
                this.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
            }
        }
    }
}
