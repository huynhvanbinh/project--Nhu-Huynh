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
    public partial class TaiKhoan : Form
    {
        //ma hoa md5
        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

        public TaiKhoan()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        TaiKhoanBUS customerBUS = new TaiKhoanBUS();
        BindingSource bs = new BindingSource();
        List<TaiKhoanDTO> dskh = new List<TaiKhoanDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskh = customerBUS.LayDskh();
            bs.DataSource = dskh.ToList();
            dtgv_ttkh.DataSource = bs;
        }
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtTaiKhoan.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                txtMatKhau.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                txtmanhanvien.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();

            }
        }
        private TaiKhoanDTO layTTKH_moi()
        {
            TaiKhoanDTO NewKH = new TaiKhoanDTO();
            NewKH.TaiKhoan = string.IsNullOrEmpty(txtTaiKhoan.Text) ? "" : txtTaiKhoan.Text;
            NewKH.MatKhau = string.IsNullOrEmpty(txtMatKhau.Text) ? "" : GetMD5 (txtMatKhau.Text);
            NewKH.MaNV = string.IsNullOrEmpty(txtmanhanvien.Text) ? "" : txtmanhanvien.Text;
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private void reset()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtmanhanvien.Text = "";
            
        }
        private void Them_Click()
        {
            TaiKhoanDTO khAdd = layTTKH_moi();
            if (khAdd.TaiKhoan == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            bool kq = customerBUS.DKKH(khAdd);
            MessageBox.Show("Thêm thành công");
            reset();
            Load_Form();
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them_Click();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
