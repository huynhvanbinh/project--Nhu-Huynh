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
    public partial class CTPhieuNhap : Form
    {
        public CTPhieuNhap()
        {
            InitializeComponent();
            dtgv_ttsp.AutoGenerateColumns = false;
            Load_Form();
        }
        CTPhieuNhapBUS customerBUS = new CTPhieuNhapBUS();
        BindingSource bs = new BindingSource();
        List<CTPhieuNhapDTO> dssp = new List<CTPhieuNhapDTO>();

        MauSacBUS customerLSPBUS = new MauSacBUS();
        BindingSource bscv = new BindingSource();
        List<MauSacDTO> dssps = new List<MauSacDTO>();

        SizeBUS customerKTBUS = new SizeBUS();
        BindingSource bscvs = new BindingSource();
        List<SizeDTO> dsspss = new List<SizeDTO>();

        CuaHangBUS customerCHBUS = new CuaHangBUS();
        BindingSource bsch = new BindingSource();
        List<CuaHangDTO> dsch = new List<CuaHangDTO>();

        PhieuNhapBUS customerPNBUS = new PhieuNhapBUS();
        BindingSource bspn = new BindingSource();
        List<PhieuNhapDTO> dspn = new List<PhieuNhapDTO>();
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
            dssps = customerLSPBUS.LayDsmau();
            bscv.DataSource = dssps.ToList();
            //khoi tao load du lieu bang kich thuoc
            dsspss = customerKTBUS.LayDskt();
            bscv.DataSource = dssps.ToList();
            //khoi tao load du lieu bang cua hang
            dsch = customerCHBUS.LayDsch();
            bsch.DataSource = dsch.ToList();
            //khoi tao load du lieu bang phieu nhap
            dspn = customerPNBUS.LayDssp();
            bspn.DataSource = dspn.ToList();

        }

        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dtgv_ttsp.CurrentRow.Index;
            txtMaSP.Text = dtgv_ttsp.Rows[i].Cells[0].Value.ToString();
           
            txtSoLuong.Text = dtgv_ttsp.Rows[i].Cells[2].Value.ToString();
            txtGiaNhap.Text = dtgv_ttsp.Rows[i].Cells[4].Value.ToString();
            txtThanhTien.Text = dtgv_ttsp.Rows[i].Cells[5].Value.ToString();
           
         
        }
        private CTPhieuNhapDTO layTTSP_moi()
        {
            CTPhieuNhapDTO NewSP = new CTPhieuNhapDTO();
            NewSP.MaCTPN = string.IsNullOrEmpty(txtMaSP.Text) ? "" : txtMaSP.Text;
            NewSP.SoLuong = string.IsNullOrEmpty(txtSoLuong.Text) ? "" : txtSoLuong.Text;
            NewSP.GiaNhap = string.IsNullOrEmpty(txtGiaNhap.Text) ? "" : txtGiaNhap.Text;
            NewSP.TongTien = string.IsNullOrEmpty(txtThanhTien.Text) ? "" : txtThanhTien.Text;
            NewSP.MaMau = string.IsNullOrEmpty(txtmau.Text) ? "" : txtmau.Text;
            NewSP.MaSize = string.IsNullOrEmpty(txtkichthuoc.Text) ? "" : txtkichthuoc.Text;
            NewSP.MaCH = string.IsNullOrEmpty(txtcuahang.Text) ? "" : txtcuahang.Text;
            NewSP.MaPhieuNhap = string.IsNullOrEmpty(txtngaynhap.Text) ? "" : txtngaynhap.Text;
            return NewSP;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            CTPhieuNhapDTO khAdd = layTTSP_moi();
            if (khAdd.MaCTPN == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            bool kq = customerBUS.DKSP(khAdd);
            MessageBox.Show("Thêm thành công");
            Load_Form();
        }
        private void reset()
        {
            txtMaSP.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            txtThanhTien.Text = "";
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            reset();
        }

        // load du lieu len combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (MauSacDTO sps in dssps )
            {
                cmbloaisanpham.Items.Add(sps.TenMau.ToString());
            }
            foreach (SizeDTO kts in dsspss)
            {
                cmbsize.Items.Add(kts.TenSize.ToString());
            }
            foreach (CuaHangDTO chs in dsch)
            {
                cmbcuahang.Items.Add(chs.TenCH.ToString());
            }
            foreach (PhieuNhapDTO pns in dspn)
            {
                cmbphieunhap.Items.Add(pns.MaPhieuNhap.ToString());
            }
        }

        private void cmbloaisanpham_onItemSelected(object sender, EventArgs e)
        {
            Load_DSSP();
            int intMaNV = dtgv_ttsp.Rows.Count;

            txtMaSP.Text = "      " + "CTPN" + "-0" + intMaNV;
            txtMaSP.Text = txtMaSP.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+");
            txtMaSP.Text = trimmer.Replace(txtMaSP.Text, " ");
            //load màu
           // txtmau.Text = cmbloaisanpham.selectedValue;
            foreach (MauSacDTO sps in dssps)
            {
               if(cmbloaisanpham.selectedValue==sps.TenMau.ToString())
                {
                    txtmau.Text = sps.MaMau.ToString();
                }    
            }
        }

        private void cmbsize_onItemSelected(object sender, EventArgs e)
        {
            foreach (SizeDTO kts in dsspss)
            {
                if (cmbsize.selectedValue == kts.TenSize.ToString())
                {
                    txtkichthuoc.Text = kts.MaSize.ToString();
                }
            }
        }

        private void cmbcuahang_onItemSelected(object sender, EventArgs e)
        {
            foreach (CuaHangDTO chs in dsch)
            {
                if (cmbcuahang.selectedValue == chs.TenCH.ToString())
                {
                    txtcuahang.Text = chs.MaCH.ToString();
                }
            }
        }

        private void cmbphieunhap_onItemSelected(object sender, EventArgs e)
        {
            foreach (PhieuNhapDTO pns in dspn)
            {
                if (cmbphieunhap.selectedValue == pns.MaPhieuNhap.ToString())
                {
                    txtngaynhap.Text = pns.MaPhieuNhap.ToString();
                }
            }
        }

        private void thanhtien(object sender, EventArgs e)
        {          
                int soluong = Int32.Parse(txtSoLuong.Text);
                int gianhap = Int32.Parse(txtGiaNhap.Text);
                int gia = soluong * gianhap;
                txtThanhTien.Text = Convert.ToString(gia);    
        }
    }
}
