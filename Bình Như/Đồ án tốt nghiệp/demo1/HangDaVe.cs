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

            //load CTSP
            dsctsp = customerCTSPBUS.LayDsCTSP();
            bsctsp.DataSource = dsctsp.ToList();
        }
        private void aotu()
        {
            string kt = "0";
            foreach (CTPhieuXuatDTO cv in dsctpx)
            {
                kt = "0";
                SanPhamDTO NewKH = new SanPhamDTO();
                CTSanPhamDTO NewCT = new CTSanPhamDTO();
                foreach (CTSanPhamDTO ct in dsctsp)
                {
                    if (cv.MaSP == ct.MaSP && cv.MaMau==ct.MaMau && cv.MaSize==ct.KichThuoc
                        && ct.MaCH==macuahang)
                    {
                        CTSanPhamDTO layCTSPupdate()
                        {
                            string slcuakho = ct.SoLuong;
                            string slnhapvaomoi = cv.SoLuong;
                            float slcuakhoint = Int32.Parse(slcuakho);
                            float slnhapvaomoiint = Int32.Parse(slnhapvaomoi);
                            float tongslhang = slcuakhoint + slnhapvaomoiint;
                            NewCT.MaCTSP = ct.MaCTSP;
                            NewCT.SoLuong = tongslhang.ToString();
                            return NewCT;
                        }
                        kt = "16062000";
                        CTSanPhamDTO CTSPUD = layCTSPupdate();
                        bool kqctsp = customerCTSPBUS.UpdateNV(CTSPUD);
                    }  
                }
                if (kt !="16062000")
                {
                    CTSanPhamDTO layCTSP_moi()
                    {
                        NewCT.MaCTSP = cv.MaSP +cv.MaMau+cv.MaSize+ DateTime.Now.ToString("ddMMyyyyHHmmss");
                        NewCT.MaSP = cv.MaSP;
                        NewCT.MaMau = cv.MaMau;
                        NewCT.KichThuoc = cv.MaSize;
                        NewCT.SoLuong = cv.SoLuong;
                        NewCT.MaCH = macuahang;
                        NewCT.TrangThai = "1";
                        return NewCT;
                    }
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
