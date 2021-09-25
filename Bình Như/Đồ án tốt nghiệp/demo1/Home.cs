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
        //bien dung cho form
        public string macuahang;
        public string manhanvien;
        public string maquyen;
        public Home()
        {
            InitializeComponent();
            hienicon();
        }
        void quyenadmin()
        {
            tabchamcong.Visible = false;
            tab4.Visible = false;
        }
        void quyenquanly()
        {
            tabxuathang.Visible = false;
            tabnhaphang.Visible = false;
            btnphieuxuat.Visible = false;
            btnkhuyenmai.Visible = false;
            btncuahang.Visible = false;
            btnluongnhanvien.Visible = false;
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
            //tab quan ly
            btnluongnhanvien.IconVisible = true;
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
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            palsubmenu.Visible = false;
            BanHang banhang = new BanHang();
            banhang.FormBorderStyle = FormBorderStyle.None;
            banhang.Dock = DockStyle.Fill;
            banhang.macuahang = macuahang;
            banhang.manhanvien = manhanvien;
            banhang.MdiParent = this;
            banhang.Show();
        }

        private void chamcong(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            palsubmenu.Visible = false;
            ChamCong chamcong = new ChamCong();
            chamcong.FormBorderStyle = FormBorderStyle.None;
            chamcong.Dock = DockStyle.Fill;
            chamcong.machpublic = macuahang;
            chamcong.MdiParent = this;
            chamcong.Show();
        }

        private void nhaphang(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            palsubmenu.Visible = false;
            NhapHang nhaphang = new NhapHang();
            nhaphang.FormBorderStyle = FormBorderStyle.None;
            nhaphang.Dock = DockStyle.Fill;
            nhaphang.MdiParent = this;
            nhaphang.Show();
        }

        private void xuathang(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            palsubmenu.Visible = false;
            XuatHangcs xuathang = new XuatHangcs();
            xuathang.FormBorderStyle = FormBorderStyle.None;
            xuathang.Dock = DockStyle.Fill;
            xuathang.manv = manhanvien;
            xuathang.macuahang = macuahang;
            xuathang.MdiParent = this;
            xuathang.Show();
        }

        private void help(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            palsubmenu.Visible = false;
            XuatHangcs xuathang = new XuatHangcs();
            xuathang.FormBorderStyle = FormBorderStyle.None;
            xuathang.Dock = DockStyle.Fill;
            xuathang.MdiParent = this;
            xuathang.Show();
        }

        private void btnluongnhanvien_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            palsubmenu.Visible = false;
            LuongNhanViens luongnhanvien = new LuongNhanViens();
            luongnhanvien.FormBorderStyle = FormBorderStyle.None;
            luongnhanvien.Dock = DockStyle.Fill;
            luongnhanvien.MdiParent = this;
            luongnhanvien.Show();
        }

        private void btnphieunhap_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            PhieuNhap phieunhap = new PhieuNhap();
            phieunhap.FormBorderStyle = FormBorderStyle.None;
            phieunhap.Dock = DockStyle.Fill;
            phieunhap.MdiParent = this;
            phieunhap.manv = manhanvien;
            phieunhap.Show();
        }

        private void btnphieuxuat_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            PhieuXuat phieuxuat = new PhieuXuat();
            phieuxuat.FormBorderStyle = FormBorderStyle.None;
            phieuxuat.Dock = DockStyle.Fill;
            phieuxuat.MdiParent = this;
            phieuxuat.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(maquyen == "AD")
            {
                quyenadmin();
            }    
            if(maquyen == "QLCN")
            {
                quyenquanly();
            }    
        }
    }
}