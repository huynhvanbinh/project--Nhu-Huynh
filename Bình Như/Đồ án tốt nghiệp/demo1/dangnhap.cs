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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
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
        TaiKhoanBUS customerBUS = new TaiKhoanBUS();
        BindingSource bs = new BindingSource();
        List<TaiKhoanDTO> dskh = new List<TaiKhoanDTO>();

        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource nv = new BindingSource();
        List<NhanVienDTO> dsnv = new List<NhanVienDTO>();

        ChucVuBUS customerCVBUS = new ChucVuBUS();
        BindingSource cv = new BindingSource();
        List<ChucVuDTO> dscv = new List<ChucVuDTO>();
        private void Load_DSKH()
        {
            dskh = customerBUS.LayDskh();
            bs.DataSource = dskh.ToList();
            //nhân viên
            dsnv = customerNVBUS.LayDskh();
            nv.DataSource = dsnv.ToList();
            //chức vụ
            dscv = customerCVBUS.LayDskh();
            cv.DataSource = dscv.ToList();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
                DialogResult h = MessageBox.Show
                 ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (h == DialogResult.Yes)
                {
                    Application.Exit();
                }            
        }

        private bool kiemtradn()
        {
            Load_DSKH();
            //string user = "binh";
            //string pass = "1234";
            foreach (TaiKhoanDTO kh in dskh)
            {
                if (kh.TaiKhoan.Equals(txtdangnhap.Text) && kh.MatKhau.Equals(GetMD5(txtpass.Text)))
                {
                    return true;
                }
            }
            return false;
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(kiemtradn()==true)
            {
                foreach (TaiKhoanDTO kh in dskh)
                {
                    if (kh.TaiKhoan.Equals(txtdangnhap.Text) && kh.MatKhau.Equals(GetMD5(txtpass.Text)))
                    {
                        foreach(NhanVienDTO nv in dsnv)
                        {
                            if(kh.MaNV.Equals(nv.MaNV))
                            {
                                foreach(ChucVuDTO cv in dscv)
                                {
                                    if(nv.MaCV.Equals(cv.MaCV))
                                    {
                                        MessageBox.Show("Dang nhap thanh cong với quyền " + cv.TenChucVu);
                                        trangchu tc = new trangchu();
                                        tc.quyen = nv.TenNV;
                                        tc.maquyen = cv.MaCV;
                                        tc.manhanvien = nv.MaNV;
                                        this.Visible = false;
                                        tc.Show();
                                    }    
                                }                   
                            }    
                        }                           
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.TextLength.ToString() != null)
            {
                txtpass.UseSystemPasswordChar = true;
            }
            else
                txtpass.UseSystemPasswordChar = false;
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
