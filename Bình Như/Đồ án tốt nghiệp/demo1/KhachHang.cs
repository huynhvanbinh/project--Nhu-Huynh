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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        KhachHangBUS customerBUS = new KhachHangBUS();
        BindingSource bs = new BindingSource();
        List<KhachHangDTO> dskhs = new List<KhachHangDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskhs = customerBUS.LayDssp();
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
        }
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtMa.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtTen.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();

            }
        }
        private KhachHangDTO layTTSP_moi()
        {
            KhachHangDTO NewSP = new KhachHangDTO();
            NewSP.SDT = string.IsNullOrEmpty(txtMa.Text) ? "" : txtMa.Text;
            NewSP.TenKH = string.IsNullOrEmpty(txtTen.Text) ? "" : txtTen.Text;
            NewSP.TrangThai = "1";
            return NewSP;
        }
        private void reset()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }
        private void Them_Click_1()
        {
          KhachHangDTO khAdd = layTTSP_moi();
            if (khAdd.SDT == "" || khAdd.TenKH == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                bool kq = customerBUS.DKSP(khAdd);
                MessageBox.Show("Thêm thành công");
                reset();
                Load_Form();
            }
        }
        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            reset();
        }
        private KhachHangDTO layTTSP_sua()
        {
            KhachHangDTO NewKH = new KhachHangDTO();
            NewKH.SDT = string.IsNullOrEmpty(txtMa.Text) ? "" : txtMa.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }

        private void bunifuButton2_Click()
        {
            KhachHangDTO khAdd = layTTSP_moi();
            if (khAdd.SDT == "" || khAdd.TenKH == "")
            {
                MessageBox.Show("Vui lòng chọn màu sửa!!");
                return;
            }
            else
            {
                KhachHangDTO nv = layTTSP_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }
        }

        private void Xóa_Click()
        {
            KhachHangDTO khAdd = layTTSP_moi();
            if (khAdd.SDT == "" || khAdd.TenKH == "")
            {
                MessageBox.Show("Vui lòng chọn sản  phẩm!!");
                return;
            }
            else
            {
                KhachHangDTO nv = layTTSP_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa một loại sản phẩm");
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
    }
}
