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
    public partial class CuaHang : Form
    {
        public CuaHang()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        CuaHangBUS customerBUS = new CuaHangBUS();
        BindingSource bs = new BindingSource();
        List<CuaHangDTO> dskhs = new List<CuaHangDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskhs = customerBUS.LayDsch();
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
        }
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtMaChucVu.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtTenChucVu.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                txtdiachi.Text= dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
            }
        }
        private CuaHangDTO layTTKH_moi()
        {
            CuaHangDTO NewKH = new CuaHangDTO();
            NewKH.MaCH = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenCH = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.DiaChi= string.IsNullOrEmpty(txtdiachi.Text) ? "" : txtdiachi.Text;
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private void reset()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            txtdiachi.Text = "";
        }
        private void Them_Click_1()
        {
            CuaHangDTO khAdd = layTTKH_moi();
            if (khAdd.MaCH == ""||khAdd.TenCH==""||khAdd.DiaChi=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                bool kq = customerBUS.DKCH(khAdd);
                MessageBox.Show("Thêm thành công");
                reset();
                Load_Form();
            }    
           
        }
        private void bunifuButton3_Click_1()
        {
            reset();
        }
        private CuaHangDTO layTTSP_sua()
        {
            CuaHangDTO NewKH = new CuaHangDTO();
            NewKH.MaCH = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }

        private void bunifuButton2_Click()
        {
            CuaHangDTO khAdd = layTTKH_moi();
            if (khAdd.MaCH == "" || khAdd.TenCH == ""||khAdd.DiaChi=="")
            {
                MessageBox.Show("Vui lòng chọn cuawr hangf sửa!!");
                return;
            }
            else
            {
                CuaHangDTO nv = layTTKH_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }
        }

        private void Xóa_Click()
        {
            CuaHangDTO khAdd = layTTKH_moi();
            if (khAdd.MaCH == "" || khAdd.TenCH == "" || khAdd.DiaChi == "")
            {
                MessageBox.Show("Vui lòng chọn cửa hàng");
                return;
            }
            else
            {
                CuaHangDTO nv = layTTSP_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa một cửa hàng");
                reset();
                Load_Form();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them_Click_1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xóa_Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuButton2_Click();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
