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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
            dtgv_ttsp.AutoGenerateColumns = false;
            Load_Form();
        }
        SanPhamBUS customerBUS = new SanPhamBUS();
        BindingSource bs = new BindingSource();
        List<SanPhamDTO> dssp = new List<SanPhamDTO>();

        LoaiSanPhamBUS customerLSPBUS = new LoaiSanPhamBUS();
        BindingSource bscv = new BindingSource();
        List<LoaiSanPhamDTO> dssps = new List<LoaiSanPhamDTO>();

        MauSacBUS customerMauBUS = new MauSacBUS();
        BindingSource bsmau = new BindingSource();
        List<MauSacDTO> dsmau = new List<MauSacDTO>();

        SizeBUS customerKTBUS = new SizeBUS();
        BindingSource bskt = new BindingSource();
        List<SizeDTO> dskt = new List<SizeDTO>();

        CTSanPhamBUS customerCTSPBUS = new CTSanPhamBUS();
        BindingSource bsctsp = new BindingSource();
        List<CTSanPhamDTO> dsctsp = new List<CTSanPhamDTO>();
        private void Load_Form()
        {
            Load_DSSP();
        }
        private void Load_DSSP()
        {
            dssp = customerBUS.LayDssp();
            bs.DataSource = dssp.ToList();
            dtgv_ttsp.DataSource = bs;
            // khoi tao load du lieu bang chuc vu
            dssps = customerLSPBUS.LayDssp();
            bscv.DataSource = dssps.ToList();
            //mau
            dsmau = customerMauBUS.LayDsmau();
            bsmau.DataSource = dssps.ToList();
            //kich thuoc
            dskt = customerKTBUS.LayDskt();
            bskt.DataSource = dskt.ToList();

            //chi tiet san pham
            string ma = txtMaSP.Text;
            dsctsp = customerCTSPBUS.LayDsmau(ma);
            bsctsp.DataSource = dsctsp.ToList();
          
        }

        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttsp.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttsp.CurrentRow.Index;
                txtMaSP.Text = dtgv_ttsp.Rows[i].Cells[0].Value.ToString();
                txtTenSP.Text = dtgv_ttsp.Rows[i].Cells[1].Value.ToString();
                txtDonGia.Text = dtgv_ttsp.Rows[i].Cells[2].Value.ToString();
                txtGiaNhap.Text = dtgv_ttsp.Rows[i].Cells[4].Value.ToString();
                txtMoTa.Text = dtgv_ttsp.Rows[i].Cells[6].Value.ToString();
                txtloaisp.Text = dtgv_ttsp.Rows[i].Cells[3].Value.ToString();
              
            }    
        }
        private SanPhamDTO layTTSP_moi()
        {
            SanPhamDTO NewSP = new SanPhamDTO();
            NewSP.MaSP = string.IsNullOrEmpty(txtMaSP.Text) ? "" : txtMaSP.Text;
            NewSP.TenSP = string.IsNullOrEmpty(txtTenSP.Text) ? "" : txtTenSP.Text;
            NewSP.DonGia = string.IsNullOrEmpty(txtDonGia.Text) ? "" : txtDonGia.Text;
            
            NewSP.GiaNhap = string.IsNullOrEmpty(txtGiaNhap.Text) ? "" : txtGiaNhap.Text;
            NewSP.MoTa = string.IsNullOrEmpty(txtMoTa.Text) ? "" : txtMoTa.Text;
            NewSP.HinhAnh = string.IsNullOrEmpty(txtHinhAnh.Text) ? "" : txtHinhAnh.Text;

            NewSP.MaLoai = string.IsNullOrEmpty(txtloaisp.Text) ? "" : txtloaisp.Text;

            NewSP.TrangThai = "1";
            return NewSP;
        }
        private CTSanPhamDTO layCTSP_moi()
        {
            CTSanPhamDTO NewSP = new CTSanPhamDTO();
            NewSP.MaCTSP="SP"+ DateTime.Now.ToString("ddMMyyyy") + DateTime.Now.ToString("HHmmss");
            NewSP.MaSP = string.IsNullOrEmpty(txtMaSP.Text) ? "" : txtMaSP.Text;
            NewSP.MaMau= string.IsNullOrEmpty(mamau.Text) ? "" : mamau.Text;
            NewSP.KichThuoc= string.IsNullOrEmpty(kichthuoc.Text) ? "" : kichthuoc.Text;
            NewSP.TrangThai = "1";
            return NewSP;
        }
        private void Them_Click()
        {
            SanPhamDTO khAdd = layTTSP_moi();
            if (khAdd.TenSP == "" ||khAdd.MaSP==""||khAdd.DonGia==""||khAdd.GiaNhap==""||khAdd.SoLuongTon==""||khAdd.MaLoai=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                bool kq = customerBUS.DKSP(khAdd);
                MessageBox.Show("Thêm thành công");
            }      
        }
        private void themCTSP()
        {
            CTSanPhamDTO khAdd = layCTSP_moi();
            if (khAdd.MaSP=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                bool kq = customerCTSPBUS.DKKH(khAdd);
                MessageBox.Show("Thêm thành công");
                Load_Form();
            }
        }
        private void reset()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            txtGiaNhap.Text = "";
            txtMoTa.Text = "";
            txtHinhAnh.Text = "";
            txtloaisp.Text = "";
            pictureBox1.Image = null;
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            reset();
        }

        // load du lieu len combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (LoaiSanPhamDTO sps in dssps)
            {
                cmbloaisanpham.Items.Add(sps.MaLoai.ToString());
            }
        }

        private void cmbloaisanpham_onItemSelected(object sender, EventArgs e)
        {
            Load_DSSP();
            int intMaNV = dtgv_ttsp.Rows.Count;
            txtMaSP.Text = "      " + "SP_HN" + "-0"+ intMaNV;
            txtMaSP.Text = txtMaSP.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+");
            txtMaSP.Text = trimmer.Replace(txtMaSP.Text, " ");
            //load loại sản phẩm
            txtloaisp.Text = cmbloaisanpham.selectedValue;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDlg = new OpenFileDialog();
            openfileDlg.Filter = openfileDlg.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openfileDlg.FilterIndex = 1;
            openfileDlg.RestoreDirectory = true;
            if(openfileDlg.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openfileDlg.FileName;
                txtHinhAnh.Text= openfileDlg.FileName;
            }    
        }
        private SanPhamDTO layTTSP_sua()
        {
            SanPhamDTO NewSP = new SanPhamDTO();
            NewSP.MaSP = string.IsNullOrEmpty(txtMaSP.Text) ? "" : txtMaSP.Text;
            NewSP.TenSP = string.IsNullOrEmpty(txtTenSP.Text) ? "" : txtTenSP.Text;
            NewSP.DonGia = string.IsNullOrEmpty(txtDonGia.Text) ? "" : txtDonGia.Text;

            NewSP.GiaNhap = string.IsNullOrEmpty(txtGiaNhap.Text) ? "" : txtGiaNhap.Text;
            NewSP.TrangThai = "0";
            return NewSP;
        }

        private void bunifuButton2_Click()
        {
            SanPhamDTO khAdd = layTTSP_moi();
            if (khAdd.TenSP == "" || khAdd.MaSP == "" || khAdd.DonGia == "" || khAdd.GiaNhap == "" || khAdd.SoLuongTon == "" || khAdd.MaLoai == "")
            {
                MessageBox.Show("Vui lòng chọn sản phảm!!");
                return;
            }
            else
            {
                SanPhamDTO nv = layTTSP_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }
        }

        private void Xóa_Click()
        {
            SanPhamDTO khAdd = layTTSP_moi();
            if (khAdd.TenSP == "" || khAdd.MaSP == "" || khAdd.DonGia == "" || khAdd.GiaNhap == "" || khAdd.SoLuongTon == "" || khAdd.MaLoai == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm xóa!!");
                return;
            }
            else
            {
                SanPhamDTO nv = layTTSP_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa một sản phẩm");
                reset();
                Load_Form();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them_Click();
            themctsampham();
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

       private void themctsampham()
        {
            CTSanPham ctsanpham = new CTSanPham();
            ctsanpham.masp = txtMaSP.Text;
            ctsanpham.tensp = txtTenSP.Text;
            ctsanpham.ShowDialog();
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            themctsampham();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
