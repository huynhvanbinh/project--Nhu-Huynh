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
    public partial class HoaDons : Form
    {
        public HoaDons()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            cthd.AutoGenerateColumns = false;
            Load_Form();
        }
        HoaDonBUS customerBUS = new HoaDonBUS();
        BindingSource bs = new BindingSource();
        List<HoaDonDTO> dskhs = new List<HoaDonDTO>();

        //chi tiet hoa don
        CTHoaDonBUS customerCTHDBUS = new CTHoaDonBUS();
        BindingSource bscthd = new BindingSource();
        List<CTHoaDonDTO> dscthd = new List<CTHoaDonDTO>();
        //
        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource bsnv = new BindingSource();
        List<NhanVienDTO> dsnv = new List<NhanVienDTO>();
        private void Load_Form()
        {
            Load_DSKH();

        }
        public string macuahang;
        private void Load_DSKH()
        {
            dtpngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            string ngay = dtpngay.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDssp(ngay,macuahang);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;

            string ma = txtMaHD.Text;
            dscthd = customerCTHDBUS.LayDssp(ma);
            bscthd.DataSource = dscthd.ToList();
            cthd.DataSource = bscthd;

            dsnv = customerNVBUS.LayDskh();
            bsnv.DataSource = dsnv.ToList();

            labtennv.Visible = false;
        }
        void reset()
        {
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtTongTien.Text = "";
        }
        private void dtpngay_ValueChanged(object sender, EventArgs e)
        {
            reset();
            string ngay = dtpngay.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDssp(ngay,macuahang);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;

            string ma = txtMaHD.Text;
            dscthd = customerCTHDBUS.LayDssp(ma);
            bscthd.DataSource = dscthd.ToList();
            cthd.DataSource = bscthd;

            labtennv.Visible = false;
        }

        private void dtgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtMaHD.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtMaKH.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
                txtTongTien.Text = dtgv_ttkh.Rows[i].Cells[4].Value.ToString();
                
                foreach (NhanVienDTO sps in dsnv)
                {
                    if (dtgv_ttkh.Rows[i].Cells[1].Value.ToString() == sps.MaNV)
                    {
                        labtennv.Text = sps.TenNV;
                    }
                }
                string ma = txtMaHD.Text;
                dscthd = customerCTHDBUS.LayDssp(ma);
                bscthd.DataSource = dscthd.ToList();
                cthd.DataSource = bscthd;

                labtennv.Visible = true;
            }
        }

        private void HoaDons_Load(object sender, EventArgs e)
        {
            Load_DSKH();
        }
    }
    }
