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
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
            changktmau();
        }
        private void changktmau()
        {
            labmau.Visible = false;
            labkichthuoc.Visible = false;
        }
        SanPhamBUS customerBUS = new SanPhamBUS();
        BindingSource bs = new BindingSource();
        List<SanPhamDTO> dssp = new List<SanPhamDTO>();

        MauSacBUS customerMauBUS = new MauSacBUS();
        BindingSource bsmau = new BindingSource();
        List<MauSacDTO> dsmau = new List<MauSacDTO>();

        SizeBUS customerKTBUS = new SizeBUS();
        BindingSource bskt = new BindingSource();
        List<SizeDTO> dskt = new List<SizeDTO>();
        // phieunhap
        PhieuNhapBUS customerPNBUS = new PhieuNhapBUS();
        BindingSource bspn = new BindingSource();
        List<PhieuNhapDTO> dspn = new List<PhieuNhapDTO>();
        //chi tiết phiếu nhập
        CTPhieuNhapBUS customerCTPNBUS = new CTPhieuNhapBUS();
        BindingSource bsctpn = new BindingSource();
        List<CTPhieuNhapDTO> dsctpn = new List<CTPhieuNhapDTO>();
        // chi tiết sản phẩm
        CTSanPhamBUS customerCTSPBUS = new CTSanPhamBUS();
        BindingSource bsctsp = new BindingSource();
        List<CTSanPhamDTO> dsctsp = new List<CTSanPhamDTO>();
        public string manhanvien;
        public string maphieunhap;
        private void Load_Form()
        {
            Load_DSSP();
        }
        private void Load_DSSP()
        {
            dssp = customerBUS.LayDssp();
            bs.DataSource = dssp.ToList();

            //mau
            dsmau = customerMauBUS.LayDsmau();
            bsmau.DataSource = dsmau.ToList();
            //kich thuoc
            dskt = customerKTBUS.LayDskt();
            bskt.DataSource = dskt.ToList();

            //phiếu nhập
            dspn = customerPNBUS.LayDssp();
            bspn.DataSource = dspn.ToList();
            //chi tiết phiếu nhập
            string ma = maphieunhap;
            dsctpn = customerCTPNBUS.LayDsspdk(ma);
            bs.DataSource = dsctpn.ToList();
            dtgv_ttkh.DataSource = bs;
            // chi tiết sản phẩm
            dsctsp = customerCTSPBUS.LayDsCTSP();
            bsctsp.DataSource = dsctsp.ToList();
        }
        private PhieuNhapDTO layTTKH_moi()
        {
            PhieuNhapDTO NewKH = new PhieuNhapDTO();
            maphieunhap= "PN" + DateTime.Now.ToString("ddMMyyyy-HHms");
            NewKH.MaPN = maphieunhap;
            NewKH.ThanhToan = "0";
            NewKH.NgayLap = DateTime.Now.ToString("dd/MM/yyyy");
            NewKH.MaCH = "Như loading";
            NewKH.MaNV = manhanvien;
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private CTPhieuNhapDTO layCTPN_moi()
        {
            CTPhieuNhapDTO NewKH = new CTPhieuNhapDTO();
            NewKH.MaCTPN = "CTPN" + DateTime.Now.ToString("ddMMyyyy-HHms");
            NewKH.MaPN = maphieunhap;
            NewKH.MaSP = string.IsNullOrEmpty(txtsp.Text) ? "" : txtsp.Text;
            NewKH.SoLuong = string.IsNullOrEmpty(txtsoluong.Text) ? "" : txtsoluong.Text;
            NewKH.GiaNhap = string.IsNullOrEmpty(txtdongia.Text) ? "" : txtdongia.Text;
            NewKH.MaMau = string.IsNullOrEmpty(labmau.Text) ? "" : labmau.Text;
            NewKH.MaSize = string.IsNullOrEmpty(labkichthuoc.Text) ? "" : labkichthuoc.Text;
            NewKH.ChiecKhau = "loading";
            NewKH.TrangThai = "1";
            return NewKH;
        }
        
        private PhieuNhapDTO layupdatePN()
        {
            string tien = "0";
            string thanhtoan = txtTongTien.Text;
            foreach (PhieuNhapDTO pn in dspn)
            {

                if (pn.MaPN == maphieunhap)
                {
                    tien = pn.ThanhToan;
                }
            }

            float thanhtien = Int32.Parse(tien);
            float thanhtoans = Int32.Parse(thanhtoan);
            thanhtoans = thanhtoans + thanhtien;

            PhieuNhapDTO NewKH = new PhieuNhapDTO();
            NewKH.MaPN = maphieunhap;
            NewKH.ThanhToan = thanhtoans.ToString();
            NewKH.TrangThai = "1";
            return NewKH;
        }
        void them()
        {
            PhieuNhapDTO khAdd = layTTKH_moi();
            bool kq = customerPNBUS.DKSP(khAdd);
            Load_Form();
        }
        void updatePN()
        {
            PhieuNhapDTO pn = layupdatePN();
            bool kqpx = customerPNBUS.UpdateSL(pn);
            Load_Form();
        }
        void themchitietphieunhap()
        {
            CTPhieuNhapDTO khAdd = layCTPN_moi();
            bool kq = customerCTPNBUS.DKSP(khAdd);
            //update phiếu nhập
            
            Load_Form();
        }
        int ktthemvao = 0;
        void kiemtrathemctpn()
        {
            if(txtsp.Text==""&& txtdongia.Text==""&& txtsoluong.Text=="")
            {
                MessageBox.Show("Kiểm tra lại sản phẩm");
                ktthemvao = 0009;
            }   
            if(txtsoluong.Text=="")
            {
                MessageBox.Show("vui lòng nhập số lượng");
                ktthemvao = 0009;
            }    
            if(labkichthuoc.Visible == false && labmau.Visible == false)
            {
                MessageBox.Show("Vui lòng chọn màu và kích thược");
                ktthemvao = 0009;
            }    
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            kiemtrathemctpn();
            if (ktthemvao==0)
            {
                themchitietphieunhap();
                updatePN();
                aotu();
                //bien mat mã màu sze
                changktmau();

            }      
        }

        private void txtsp_TextChanged(object sender, EventArgs e)
        {
            foreach (SanPhamDTO sp in dssp)
            {
                if (sp.MaSP.Equals(txtsp.Text))
                {
                    txttensanpham.Text = sp.TenSP;
                    txtdongia.Text = sp.DonGia; 
                }
            }
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            foreach (MauSacDTO sps in dsmau)
            {
                cmbmau.Items.Add(sps.TenMau.ToString());
            }
            foreach (SizeDTO sps in dskt)
            {
                cmbkichthuoc.Items.Add(sps.TenSize.ToString());
            }
            them();
        }

        private void cmbmau_onItemSelected(object sender, EventArgs e)
        {
            labmau.Visible = true;
            foreach (MauSacDTO cv in dsmau)
            {
                if (cmbmau.selectedValue.Equals(cv.TenMau))
                {
                    labmau.Text = cv.MaMau;
                }
            }
        }

        private void cmbkichthuoc_onItemSelected(object sender, EventArgs e)
        {
            labkichthuoc.Visible = true;
            foreach (SizeDTO cv in dskt)
            {
                if (cmbkichthuoc.selectedValue.Equals(cv.TenSize))
                {
                    labkichthuoc.Text = cv.MaSize;
                }
            }
        }
        private void aotu()
        {
            string kt = "";
            CTSanPhamDTO NewCT = new CTSanPhamDTO();
            foreach (CTSanPhamDTO ct in dsctsp)
            {
                if (txtsp.Text == ct.MaSP && labmau.Text == ct.MaMau && labkichthuoc.Text == ct.KichThuoc
                    && ct.MaCH == "admin")
                {
                    CTSanPhamDTO layCTSPupdate()
                    {
                        string slcuakho = ct.SoLuong;
                        string slnhapvaomoi = txtsoluong.Text;
                        float slcuakhoint = Int32.Parse(slcuakho);
                        float slnhapvaomoiint = Int32.Parse(slnhapvaomoi);
                        float tongslhang = slcuakhoint + slnhapvaomoiint;
                        NewCT.MaCTSP = ct.MaCTSP;
                        NewCT.SoLuong = tongslhang.ToString();
                        return NewCT;
                    }
                    kt = "009";
                    CTSanPhamDTO CTSPUD = layCTSPupdate();
                    bool kqctsp = customerCTSPBUS.UpdateNV(CTSPUD);
                }
            }
            CTSanPhamDTO layCTSP_moi()
            {
                NewCT.MaCTSP =txtsp.Text + DateTime.Now.ToString("ddMMyyyy") + DateTime.Now.ToString("HHmmss");
                NewCT.MaSP = txtsp.Text;
                NewCT.MaMau = labmau.Text;
                NewCT.KichThuoc = labkichthuoc.Text;
                NewCT.SoLuong = txtsoluong.Text;
                NewCT.MaCH = "admin";
                NewCT.TrangThai = "1";
                return NewCT;
            }

            if (kt != "009")
            {
                //them chi tiet san pham
                CTSanPhamDTO CT = layCTSP_moi();
                bool kqctsp = customerCTSPBUS.DKKH(CT);
            }
        
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            float dongia = Int32.Parse(txtdongia.Text);
            float soluong = Int32.Parse(txtsoluong.Text);
            float thanhtien = dongia*soluong;
            txtTongTien.Text = thanhtien.ToString();
        }
    }
}
