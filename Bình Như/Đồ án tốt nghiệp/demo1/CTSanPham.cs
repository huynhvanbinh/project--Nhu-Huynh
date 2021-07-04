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
    public partial class CTSanPham : Form
    {
        public CTSanPham()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            Load_Form();
        }
        public string masp = "";
        public string tensp = "";
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
            //mau
            dsmau = customerMauBUS.LayDsmau();
            bsmau.DataSource = dsmau.ToList();
            //kich thuoc
            dskt = customerKTBUS.LayDskt();
            bskt.DataSource = dskt.ToList();

            //chi tiet san pham
            string ma = txtMaSP.Text;
            dsctsp = customerCTSPBUS.LayDsmau(ma);
            bsctsp.DataSource = dsctsp.ToList();
            dataGridView1.DataSource = bsctsp;

        }
        private CTSanPhamDTO layCTSP_moi()
        {
            CTSanPhamDTO NewSP = new CTSanPhamDTO();
            NewSP.MaCTSP = "SP" + DateTime.Now.ToString("ddMMyyyy") + DateTime.Now.ToString("HHmmss");
            NewSP.MaSP = string.IsNullOrEmpty(txtMaSP.Text) ? "" : txtMaSP.Text;
            NewSP.MaMau = string.IsNullOrEmpty(mamau.Text) ? "" : mamau.Text;
            NewSP.KichThuoc = string.IsNullOrEmpty(kichthuoc.Text) ? "" : kichthuoc.Text;
            NewSP.SoLuong = string.IsNullOrEmpty(txtSoLuong.Text) ? "" : txtSoLuong.Text;
            NewSP.TrangThai = "1";
            return NewSP;
        }
        private void themCTSP()
        {
            CTSanPhamDTO khAdd = layCTSP_moi();
            if (khAdd.MaSP == "")
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

        private void load(object sender, EventArgs e)
        {
            foreach (MauSacDTO sps in dsmau)
            {
                cmbmau.Items.Add(sps.TenMau.ToString());
            }
            foreach (SizeDTO sps in dskt)
            {
                cmbkichthuoc.Items.Add(sps.TenSize.ToString());
            }
            txtMaSP.Text = masp;
            txtTenSP.Text = tensp;
            string ma = txtMaSP.Text;
            dsctsp = customerCTSPBUS.LayDsmau(ma);
            bsctsp.DataSource = dsctsp.ToList();
            dataGridView1.DataSource = bsctsp;
        }

        private void cmbmau_onItemSelected(object sender, EventArgs e)
        {
            foreach (MauSacDTO cv in dsmau)
            {
                if (cmbmau.selectedValue.Equals(cv.TenMau))
                {
                    labmau.Text = cv.MaMau;
                }
            }
        }

        private void cmbkichthuoc_onItemSelected(object sender, EventArgs e)
        {
            foreach (SizeDTO cv in dskt)
            {
                if (cmbkichthuoc.selectedValue.Equals(cv.TenSize))
                {
                    labkt.Text = cv.MaSize;
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themCTSP();
        }
    }
}
