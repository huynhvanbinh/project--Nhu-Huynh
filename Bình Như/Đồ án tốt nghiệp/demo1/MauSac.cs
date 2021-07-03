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
    public partial class MauSac : Form
    {
        public MauSac()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        MauSacBUS customerBUS = new MauSacBUS();
        BindingSource bs = new BindingSource();
        List<MauSacDTO> dskhs = new List<MauSacDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskhs = customerBUS.LayDsmau();
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
        private MauSacDTO layTTKH_moi()
        {
            MauSacDTO NewKH = new MauSacDTO();
                NewKH.MaMau = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
                NewKH.TenMau = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
                NewKH.TrangThai = "1";
            return NewKH;
        }
        private void reset()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }
        private void Them_Click_1()
        {
            MauSacDTO khAdd = layTTKH_moi();
            if (khAdd.TenMau == "" || khAdd.MaMau=="")
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
        //??????????
        private MauSacDTO layTTSP_sua()
        {
            MauSacDTO NewKH = new MauSacDTO();
            NewKH.MaMau = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenMau = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }
        private void ChucVu_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click()
        {
            MauSacDTO khAdd = layTTKH_moi();
            if (khAdd.TenMau == "" || khAdd.MaMau == "")
            {
                MessageBox.Show("Vui lòng chọn màu sửa!!");
                return;
            }
            else
            {
                MauSacDTO nv = layTTKH_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }      
        }

        private void Xóa_Click()
        {
            MauSacDTO khAdd = layTTKH_moi();
            if (khAdd.TenMau == "" || khAdd.MaMau == "")
            {
                MessageBox.Show("Vui lòng chọn màu xóa!!");
                return;
            }
            else
            {
                MauSacDTO nv = layTTSP_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa một màu xanh tươi");
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
