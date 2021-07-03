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
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            
            Load_Form();
            loadtheongay();
        }
        ChamCongBUS customerBUS = new ChamCongBUS();
        BindingSource bs = new BindingSource();
        List<ChamCongDTO> dskhs = new List<ChamCongDTO>();

        //nhan vien
        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource bsnv = new BindingSource();
        List<NhanVienDTO> dskh = new List<NhanVienDTO>();
        List<NhanVienDTO> dskhngay = new List<NhanVienDTO>();
        //chuc vu
        ChucVuBUS customerCVBUS = new ChucVuBUS();
        BindingSource bscv = new BindingSource();
        List<ChucVuDTO> dscv = new List<ChucVuDTO>();
        //luongnhanvien
        LuongNhanVienBUS customerLuongBUS = new LuongNhanVienBUS();
        BindingSource bsluong = new BindingSource();
        List<LuongNhanVienDTO> dsluong = new List<LuongNhanVienDTO>();
        private void Load_Form()
        {
            Load_DSKH();
            txtsogiolam.Visible = false;
            laysogiolam.Visible = false;
            dtpngaychamcong.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpngaycham.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Load_DSKH()
        {
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDssp(ngay);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
            //nhanvien
            dskh = customerNVBUS.LayDskh();
            bsnv.DataSource = dskh.ToList();
            nhanvien.DataSource = bsnv;
            //cell call
           
            //chuc vu
            dscv = customerCVBUS.LayDskh();
            bscv.DataSource = dscv.ToList();
        }
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                txtsogiolam.Visible = false;
                laysogiolam.Visible = false;
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtmanv.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                foreach (NhanVienDTO nv in dskh)
                {
                    if (nv.MaNV.Equals(dtgv_ttkh.Rows[i].Cells[0].Value.ToString()))
                    {
                        txttennv.Text = nv.TenNV;
                        txtsdt.Text = nv.SDT;
                        txtchucvu.Text = nv.MaCV;
                        if (nv.MaCV == "PT")
                        {
                            txtsogiolam.Visible = true;
                            laysogiolam.Visible = true;
                            txtsogiolam.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                        }
                    }
                    foreach (ChucVuDTO cv in dscv)
                    {
                        if (cv.MaCV.Equals(txtchucvu.Text))
                        {
                            txtchucvu.Text = cv.TenChucVu;
                        }
                    }
                }
            }
        }
        private void reset()
        {
            txtchucvu.Text = "";
            txtmanv.Text = "";
            txtsogiolam.Text = "";
            txttangca.Text = "";
            txttennv.Text = "";
            txtsdt.Text = "";
        }
        private ChamCongDTO layTTSP_moi()
        {
            ChamCongDTO NewSP = new ChamCongDTO();

            NewSP.MaCC = txtmanv.Text + dtpngaycham.Value.ToString("dd/MM/yyyy");
            NewSP.MaNV = string.IsNullOrEmpty(txtmanv.Text) ? "" : txtmanv.Text;
            NewSP.Ngay = dtpngaycham.Value.ToString("dd/MM/yyyy");
            if (txtsogiolam.Visible == true)
            {
                NewSP.SoGioLam = string.IsNullOrEmpty(txtsogiolam.Text) ? "" : txtsogiolam.Text;
                NewSP.TrangThaiChamCong = "NV PartTime";
            }
            else
            {
                NewSP.SoGioLam = "X";
                NewSP.TrangThaiChamCong = "Cả ngày";
            }
            //NewSP.TrangThaiChamCong = string.IsNullOrEmpty(txtMaKH.Text) ? "" : txtMaKH.Text;
            NewSP.TangCa = string.IsNullOrEmpty(txttangca.Text) ? "" : txttangca.Text;
            NewSP.TrangThai = "1";
            return NewSP;
        }
        //private HoaDonDTO layTTSP_sua()
        //{
        //    HoaDonDTO NewSP = new HoaDonDTO();
        //    NewSP.TongTien = string.IsNullOrEmpty(txtTongTien.Text) ? "" : txtTongTien.Text;
        //    return NewSP;
        //}
       
        private void Them_Click_1(object sender, EventArgs e)
        {
            ChamCongDTO khAdd = layTTSP_moi();
            if (khAdd.MaCC == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                bool kq = customerBUS.DKSP(khAdd);
                MessageBox.Show("Thêm sản phẩm");
                CTHoaDon cthd = new CTHoaDon();

                cthd.Show();
                Load_Form();
            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Load_DSKH();
            int intMaHD = dtgv_ttkh.Rows.Count;

        }

        private void Them_Click(object sender, EventArgs e)
        {
            int kiemtranhanvienchamcong = 0;
            ChamCongDTO khAdd = layTTSP_moi();
            if (khAdd.MaCC == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                foreach (ChamCongDTO cv in dskhs)
                {
                    if (cv.MaCC.Equals(txtmanv.Text + DateTime.Now.ToString("dd/MM/yyyy")))
                    {
                        kiemtranhanvienchamcong = 1;
                    }
                }
                if (kiemtranhanvienchamcong == 1)
                {
                    MessageBox.Show("Nhân viên này bạn đã chấm công hôm nay rồi");
                }
                else
                {
                    bool kq = customerBUS.DKSP(khAdd);
                    MessageBox.Show("Chấm công thành công");
                   // Load_Form();
                    loadtheongay();
                }
            }
            reset();
        }

        private void nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nhanvien.SelectedCells.Count > 0)
            {
                int i;
                i = nhanvien.CurrentRow.Index;
                txtmanv.Text = nhanvien.Rows[i].Cells[1].Value.ToString();
                txttennv.Text = nhanvien.Rows[i].Cells[2].Value.ToString();
                txtsdt.Text = nhanvien.Rows[i].Cells[3].Value.ToString();
                txtchucvu.Text = nhanvien.Rows[i].Cells[4].Value.ToString();
                if (txtchucvu.Text == "PT")
                {
                    txtsogiolam.Visible = true;
                    laysogiolam.Visible = true;
                    txttangca.Enabled = false;
                }
                else
                {
                    txtsogiolam.Visible = false;
                    laysogiolam.Visible = false;
                    txttangca.Enabled = true;
                }
                foreach (ChucVuDTO cv in dscv)
                {
                    if (cv.MaCV.Equals(txtchucvu.Text))
                    {
                        txtchucvu.Text = cv.TenChucVu;
                    }
                }
            }
        }

        private void dtpngaychamcong_ValueChanged(object sender, EventArgs e)
        {
            dtpngaycham.Text = dtpngaychamcong.Value.ToString("dd/MM/yyyy");
            loadtheongay();
        }
        private void loadtheongay()
        {
            string ngay = dtpngaychamcong.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDssp(ngay);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
            //load duwx lieeuj bangr chaams cong nhan vien
            string manhanvien = "";
            string manhanvien1 = "";
            string manhanvien2= "";
            string manhanvien3 = "";
            string manhanvien4 = "";
            string manhanvien5 = "";
            string manhanvien6 = "";
            string manhanvien7 = "";
            string manhanvien8 = "";
            string manhanvien9 = "";
            string manhanvien10 = "";
            string manhanvien11 = "";
            string manhanvien12 = "";
            string manhanvien13 = "";
            string manhanvien14 = "";
            string manhanvien15 = "";
            string manhanvien16 = "";
            string manhanvien17 = "";
            string manhanvien18 = "";
            string manhanvien19 = "";
            string manhanvien20 = "";
            int kts = 0;
            int kt = 0;
            foreach (ChamCongDTO chamcong in dskhs)
            {
                
                if (chamcong.Ngay.Equals(ngay))
                {
                    kt++;
                    if (kts==0)
                    {
                        manhanvien = chamcong.MaNV;
                        kts++;
                        kt++;
                    }
                  if(kts==1 && manhanvien!=chamcong.MaNV)
                    {
                        manhanvien1 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 2 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV)
                    {
                        manhanvien2 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 3 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV )
                    {
                        manhanvien3 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 4 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV)
                    {
                        manhanvien4 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 5 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV)
                    {
                        manhanvien5 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 6 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV)
                    {
                        manhanvien6 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 7 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV && manhanvien6 != chamcong.MaNV)
                    {
                        manhanvien7 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 8 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV)
                    {
                        manhanvien8 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 9 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV)
                    {
                        manhanvien1 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 10 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV)
                    {
                        manhanvien10 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 11 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV)
                    {
                        manhanvien11 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 12 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV)
                    {
                        manhanvien12 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 13 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV)
                    {
                        manhanvien13 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 14 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV)
                    {
                        manhanvien14 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 15 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV)
                    {
                        manhanvien15 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 16 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV)
                    {
                        manhanvien16 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 17 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV && manhanvien16 != chamcong.MaNV)
                    {
                        manhanvien17 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 18 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV && manhanvien16 != chamcong.MaNV && manhanvien17 != chamcong.MaNV)
                    {
                        manhanvien18 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 19 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV && manhanvien16 != chamcong.MaNV && manhanvien17 != chamcong.MaNV
                           && manhanvien18 != chamcong.MaNV)
                    {
                        manhanvien19 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 20 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV && manhanvien16 != chamcong.MaNV && manhanvien17 != chamcong.MaNV
                           && manhanvien18 != chamcong.MaNV && manhanvien19 != chamcong.MaNV)
                    {
                        manhanvien20 = chamcong.MaNV;
                        kts++;
                    }
                    dskh = customerNVBUS.LayDskhNgay(manhanvien, manhanvien1, manhanvien2, manhanvien3, manhanvien4, manhanvien5, manhanvien6, manhanvien7,
                manhanvien8, manhanvien9, manhanvien10, manhanvien11, manhanvien12, manhanvien13, manhanvien14, manhanvien15, manhanvien16,
                manhanvien17, manhanvien18, manhanvien19, manhanvien20);
                    bsnv.DataSource = dskh.ToList();
                    nhanvien.DataSource = bsnv;
                }
                if (kt == 0)
                {
                    dskh = customerNVBUS.LayDskh();
                    bsnv.DataSource = dskh.ToList();
                    nhanvien.DataSource = bsnv;
                }
            }
            if (kt == 0)
            {
                dskh = customerNVBUS.LayDskh();
                bsnv.DataSource = dskh.ToList();
                nhanvien.DataSource = bsnv;
            }
        }
        private void loadtheongaycham()
        {
            string ngay = dtpngaycham.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDssp(ngay);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
            //load duwx lieeuj bangr chaams cong nhan vien
            string manhanvien = "";
            string manhanvien1 = "";
            string manhanvien2 = "";
            string manhanvien3 = "";
            string manhanvien4 = "";
            string manhanvien5 = "";
            string manhanvien6 = "";
            string manhanvien7 = "";
            string manhanvien8 = "";
            string manhanvien9 = "";
            string manhanvien10 = "";
            string manhanvien11 = "";
            string manhanvien12 = "";
            string manhanvien13 = "";
            string manhanvien14 = "";
            string manhanvien15 = "";
            string manhanvien16 = "";
            string manhanvien17 = "";
            string manhanvien18 = "";
            string manhanvien19 = "";
            string manhanvien20 = "";
            int kts = 0;
            int kt = 0;
            foreach (ChamCongDTO chamcong in dskhs)
            {
               
                if (chamcong.Ngay.Equals(ngay))
                {
                    kt++;
                    if (kts == 0)
                    {
                        manhanvien = chamcong.MaNV;
                        kts++;
                        kt++;
                    }
                    if (kts == 1 && manhanvien != chamcong.MaNV)
                    {
                        manhanvien1 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 2 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV)
                    {
                        manhanvien2 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 3 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV)
                    {
                        manhanvien3 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 4 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV)
                    {
                        manhanvien4 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 5 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV)
                    {
                        manhanvien5 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 6 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV)
                    {
                        manhanvien6 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 7 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV && manhanvien6 != chamcong.MaNV)
                    {
                        manhanvien7 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 8 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV)
                    {
                        manhanvien8 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 9 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV)
                    {
                        manhanvien1 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 10 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV)
                    {
                        manhanvien10 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 11 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV)
                    {
                        manhanvien11 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 12 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV)
                    {
                        manhanvien12 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 13 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV)
                    {
                        manhanvien13 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 14 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV)
                    {
                        manhanvien14 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 15 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV)
                    {
                        manhanvien15 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 16 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV)
                    {
                        manhanvien16 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 17 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV && manhanvien16 != chamcong.MaNV)
                    {
                        manhanvien17 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 18 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV && manhanvien16 != chamcong.MaNV && manhanvien17 != chamcong.MaNV)
                    {
                        manhanvien18 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 19 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV && manhanvien16 != chamcong.MaNV && manhanvien17 != chamcong.MaNV
                           && manhanvien18 != chamcong.MaNV)
                    {
                        manhanvien19 = chamcong.MaNV;
                        kts++;
                    }
                    if (kts == 20 && manhanvien != chamcong.MaNV && manhanvien1 != chamcong.MaNV && manhanvien2 != chamcong.MaNV
                       && manhanvien3 != chamcong.MaNV && manhanvien4 != chamcong.MaNV && manhanvien5 != chamcong.MaNV &&
                       manhanvien6 != chamcong.MaNV && manhanvien7 != chamcong.MaNV && manhanvien8 != chamcong.MaNV
                       && manhanvien9 != chamcong.MaNV && manhanvien10 != chamcong.MaNV && manhanvien11 != chamcong.MaNV
                       && manhanvien12 != chamcong.MaNV && manhanvien13 != chamcong.MaNV && manhanvien14 != chamcong.MaNV
                       && manhanvien15 != chamcong.MaNV && manhanvien16 != chamcong.MaNV && manhanvien17 != chamcong.MaNV
                           && manhanvien18 != chamcong.MaNV && manhanvien19 != chamcong.MaNV)
                    {
                        manhanvien20 = chamcong.MaNV;
                        kts++;
                    }
                    dskh = customerNVBUS.LayDskhNgay(manhanvien, manhanvien1, manhanvien2, manhanvien3, manhanvien4, manhanvien5, manhanvien6, manhanvien7,
                manhanvien8, manhanvien9, manhanvien10, manhanvien11, manhanvien12, manhanvien13, manhanvien14, manhanvien15, manhanvien16,
                manhanvien17, manhanvien18, manhanvien19, manhanvien20);
                    bsnv.DataSource = dskh.ToList();
                    nhanvien.DataSource = bsnv;
                }
                if (kt == 0)
                {
                    dskh = customerNVBUS.LayDskh();
                    bsnv.DataSource = dskh.ToList();
                    nhanvien.DataSource = bsnv;
                }
            }
            if (kt == 0)
            {
                dskh = customerNVBUS.LayDskh();
                bsnv.DataSource = dskh.ToList();
                nhanvien.DataSource = bsnv;
            }
        }
        private void dtpngaycham_ValueChanged(object sender, EventArgs e)
        {
            dtpngaychamcong.Text= dtpngaycham.Value.ToString("dd/MM/yyyy");
            loadtheongaycham();
        }

        private void dtgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtmanv.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                dskh = customerNVBUS.LayDskh();
                //bsnv.DataSource = dskh.ToList();
                foreach (NhanVienDTO nv in dskh)
                {
                    if (nv.MaNV.Equals(txtmanv.Text))
                    {
                        txttennv.Text = nv.TenNV;
                        foreach (ChucVuDTO cv in dscv)
                        {
                            if (cv.MaCV.Equals(nv.MaCV))
                            {
                                txtchucvu.Text = cv.TenChucVu;
                            }
                        }
                        txtsdt.Text = nv.SDT;
                        if (nv.MaCV == "PT")
                        {
                            txtsogiolam.Visible = true;
                            laysogiolam.Visible = true;
                            txttangca.Enabled = false;
                            txttangca.Text = "";
                            txtsogiolam.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
                        }
                        if (nv.MaCV != "PT")
                        {
                            txtsogiolam.Visible = false;
                            laysogiolam.Visible = false;
                            txttangca.Enabled = true;
                            txttangca.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                        }
                    }   
                }
                
            }
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            ChamCongDTO khAdd = layTTSP_moi();
            if (khAdd.MaCC == "" || khAdd.MaNV == "")
            {
                MessageBox.Show("Vui lòng chọn ngày công!!");
                return;
            }
            else
            {
                ChamCongDTO nv = layTTSP_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                loadtheongay();
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            ChamCongDTO khAdd = layTTSP_moi();
            if (khAdd.MaCC == "" || khAdd.MaNV == "")
            {
                MessageBox.Show("Vui lòng chọn chucws vụ!!");
                return;
            }
            else
            {
                ChamCongDTO nv = layTTSP_moi();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa ngày công: " + txttennv.Text);
                reset();
                loadtheongay();
            }
        }
    }
}

