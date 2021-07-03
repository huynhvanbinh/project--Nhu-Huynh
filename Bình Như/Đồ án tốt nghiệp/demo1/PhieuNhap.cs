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
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
            dtgv_ttsp.AutoGenerateColumns = false;
            Load_Form();
        }
        PhieuNhapBUS customerBUS = new PhieuNhapBUS();
        BindingSource bs = new BindingSource();
        List<PhieuNhapDTO> dssp = new List<PhieuNhapDTO>();

        CuaHangBUS customerLSPBUS = new CuaHangBUS();
        BindingSource bscv = new BindingSource();
        List<CuaHangDTO> dssps = new List<CuaHangDTO>();
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
            dssps = customerLSPBUS.LayDsch();
            bscv.DataSource = dssps.ToList();

        }

        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dtgv_ttsp.SelectedCells.Count > 0)
            //{
            //    foreach (SanPhamDTO sp in dssp)
            //    {
            //        txtMaSP.Text = sp.MaSP;
            //        txtTenSP.Text = sp.TenSP;
            //        txtDonGia.Text = sp.DonGia;
            //        txtGiaNhap.Text = sp.GiaNhap;
            //        txtSoLuong.Text = sp.SoLuongTon;
            //        txtHinhAnh.Text = sp.HinhAnh;
            //        break;
            //    }
            //}
            int i;
            i = dtgv_ttsp.CurrentRow.Index;
            txtMaSP.Text = dtgv_ttsp.Rows[i].Cells[0].Value.ToString();         
            txtDonGia.Text = dtgv_ttsp.Rows[i].Cells[2].Value.ToString();
            txtGiaNhap.Text = dtgv_ttsp.Rows[i].Cells[4].Value.ToString();
           
        }
        private PhieuNhapDTO layTTSP_moi()
        {
            PhieuNhapDTO NewSP = new PhieuNhapDTO();
            NewSP.MaPhieuNhap = string.IsNullOrEmpty(txtMaSP.Text) ? "" : txtMaSP.Text;
           
            NewSP.ThanhToan = string.IsNullOrEmpty(txtDonGia.Text) ? "" : txtDonGia.Text;

            NewSP.NgayLap = DateTime.Today;

            return NewSP;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            PhieuNhapDTO khAdd = layTTSP_moi();
            if (khAdd.MaPhieuNhap == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            bool kq = customerBUS.DKSP(khAdd);
            MessageBox.Show("Thêm thành công");
            reset();
            Load_Form();
        }
        private void reset()
        {
            txtMaSP.Text = "";
           
            txtDonGia.Text = "";
            txtGiaNhap.Text = "";
           
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            reset();
        }

        // load du lieu len combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (CuaHangDTO sps in dssps)
            {
                cmbloaisanpham.Items.Add(sps.MaCH.ToString());
            }
        }

        private void cmbloaisanpham_onItemSelected(object sender, EventArgs e)
        {
            Load_DSSP();
            int intMaNV = dtgv_ttsp.Rows.Count;

            txtMaSP.Text = "      " + "SP_HN" + "-0" + intMaNV;
            txtMaSP.Text = txtMaSP.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+");
            txtMaSP.Text = trimmer.Replace(txtMaSP.Text, " ");
            //load loại sản phẩm
           
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}