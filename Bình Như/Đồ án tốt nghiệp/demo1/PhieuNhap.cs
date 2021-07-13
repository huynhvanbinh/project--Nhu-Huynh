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
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        public string manv = "";
        public string tenNV;
        PhieuNhapBUS customerBUS = new PhieuNhapBUS();
        BindingSource bs = new BindingSource();
        List<PhieuNhapDTO> dskhs = new List<PhieuNhapDTO>();

        CuaHangBUS customerCHBUS = new CuaHangBUS();
        BindingSource bsch = new BindingSource();
        List<CuaHangDTO> dsch = new List<CuaHangDTO>();

        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource bsnv = new BindingSource();
        List<NhanVienDTO> dsnv = new List<NhanVienDTO>();
        private void Load_Form()
        {
            labmacuahang.Visible = false;
            labmanv.Visible = false;
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskhs = customerBUS.LayDssp();
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
            dtpngay.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //cua hang
            dsch = customerCHBUS.LayDsch();
            bsch.DataSource = dsch.ToList();
            //nhanvien
            dsnv = customerNVBUS.LayDskh();
            bsnv.DataSource = dsnv.ToList();
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            labmanv.Text = manv;
            foreach (NhanVienDTO nv in dsnv)
            {
                if (nv.MaNV == labmanv.Text)
                {
                    labnhanvien.Text = nv.TenNV;
                }

            }
            foreach (CuaHangDTO khs in dsch)
            {
                cmbcuahang.Items.Add(khs.TenCH.ToString());
            }
        }

        private void cmbcuahang_onItemSelected(object sender, EventArgs e)
        {
            foreach (CuaHangDTO khs in dsch)
            {
                if (cmbcuahang.selectedValue == khs.TenCH.ToString())
                {
                    labmacuahang.Visible = true;
                    labmacuahang.Text = khs.MaCH;
                    txtMaPX.Text = "PN_" + khs.MaCH + "_" + DateTime.Now.ToString("ddMMyyyy-HHms");
                }
            }
        }
        private PhieuNhapDTO layTTKH_moi()
        {
            PhieuNhapDTO NewKH = new PhieuNhapDTO();
            NewKH.MaPN = string.IsNullOrEmpty(txtMaPX.Text) ? "" : txtMaPX.Text;
            NewKH.ThanhToan = string.IsNullOrEmpty(txtThanhToan.Text) ? "" : txtThanhToan.Text;
            NewKH.NgayLap = dtpngay.Value.ToString("dd/MM/yyyy");
            NewKH.MaCH = string.IsNullOrEmpty(labmacuahang.Text) ? "" : labmacuahang.Text;
            NewKH.MaNV = string.IsNullOrEmpty(labmanv.Text) ? "" : labmanv.Text;
            NewKH.TrangThai = "1";
            return NewKH;
        }
        void them()
        {
            PhieuNhapDTO khAdd = layTTKH_moi();
            bool kq = customerBUS.DKSP(khAdd);
            Load_Form();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them();
            MessageBox.Show("Thêm chi tiết phiếu xuất");
            CTPhieuNhap ctphieunhap = new CTPhieuNhap();
            ctphieunhap.maphieunhap = txtMaPX.Text;
            ctphieunhap.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            CTPhieuNhap ctphieunhap = new CTPhieuNhap();
            ctphieunhap.maphieunhap = txtMaPX.Text;
            ctphieunhap.Show();
        }
        void sua()
        {
            PhieuNhapDTO khAdd = layTTKH_moi();
            if (khAdd.MaPN == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập!!");
                return;
            }
            else
            {
                PhieuNhapDTO nv = layTTKH_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sua();
        }
        private PhieuNhapDTO layTTSP_xoa()
        {
            PhieuNhapDTO NewKH = new PhieuNhapDTO();
            NewKH.MaPN = string.IsNullOrEmpty(txtMaPX.Text) ? "" : txtMaPX.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }
        void xoa()
        {
            PhieuNhapDTO khAdd = layTTKH_moi();
            if (khAdd.MaPN == "")
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi xóa!!");
                return;
            }
            else
            {
                PhieuNhapDTO nv = layTTSP_xoa();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa " + txtMaPX.Text);
                Load_Form();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xoa();
        }
        private void dtgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                labmacuahang.Visible = true;
                i = dtgv_ttkh.CurrentRow.Index;
                txtMaPX.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                dtpngay.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                txtThanhToan.Text = dtgv_ttkh.Rows[i].Cells[4].Value.ToString();
                labmanv.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                labmacuahang.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
            }
        }

    }
}