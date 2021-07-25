using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        NhanVienBUS customerBUS = new NhanVienBUS();
        BindingSource bs = new BindingSource();
        List<NhanVienDTO> dskh = new List<NhanVienDTO>();

        ChucVuBUS customerCVBUS = new ChucVuBUS();
        BindingSource bscv = new BindingSource();
        List<ChucVuDTO> dskhs = new List<ChucVuDTO>();

        CuaHangBUS customerCHBUS = new CuaHangBUS();
        BindingSource bsch = new BindingSource();
        List<CuaHangDTO> dsch = new List<CuaHangDTO>();
        private void Load_Form()
        {
            Load_DSKH();
            labmach.Visible = false;
        }
        private void Load_DSKH()
        {
            dskh = customerBUS.LayDskh();
            bs.DataSource = dskh.ToList();
            dtgv_ttkh.DataSource = bs;
            // khoi tao load du lieu bang chuc vu
            dskhs = customerCVBUS.LayDskh();
            bscv.DataSource = dskhs.ToList();
            //cua hang
            dsch = customerCHBUS.LayDsch();
            bsch.DataSource = dsch.ToList();

        }
       
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtMaNV.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtTenNV.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                txtSoDienThoai.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                txtchucvu.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
            }
        }
        private NhanVienDTO layTTKH_moi()
        {
            NhanVienDTO NewKH = new NhanVienDTO();           
            NewKH.MaNV = string.IsNullOrEmpty(txtMaNV.Text) ? "" : txtMaNV.Text;
            NewKH.TenNV = string.IsNullOrEmpty(txtTenNV.Text) ? "" : txtTenNV.Text;
            NewKH.SDT = string.IsNullOrEmpty(txtSoDienThoai.Text) ? "" : txtSoDienThoai.Text;
            NewKH.MaCV = string.IsNullOrEmpty(txtchucvu.Text) ? "" : txtchucvu.Text;
            NewKH.MaCH=string.IsNullOrEmpty(labmach.Text) ? "" : labmach.Text;
            NewKH.TrangThai = "1";
            return NewKH;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            NhanVienDTO khAdd = layTTKH_moi();
            if (khAdd.TenNV == ""||khAdd.MaNV==""||khAdd.SDT==""||khAdd.MaCV=="")
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
        private void reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSoDienThoai.Text = "";
            txtchucvu.Text = "";
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            reset();
        }

        // load du lieu len combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (ChucVuDTO khs in dskhs)
            {
                cmbchucvu.Items.Add(khs.TenChucVu.ToString());
            }
            //load cua hang
            foreach (CuaHangDTO ch in dsch)
            {
                cmbcuahang.Items.Add(ch.TenCH.ToString());
            }
        }

        private void cmbchucvu_onItemSelected(object sender, EventArgs e)
        {
            Load_DSKH();
            int intMaNV = dtgv_ttkh.Rows.Count;
           
            foreach (ChucVuDTO sps in dskhs)
            {
                if (cmbchucvu.selectedValue == sps.TenChucVu.ToString())
                {
                    txtchucvu.Text = sps.MaCV.ToString();
                    txtMaNV.Text = sps.MaCV + "-0" + " " + intMaNV;
                }
            }
        }

        private void indanhsach(object sender, EventArgs e)
        {
            DSNhanVien dsnv = new DSNhanVien();
            dsnv.Show();
        }
        private NhanVienDTO layTTSP_sua()
        {
            NhanVienDTO NewKH = new NhanVienDTO();
            NewKH.MaNV = string.IsNullOrEmpty(txtMaNV.Text) ? "" : txtMaNV.Text;
            NewKH.TenNV = string.IsNullOrEmpty(txtTenNV.Text) ? "" : txtTenNV.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            NhanVienDTO khAdd = layTTKH_moi();
            if (khAdd.TenNV == "" || khAdd.MaNV == "" || khAdd.SDT == "" || khAdd.MaCV == "")
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên sửa!!");
                return;
            }
            else
            {
                NhanVienDTO nv = layTTKH_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            NhanVienDTO khAdd = layTTKH_moi();
            if (khAdd.TenNV == "" || khAdd.MaNV == "" || khAdd.SDT == "" || khAdd.MaCV == "")
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên xóa!!");
                return;
            }
            else
            {
                NhanVienDTO nv = layTTSP_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa một nhân viên");
                reset();
                Load_Form();
            }
        }

        private void cmbcuahang_onItemSelected(object sender, EventArgs e)
        {
            labmach.Visible = true;
            foreach (CuaHangDTO ch in dsch)
            {
                if (cmbcuahang.selectedValue == ch.TenCH.ToString())
                {
                    labmach.Text = ch.MaCH.ToString();
                }
            }
        }
    }
}
