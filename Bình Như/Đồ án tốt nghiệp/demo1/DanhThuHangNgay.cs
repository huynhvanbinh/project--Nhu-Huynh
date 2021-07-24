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
    public partial class DanhThuHangNgay : Form
    {
        public DanhThuHangNgay()
        {
            InitializeComponent();
        }
        HoaDonBUS customerBUS = new HoaDonBUS();
        BindingSource bs = new BindingSource();
        List<HoaDonDTO> dskhs = new List<HoaDonDTO>();

        //chi tiet hoa don
        CTHoaDonBUS customerCTHDBUS = new CTHoaDonBUS();
        BindingSource bscthd = new BindingSource();
        List<CTHoaDonDTO> dscthd = new List<CTHoaDonDTO>();
        public List<DTNgay> danhthu { get; set; }
        string tongtn1 = "0";
        string tongtn2 = "0";
        string tongtn3 = "0";
        string tongtn4 = "0";
        string tongtn5 = "0";
        string tongtn6 = "0";
        string tongtn7 = "0";
        string tongtn8 = "0";
        string tongtn9 = "0";
        string tongtn10 = "0";
        string tongtn11 = "0";
        string tongtn12 = "0";
        string tongtn13 = "0";
        string tongtn14 = "0";
        string tongtn15 = "0";
        string tongtn16 = "0";
        string tongtn17 = "0";
        string tongtn18 = "0";
        string tongtn19 = "0";
        string tongtn20 = "0";
        string tongtn21 = "0";
        string tongtn22 = "0";
        string tongtn23 = "0";
        string tongtn24 = "0";
        string tongtn25 = "0";
        string tongtn26 = "0";
        string tongtn27 = "0";
        string tongtn28 = "0";
        string tongtn29 = "0";
        string tongtn30 = "0";
        string tongtn31 = "0";
        private List<DTNgay> getdanhthu()
        {
            var list = new List<DTNgay>();
            list.Add(new DTNgay()
            {
                ngay1 = tongtn1,
                ngay2 = tongtn2,
                ngay3 = tongtn3,
                ngay4 = tongtn4,
                ngay5 = tongtn5,
                ngay6 = tongtn6,
                ngay7 = tongtn7,
                ngay8 = tongtn8,
                ngay9 = tongtn9,
                ngay10 = tongtn10,
                ngay11 = tongtn11,
                ngay12 = tongtn12,
                ngay13 = tongtn13,
                ngay14 = tongtn14,
                ngay15 = tongtn15,
                ngay16 = tongtn16,
                ngay17 = tongtn17,
                ngay18 = tongtn18,
                ngay19 = tongtn19,
                ngay20 = tongtn20,
                ngay21 = tongtn21,
                ngay22 = tongtn22,
                ngay23 = tongtn23,
                ngay24 = tongtn24,
                ngay25 = tongtn25,
                ngay26 = tongtn26,
                ngay27 = tongtn27,
                ngay28 = tongtn28,
                ngay29 = tongtn29,
                ngay30 = tongtn30,
                ngay31 = tongtn31,
            });

            return list;
        }


        private void DanhThuHangNgay_Load(object sender, EventArgs e)
        {
            Load_DSKH();
            if(tongtn1 !="0")
            {
                chartcot.Series["thang"].Points.AddXY("ngay 1", tongtn1);
            }
            chartcot.Series["thang"].Points.AddXY("ngay 2", tongtn2);
            chartcot.Series["thang"].Points.AddXY("ngay 3", tongtn3);
            chartcot.Series["thang"].Points.AddXY("ngay 4", tongtn4);
            chartcot.Series["thang"].Points.AddXY("ngay 5", tongtn5);
            //demo load bien
            danhthu = getdanhthu();
            var danhthus = this.danhthu;
            dataGridView1.DataSource = danhthus;
        }

        private void Load_DSKH()
        {
            string ngay1 = "01";
            string ngay2 = "02";
            string ngay3 = "03";
            string ngay4 = "04";
            string ngay5 = "05";
            string ngay6 = "06";
            string ngay7 = "07";
            string ngay8 = "08";
            string ngay9 = "09";
            string ngay10 = "10";
            string ngay11 = "11";
            string ngay12 = "12";
            string ngay = "";
            dskhs = customerBUS.LayDsspall();
            bs.DataSource = dskhs.ToList();
            float thunhapngay1 = 0;
            float thunhapngay2 = 0;
            float thunhapngay3 = 0;
            float thunhapngay4 = 0;
            float thunhapngay5 = 0;
            float thunhapngay6 = 0;
            float thunhapngay7 = 0;
            float thunhapngay8 = 0;
            float thunhapngay9 = 0;
            float thunhapngay10 = 0;
            float thunhapngay11 = 0;
            float thunhapngay12 = 0;
            foreach (HoaDonDTO cv in dskhs)
            {
                ngay = cv.NgayLap.Substring(0, 2);
                if (ngay.Equals(ngay1))
                {
                    thunhapngay1 = thunhapngay1 + Int32.Parse(cv.TongTien);
                    if (thunhapngay1 == 0)
                        tongtn1 = thunhapngay1.ToString();

                }
                if (ngay.Equals(ngay2))
                {
                    thunhapngay2 = thunhapngay2 + Int32.Parse(cv.TongTien);
                    tongtn2 = thunhapngay2.ToString();
                }
                if (ngay.Equals(ngay3))
                {
                    thunhapngay3 = thunhapngay3 + Int32.Parse(cv.TongTien);
                    tongtn3 = thunhapngay3.ToString();
                }
                if (ngay.Equals(ngay4))
                {
                    thunhapngay4 = thunhapngay4 + Int32.Parse(cv.TongTien);
                    tongtn4 = thunhapngay4.ToString();
                }
                if (ngay.Equals(ngay5))
                {
                    thunhapngay5 = thunhapngay5 + Int32.Parse(cv.TongTien);
                    tongtn5 = thunhapngay5.ToString();
                }
                if (ngay.Equals(ngay6))
                {
                    thunhapngay6 = thunhapngay6 + Int32.Parse(cv.TongTien);
                    tongtn6 = thunhapngay6.ToString();
                }               
            }
        }
    }
}
