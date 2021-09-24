using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
namespace demo1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent(); 
        }
        bool menuExpanded = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if (palMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!menuExpanded)
                {
                    menuExpanded = true;
                    palMainMenu.Visible = false;
                    palMainMenu.Width = 250;
                    bunifuTransition1.Show(palMainMenu);
                }
            }
            else
            {
                if (menuExpanded)
                {
                    menuExpanded = false;
                    palMainMenu.Visible = false;
                    palMainMenu.Width = 45;
                    bunifuTransition1.Show(palMainMenu);
                }
            }
        }

        private void sideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }

    }
}
