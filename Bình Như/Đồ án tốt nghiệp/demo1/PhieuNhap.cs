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
            dataGridView1.AutoGenerateColumns = false;
            Load_Form();
        }
        public string manv = "";
        public string tenNV;
        PhieuNhapBUS customerBUS = new PhieuNhapBUS();
        BindingSource bs = new BindingSource();
        List<PhieuNhapDTO> dskhs = new List<PhieuNhapDTO>();

        CTPhieuNhapBUS customerCTPNBUS = new CTPhieuNhapBUS();
        BindingSource bsctpn = new BindingSource();
        List<CTPhieuNhapDTO> dsctpn = new List<CTPhieuNhapDTO>();
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
        }

        private void dtpngay_ValueChanged(object sender, EventArgs e)
        {
            string ngay = dtpngay.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDsspngay(ngay);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
        }

        private void dtgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;

                i = dtgv_ttkh.CurrentRow.Index;
                txtMaPX.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                dtpngay.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                txtThanhToan.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
            }
            string ma = txtMaPX.Text;
            dsctpn = customerCTPNBUS.LayDsspdk(ma);
            bsctpn.DataSource = dsctpn.ToList();
            dataGridView1.DataSource = bsctpn;
        }

        
    }
}