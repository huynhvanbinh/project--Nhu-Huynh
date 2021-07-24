using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1
{
    public partial class trangchu : Form
    {
        public string taikhoan;
        public trangchu()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            Load_Form();
        }
        
        public void Load_Form()
        {
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;

        }

        public void trangchu_Load(object sender, EventArgs e)
        {
            lay.Text = quyen;
            if (maquyen == "AD")
            {
                MessageBox.Show("Toàn quyền hệ thống");
            }
            else if (maquyen == "NV")
            {
                MessageBox.Show("Đăng nhập quyền Nhân Viên");
                quanly.Visible = false; 
            }
            labcuahang.Text = macuahang;
        }
        public string quyen = "";
        public string maquyen = "";
        public string manhanvien = "";
        public string macuahang = "";

        private void timer1_Tick(object sender, EventArgs e)
        {
            labgio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
       
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 dn = new Form1();
            dn.FormBorderStyle = FormBorderStyle.None;
            dn.Dock = DockStyle.Fill;
            dn.MdiParent = this;
 
            dn.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild !=null)
            {
                this.ActiveMdiChild.Close();
            }    
            SanPham sp = new SanPham();
            sp.MdiParent = this;
            sp.FormBorderStyle = FormBorderStyle.None;
            sp.Dock = DockStyle.Fill;
            sp.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            KhuyenMai km = new KhuyenMai();
            km.MdiParent = this;
            km.FormBorderStyle = FormBorderStyle.None;
            km.Dock=DockStyle.Fill;
            km.Show();
        }

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuaHang ch = new CuaHang();
            ch.MdiParent = this;
            ch.FormBorderStyle = FormBorderStyle.None;
            ch.Dock = DockStyle.Fill;
            ch.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.FormBorderStyle = FormBorderStyle.None;
            taikhoan.Dock = DockStyle.Fill;
            taikhoan.MdiParent = this;
            taikhoan.Show();
        }

        private void loạiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu chucvu = new ChucVu();
            chucvu.FormBorderStyle = FormBorderStyle.None;
            chucvu.Dock = DockStyle.Fill;
            chucvu.MdiParent = this;
            chucvu.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HoaDons hoadon = new HoaDons();
            hoadon.FormBorderStyle = FormBorderStyle.None;
            hoadon.Dock = DockStyle.Fill;
            hoadon.MdiParent = this;
            hoadon.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiSanPham loaisanpham = new LoaiSanPham();
            loaisanpham.FormBorderStyle = FormBorderStyle.None;
            loaisanpham.Dock = DockStyle.Fill;
            loaisanpham.MdiParent = this;
            loaisanpham.Show();
        }

        private void màuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MauSac mau = new MauSac();
            mau.FormBorderStyle = FormBorderStyle.None;
            mau.Dock = DockStyle.Fill;
            mau.MdiParent = this;
            mau.Show();
        }

        private void kíchThướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size kichthuoc = new Size();
            kichthuoc.FormBorderStyle = FormBorderStyle.None;
            kichthuoc.Dock = DockStyle.Fill;
            kichthuoc.MdiParent = this;
            kichthuoc.Show();
        }

        private void phiếuNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhieuNhap phieunhap = new PhieuNhap();
            phieunhap.FormBorderStyle = FormBorderStyle.None;
            phieunhap.Dock = DockStyle.Fill;
            phieunhap.MdiParent = this;
            phieunhap.manv = manhanvien;
            phieunhap.Show();
        }

        private void cTPhiếuNhậpDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTPhieuNhap ctpn = new CTPhieuNhap();
            ctpn.FormBorderStyle = FormBorderStyle.None;
            ctpn.Dock = DockStyle.Fill;
            ctpn.MdiParent = this;
            ctpn.Show();
        }

        private void phiếuXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhieuXuat phieuxuat = new PhieuXuat();
            phieuxuat.FormBorderStyle = FormBorderStyle.None;
            phieuxuat.Dock = DockStyle.Fill;
            phieuxuat.MdiParent = this;
            phieuxuat.Show();
        }

        private void chamCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCong chamcong = new ChamCong();
            chamcong.FormBorderStyle = FormBorderStyle.None;
            chamcong.Dock = DockStyle.Fill;
            chamcong.MdiParent = this;
            chamcong.Show();
        }

        private void luongNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuongNhanVien luongnhanvien = new LuongNhanVien();
            luongnhanvien.FormBorderStyle = FormBorderStyle.None;
            luongnhanvien.Dock = DockStyle.Fill;
            luongnhanvien.MdiParent = this;
            luongnhanvien.Show();
        }

        private void danhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doanhthu danhthu = new Doanhthu();
            danhthu.FormBorderStyle = FormBorderStyle.None;
            danhthu.Dock = DockStyle.Fill;
            danhthu.MdiParent = this;
            danhthu.Show();
        }

        private void thángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThuThang danhthuthang = new DoanhThuThang();
            danhthuthang.FormBorderStyle = FormBorderStyle.None;
            danhthuthang.Dock = DockStyle.Fill;
            danhthuthang.MdiParent = this;
            danhthuthang.Show();
        }

        private void hàngNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhThuHangNgay danhthungay = new DanhThuHangNgay();
            danhthungay.FormBorderStyle = FormBorderStyle.None;
            danhthungay.Dock = DockStyle.Fill;
            danhthungay.MdiParent = this;
            danhthungay.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang banhang = new BanHang();
            banhang.FormBorderStyle = FormBorderStyle.None;
            banhang.Dock = DockStyle.Fill;
            banhang.MdiParent = this;
            banhang.manhanvien = manhanvien;
            banhang.Show();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatHangcs phieuxuat = new XuatHangcs();
            phieuxuat.FormBorderStyle = FormBorderStyle.None;
            phieuxuat.Dock = DockStyle.Fill;
            phieuxuat.MdiParent = this;
            phieuxuat.manv = manhanvien;
            phieuxuat.macuahang = macuahang;
            phieuxuat.Show();
        }

        private void báoCáoSảnPhầmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPBanNhieuNhat spbannhieunhat = new SPBanNhieuNhat();
            spbannhieunhat.FormBorderStyle = FormBorderStyle.None;
            spbannhieunhat.Dock = DockStyle.Fill;
            spbannhieunhat.MdiParent = this;
           
            spbannhieunhat.Show();
        }
    }
}
