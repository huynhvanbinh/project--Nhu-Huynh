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
    public partial class LuongNhanVien : Form
    {
        public LuongNhanVien()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
            aotu();
            Load_Form();
        }
        LuongNhanVienBUS customerBUS = new LuongNhanVienBUS();
        BindingSource bs = new BindingSource();
        List<LuongNhanVienDTO> dskhs = new List<LuongNhanVienDTO>();

        // load text chamcong
        ChamCongBUS customerCCBUS = new ChamCongBUS();
        BindingSource bscc = new BindingSource();
        List<ChamCongDTO> dscc = new List<ChamCongDTO>();
        //load chuc vu
        ChucVuBUS customerCVBUS = new ChucVuBUS();
        BindingSource bscv = new BindingSource();
        List<ChucVuDTO> dscv = new List<ChucVuDTO>();
        //load nhan vien
        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource bsnv = new BindingSource();
        List<NhanVienDTO> dsnv = new List<NhanVienDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskhs = customerBUS.LayDskh();
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;

            //load cham cong
            dscc = customerCCBUS.LayDsspdk();
            bscc.DataSource = dscc.ToList();
          
            //
            aotu();
            //load thang hien tai
            txtthang.Text = DateTime.Now.ToString("MM");
            txtnam.Text = DateTime.Now.ToString("yyyy");
            loadtheothangnan();

            //load chuc vu
            dscv = customerCVBUS.LayDskh();
            bscv.DataSource = dscv.ToList();
            //load nhanvien
            dsnv = customerNVBUS.LayDskh();
            bscv.DataSource = dsnv.ToList();
        }
        private LuongNhanVienDTO layTTKH_moi()
        {
            LuongNhanVienDTO NewKH = new LuongNhanVienDTO();
          
            NewKH.Thang = DateTime.Now.ToString("MM");
            NewKH.Nam = DateTime.Now.ToString("yyyy");
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private void aotu()
        {
            string kt = "";
            foreach (ChamCongDTO cv in dscc)
            {
                LuongNhanVienDTO NewKH = new LuongNhanVienDTO();
                LuongNhanVienDTO layTTKH_moi()
                {
                    NewKH.MaLuong = cv.MaNV + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("yyyy");
                    NewKH.MaNV = cv.MaNV;
                    kt = cv.MaNV;
                    int tongngay = 0;
                    int tangca = 0;
                    int phuc = 0;
                    int luongpt=0;
                    foreach (ChamCongDTO cvngay in dscc)
                    {
                        if (cvngay.MaNV.Equals(cv.MaNV))
                        {
                            tongngay++;
                            if (cvngay.TangCa != "")
                            {
                                int doidonvi = Int32.Parse(cvngay.TangCa);
                                tangca = tangca + doidonvi;
                                phuc++;
                            }
                            if(cv.MaNV== "PT-0 5")
                            {
                                int lpt= Int32.Parse(cvngay.SoGioLam);
                                luongpt = luongpt + lpt;
                            }    
                        }
                    }
                    int luongtangca = phuc * 2500;
                    NewKH.PhuCap = luongtangca.ToString() +" VNĐ";
                    NewKH.SoNgayLam = tongngay.ToString();
                    NewKH.TangCa = tangca.ToString()+ " Giờ";
                    NewKH.Thang = DateTime.Now.ToString("MM");
                    NewKH.Nam = DateTime.Now.ToString("yyyy");
                    NewKH.LuongCoBan = "10000";
                    int tiennvlanh = luongtangca + tongngay * 10000;
                    NewKH.TienLanh = tiennvlanh.ToString() + " VNĐ";
                    if (cv.MaNV=="PT")
                    {
                        NewKH.TangCa = "";
                        NewKH.PhuCap = "";
                        NewKH.LuongCoBan = "";
                        NewKH.SoGioLam = luongpt.ToString() +" Giờ";
                        NewKH.LuongPartTime = "2000";
                        int luongppt= luongpt * 2000;
                        NewKH.TienLanh = luongppt.ToString() + " VNĐ";
                    }
                    NewKH.TrangThai = "1";
                    return NewKH;
                }
                if (cv.MaNV != kt)
                {
                    LuongNhanVienDTO khAdd = layTTKH_moi();
                    bool kq = customerBUS.DKKH(khAdd);
                } 
            }
        }
        private LuongNhanVienDTO layTTKH_delete()
        {
            LuongNhanVienDTO NewKH = new LuongNhanVienDTO();
            NewKH.Thang = DateTime.Now.ToString("MM");
            NewKH.Nam = DateTime.Now.ToString("yyyy");
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private void reset()
        {
          
        }
        private void Them_Click_1(object sender, EventArgs e)
        {
            LuongNhanVienDTO khAdd = layTTKH_moi();
            if (khAdd.MaLuong == "" || khAdd.MaNV == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                bool kq = customerBUS.DKKH(khAdd);
                MessageBox.Show("Thêm thành công");
                reset();
                Load_Form();
            }
        }
        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private LuongNhanVienDTO layTTSP_sua()
        {
            LuongNhanVienDTO NewKH = new LuongNhanVienDTO();
           
            NewKH.TrangThai = "0";
            return NewKH;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            LuongNhanVienDTO khAdd = layTTKH_delete();
            if (khAdd.MaLuong == "" || khAdd.MaNV == "")
            {
                MessageBox.Show("Vui lòng chọn màu sửa!!");
                return;
            }
            else
            {
                LuongNhanVienDTO nv = layTTKH_delete();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            LuongNhanVienDTO khAdd = layTTKH_moi();
            if (khAdd.MaLuong == "" || khAdd.MaLuong == "")
            {
                MessageBox.Show("Vui lòng chọn chucws vụ!!");
                return;
            }
            else
            {
                LuongNhanVienDTO nv = layTTSP_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa chức vụ: ");
                reset();
                Load_Form();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //thuong nhan vien
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dtgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //In Bảng Lương Nhân Viên
            InLuongNhanVien inluong = new InLuongNhanVien();
            inluong.Show();
        }

       
        private void loadtheothangnan()
        {
            string ma = txtthang.Text;
            string nam = txtnam.Text;
            if (ma == "Tất cả")
            {
                dskhs = customerBUS.LayDskh();
                bs.DataSource = dskhs.ToList();
                dtgv_ttkh.DataSource = bs;
            }
            else
            {
                dskhs = customerBUS.LayDsLT(ma, nam);
                bs.DataSource = dskhs.ToList();
                dtgv_ttkh.DataSource = bs;
            }
        }

        private void cmbloaisanpham_onItemSelected_1(object sender, EventArgs e)
        {
            txtthang.Text = cmbloaisanpham.selectedValue;
            loadtheothangnan();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            txtnam.Text = bunifuDropdown1.selectedValue;
            loadtheothangnan();
        }

        private void LuongNhanVien_Load(object sender, EventArgs e)
        {
            foreach (ChucVuDTO sps in dscv)
            {
                cmbchucvu.Items.Add(sps.TenChucVu.ToString());
            }
        }

        private void cmbchucvu_onItemSelected(object sender, EventArgs e)
        {
            foreach (ChucVuDTO sps in dscv)
            {
                if (cmbchucvu.selectedValue == sps.TenChucVu)
                {
                    foreach (NhanVienDTO nv in dsnv)
                    {
                        if (nv.MaCV == sps.MaCV)
                        {

                            string ma = txtthang.Text;
                            string nam = txtnam.Text;
                            string manv = nv.MaNV;
                            if (ma == "Tất cả")
                            {
                                dskhs = customerBUS.LayDskh();
                                bs.DataSource = dskhs.ToList();
                                dtgv_ttkh.DataSource = bs;
                            }
                            else
                            {
                                dskhs = customerBUS.LayDsLTMA(ma, nam, manv);
                                bs.DataSource = dskhs.ToList();
                                dtgv_ttkh.DataSource = bs;
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (NhanVienDTO nv in dsnv)
            {
                foreach (NhanVienDTO l in dsnv)
                {
                    if (nv.MaNV == l.MaNV)
                    {
                        string ma = txtthang.Text;
                        string nam = txtnam.Text;
                        string manv = nv.MaNV;
                        string noidung = txtnoidungtimkiem.Text;
                        if (ma == "Tất cả")
                        {
                            dskhs = customerBUS.LayDskh();
                            bs.DataSource = dskhs.ToList();
                            dtgv_ttkh.DataSource = bs;
                        }
                        else
                        {
                            dskhs = customerBUS.LayDsTK(ma, nam, noidung);
                            bs.DataSource = dskhs.ToList();
                            dtgv_ttkh.DataSource = bs;
                        }
                    }
                }
            }
        }
    }
}
