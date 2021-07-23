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
    public partial class SPBanNhieuNhat : Form
    {
        public SPBanNhieuNhat()
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
            dssp = customerBUS.LayDsspbancham();
            bs.DataSource = dssp.ToList();
            dtgv_ttsp.DataSource = bs;
            MessageBox.Show("San pham ton kho nhieu");
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
            //string ma = txtMaSP.Text;
            //dsctsp = customerCTSPBUS.LayDsmau(ma);
            //bsctsp.DataSource = dsctsp.ToList();

        }

        private void cmbloaisanpham_onItemSelected(object sender, EventArgs e)
        {
            if(cmbloaisanpham.selectedValue == "Bán nhiều nhất")
            {
                MessageBox.Show("sản phẩm bán nhiều nhất");
               
            }    
            else if(cmbloaisanpham.selectedValue== "Bán chậm nhất")
            {
                MessageBox.Show("Sản phẩm bán chậm nhất");
                dssp = customerBUS.LayDsspbancham();
                bs.DataSource = dssp.ToList();
                dtgv_ttsp.DataSource = bs;
            }    
        }
    }
}
