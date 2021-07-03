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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        HoaDonBUS customerBUS = new HoaDonBUS();
        BindingSource bs = new BindingSource();
        List<HoaDonDTO> dskhs = new List<HoaDonDTO>();

        //chi tiet hoa don
        CTHoaDonBUS customerCTHDBUS = new CTHoaDonBUS();
        BindingSource bscthd = new BindingSource();
        List<CTHoaDonDTO> dscthd = new List<CTHoaDonDTO>();
        private void Load_Form()
        {
            Load_DSKH();
          
        }
        private void Load_DSKH()
        {
            dtpngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            string ngay= dtpngay.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDssp(ngay);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;

            string ma = txtMaHD.Text;
            dscthd = customerCTHDBUS.LayDssp(ma);
            bscthd.DataSource = dscthd.ToList();
            cthd.DataSource = bscthd;
        }
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtMaHD.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtMaKH.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
                txtTongTien.Text = dtgv_ttkh.Rows[i].Cells[4].Value.ToString();
                dtpngay.Text=dtgv_ttkh.Rows[i].Cells[1].Value.ToString();

                string ma = txtMaHD.Text;
                dscthd = customerCTHDBUS.LayDssp(ma);
                bscthd.DataSource = dscthd.ToList();
                cthd.DataSource = bscthd;
            }
        }
        
        private HoaDonDTO layTTSP_moi()
        {
            HoaDonDTO NewSP = new HoaDonDTO();
            NewSP.MaHD = string.IsNullOrEmpty(txtMaHD.Text) ? "" : txtMaHD.Text;
            NewSP.NgayLap = dtpngay.Value.ToString("dd/MM/yyyy");
            NewSP.MaKH = string.IsNullOrEmpty(txtMaKH.Text) ? "" : txtMaKH.Text;
            NewSP.MaNV = string.IsNullOrEmpty(txtMaNV.Text) ? "" : txtMaNV.Text;
            NewSP.TongTien = string.IsNullOrEmpty(txtTongTien.Text) ? "" : txtTongTien.Text;
            NewSP.TrangThai = "1";
            return NewSP;
        }
        private HoaDonDTO layTTSP_sua()
        {
            HoaDonDTO NewSP = new HoaDonDTO();
            NewSP.TongTien = string.IsNullOrEmpty(txtTongTien.Text) ? "" : txtTongTien.Text;
            return NewSP;
        }
        private void reset()
        {
            txtMaHD.Text = "";
            txtMaKH.Text = "";
        }
        private void Them_Click_1()
        {
            HoaDonDTO khAdd = layTTSP_moi();
            if (khAdd.MaHD == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                bool kq = customerBUS.DKSP(khAdd);
                MessageBox.Show("Thêm sản phẩm vào hóa đơn");
                CTHoaDon cthd = new CTHoaDon();
                cthd.mahoadon = txtMaHD.Text;
                cthd.makhachhang = txtMaKH.Text;
                cthd.manhanvien = txtMaNV.Text;
                cthd.tongtienhoadon = txtTongTien.Text;
                cthd.Show();
                Load_Form();
            }       
        }
        //khoi tao bien nhan ma nhan vien
        //public string manv="";
        public string tongtienhoadon = "0";
        public string mahoadon = "";
        public string MaNV = "";
        public string makhachhang = "";
        private void hoadon(object sender, EventArgs e)
        {
            txtMaNV.Text = MaNV;
            txtMaHD.Text = mahoadon;
            txtMaKH.Text =makhachhang;
            txtTongTien.Text = tongtienhoadon;
            //txtMaNV.Text = "      " + "SP_HN" + "-0" + manv; 
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            //thay đổi mã khách hàng 
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Load_DSKH();
            int intMaHD = dtgv_ttkh.Rows.Count;
            txtMaHD.Text = "HD" + DateTime.Now.ToString("ddMMyyyy")+ DateTime.Now.ToString("HHmmss");
        }

        private void ThanhToan_Click()
        {
            HoaDonDTO nv = layTTSP_moi();
                bool kq = customerBUS.UpdateNV(nv); 
            MessageBox.Show("Tổng tiền nhận được là: "+txtTongTien.Text);
            Load_Form();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text.Length<=0||txtTongTien.Text.Length<=0)
            {
                MessageBox.Show("vui lòng chọn hóa đơn để In");
            } 
            else
            {
                InHoaDon mayin = new InHoaDon();
                mayin.mahd = txtMaHD.Text;
                mayin.Show();
                Load_Form();
            }      
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them_Click_1();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThanhToan_Click();
        }

        private void dtpngay_ValueChanged(object sender, EventArgs e)
        {
            string ngay = dtpngay.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDssp(ngay);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
        }
    }
}
