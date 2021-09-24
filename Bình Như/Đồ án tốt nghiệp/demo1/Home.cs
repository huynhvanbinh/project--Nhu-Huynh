using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                    palMainMenu.Width = 177;
                    bunifuTransition1.Show(palMainMenu);
                }
            }
            else
            {
                if (menuExpanded)
                {
                    menuExpanded = false;
                    palMainMenu.Visible = false;
                    palMainMenu.Width = 50;
                    bunifuTransition1.Show(palMainMenu);
                }
            }
        }
        private void sideMenu_Click(object sender, EventArgs e)
        {
            //if (activeForm != null)
            //    activeForm.Close();
            palsubmenu.Visible = true;
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));

            VSReactive<int>.Subscribe("menu", w => tabControl1.SelectedIndex = w);
        }
       // private Form activeForm = null;
        void loading()
        {
            for (int i = 0; i < 500; i++)
                Thread.Sleep(10);
        }
        //public void openpanlForm(Form panlForm)
        //{
        //    using (LoadingLuong f1 = new LoadingLuong(loading))
        //    {
        //        f1.ShowDialog(this);
        //    }
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = panlForm;
        //    panlForm.TopLevel = false;
        //    panlForm.FormBorderStyle = FormBorderStyle.None;
        //    panlForm.Dock = DockStyle.Fill;
        //    panelForm.Controls.Add(panlForm);
        //    panelForm.Tag = panlForm;
        //    panlForm.BringToFront();
        //    panlForm.Show();     
        //}

        private void banhang(object sender, EventArgs e)
        {
            palsubmenu.Visible = false;
            //openpanlForm(new BanHang());
            BanHang bh = new BanHang();
            bh.MdiParent = this;
            bh.Show();
            palMainMenu.Width = 50;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form1 bh = new Form1();
            bh.MdiParent = this;
            bh.Show();
        }
    }
}
