using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace demo1
{
    public partial class trangchu : Form
    {
        PhieuXuatBUS customerBUS = new PhieuXuatBUS();
        BindingSource bs = new BindingSource();
        List<PhieuXuatDTO> dskhs = new List<PhieuXuatDTO>();

        TaiKhoanBUS customerTKBUS = new TaiKhoanBUS();
        BindingSource bstk = new BindingSource();
        List<TaiKhoanDTO> dskh = new List<TaiKhoanDTO>();

        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource nv = new BindingSource();
        List<NhanVienDTO> dsnv = new List<NhanVienDTO>();

        ChucVuBUS customerCVBUS = new ChucVuBUS();
        BindingSource cv = new BindingSource();
        List<ChucVuDTO> dscv = new List<ChucVuDTO>();

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
            menuStrip1.Enabled = false;
            labcuahang.Visible = false;
            lay.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            dskh = customerTKBUS.LayDskh();
            bs.DataSource = dskh.ToList();
            //nhân viên
            dsnv = customerNVBUS.LayDskh();
            nv.DataSource = dsnv.ToList();
            //chức vụ
            dscv = customerCVBUS.LayDskh();
            cv.DataSource = dscv.ToList();
        }
        //ma hoa md5
        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
        public void trangchu_Load()
        {
            panel1.Visible = false;
            menuStrip1.Enabled = true;
            labcuahang.Visible = true;
            lay.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            dskhs = customerBUS.LayDssp();
            bs.DataSource = dskhs.ToList();
            lay.Text = quyen;
            if (maquyen == "AD")
            {
                MessageBox.Show("Toàn quyền hệ thống");
                phieunhapxuat.Visible = true;
                quanly.Visible = true;
            }
            else if (maquyen == "NV")
            {
                MessageBox.Show("Đăng nhập quyền Nhân Viên");
                phieunhapxuat.Visible = false;
            }
            labcuahang.Text = macuahang;
            foreach (PhieuXuatDTO sps in dskhs)
            {
                if (sps.MaCH == labcuahang.Text && sps.TrangThai=="1" && sps.TringTrang== "Chờ nhận hàng")
                {
                    HangDaVe dn = new HangDaVe();
                    dn.maphieuxuat = sps.MaPX;
                    dn.macuahang = labcuahang.Text;
                    dn.FormBorderStyle = FormBorderStyle.None;
                    dn.Dock = DockStyle.Fill;
                    dn.MdiParent = this;
                    dn.Show();
                }
            } 
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
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
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
            sp.mach = macuahang;
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
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
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
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            ChucVu chucvu = new ChucVu();
            chucvu.FormBorderStyle = FormBorderStyle.None;
            chucvu.Dock = DockStyle.Fill;
            chucvu.MdiParent = this;
            chucvu.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            HoaDons hoadon = new HoaDons();
            hoadon.FormBorderStyle = FormBorderStyle.None;
            hoadon.Dock = DockStyle.Fill;
            hoadon.MdiParent = this;
            hoadon.macuahang = macuahang;
            hoadon.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            LoaiSanPham loaisanpham = new LoaiSanPham();
            loaisanpham.FormBorderStyle = FormBorderStyle.None;
            loaisanpham.Dock = DockStyle.Fill;
            loaisanpham.MdiParent = this;
            loaisanpham.Show();
        }

        private void màuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            MauSac mau = new MauSac();
            mau.FormBorderStyle = FormBorderStyle.None;
            mau.Dock = DockStyle.Fill;
            mau.MdiParent = this;
            mau.Show();
        }

        private void kíchThướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            Size kichthuoc = new Size();
            kichthuoc.FormBorderStyle = FormBorderStyle.None;
            kichthuoc.Dock = DockStyle.Fill;
            kichthuoc.MdiParent = this;
            kichthuoc.Show();
        }

        private void phiếuNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void cTPhiếuNhậpDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            CTPhieuNhap ctpn = new CTPhieuNhap();
            ctpn.FormBorderStyle = FormBorderStyle.None;
            ctpn.Dock = DockStyle.Fill;
            ctpn.MdiParent = this;
            ctpn.Show();
        }

        private void phiếuXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void chamCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            ChamCong chamcong = new ChamCong();
            chamcong.FormBorderStyle = FormBorderStyle.None;
            chamcong.Dock = DockStyle.Fill;
            chamcong.MdiParent = this;
            chamcong.Show();
        }

        private void luongNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            LuongNhanVien luongnhanvien = new LuongNhanVien();
            luongnhanvien.FormBorderStyle = FormBorderStyle.None;
            luongnhanvien.Dock = DockStyle.Fill;
            luongnhanvien.MdiParent = this;
            luongnhanvien.Show();
        }

        private void danhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            Doanhthu danhthu = new Doanhthu();
            danhthu.FormBorderStyle = FormBorderStyle.None;
            danhthu.Dock = DockStyle.Fill;
            danhthu.MdiParent = this;
            danhthu.Show();
        }

        private void thángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            DoanhThuThang danhthuthang = new DoanhThuThang();
            danhthuthang.FormBorderStyle = FormBorderStyle.None;
            danhthuthang.Dock = DockStyle.Fill;
            danhthuthang.MdiParent = this;
            danhthuthang.Show();
        }

        private void hàngNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            DanhThuHangNgay danhthungay = new DanhThuHangNgay();
            danhthungay.FormBorderStyle = FormBorderStyle.None;
            danhthungay.Dock = DockStyle.Fill;
            danhthungay.MdiParent = this;
            danhthungay.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            BanHang banhang = new BanHang();
            banhang.FormBorderStyle = FormBorderStyle.None;
            banhang.Dock = DockStyle.Fill;
            banhang.MdiParent = this;
            banhang.macuahang = macuahang;
            banhang.manhanvien = manhanvien;          
            banhang.Show();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
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
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            SPBanNhieuNhat spbannhieunhat = new SPBanNhieuNhat();
            spbannhieunhat.FormBorderStyle = FormBorderStyle.None;
            spbannhieunhat.Dock = DockStyle.Fill;
            spbannhieunhat.MdiParent = this;
           
            spbannhieunhat.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                 ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private bool kiemtradn()
        {
            Load_Form();
            //string user = "binh";
            //string pass = "1234";
            foreach (TaiKhoanDTO kh in dskh)
            {
                if (kh.TaiKhoan.Equals(txtdangnhap.Text) && kh.MatKhau.Equals(GetMD5(txtpass.Text)))
                {
                    return true;
                }
            }
            return false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (kiemtradn() == true)
            {
                foreach (TaiKhoanDTO kh in dskh)
                {
                    if (kh.TaiKhoan.Equals(txtdangnhap.Text) && kh.MatKhau.Equals(GetMD5(txtpass.Text)))
                    {
                        foreach (NhanVienDTO nv in dsnv)
                        {
                            if (kh.MaNV.Equals(nv.MaNV))
                            {
                                foreach (ChucVuDTO cv in dscv)
                                {
                                    if (nv.MaCV.Equals(cv.MaCV))
                                    {
                                        MessageBox.Show("Dang nhap thanh cong với quyền " + cv.TenChucVu);
                                        quyen = nv.TenNV;
                                        maquyen = cv.MaCV;
                                        manhanvien = nv.MaNV;
                                        macuahang = nv.MaCH;
                                        trangchu_Load();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.TextLength.ToString() != null)
            {
                txtpass.UseSystemPasswordChar = true;
            }
            else
                txtpass.UseSystemPasswordChar = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                 ("Bạn có đăng suất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
                menuStrip1.Enabled = false;
                labcuahang.Visible = false;
                lay.Visible = false;
                label1.Visible = false;
                txtpass.Text = "";
                panel1.Visible = true;
                label3.Visible = false;
            }
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            NhapHang nhaphang = new NhapHang();
            nhaphang.FormBorderStyle = FormBorderStyle.None;
            nhaphang.Dock = DockStyle.Fill;
            nhaphang.MdiParent = this;
            nhaphang.manhanvien = manhanvien;
            nhaphang.Show();
        }
    }
}
