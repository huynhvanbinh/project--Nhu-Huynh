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
    public partial class HangDaVe : Form
    {
        public HangDaVe()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            Load_Form();
        }
        PhieuXuatBUS customerBUS = new PhieuXuatBUS();
        BindingSource bs = new BindingSource();
        List<PhieuXuatDTO> dskhs = new List<PhieuXuatDTO>();

        CTPhieuXuatBUS customerCTPXBUS = new CTPhieuXuatBUS();
        BindingSource bsctpx = new BindingSource();
        List<CTPhieuXuatDTO> dsctpx = new List<CTPhieuXuatDTO>();

        SanPhamBUS customerSPBUS = new SanPhamBUS();
        BindingSource bssp = new BindingSource();
        List<SanPhamDTO> dssp = new List<SanPhamDTO>();

        LoaiSanPhamBUS customerLSPBUS = new LoaiSanPhamBUS();
        BindingSource bscv = new BindingSource();
        List<LoaiSanPhamDTO> dssps = new List<LoaiSanPhamDTO>();

        MauSacBUS customerMauBUS = new MauSacBUS();
        BindingSource bsmau = new BindingSource();
        List<MauSacDTO> dsmau = new List<MauSacDTO>();

        SizeBUS customerKTBUS = new SizeBUS();
        BindingSource bskt = new BindingSource();
        List<SizeDTO> dskt = new List<SizeDTO>();

        CTSanPhamBUS customerCTSPBUS = new CTSanPhamBUS();
        BindingSource bsctsp = new BindingSource();
        List<CTSanPhamDTO> dsctsp = new List<CTSanPhamDTO>();
        public string maphieuxuat;
        public string macuahang;
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            string mapx = maphieuxuat;
            dsctpx = customerCTPXBUS.LayDsspdk(mapx);
            bsctpx.DataSource = dsctpx.ToList();
            dataGridView1.DataSource = bsctpx;

            string mach = "admin";
            dssp = customerSPBUS.LayDsspcuahang(mach);
            bssp.DataSource = dssp.ToList();
        }
        private void aotu()
        {
            string kt = "";
            foreach (CTPhieuXuatDTO cv in dsctpx)
            {
                SanPhamDTO NewKH = new SanPhamDTO();
                CTSanPhamDTO NewCT = new CTSanPhamDTO();
                SanPhamDTO layTTKH_moi()
                {
                    NewKH.MaSP = labmacuahang.Text+"_"+cv.MaSP;                   
                    foreach (SanPhamDTO cvngay in dssp)
                    {
                        if (cvngay.MaSP.Equals(cv.MaSP))
                        {
                            NewKH.TenSP = cvngay.TenSP;
                            NewKH.DonGia = cvngay.DonGia;
                            NewKH.MaLoai = cvngay.MaLoai;
                            NewKH.MoTa = cvngay.MoTa;
                            NewKH.HinhAnh = cvngay.HinhAnh;
                            NewKH.GiaNhap = cvngay.GiaNhap;
                        }
                    }
                    NewKH.MaCH = labmacuahang.Text;
                    NewKH.TrangThai = "1";                  
                    return NewKH;
                }
                CTSanPhamDTO layCTSP_moi()
                {
                    NewCT.MaCTSP = cv.MaSP+ "_"  + DateTime.Now.ToString("HHmmss");
                    NewCT.MaSP = labmacuahang.Text + "_" + cv.MaSP;
                    NewCT.MaMau = cv.MaMau;
                    NewCT.KichThuoc = cv.MaSize;
                    NewCT.SoLuong = cv.SoLuong;
                    NewCT.TrangThai = "1";
                    return NewCT;
                }
                if (cv.MaSP != kt)
                {
                    SanPhamDTO khAdd = layTTKH_moi();
                    bool kq = customerSPBUS.DKSP(khAdd);
                    //them chi tiet san pham
                    CTSanPhamDTO CT = layCTSP_moi();
                    bool kqctsp = customerCTSPBUS.DKKH(CT);
                }
               
            }
        }
        private void HangDaVe_Load(object sender, EventArgs e)
        {
            string mapx = maphieuxuat;   
            dsctpx = customerCTPXBUS.LayDsspdk(mapx);
            bsctpx.DataSource = dsctpx.ToList();
            dataGridView1.DataSource = bsctpx;
            labmacuahang.Text = macuahang;
        }
        private PhieuXuatDTO layTTSP_sua()
        {
            PhieuXuatDTO NewKH = new PhieuXuatDTO();
            NewKH.MaPX = maphieuxuat;
            NewKH.TringTrang = "Đã nhận";
          
            return NewKH;
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Load_DSKH();
            aotu();
            PhieuXuatDTO khAdd = layTTSP_sua();
            bool kq = customerBUS.UpdateNV(khAdd);
            MessageBox.Show("da them sp vao cua hang");
            this.Close();
           
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
