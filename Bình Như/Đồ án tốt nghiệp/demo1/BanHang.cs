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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
            dtgv_ttsp.AutoGenerateColumns = false;
            cthd.AutoGenerateColumns = false;
            Load_Form();
        }
        HoaDonBUS customerHDBUS = new HoaDonBUS();
        BindingSource bshd = new BindingSource();
        List<HoaDonDTO> dshds = new List<HoaDonDTO>();

        SanPhamBUS customerBUS = new SanPhamBUS();
        BindingSource bs = new BindingSource();
        List<SanPhamDTO> dssp = new List<SanPhamDTO>();
        List<SanPhamDTO> dssps = new List<SanPhamDTO>();

        CTHoaDonBUS customerCTHDBUS = new CTHoaDonBUS();
        BindingSource bscthd = new BindingSource();
        List<CTHoaDonDTO> dscthd = new List<CTHoaDonDTO>();

        CTKhuyenMaiBUS customerKMBUS = new CTKhuyenMaiBUS();
        BindingSource bskm = new BindingSource();
        List<CTKhuyenMaiDTO> dskm = new List<CTKhuyenMaiDTO>();
        private void Load_Form()
        {
            Load_DSSP();
        }
        private void Load_DSSP()
        {

            // khoi tao load du lieu bang chi tiết hóa đơn có truyền mã
            string ma = txtmahoadon.Text;
            dscthd = customerCTHDBUS.LayDssp(ma);
            bscthd.DataSource = dscthd.ToList();
            cthd.DataSource = bscthd;
            //san pham khong co trong hoa don
            string masp = "";
            string masp1 = "";
            string masp2 = "";
            string masp3 = "";
            string masp4 = "";
            string masp5 = "";
            string masp6 = "";
            string masp7 = "";
            string masp8 = "";
            string masp9 = "";
            string masp10 = "";
            string masp11 = "";
            string masp12 = "";
            string masp13 = "";
            string masp14 = "";
            string masp15 = "";
            string masp16 = "";
            string masp17 = "";
            string masp18 = "";
            string masp19 = "";
            string masp20 = "";
            int kt = 0;
            foreach (CTHoaDonDTO cv in dscthd)
            {
                if (kt == 0)
                {
                    masp = cv.MaSP;
                    kt++;
                }
                if (kt == 1 && masp != cv.MaSP)
                {
                    masp1 = cv.MaSP;
                    kt++;
                }
                if (kt == 2 && masp != cv.MaSP && masp1 != cv.MaSP)
                {
                    masp2 = cv.MaSP;
                    kt++;
                }
                if (kt == 3 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP)
                {
                    masp3 = cv.MaSP;
                    kt++;
                }
                if (kt == 4 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP)
                {
                    masp4 = cv.MaSP;
                    kt++;
                }
                if (kt == 5 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                   masp4 != cv.MaSP)
                {
                    masp5 = cv.MaSP;
                    kt++;
                }
                if (kt == 6 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP)
                {
                    masp6 = cv.MaSP;
                    kt++;
                }
                if (kt == 7 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP)
                {
                    masp7 = cv.MaSP;
                    kt++;
                }
                if (kt == 8 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP)
                {
                    masp8 = cv.MaSP;
                    kt++;
                }
                if (kt == 9 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP)
                {
                    masp9 = cv.MaSP;
                    kt++;
                }
                if (kt == 10 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP &&
                    masp9 != cv.MaSP
            )
                {
                    masp10 = cv.MaSP;
                    kt++;
                }
                if (kt == 11 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP &&
                    masp9 != cv.MaSP && masp10 != cv.MaSP
            )
                {
                    masp11 = cv.MaSP;
                    kt++;
                }
                if (kt == 12 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP &&
                    masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
            )
                {
                    masp12 = cv.MaSP;
                    kt++;
                }
                if (kt == 13 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
             && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
             && masp12 != cv.MaSP)
                {
                    masp13 = cv.MaSP;
                    kt++;
                }
                if (kt == 14 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
              && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
              && masp12 != cv.MaSP && masp13 != cv.MaSP)
                {
                    masp14 = cv.MaSP;
                    kt++;
                }
                if (kt == 15 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
               && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
               && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP)
                {
                    masp15 = cv.MaSP;
                    kt++;
                }
                if (kt == 16 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP)
                {
                    masp16 = cv.MaSP;
                    kt++;
                }
                if (kt == 17 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                 && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                 && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP && masp16 != cv.MaSP)
                {
                    masp17 = cv.MaSP;
                    kt++;
                }
                if (kt == 18 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                   && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                   && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP && masp16 != cv.MaSP && masp17 != cv.MaSP)
                {
                    masp18 = cv.MaSP;
                    kt++;
                }
                if (kt == 19 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                    && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                    && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP && masp16 != cv.MaSP && masp17 != cv.MaSP && masp18 != cv.MaSP)
                {
                    masp19 = cv.MaSP;
                    kt++;
                }
                if (kt == 20 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                    && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                    && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP && masp16 != cv.MaSP && masp17 != cv.MaSP && masp18 != cv.MaSP && masp19 != cv.MaSP)
                {
                    masp20 = cv.MaSP;
                    kt++;
                }

            }
            dssp = customerBUS.LayDssphd(masp, masp1, masp2, masp3, masp4, masp5, masp6, masp7, masp8, masp9, masp10, masp11, masp12, masp13
                , masp14, masp15, masp16, masp17, masp18, masp19, masp20);
            bs.DataSource = dssp.ToList();
            dtgv_ttsp.DataSource = bs;

            // khoi tao load du lieu bang khuyến mãi
            dskm = customerKMBUS.LayDssp();
            bskm.DataSource = dskm.ToList();
        }
        private void ThemHD()
        {
            HoaDonDTO khAdd = layHD_moi();
            if (khAdd.MaHD == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                bool kq = customerHDBUS.DKSP(khAdd);
                txtmahoadon.Text = khAdd.MaHD;
                MessageBox.Show("Thêm sản phẩm vào hóa đơn");
            }
        }
        private HoaDonDTO layHD_moi()
        {
            HoaDonDTO NewSP = new HoaDonDTO();
            NewSP.MaHD = "HD" + DateTime.Now.ToString("ddMMyyyy") + DateTime.Now.ToString("HHmmss");
            NewSP.NgayLap = DateTime.Now.ToString("dd/MM/yyyy");
            NewSP.MaKH = "";
            NewSP.MaNV = string.IsNullOrEmpty(txtMaNV.Text) ? "" : txtMaNV.Text;
            NewSP.TongTien = string.IsNullOrEmpty(txttongtiendamua.Text) ? "" : txttongtiendamua.Text;
            NewSP.TrangThai = "1";
            return NewSP;
        }
        private HoaDonDTO layHD_update()
        {
            HoaDonDTO NewSP = new HoaDonDTO();
            NewSP.MaHD = txtmahoadon.Text;
            NewSP.TongTien = string.IsNullOrEmpty(txttongtiendamua.Text) ? "" : txttongtiendamua.Text;
            NewSP.MaKH = string.IsNullOrEmpty(txtmakhachhang.Text) ? "" :txtmakhachhang.Text;
            NewSP.TrangThai = "1";
            return NewSP;
        }
        int khuyenmaiss = 0;
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttsp.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttsp.CurrentRow.Index;
                txtSP.Text = dtgv_ttsp.Rows[i].Cells[0].Value.ToString();
                txtTenSP.Text = dtgv_ttsp.Rows[i].Cells[1].Value.ToString();
                txtDonGia.Text = dtgv_ttsp.Rows[i].Cells[2].Value.ToString();
                txtsoluongton.Text = dtgv_ttsp.Rows[i].Cells[5].Value.ToString();
                //tim khuyến mãi
                foreach (CTKhuyenMaiDTO cv in dskm)
                {
                    khuyenmaiss = 0;
                    if (txtSP.Text.Equals(cv.MaSP))
                    {
                        MessageBox.Show("sản phẩm có chương trình khuyến mãi " + cv.GiamGia);
                        txtkhuyenmai.Text = cv.GiamGia;
                        khuyenmaiss = 1;
                    }
                }
                if (khuyenmaiss == 0)
                {
                    txtkhuyenmai.Text = "Không có khuyến mãi nào!";
                    MessageBox.Show("sản phẩm không có chương trình khuyến mãi! hehe");
                }
            }

            //khoi tao ma chi tiết hóa đơn
            int ma = 1;
            foreach (CTHoaDonDTO cv in dscthd)
            {
                if (cv.MaHD.Equals(txtmahoadon.Text))
                {
                    ma++;
                }
            }
            string km = null;
            string giakm = null;
            km = txtkhuyenmai.Text;
            if (txtkhuyenmai.Text != "Không có khuyến mãi nào!")
            {
                giakm = km.Substring(0, 2);
            }
            if (khuyenmaiss == 0)
            {
                giakm = "0";
            }
            float dongia = Int32.Parse(txtDonGia.Text);
            txtsoluongmuasanpham.Text = "1";
            float soluong = Int32.Parse(txtsoluongmuasanpham.Text);
            float kuyenmai = Int32.Parse(giakm);
            //bang du lieu chi co 1 hoa don
            //Load_DSSP();
            //int intmact = dtgcthoadon.Rows.Count;
            if (ma < 10)
            {
                txtmact.Text = txtmahoadon.Text + "SP_0" + ma;
            }
            if (ma >= 10)
            {
                txtmact.Text = txtmahoadon.Text + "SP_" + ma;
            }
            float thanhtien = (dongia * soluong - (dongia * soluong * (kuyenmai / 100)));
            //tinh tiền sản phẩm
            //float tongtien = Int32.Parse(txttongtiendamua.Text);
            txtthanhtien.Text = thanhtien.ToString();
            //tongtien = tongtien + thanhtien;
            //txttongtiendamua.Text = tongtien.ToString();
        }
        //lấy 2 giá trị đầu tiên của chuỗi

        private string ExtractNumber(string original)
        {
            original = txtkhuyenmai.Text;
            return new string(original.Where(c => Char.IsDigit(c)).ToArray());
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtsoluongmuasanpham.Text == "")
            {
                MessageBox.Show("không được để trống dữ liệu");
                txtsoluongmuasanpham.Text = "1";
            }
            else
            {
                int ktnhap = Int32.Parse(txtsoluongmuasanpham.Text);
                if (ktnhap <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lớn hơn 0");
                    txtsoluongmuasanpham.Text = "1";
                }
                else
                     if (txttongtiendamua.Text != null)
                {
                    //cat gia khuyen mai
                    string kms = null;
                    string giakm = null;
                    float kuyenmai = 0;
                    kms = txtkhuyenmai.Text;
                    if (txtkhuyenmai.Text == "Không có khuyến mãi nào!")
                    {
                        kms = "0";
                    }
                    if (txtkhuyenmai.Text != "Không có khuyến mãi nào!")
                    {
                        giakm = kms.Substring(0, 2);
                        kuyenmai = Int32.Parse(giakm);
                    }
                    else
                    {
                        giakm = "0";
                        kuyenmai = 0;
                    }
                    //tinh gia tien that
                    float dongia = Int32.Parse(txtDonGia.Text);
                    float soluong = Int32.Parse(txtsoluongmuasanpham.Text);
                    float thanhtien = (dongia * soluong - (dongia * soluong * (kuyenmai / 100)));
                    txtthanhtien.Text = thanhtien.ToString();
                    //tinh tiền sản phẩm
                    //float tongtien = Int32.Parse(txttongtiendamua.Text);
                    // tongtien = tongtien + thanhtien;
                    //txttongtiendamua.Text = tongtien.ToString();

                }
            }
        }
        //khoi tao ma hoa don
        public string mahoadon;
        public string makhachhang;
        public string manhanvien;
        public string maKH;
        public string tongtienhd;
        public string tongtienhoadon;
        //lay du lieu form Hoa Don
        private void chuyendatatoform(object sender, EventArgs e)
        {
            txtmahoadon.Text = mahoadon;
            txtMaNV.Text = manhanvien;
            txtmakhachhang.Text = makhachhang;
            txttongtiendamua.Text = tongtienhoadon;
            Load_DSSP();
        }

        //lay du lieu textbox
        private CTHoaDonDTO layTTSP_moi()
        {
            CTHoaDonDTO NewSP = new CTHoaDonDTO();
            NewSP.MaHD = string.IsNullOrEmpty(txtmahoadon.Text) ? "" : txtmahoadon.Text;
            NewSP.MaSP = string.IsNullOrEmpty(txtSP.Text) ? "" : txtSP.Text;
            NewSP.GiaBan = string.IsNullOrEmpty(txtDonGia.Text) ? "" : txtDonGia.Text;
            NewSP.SoLuong = string.IsNullOrEmpty(txtsoluongmuasanpham.Text) ? "" : txtsoluongmuasanpham.Text;
            NewSP.MaCTHD = string.IsNullOrEmpty(txtmact.Text) ? "" : txtmact.Text;
            NewSP.TrangThai = "1";
            return NewSP;
        }
        // click Thêm
        private void Them_Click_1(object sender, EventArgs e)
        {

        }
        //reset
        private void reset()
        {
            txtSP.Text = "";
            txtTenSP.Text = "";
            txtkhuyenmai.Text = "";
            txtthanhtien.Text = "0 đồng";
            txtsoluongton.Text = "";
            txtsoluongmuasanpham.Text = "1";
            txtmact.Text = "";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.tongtienhoadon = txttongtiendamua.Text;
            hd.mahoadon = txtmahoadon.Text;
            hd.MaNV = txtMaNV.Text;
            hd.makhachhang = txtmakhachhang.Text;
            hd.Show();
        }
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            sua();
        }
        public void sua()
        {
            CTHoaDonDTO nv = layTTSP_moi();

            bool kq = customerCTHDBUS.UpdateNV(nv);

            MessageBox.Show("Thêm thành công" + txtsoluongmuasanpham.Text + "sản phẩm");
            Load_Form();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InHoaDon mayin = new InHoaDon();
            mayin.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        // update san pham
        private SanPhamDTO layTTSP_sua()
        {
            //tinh so luong con lai
            string soluongkho = null;
            foreach (SanPhamDTO cv in dssp)
            {
                if (cv.MaSP == txtSP.Text)
                {
                    soluongkho = cv.SoLuongTon;
                }
            }
            float slupdates = Int32.Parse(soluongkho);
            float soluongss = Int32.Parse(txtsoluongmuasanpham.Text);
            float slconlai = slupdates - soluongss;
            //end
            if (slconlai <= 0)
            {
                slconlai = 0;
            }
            SanPhamDTO NewSP = new SanPhamDTO();
            NewSP.MaSP = string.IsNullOrEmpty(txtSP.Text) ? "" : txtSP.Text;
            NewSP.SoLuongTon = slconlai.ToString();
            NewSP.TrangThai = "1";
            return NewSP;
        }

        private void dtgcthoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cthd.SelectedCells.Count > 0)
            {
                int i;
                i = cthd.CurrentRow.Index;
                txtSP.Text = cthd.Rows[i].Cells[0].Value.ToString();

                //khoi tao san pham khong truyen ma hóa đơn
                dssps = customerBUS.LayDssp();
                foreach (SanPhamDTO cv in dssps)
                {
                    if (cv.MaSP.Equals(txtSP.Text))
                    {
                        txtTenSP.Text = cv.TenSP;
                        txtDonGia.Text = cv.DonGia;
                    }
                }
                foreach (CTKhuyenMaiDTO km in dskm)
                {
                    if (txtSP.Text.Equals(km.MaSP))
                    {
                        MessageBox.Show("sản phẩm khuyến mãi " + km.GiamGia);
                        txtkhuyenmai.Text = km.GiamGia;
                    }
                }
            }
        }

        private void load_2(object sender, EventArgs e)
        {
            txtMaNV.Text = manhanvien;
            ThemHD();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            //tim kiem san pham
            foreach (SanPhamDTO sp in dssp)
            {
                if (sp.MaSP.Equals(txtSP.Text))
                {
                    txtTenSP.Text = sp.TenSP;
                    txtDonGia.Text = sp.DonGia;
                    txtsoluongton.Text = sp.SoLuongTon;
                    foreach (CTKhuyenMaiDTO cv in dskm)
                    {
                        khuyenmaiss = 0;
                        if (txtSP.Text.Equals(cv.MaSP))
                        {
                            MessageBox.Show("sản phẩm có chương trình khuyến mãi " + cv.GiamGia);
                            txtkhuyenmai.Text = cv.GiamGia;
                            khuyenmaiss = 1;
                        }
                    }
                    if (khuyenmaiss == 0)
                    {
                        txtkhuyenmai.Text = "Không có khuyến mãi nào!";
                        MessageBox.Show("sản phẩm không có chương trình khuyến mãi! hehe");
                    }
                }
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang();
            khachhang.Show();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            CTHoaDonDTO khAdd = layTTSP_moi();
            if (khAdd.MaHD == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            //kiem tra so luing du ban hay khong
            string soluongkho = null;
            foreach (SanPhamDTO cv in dssp)
            {
                if (cv.MaSP == txtSP.Text)
                {
                    soluongkho = cv.SoLuongTon;
                }
            }
            float slupdates = Int32.Parse(soluongkho);
            float soluongss = Int32.Parse(txtsoluongmuasanpham.Text);
            float slconlai = slupdates - soluongss;
            if (slconlai < 0)
            {
                MessageBox.Show("Hiện tại không đủ số lượng bán, vui lòng kiểm tra lại");
                DialogResult ktsl = MessageBox.Show
                ("Số lượng tại cửa hàng đủ bán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ktsl == DialogResult.Yes)
                {
                    //kiem tra san pham da ton tai hay chua
                    int ktsp = 0;
                    foreach (CTHoaDonDTO cv in dscthd)
                    {
                        if (txtSP.Text.Equals(cv.MaSP))
                        {
                            ktsp = 1;
                        }
                    }
                    if (ktsp == 1)
                    {
                        DialogResult h = MessageBox.Show
                         ("sản phẩm đã tồn tại trong hóa đơn. Bạn có muốn thêm số lượng" + txtsoluongmuasanpham.Text,
                         "Thông báo",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (h == DialogResult.Yes)
                        {
                            sua();
                            //reset;
                        }
                    }
                    else
                    {
                        bool kq = customerCTHDBUS.DKSP(khAdd);
                        MessageBox.Show("Thêm Thành công");
                    }
                    float tongtien = Int32.Parse(txttongtiendamua.Text);
                    float thanhtien = Int32.Parse(txtthanhtien.Text);
                    tongtien = tongtien + thanhtien;
                    txttongtiendamua.Text = tongtien.ToString();
                    SanPhamDTO khAdds = layTTSP_sua();
                    if (khAdds.SoLuongTon == "")
                    {
                        MessageBox.Show("Vui lòng chọn sản phảm!!");
                        return;
                    }
                    else
                    {
                        SanPhamDTO nv = layTTSP_sua();
                        bool kq = customerBUS.UpdateSL(nv);
                        MessageBox.Show("đã update sản phẩm");
                    }
                    reset();
                    Load_Form();
                }
                if (ktsl == DialogResult.No)
                {
                    MessageBox.Show("số lượng không đủ bán, vui long nhập lạp số lượng");
                }
            }
            else
            {
                int kt1 = 0;
                foreach (CTHoaDonDTO cv in dscthd)
                {
                    if (txtSP.Text.Equals(cv.MaSP))
                    {
                        kt1 = 1;
                    }
                }
                if (kt1 == 1)
                {
                    DialogResult h = MessageBox.Show
                     ("sản phẩm đã tồn tại trong hóa đơn. Bạn có muốn thêm số lượng" + txtsoluongmuasanpham.Text,
                     "Thông báo",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (h == DialogResult.Yes)
                    {
                        sua();
                        //reset;
                    }
                }
                else
                {
                    bool kq = customerCTHDBUS.DKSP(khAdd);
                    MessageBox.Show("Thêm Thành công");
                }
                float tongtien = Int32.Parse(txttongtiendamua.Text);
                float thanhtien = Int32.Parse(txtthanhtien.Text);
                tongtien = tongtien + thanhtien;
                txttongtiendamua.Text = tongtien.ToString();
                // update so luong san pham
                SanPhamDTO khAdds = layTTSP_sua();
                if (khAdds.SoLuongTon == "")
                {
                    MessageBox.Show("Vui lòng chọn sản phảm!!");
                    return;
                }
                else
                {
                    SanPhamDTO nv = layTTSP_sua();
                    bool kq = customerBUS.UpdateSL(nv);
                    MessageBox.Show("đã update sản phẩm");
                }
                reset();
                suahoadon();
                Load_Form();
            }
        }
        private void suahoadon()
        {
            HoaDonDTO hd = layHD_update();
            bool kq = customerHDBUS.UpdateNV(hd);
            MessageBox.Show("Tổng tiền nhận được là: " + txttongtiendamua.Text);
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            suahoadon();
            InHoaDon mayin = new InHoaDon();
            mayin.mahd = txtmahoadon.Text;
            mayin.Show();
            Load_Form();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtmakhachhang.Text = "";
            ThemHD();
            Load_Form();
        }
    }
}
