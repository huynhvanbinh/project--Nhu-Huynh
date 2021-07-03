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
    public partial class ChucVu : Form
    {
        public ChucVu()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        ChucVuBUS customerBUS = new ChucVuBUS();
        BindingSource bs = new BindingSource();
        List<ChucVuDTO> dskhs = new List<ChucVuDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskhs = customerBUS.LayDskh();
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
            }
        }
        private ChucVuDTO layTTKH_moi()
        {
            ChucVuDTO NewKH = new ChucVuDTO();
            NewKH.MaCV = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenChucVu = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.TrangThai = "1";
            return NewKH;
        }  
        private void reset()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }
        
        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {

        }
        private ChucVuDTO layTTSP_sua()
        {
            ChucVuDTO NewKH = new ChucVuDTO();
            NewKH.MaCV = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenChucVu = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }

        private void bunifuButton2_Click()
        {
            ChucVuDTO khAdd = layTTKH_moi();
            if (khAdd.MaCV == "" || khAdd.TenChucVu == "")
            {
                MessageBox.Show("Vui lòng chọn màu sửa!!");
                return;
            }
            else
            {
                ChucVuDTO nv = layTTKH_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }
        }

        private void Xóa_Click()
        {
            ChucVuDTO khAdd = layTTKH_moi();
            if (khAdd.MaCV == "" || khAdd.TenChucVu == "")
            {
                MessageBox.Show("Vui lòng chọn chucws vụ!!");
                return;
            }
            else
            {
                ChucVuDTO nv = layTTSP_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa chức vụ: " +txtTenChucVu.Text);
                reset();
                Load_Form();
            }
        }

        private void pictureBox1_Click()
        {
            ChucVuDTO khAdd = layTTKH_moi();
            if (khAdd.TenChucVu == "" || khAdd.MaCV == "")
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            pictureBox1_Click();
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
