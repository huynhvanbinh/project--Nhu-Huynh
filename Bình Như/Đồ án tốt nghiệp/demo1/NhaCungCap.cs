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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        NhaCungCapBUS customerBUS = new NhaCungCapBUS();
        BindingSource bs = new BindingSource();
        List<NhaCungCapDTO> dskhs = new List<NhaCungCapDTO>();
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
                txtsdt.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                txtemail.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
                txtdiachi.Text = dtgv_ttkh.Rows[i].Cells[4].Value.ToString();
            }
        }
        private NhaCungCapDTO layTTKH_moi()
        {
            NhaCungCapDTO NewKH = new NhaCungCapDTO();
            NewKH.MaNCC = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenNCC = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.SDT = string.IsNullOrEmpty(txtsdt.Text) ? "" : txtsdt.Text;
            NewKH.Email = string.IsNullOrEmpty(txtemail.Text) ? "" : txtemail.Text;
            NewKH.DiaChi = string.IsNullOrEmpty(txtdiachi.Text) ? "" : txtdiachi.Text;
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private void reset()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
        }
        private void Them_Click_1()
        {
            NhaCungCapDTO khAdd = layTTKH_moi();
            if (khAdd.MaNCC == "" ||khAdd.TenNCC==""||khAdd.SDT==""||khAdd.DiaChi=="")
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
        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            reset();
        }
        private NhaCungCapDTO layTTSP_sua()
        {
            NhaCungCapDTO NewKH = new NhaCungCapDTO();
            NewKH.MaNCC = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }

        private void bunifuButton2_Click()
        {
            NhaCungCapDTO khAdd = layTTKH_moi();
            if (khAdd.MaNCC == "" || khAdd.TenNCC == "" || khAdd.SDT == "" || khAdd.DiaChi == "")
            {
                MessageBox.Show("Vui lòng chọn màu sửa!!");
                return;
            }
            else
            {
                NhaCungCapDTO nv = layTTKH_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }
        }

        private void Xóa_Click()
        {
            NhaCungCapDTO khAdd = layTTKH_moi();
            if (khAdd.MaNCC == "" || khAdd.TenNCC == "" || khAdd.SDT == "" || khAdd.DiaChi == "")
            {
                MessageBox.Show("Vui lòng chọn màu xóa!!");
                return;
            }
            else
            {
                NhaCungCapDTO nv = layTTSP_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa một nhà cung cấp");
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
