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
            txtmactpx.Text = txtmaphieuxuat.Text + "_" + DateTime.Now.ToString("ddMMyyyy-HHms");
            CTPhieuXuatDTO khAdd = layTTKH_moi();
            bool kq = customerBUS.DKSP(khAdd);
            MessageBox.Show("Thêm thành công");
            Load_Form();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            
            themsanphamPX();
        }
        void sua()
        {
            CTPhieuXuatDTO khAdd = layTTKH_moi();
            bool kq = customerBUS.UpdateNV(khAdd);
            MessageBox.Show("bạn đã thay đổi thành công");
            Load_Form();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sua();
        }
        private CTPhieuXuatDTO layTTKH_xoa()
        {
            CTPhieuXuatDTO NewKH = new CTPhieuXuatDTO();
            NewKH.MaCTPX = string.IsNullOrEmpty(txtmactpx.Text) ? "" : txtmactpx.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }
        void xoa()
        {
            CTPhieuXuatDTO khAdd = layTTKH_xoa();
            bool kq = customerBUS.DELETENV(khAdd);
            MessageBox.Show("bạn đã thay đổi thành công");
            Load_Form();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void dtgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                labmau.Visible = true;
                labkichthuoc.Visible = true;
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtmactpx.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtsp.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                labmau.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                labkichthuoc.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
                txtsoluong.Text = dtgv_ttkh.Rows[i].Cells[4].Value.ToString();
                txtdongia.Text = dtgv_ttkh.Rows[i].Cells[5].Value.ToString();
            }
        }
    }
}
