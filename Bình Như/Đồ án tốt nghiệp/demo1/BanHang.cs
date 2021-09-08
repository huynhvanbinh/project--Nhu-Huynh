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
        List<SanPhamban> listsanphamban;
        public BanHang()
        {
            InitializeComponent();
            dtgv_ttsp.AutoGenerateColumns = false;
            cthd.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Visible = false;
            Load_Form();
            listsanphamban = new List<SanPhamban>();
        }

        HoaDonBUS customerHDBUS = new HoaDonBUS();
        BindingSource bshd = new BindingSource();
        List<HoaDonDTO> dshds = new List<HoaDonDTO>();

        SanPhamBUS customerBUS = new SanPhamBUS();
        BindingSource bs = new BindingSource();
        List<SanPhamDTO> dssp = new List<SanPhamDTO>();

        CTHoaDonBUS customerCTHDBUS = new CTHoaDonBUS();
        BindingSource bscthd = new BindingSource();
        List<CTHoaDonDTO> dscthd = new List<CTHoaDonDTO>();


        KhuyenMaiBUS customerTKMBUS = new KhuyenMaiBUS();
        BindingSource bstkm = new BindingSource();
        List<KhuyenMaiDTO> dstkm = new List<KhuyenMaiDTO>();

        CTKhuyenMaiBUS customerKMBUS = new CTKhuyenMaiBUS();
        BindingSource bskm = new BindingSource();
        List<CTKhuyenMaiDTO> dskm = new List<CTKhuyenMaiDTO>();

        CTSanPhamBUS customerCTSPBUS = new CTSanPhamBUS();
        BindingSource bsctsp = new BindingSource();
        List<CTSanPhamDTO> dsctsp = new List<CTSanPhamDTO>();
        private void Load_Form()
        {
            Load_DSSP();
            
        }
        public string macuahang;
        private void Load_DSSP()
        {
            // khoi tao load du lieu bang chi tiết hóa đơn có truyền mã
            string ma = txtmahoadon.Text;
            dscthd = customerCTHDBUS.LayDssp(ma);
            bscthd.DataSource = dscthd.ToList();
            cthd.DataSource = bscthd;
            //khoi tao load khuyen mai
            dstkm = customerTKMBUS.LayDssp();
            bstkm.DataSource = dstkm.ToList();
            // khoi tao load du lieu bang chi tiet khuyến mãi
            dskm = customerKMBUS.LayDssp();
            bskm.DataSource = dskm.ToList();
            // san pham
            dssp = customerBUS.LayDssp();
            bs.DataSource = dssp.ToList();
            dtgv_ttsp.DataSource = bs;
        }
     
        int khuyenmaiss = 0;
        string giamgia="0";
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttsp.SelectedCells.Count > 0)
            {
                txtmamau.Text = "";
                txtkichthuoc.Text = "";
                txtkhuyenmai.Text = "";
                giamgia = "0";
                int i;
                i = dtgv_ttsp.CurrentRow.Index;
                txtmasp.Text = dtgv_ttsp.Rows[i].Cells[0].Value.ToString();
                txtTenSP.Text = dtgv_ttsp.Rows[i].Cells[1].Value.ToString();
                txtDonGia.Text = dtgv_ttsp.Rows[i].Cells[2].Value.ToString();
                txtsoluongmuasanpham.Text = "";
                txtthanhtien.Text = "";
                //tim khuyến mãi
                string makhuyenmai = "16062000";
                DateTime ngayhientai = DateTime.Now;
                foreach (KhuyenMaiDTO cv in dstkm)
                {
                    DateTime ngaybatdau = Convert.ToDateTime(cv.NgayBatDau);
                    DateTime ngayketthuc = Convert.ToDateTime(cv.NgayKetThuc);
                    TimeSpan batdaudung = ngayhientai.Subtract(ngaybatdau);
                    TimeSpan ketthucdung = ngayketthuc.Subtract(ngayhientai);
                    int batdaudungs = batdaudung.Days;
                    int ketthucdungs = ketthucdung.Days;
                    if (batdaudungs>=0 && ketthucdungs>=0)
                   {
                        makhuyenmai = cv.MaKM;
                    }
                }
                foreach (CTKhuyenMaiDTO cv in dskm)
                {
                    if(cv.MaKM == makhuyenmai.ToString() && cv.MaSP==txtmasp.Text)
                    {
                       // cat bo % c#
                        giamgia = cv.GiamGia;
                        var charsToRemove = new string[] { "%"};
                        foreach (var c in charsToRemove)
                        {
                            giamgia = giamgia.Replace(c, string.Empty);
                        }
                        txtkhuyenmai.Text = cv.GiamGia;
                    }    
                }
                dataGridView1.Visible = true;
                string masanpham = txtmasp.Text;
                dsctsp = customerCTSPBUS.LayDsctspch(masanpham,macuahang);
                bsctsp.DataSource = dsctsp.ToList();
                dataGridView1.DataSource = bsctsp;
            }

        }
        private string ExtractNumber(string original)
        {
            original = txtkhuyenmai.Text;
            return new string(original.Where(c => Char.IsDigit(c)).ToArray());
        }
        //khoi tao ma hoa don
        public string manhanvien;      
        public string mach;
        public void load_2(object sender, EventArgs e)
        {
            mach = macuahang;
            txtmahoadon.Text = "HD" + DateTime.Now.ToString("ddMMyyyyHHmmss");
            Load_Form();
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang();
            khachhang.Show();
        }               
        private HoaDonDTO layHD_moi()
        {
            int thanhtoan = 0;
            foreach (SanPhamban listsp in listsanphamban)
            {
                int dongia = Int32.Parse(listsp.GiaBan);
                int soluong = Int32.Parse(listsp.SoLuong);
                thanhtoan = thanhtoan + dongia * soluong- Int32.Parse(listsp.MaKM);
            }
            HoaDonDTO NewSP = new HoaDonDTO();
            NewSP.MaHD = string.IsNullOrEmpty(txtmahoadon.Text) ? "" : txtmahoadon.Text;
            NewSP.NgayLap = DateTime.Now.ToString("dd/MM/yyyy");
            NewSP.MaKH = string.IsNullOrEmpty(txtmakhachhang.Text) ? "" : txtmakhachhang.Text;
            NewSP.MaNV = manhanvien;
            NewSP.MaCH = macuahang;
            NewSP.TongTien = thanhtoan.ToString();
            NewSP.TrangThai = "1";
            return NewSP;
        }
        void taohoadon()
        {
            HoaDonDTO khAdd = layHD_moi();
            bool kq = customerHDBUS.DKSP(khAdd);
        }
        private void aotuthemcthoadon()
        {
            foreach (SanPhamban listsp in listsanphamban)
            {
                CTHoaDonDTO layTTSP_moi()
                {
                    CTHoaDonDTO NewSP = new CTHoaDonDTO();
                    NewSP.MaHD = string.IsNullOrEmpty(txtmahoadon.Text) ? "" : txtmahoadon.Text;
                    NewSP.MaSP = listsp.MaSP;
                    NewSP.MaMau = listsp.MaMau;
                    NewSP.MaSize = listsp.MaSize;
                    NewSP.GiaBan = listsp.GiaBan;
                    NewSP.SoLuong = listsp.SoLuong;
                    NewSP.MaKM = listsp.MaKM;
                    NewSP.MaCTHD = "CTHD" + "_" + txtmahoadon.Text+listsp.MaSP+listsp.MaMau+listsp.MaSize;
                    NewSP.TrangThai = "1";
                    return NewSP;
                }
                CTHoaDonDTO khAdd = layTTSP_moi();
                bool kq = customerCTHDBUS.DKSP(khAdd);
                //update san pham
                 CTSanPhamDTO UpdateCTSP()
                 { 
                    string soluongsanpham = null;
                    CTSanPhamDTO NewSP = new CTSanPhamDTO();
                    NewSP.MaSP = listsp.MaSP;
                    NewSP.MaMau = listsp.MaMau;
                    NewSP.KichThuoc = listsp.MaSize;
                    dsctsp = customerCTSPBUS.Laydsctspmacuahang(macuahang);
                    bsctsp.DataSource = dsctsp.ToList();
                    foreach (CTSanPhamDTO cv in dsctsp)
                    {
                        if (cv.MaSP == listsp.MaSP && listsp.MaMau == cv.MaMau && listsp.MaSize == cv.KichThuoc)
                        {
                            NewSP.MaCTSP = cv.MaCTSP;
                            soluongsanpham = cv.SoLuong;
                        }
                    }
                    float soluongsp = Int32.Parse(soluongsanpham);
                    float soluongmua = Int32.Parse(listsp.SoLuong);
                    float soluongupdate = soluongsp - soluongmua;
                    NewSP.SoLuong = soluongupdate.ToString();
                    return NewSP;
                 }
                 CTSanPhamDTO ct = UpdateCTSP();
                 bool kqctsp = customerCTSPBUS.UpdateSL(ct);                
            }
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            int kt = 0;
            foreach (SanPhamban listsp in listsanphamban)
            {
                if (listsp.MaSP != "")
                {
                    kt = 1;
                }
            }
            if (kt == 1)
            {
                MessageBox.Show("đã bán " + listsanphamban.Count + " sản phẩm ", "thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                //tao Hoa Don
                taohoadon();
                //them CT Hoa Don
                aotuthemcthoadon();
                //load lai chi tiet san pham cho dung
                string masanpham = txtmasp.Text;
                dsctsp = customerCTSPBUS.LayDsctspch(masanpham, macuahang);
                bsctsp.DataSource = dsctsp.ToList();
                dataGridView1.DataSource = bsctsp;
            }
            if (kt == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm bán");
            }
            //InHoaDon mayin = new InHoaDon();
            //mayin.mahd = txtmahoadon.Text;
            //mayin.Show();
            Load_Form();
            btnthem.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtmakhachhang.Text = "";
            txtmahoadon.Text= "HD"+DateTime.Now.ToString("ddMMyyyyhhmmss");
            Load_Form();
            btnthem.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            reset();
            txtmakhachhang.Enabled = true;
        }
        void reset()
        {
            txtDonGia.Text = "";
            txtkhuyenmai.Text = "";
            txtkichthuoc.Text = "";
            txtmakhachhang.Text = "";
            txtmamau.Text = "";
            txtmasp.Text = "";
            txtsoluongmuasanpham.Text = "";
            txtTenSP.Text = "";
            txtthanhtien.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int i;
                i = dataGridView1.CurrentRow.Index;
                txtmamau.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtkichthuoc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtsoluongmuasanpham.Text = "";
                txtthanhtien.Text = "";
            }
        }

        private void txtsoluongmuasanpham_TextChanged(object sender, EventArgs e)
        {
            if(txtsoluongmuasanpham.Text!="")
            {
                float giamgias = Int32.Parse(txtsoluongmuasanpham.Text) * Int32.Parse(txtDonGia.Text)* (float.Parse(giamgia) / 100);
                float thanhtien = Int32.Parse(txtsoluongmuasanpham.Text) * Int32.Parse(txtDonGia.Text) - giamgias ;
                txtthanhtien.Text = thanhtien.ToString();
                txtkhuyenmai.Text =giamgias.ToString();
            }
            if(txtsoluongmuasanpham.Text=="")
            {
                txtthanhtien.Text = "";
                txtkhuyenmai.Text = giamgia.ToString() + "%";
            }    
        }

        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtmasp.Text) || string.IsNullOrWhiteSpace(txtmamau.Text))
            {
                MessageBox.Show("Vui long chon san pham", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtsoluongmuasanpham.Text))
            {
                MessageBox.Show("Vui long nhap so luong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsoluongmuasanpham.Focus();
                return false;
            }
            if(Int32.Parse(txtsoluongmuasanpham.Text)<=0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsoluongmuasanpham.Focus();
                return false;
            }    
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                string masanpham = txtmasp.Text;
                dsctsp = customerCTSPBUS.LayDsctspch(masanpham, macuahang);
                bsctsp.DataSource = dsctsp.ToList();
                int ktthemlist = 16062000;
                SanPhamban sanpham = new SanPhamban();
                sanpham.MaSP = txtmasp.Text;
                sanpham.MaMau = txtmamau.Text;
                sanpham.MaSize = txtkichthuoc.Text;
                sanpham.SoLuong = txtsoluongmuasanpham.Text;
                sanpham.MaKM = txtkhuyenmai.Text;
                sanpham.GiaBan = txtDonGia.Text;
                int ktsp = 14071999;
                foreach (SanPhamban listsp in listsanphamban)
                {
                    if (listsp.MaSP == txtmasp.Text && listsp.MaMau == txtmamau.Text && listsp.MaSize == txtkichthuoc.Text)
                    {
                        MessageBox.Show("san pham da ton tai trong hoa don", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ktthemlist = 0;
                        ktsp = 0;
                    }
                }
                foreach (CTSanPhamDTO cv in dsctsp)
                {
                    if(cv.MaSP==txtmasp.Text && cv.MaMau==txtmamau.Text && cv.KichThuoc==txtkichthuoc.Text && ktsp==14071999)
                    {
                        if(Int32.Parse(cv.SoLuong)-Int32.Parse(txtsoluongmuasanpham.Text) < 0)
                        {
                            MessageBox.Show("không đủ sản phẩm bán", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ktthemlist = 0;
                            txtsoluongmuasanpham.Focus();
                        }    
                    }    
                }
                if (ktthemlist == 16062000)
                {
                    listsanphamban.Add(sanpham);
                    cthd.DataSource = null;
                    cthd.DataSource = listsanphamban;
                    cthd.Refresh();
                }
                txtmakhachhang.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ban co muon xoa", "thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listsanphamban.RemoveAt(index);
                cthd.DataSource = null;
                cthd.DataSource = listsanphamban;
                cthd.Refresh();
            }
        }
        int index;
        private void cthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (cthd.SelectedCells.Count > 0)
            {
                int i;
                i = cthd.CurrentRow.Index;
                txtmasp.Text = cthd.Rows[i].Cells[0].Value.ToString();
                txtmamau.Text = cthd.Rows[i].Cells[1].Value.ToString();
                txtkichthuoc.Text = cthd.Rows[i].Cells[2].Value.ToString();
                txtsoluongmuasanpham.Text = cthd.Rows[i].Cells[4].Value.ToString();
                txtDonGia.Text = cthd.Rows[i].Cells[3].Value.ToString();
                foreach (SanPhamDTO sp in dssp)
                {
                    if (sp.MaSP == txtmasp.Text)
                    {
                        txtTenSP.Text = sp.TenSP;
                    }
                }
                float soluong = Int32.Parse(txtsoluongmuasanpham.Text);
                float giaban = Int32.Parse(txtDonGia.Text);
                float thanhtien = soluong * giaban;
                txtthanhtien.Text = thanhtien.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listsanphamban[index].MaSP = txtmasp.Text;
            listsanphamban[index].MaMau = txtmamau.Text;
            listsanphamban[index].MaSize = txtkichthuoc.Text;
            listsanphamban[index].SoLuong = txtsoluongmuasanpham.Text;
            listsanphamban[index].GiaBan = txtDonGia.Text;
            cthd.DataSource = null;
            cthd.DataSource = listsanphamban;
            cthd.Refresh();
        }
    }
}
