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
            nhanvien.AutoGenerateColumns = false;
            dtpngaychamcong.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Load_Form();
        }
        ChamCongBUS customerBUS = new ChamCongBUS();
        BindingSource bs = new BindingSource();
        List<ChamCongDTO> dskhs = new List<ChamCongDTO>();

        //nhan vien
        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource bsnv = new BindingSource();
        List<NhanVienDTO> dskh = new List<NhanVienDTO>();
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
        }
        public string machpublic;
        private void Load_DSKH()
        {
            dskhs = customerBUS.LayCCCH(dtpngaychamcong.Text, machpublic);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
            //nhanvien
            dskh = customerNVBUS.LayDsnvch(machpublic);
            bsnv.DataSource = dskh.ToList();
            nhanvien.DataSource = bsnv;
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
                    }
                  
                }
            }
        }
  
        private ChamCongDTO layTTSP_moi()
        {
            ChamCongDTO NewSP = new ChamCongDTO();

            NewSP.MaCC = txtmanv.Text + dtpngaychamcong.Value.ToString("dd/MM/yyyy");
            NewSP.MaNV = string.IsNullOrEmpty(txtmanv.Text) ? "" : txtmanv.Text;
            NewSP.Ngay = dtpngaychamcong.Value.ToString("dd/MM/yyyy");
            NewSP.MaCH = machpublic;
            if (txtsogiolam.Visible == true)
            {
                NewSP.SoGioLam = string.IsNullOrEmpty(txtsogiolam.Text) ? "" : txtsogiolam.Text;
                NewSP.TrangThaiChamCong = "PartTime";
            }
            if(txtsogiolam.Visible == false)
            {
                NewSP.TrangThaiChamCong ="đã chấm công";
            }    
            NewSP.TangCa = string.IsNullOrEmpty(txttangca.Text) ? "" : txttangca.Text;
            NewSP.TrangThai = "1";
            return NewSP;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            int kiemtranhanvienchamcong = 0;
            if(CheckControl())
            {
                ChamCongDTO khAdd = layTTSP_moi();
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
                }
                Load_Form();
            }    
        }
        void reset()
        {
            txtmanv.Text = "";
            txtsdt.Text = "";
            txtsogiolam.Text = "";
            txttangca.Text = "";
            txttennv.Text = "";
        }
        private void nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nhanvien.SelectedCells.Count > 0)
            {
                reset();
                int i;
                i = nhanvien.CurrentRow.Index;
                txtmanv.Text = nhanvien.Rows[i].Cells[0].Value.ToString();
                txttennv.Text = nhanvien.Rows[i].Cells[1].Value.ToString();
                txtsdt.Text = nhanvien.Rows[i].Cells[2].Value.ToString();
                if(nhanvien.Rows[i].Cells[3].Value.ToString()=="PT")
                {
                    laysogiolam.Visible = true;
                    txtsogiolam.Visible = true;
                    txttangca.Enabled = false;
                }                  
            }
        }

        private void dtpngaychamcong_ValueChanged(object sender, EventArgs e)
        {
            dskhs = customerBUS.LayCCCH(dtpngaychamcong.Value.ToString("dd/MM/yyyy"), machpublic);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
            reset();
        }
       
        private void dtgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtmanv.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                dskh = customerNVBUS.LayDskh();
                foreach (NhanVienDTO nv in dskh)
                {
                    if (nv.MaNV.Equals(txtmanv.Text))
                    {
                        txttennv.Text = nv.TenNV;
                        
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
            }
        }
        private void ChamCong_Load(object sender, EventArgs e)
        {
            dskh = customerNVBUS.LayDsnvch(machpublic);
            bsnv.DataSource = dskh.ToList();
            nhanvien.DataSource = bsnv;
            //cham cong
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayCCCH(ngay, machpublic);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
        }
        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtmanv.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên chấm công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtsogiolam.Visible == true && txtsogiolam.Text=="")
            {
                MessageBox.Show("nhập số giờ làm", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsogiolam.Focus();
                return false;
            }
            return true;
        }
    }
}

