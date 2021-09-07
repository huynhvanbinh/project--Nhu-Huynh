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
            // khoi tao load du lieu bang khuyến mãi
            dskm = customerKMBUS.LayDssp();
            bskm.DataSource = dskm.ToList();
            // san pham
            dssp = customerBUS.LayDssp();
            bs.DataSource = dssp.ToList();
            dtgv_ttsp.DataSource = bs;
        }
     
        int khuyenmaiss = 0;
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttsp.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttsp.CurrentRow.Index;
                txtmasp.Text = dtgv_ttsp.Rows[i].Cells[0].Value.ToString();
                txtTenSP.Text = dtgv_ttsp.Rows[i].Cells[1].Value.ToString();
                txtDonGia.Text = dtgv_ttsp.Rows[i].Cells[2].Value.ToString();
                txtsoluongmuasanpham.Text = "";
                txtthanhtien.Text = "";
                //tim khuyến mãi
                foreach (CTKhuyenMaiDTO cv in dskm)
                {
                    khuyenmaiss = 0;
                    if (txtmasp.Text.Equals(cv.MaSP))
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
                dataGridView1.Visible = true;
                string masanpham = txtmasp.Text;
                dsctsp = customerCTSPBUS.LayDsctspch(masanpham,macuahang);
                bsctsp.DataSource = dsctsp.ToList();
                dataGridView1.DataSource = bsctsp;
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
        }
        private string ExtractNumber(string original)
        {
            original = txtkhuyenmai.Text;
            return new string(original.Where(c => Char.IsDigit(c)).ToArray());
        }
        //khoi tao ma hoa don
        public string mahoadon;
        public string makhachhang;
        public string manhanvien;
        public string maKH;
        public string tongtienhd;
        public string tongtienhoadon;
        public string mamau;
        public string kichthuoc;

       
        public string mach;
        public void load_2(object sender, EventArgs e)
        {
            mach = macuahang;
            txtmahoadon.Text = "HD" + DateTime.Now.ToString("ddMMyyyyHHmmss");
            Load_Form();
        }
        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            //tim kiem san pham
            foreach (SanPhamDTO sp in dssp)
            {
                if (sp.MaSP.Equals(txtmasp.Text))
                {
                    txtTenSP.Text = sp.TenSP;
                    txtDonGia.Text = sp.DonGia;

                    foreach (CTKhuyenMaiDTO cv in dskm)
                    {
                        khuyenmaiss = 0;
                        if (txtmasp.Text.Equals(cv.MaSP))
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
                    dataGridView1.Visible = true;
                    string masanpham = txtmasp.Text;
                    dsctsp = customerCTSPBUS.LayDsctspch(masanpham, macuahang);
                    bsctsp.DataSource = dsctsp.ToList();
                    dataGridView1.DataSource = bsctsp;
                }
            }
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
                thanhtoan = thanhtoan + dongia * soluong;
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
                    NewSP.MaCTHD = "CTHD" + "_" + DateTime.Now.ToString("ddMMyyyyhhmmss");
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
                    float soluongmua = Int32.Parse(txtsoluongmuasanpham.Text);
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
                string slmua = txtsoluongmuasanpham.Text;
                float sluongmua = Int32.Parse(slmua);
                string dongia = txtDonGia.Text;
                float giamuavao = Int32.Parse(dongia);
                float thanhtien = sluongmua * giamuavao;
                txtthanhtien.Text = thanhtien.ToString();
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
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                int ktthemlist = 16062000;
                SanPhamban sanpham = new SanPhamban();
                sanpham.MaSP = txtmasp.Text;
                sanpham.MaMau = txtmamau.Text;
                sanpham.MaSize = txtkichthuoc.Text;
                sanpham.SoLuong = txtsoluongmuasanpham.Text;
                sanpham.MaKM = txtkhuyenmai.Text;
                sanpham.GiaBan = txtDonGia.Text;
                foreach (SanPhamban listsp in listsanphamban)
                {
                    if (listsp.MaSP == txtmasp.Text && listsp.MaMau == txtmamau.Text && listsp.MaSize == txtkichthuoc.Text)
                    {
                        MessageBox.Show("san pham da ton tai trong hoa don", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ktthemlist = 0;
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
