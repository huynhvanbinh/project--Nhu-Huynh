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
    public partial class Size : Form
    {
        public Size()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        SizeBUS customerBUS = new SizeBUS();
        BindingSource bs = new BindingSource();
        List<SizeDTO> dskhs = new List<SizeDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskhs = customerBUS.LayDskt();
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
                txtcannang.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
            }
        }
        private SizeDTO layTTKH_moi()
        {
            SizeDTO NewKH = new SizeDTO();
            NewKH.MaSize = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenSize = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.CanNang = string.IsNullOrEmpty(txtcannang.Text) ? "" : txtcannang.Text;
            NewKH.trangThai = "1";
            return NewKH;
        }
        private void reset()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            txtcannang.Text = "";
        }
        private void Them_Click_1()
        {
            SizeDTO khAdd = layTTKH_moi();
            if (khAdd.MaSize == "" || khAdd.TenSize==""||khAdd.CanNang=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            bool kq = customerBUS.DKKT(khAdd);
            MessageBox.Show("Thêm thành công");
            reset();
            Load_Form();
        }
        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void Size_Load(object sender, EventArgs e)
        {

        }
        private SizeDTO layTTSP_sua()
        {
            SizeDTO NewKH = new SizeDTO();
            NewKH.MaSize = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenSize = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.CanNang= string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.trangThai = "0";
            return NewKH;
        }
        private void bunifuButton2_Click()
        {
            SizeDTO kt = layTTKH_moi();
            bool kq = customerBUS.UpdateNV(kt);
            MessageBox.Show("Sửa thành công");
            Load_Form();
        }
        private void Xóa_Click()
        {
            SizeDTO nv = layTTSP_sua();
            bool kq = customerBUS.DELETENV(nv);
            MessageBox.Show("Đã xóa");
            reset();
            Load_Form();
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
