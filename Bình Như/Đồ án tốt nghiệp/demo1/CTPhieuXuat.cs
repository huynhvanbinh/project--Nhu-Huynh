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
    public partial class CTPhieuXuat : Form
    {
        public CTPhieuXuat()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        CTPhieuXuatBUS customerBUS = new CTPhieuXuatBUS();
        BindingSource bs = new BindingSource();
        List<CTPhieuXuatDTO> dskhs = new List<CTPhieuXuatDTO>();

        MauSacBUS customerMAUBUS = new MauSacBUS();
        BindingSource bsmau = new BindingSource();
        List<MauSacDTO> dsmau = new List<MauSacDTO>();

        SizeBUS customerKTBUS = new SizeBUS();
        BindingSource bskt = new BindingSource();
        List<SizeDTO> dskt = new List<SizeDTO>();


        private void Load_Form()
        {
            labkichthuoc.Visible = false;
            labmau.Visible = false;
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            string ma = maphieuxuat;
            dskhs = customerBUS.LayDsspdk(ma);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;

            //mau
            dsmau = customerMAUBUS.LayDsmau();
            bsmau.DataSource = dsmau.ToList();

            //kichthuoc
            dskt = customerKTBUS.LayDskt();
            bskt.DataSource = dskt.ToList();
        }
        public string maphieuxuat;
        
        private void Load_CTPX(object sender, EventArgs e)
        {
            txtmaphieuxuat.Text = maphieuxuat;
            string ma = maphieuxuat;
            dskhs = customerBUS.LayDsspdk(ma);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;

            //mau combobox
            foreach (MauSacDTO sps in dsmau)
            {
                cmbmau.Items.Add(sps.TenMau.ToString());
            }
            //kich thuoc
            foreach (SizeDTO kt in dskt)
            {
                cmbkichthuoc.Items.Add(kt.TenSize.ToString());
            }
        }

        private void cmbmau_onItemSelected(object sender, EventArgs e)
        {
            labmau.Visible = true;
            foreach (MauSacDTO sps in dsmau)
            {
               if(sps.TenMau==cmbmau.selectedValue.ToString())
                {
                    labmau.Text = sps.MaMau;
                }
            }
        }

        private void cmbkichthuoc_onItemSelected(object sender, EventArgs e)
        {
            labkichthuoc.Visible = true;
            foreach (SizeDTO sps in dskt)
            {
                if (sps.TenSize == cmbkichthuoc.selectedValue.ToString())
                {
                    labkichthuoc.Text = sps.MaSize;
                }
            }
        }

        private CTPhieuXuatDTO layTTKH_moi()
        {
            CTPhieuXuatDTO NewKH = new CTPhieuXuatDTO();
            NewKH.MaCTPX = string.IsNullOrEmpty(txtmactpx.Text) ? "" : txtmactpx.Text;
            NewKH.MaPX = string.IsNullOrEmpty(txtmaphieuxuat.Text) ? "" : txtmaphieuxuat.Text;
            NewKH.MaSP = string.IsNullOrEmpty(txtsp.Text) ? "" : txtsp.Text;
            NewKH.SoLuong = string.IsNullOrEmpty(txtsoluong.Text) ? "" : txtsoluong.Text;
            NewKH.GiaNhap = string.IsNullOrEmpty(txtdongia.Text) ? "" : txtdongia.Text;
            NewKH.MaMau = string.IsNullOrEmpty(labmau.Text) ? "" : labmau.Text;
            NewKH.MaSize = string.IsNullOrEmpty(labkichthuoc.Text) ? "" : labkichthuoc.Text;
            NewKH.ChiecKhau = "No ";
            NewKH.TrangThai = "1";
            return NewKH;
        }
        void themsanphamPX()
        {
            CTPhieuXuatDTO khAdd = layTTKH_moi();
            bool kq = customerBUS.DKSP(khAdd);
            MessageBox.Show("Thêm thành công");
            Load_Form();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themsanphamPX();
        }
    }
}
