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
    public partial class PhieuXuat : Form
    {
        public PhieuXuat()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;
            Load_Form();
        }
        PhieuXuatBUS customerBUS = new PhieuXuatBUS();
        BindingSource bs = new BindingSource();
        List<PhieuXuatDTO> dskhs = new List<PhieuXuatDTO>();

        CuaHangBUS customerCHBUS = new CuaHangBUS();
        BindingSource bsch = new BindingSource();
        List<CuaHangDTO> dsch = new List<CuaHangDTO>();

        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource bsnv = new BindingSource();
        List<NhanVienDTO> dsnv= new List<NhanVienDTO>();

        CTPhieuXuatBUS customerCTPXBUS = new CTPhieuXuatBUS();
        BindingSource bsctpx = new BindingSource();
        List<CTPhieuXuatDTO> dsctpx = new List<CTPhieuXuatDTO>();
        private void Load_Form()
        { 
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dtpngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            string ngay = dtpngay.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDsspngay(ngay);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
            //ct hieu xuat
            
        }

        private PhieuXuatDTO layTTSP_sua()
        {
            PhieuXuatDTO NewKH = new PhieuXuatDTO();
            NewKH.MaPX = string.IsNullOrEmpty(txtMaPX.Text) ? "" : txtMaPX.Text;
            NewKH.ThanhToan = string.IsNullOrEmpty(txtThanhToan.Text) ? "" : txtThanhToan.Text;
            NewKH.NgayLap = dtpngay.Value.ToString("dd/MM/yyyy");
            NewKH.TrangThai = "0";
            return NewKH;
        }
        void xoa()
        {
            PhieuXuatDTO khAdd = layTTSP_sua();
            if (khAdd.MaPX == "")
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi xóa!!");
                return;
            }
            else
            {
                PhieuXuatDTO nv = layTTSP_sua();
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
              
                i = dtgv_ttkh.CurrentRow.Index;
                txtMaPX.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                dtpngay.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                txtThanhToan.Text= dtgv_ttkh.Rows[i].Cells[4].Value.ToString();
            }
            string ma = txtMaPX.Text;
            dsctpx = customerCTPXBUS.LayDsspdk(ma);
            bsctpx.DataSource = dsctpx.ToList();
            dataGridView1.DataSource = bsctpx;
        }

        private void dtpngay_ValueChanged(object sender, EventArgs e)
        {
            string ngay = dtpngay.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDsspngay(ngay);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;

            string ma = "";
            dsctpx = customerCTPXBUS.LayDsspdk(ma);
            bsctpx.DataSource = dsctpx.ToList();
            dataGridView1.DataSource = bsctpx;
        }
    }
}
