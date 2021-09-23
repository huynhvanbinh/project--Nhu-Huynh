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
    public partial class LuongNhanViens : Form
    {
        List<classLuongNhanVien> listluongnhanvien;
        public LuongNhanViens()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
            listluongnhanvien = new List<classLuongNhanVien>();
            autolistluong();
        }
        ChamCongBUS customerCCBUS = new ChamCongBUS();
        BindingSource bscc = new BindingSource();
        List<ChamCongDTO> dscc = new List<ChamCongDTO>();
        //nhan vien
        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource bsnv = new BindingSource();
        List<NhanVienDTO> dsnv = new List<NhanVienDTO>();
        //luong nhan vien
        LuongNhanVienBUS customerLNVBUS = new LuongNhanVienBUS();
        BindingSource bslnv = new BindingSource();
        List<LuongNhanVienDTO> dslnv = new List<LuongNhanVienDTO>();

        private void autolistluong()
        {
            foreach (ChamCongDTO cv in dscc)
            {
                int manvdaco = 160600;
                int ngaylam = 0;
                int giolam = 0;
                int tangca = 0;
               
                float hesoluong = 0;
                DateTime hientai = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                DateTime ngay = Convert.ToDateTime(cv.Ngay);
                TimeSpan hople = hientai.Subtract(ngay);
                TimeSpan hoples = ngay.Subtract(hientai);
                int batdau = hople.Days;
                int ketthuc = hoples.Days;
                if(ketthuc>=-31 && batdau>=0)
                {
                    foreach (ChamCongDTO cc in dscc)
                    {
                        if (ketthuc >= -31 && batdau >= 0 && cc.MaNV==cv.MaNV)
                        {
                            if(cc.TrangThaiChamCong== "PartTime")
                            {
                                giolam = giolam + Int32.Parse(cc.SoGioLam);
                            }   
                            else
                            {
                                if(cc.TangCa!="")
                                {
                                    tangca = tangca + Int32.Parse(cc.TangCa);
                                  
                                }    
                                ngaylam++;
                            }                                                        
                        }
                    }
                    foreach (classLuongNhanVien listlnv in listluongnhanvien)
                    {
                        if (listlnv.MaNV == cv.MaNV )
                        {
                            manvdaco = 0;
                        }
                    }
                    if(manvdaco==160600)
                    {
                        int loainv = 04032000;
                        foreach (NhanVienDTO nc in dsnv)
                        {
                            if (nc.MaNV == cv.MaNV && nc.MaCV == "PT")
                            {
                                loainv = 160600;
                            }
                            if (nc.MaNV == cv.MaNV && nc.MaCV != "PT")
                            {
                                DateTime hientais = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                                DateTime ngayvaolam = Convert.ToDateTime(nc.NgayVaoLam);
                                TimeSpan thamnien = hientais.Subtract(ngayvaolam);
                                float sothang = (thamnien.Days)/28;
                                hesoluong = 4 + sothang/20;
                            }
                        }
                        if(loainv==160600)
                        {
                            classLuongNhanVien luongnhanvien = new classLuongNhanVien();
                            luongnhanvien.MaLuong = "LT" + cv.MaNV;
                            luongnhanvien.MaNV = cv.MaNV;
                            luongnhanvien.SoNgayLam = "NV PartTime";
                            luongnhanvien.LuongPartTime = txtluongpt.Text;
                            luongnhanvien.SoGiolam = giolam.ToString();
                            luongnhanvien.TienLanh = (giolam*Int32.Parse(txtluongpt.Text)).ToString();
                            listluongnhanvien.Add(luongnhanvien);
                            dtgv_ttkh.DataSource = null;
                            dtgv_ttkh.DataSource = listluongnhanvien;
                            dtgv_ttkh.Refresh();
                        }    
                        if(loainv==04032000)
                        {
                            classLuongNhanVien luongnhanvien = new classLuongNhanVien();
                            luongnhanvien.MaLuong = "LT" + cv.MaNV;
                            luongnhanvien.MaNV = cv.MaNV;
                            luongnhanvien.SoNgayLam = ngaylam.ToString();
                            luongnhanvien.LuongCoBan = txtluongcoban.Text;
                            luongnhanvien.ThamNien = hesoluong.ToString();
                            luongnhanvien.TangCa = tangca.ToString();
                            int phucap = Int32.Parse(txtphucap.Text) * Int32.Parse(tangca.ToString());
                            luongnhanvien.PhuCap = phucap.ToString();
                            float luong1ngay = (Int32.Parse(txtluongcoban.Text) * hesoluong) / 28;
                            luongnhanvien.TienLanh = (ngaylam*luong1ngay+phucap).ToString();
                            luongnhanvien.Thuong = "0";
                            listluongnhanvien.Add(luongnhanvien);
                            dtgv_ttkh.DataSource = null;
                            dtgv_ttkh.DataSource = listluongnhanvien;
                            dtgv_ttkh.Refresh();
                        }    
                    }                    
                }
               
            }              
        }
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            //load cham cong
            dscc = customerCCBUS.LayDsspdk();
            bscc.DataSource = dscc.ToList();
            //load nhan vien
            dsnv = customerNVBUS.LayDskh();
            bsnv.DataSource = dscc.ToList();
            //load luong nhan vien
            dslnv = customerLNVBUS.LayDskh();
            bslnv.DataSource = dscc.ToList();
            //load txt
            txtluongcoban.Text = "180000";
            txtphucap.Text = "2000";
            txtluongpt.Text = "1500";
        }

        private void txtluongcoban_TextChanged(object sender, EventArgs e)
        {
            int index = -1;
            foreach (classLuongNhanVien listlnv in listluongnhanvien)
            {
                index++;
                if(listlnv.LuongCoBan != null)
                {
                    listluongnhanvien[index].LuongCoBan = txtluongcoban.Text;
                    int tangca = Int32.Parse(listluongnhanvien[index].TangCa);
                    int phucap = Int32.Parse(txtphucap.Text) * Int32.Parse(tangca.ToString());
                    float hesoluong = float.Parse(listluongnhanvien[index].ThamNien);
                    int ngaylam = Int32.Parse(listluongnhanvien[index].SoNgayLam);
                    float luong1ngay = (Int32.Parse(txtluongcoban.Text) * hesoluong) / 28;
                    listluongnhanvien[index].TienLanh = (ngaylam * luong1ngay + phucap).ToString();
                }                    
            } 
            dtgv_ttkh.DataSource = null;
            dtgv_ttkh.DataSource = listluongnhanvien;
            dtgv_ttkh.Refresh();
        }

        private void txtphucap_TextChanged(object sender, EventArgs e)
        {
            int index = -1;
            foreach (classLuongNhanVien listlnv in listluongnhanvien)
            {
                index++;
                if (listlnv.PhuCap != null)
                {
                    int tangca = Int32.Parse(listluongnhanvien[index].TangCa);
                    int phucap = Int32.Parse(txtphucap.Text) * Int32.Parse(tangca.ToString());
                    listluongnhanvien[index].PhuCap = phucap.ToString();
                    float hesoluong = float.Parse(listluongnhanvien[index].ThamNien);
                    int ngaylam = Int32.Parse(listluongnhanvien[index].SoNgayLam);
                    float luong1ngay = (Int32.Parse(txtluongcoban.Text) * hesoluong) / 28;
                    listluongnhanvien[index].TienLanh = (ngaylam * luong1ngay + phucap).ToString();
                }
            }
            dtgv_ttkh.DataSource = null;
            dtgv_ttkh.DataSource = listluongnhanvien;
            dtgv_ttkh.Refresh();
        }

        private void txtluongpt_TextChanged(object sender, EventArgs e)
        {
            int index = -1;
            foreach (classLuongNhanVien listlnv in listluongnhanvien)
            {
                index++;
                if (listlnv.LuongPartTime != null)
                {
                    int giolam = Int32.Parse(listluongnhanvien[index].SoGiolam);
                    listluongnhanvien[index].LuongPartTime = txtluongpt.Text;
                    listluongnhanvien[index].TienLanh = (giolam * Int32.Parse(txtluongpt.Text)).ToString();
                }
            }
            dtgv_ttkh.DataSource = null;
            dtgv_ttkh.DataSource = listluongnhanvien;
            dtgv_ttkh.Refresh();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            foreach (classLuongNhanVien listsp in listluongnhanvien)
            {
                LuongNhanVienDTO layLuong_List()
                {
                    LuongNhanVienDTO NewKH = new LuongNhanVienDTO();
                    NewKH.MaLuong = listsp.MaLuong;
                    NewKH.MaNV = listsp.MaNV;
                    NewKH.LuongCoBan = listsp.LuongCoBan;
                    NewKH.SoNgayLam = listsp.SoNgayLam;
                    NewKH.TangCa = listsp.TangCa;
                    NewKH.ThamNien = listsp.ThamNien;
                    NewKH.PhuCap = listsp.PhuCap;
                    NewKH.Thuong = txtthuong.Text;
                    NewKH.TienLanh = listsp.TienLanh;
                    NewKH.LuongPartTime = listsp.LuongPartTime;
                    NewKH.SoGioLam = listsp.SoGiolam;
                    NewKH.Thuong = listsp.Thuong;
                    NewKH.TrangThai = "1";
                    return NewKH;
                }
                LuongNhanVienDTO khAdd = layLuong_List();
                bool kq = customerLNVBUS.DKKH(khAdd);
            }
            txtluongcoban.Enabled = false;
            txtluongpt.Enabled = false;
            txtphucap.Enabled = false;
            txtthuong.Enabled = false;
            MessageBox.Show("đã chi trả xong lương tháng " + DateTime.Now.ToString("MM"));
        }

        private void txtthuong_TextChanged(object sender, EventArgs e)
        {
            int index = -1;
            foreach (classLuongNhanVien listlnv in listluongnhanvien)
            {
                index++;
                if (listlnv.LuongPartTime == null)
                {
                    listluongnhanvien[index].Thuong = txtthuong.Text;
                    float hesoluong = float.Parse(listluongnhanvien[index].ThamNien);
                    int ngaylam = Int32.Parse(listluongnhanvien[index].SoNgayLam);
                    float luong1ngay = (Int32.Parse(txtluongcoban.Text) * hesoluong) / 28;
                    listluongnhanvien[index].TienLanh = (ngaylam* luong1ngay + Int32.Parse(txtthuong.Text)).ToString();
                }
            }
            dtgv_ttkh.DataSource = null;
            dtgv_ttkh.DataSource = listluongnhanvien;
            dtgv_ttkh.Refresh();
        }
    }
}
