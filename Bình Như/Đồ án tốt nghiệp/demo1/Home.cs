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
            hienicon();
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
        void hienicon()
        {
            //Home
            btndanhthu.IconVisible = true;
            btnnghenhac.IconVisible = true;
            btngoogle.IconVisible = true;
            //Quan ly
            btnnhanvien.IconVisible = true;
            btnphieunhap.IconVisible = true;
            btnphieuxuat.IconVisible = true;
            btnsanpham.IconVisible = true;
            btnhoadon.IconVisible = true;
            btnkhuyenmai.IconVisible = true;
            btncuahang.IconVisible = true;
            //tab cai dat
            btnngonngu.IconVisible = true;
            btngiaodien.IconVisible = true;
        }
        private void sideMenu_Click(object sender, EventArgs e)
        {
            palsubmenu.Visible = true;
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            VSReactive<int>.Subscribe("menu", w => tabControl1.SelectedIndex = w);
        }
        void loading()
        {
            for (int i = 0; i < 500; i++)
                Thread.Sleep(10);
        }
       
        private void banhang(object sender, EventArgs e)
        {
            palsubmenu.Visible = false;
            BanHang bh = new BanHang();
            bh.MdiParent = this;
            bh.Show();
            palMainMenu.Width = 50;
        }

        private void chamcong(object sender, EventArgs e)
        {
            palsubmenu.Visible = false;
            palMainMenu.Width = 50;
        }

        private void nhaphang(object sender, EventArgs e)
        {
            palsubmenu.Visible = false;
            palMainMenu.Width = 50;
        }

        private void xuathang(object sender, EventArgs e)
        {
            palsubmenu.Visible = false;
            palMainMenu.Width = 50;
        }

        private void help(object sender, EventArgs e)
        {
            palsubmenu.Visible = false;
            palMainMenu.Width = 50;
        }

    }
}