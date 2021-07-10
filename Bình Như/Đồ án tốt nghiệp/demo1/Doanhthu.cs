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
    public partial class Doanhthu : Form
    {
        public Doanhthu()
        {
            InitializeComponent();
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
            dtpngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        
        private void Load_DSKH()
        {
            string ngay = dtpngay.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDssp(ngay);
            bs.DataSource = dskhs.ToList();
            float thunhapngay = 0;
            foreach (HoaDonDTO cv in dskhs)
            {
                if (cv.NgayLap.Equals(ngay))
                {
                    string ma = cv.MaHD;
                    dscthd = customerCTHDBUS.LayDssp(ma);
                    bscthd.DataSource = dscthd.ToList();
                    foreach (CTHoaDonDTO ct in dscthd)
                    {
                        if (cv.MaHD.Equals(ct.MaHD))
                        {
                            string soluong = ct.SoLuong;
                            string giaban = ct.GiaBan;
                            float soluongs = Int32.Parse(soluong);
                            float giabans = Int32.Parse(giaban);
                            float thunhap = soluongs * giabans;
                            thunhapngay = thunhapngay + thunhap;
                            txtdanhthungay.Text = thunhapngay.ToString();
                        }
                    }
                }
            }
        }

        private void dtpngay_ValueChanged(object sender, EventArgs e)
        {
            float thunhapngay = 0;
            int kt = 0;
            string ngay = dtpngay.Value.ToString("dd/MM/yyyy");
            dskhs = customerBUS.LayDssp(ngay);
            bs.DataSource = dskhs.ToList();
            foreach (HoaDonDTO cv in dskhs)
            {
                if (cv.NgayLap.Equals(ngay))
                {
                    string ma = cv.MaHD;
                    dscthd = customerCTHDBUS.LayDssp(ma);
                    bscthd.DataSource = dscthd.ToList();
                    foreach (CTHoaDonDTO ct in dscthd)
                    {
                        if (cv.MaHD.Equals(ct.MaHD))
                        {
                            string soluong = ct.SoLuong;
                            string giaban = ct.GiaBan;
                            float soluongs = Int32.Parse(soluong);
                            float giabans = Int32.Parse(giaban);
                            float thunhap = soluongs * giabans;
                            thunhapngay = thunhapngay + thunhap;
                            txtdanhthungay.Text = thunhapngay.ToString();
                            kt = 1;
                        }
                    }
                }
            }
            if(kt==0)
            {
                txtdanhthungay.Text = thunhapngay.ToString();
            }
        }
    }
}
