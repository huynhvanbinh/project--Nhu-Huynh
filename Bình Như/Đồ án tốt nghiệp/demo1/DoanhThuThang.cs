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
    public partial class DoanhThuThang : Form
    {
        public DoanhThuThang()
        {
            InitializeComponent();
            Load_Form();
        }

        private List<DTThang> getdanhthu()
        {
            var list = new List<DTThang>();
            list.Add(new DTThang()
            {
                thang1 = tongtn1,
                thang2 = tongtn2,
                thang3 = tongtn3,
                thang4 = tongtn4,
                thang5 = tongtn5,
                thang6 = tongtn6,
                thang7 = tongtn7,
                thang8 = tongtn8,
                thang9 = tongtn9,
                thang10 = tongtn10,
                thang11 = tongtn11,
                thang12 = tongtn12,
            }) ;
           
            return list;
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
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 1", tongtn1);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 2", tongtn2);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 3", tongtn3);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 4", tongtn4);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 5", tongtn5);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 6", tongtn6);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 7", tongtn7);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 8", tongtn8);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 9", tongtn9);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 10", tongtn10);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 11", tongtn11);
            danhthuthang.Series["danhthuthang"].Points.AddXY("tháng 12", tongtn12);
            //demo load bien
            danhthu = getdanhthu();
            var danhthus = this.danhthu;
            dataGridView1.DataSource = danhthus;
        }
        public List<DTThang> danhthu { get; set; }
        string tongtn1="0";
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
        private void Load_DSKH()
        {
            string thang1 = "01";
            string thang2 = "02";
            string thang3 = "03";
            string thang4 = "04";
            string thang5 = "05";
            string thang6 = "06";
            string thang7 = "07";
            string thang8 = "08";
            string thang9 = "09";
            string thang10 = "10";
            string thang11 = "11";
            string thang12 = "12";
            string thang = "";
            dskhs = customerBUS.LayDsspall();
            bs.DataSource = dskhs.ToList();
            float thunhapthang1 = 0;
            float thunhapthang2 = 0;
            float thunhapthang3 = 0;
            float thunhapthang4 = 0;
            float thunhapthang5 = 0;
            float thunhapthang6 = 0;
            float thunhapthang7 = 0;
            float thunhapthang8 = 0;
            float thunhapthang9 = 0;
            float thunhapthang10 = 0;
            float thunhapthang11 = 0;
            float thunhapthang12 = 0;
            foreach (HoaDonDTO cv in dskhs)
            {
                thang = cv.NgayLap.Substring(3, 2);
                if(thang.Equals(thang1))
                {
                    thunhapthang1 = thunhapthang1 + Int32.Parse(cv.TongTien);
                    tongtn1 = thunhapthang1.ToString();
                }
                if (thang.Equals(thang2))
                {
                    thunhapthang2 = thunhapthang2 + Int32.Parse(cv.TongTien);
                    tongtn2 = thunhapthang2.ToString();
                }
                if (thang.Equals(thang3))
                {
                    thunhapthang3 = thunhapthang3 + Int32.Parse(cv.TongTien);
                    tongtn3 = thunhapthang3.ToString();
                }
                if (thang.Equals(thang4))
                {
                    thunhapthang4 = thunhapthang4 + Int32.Parse(cv.TongTien);
                    tongtn4 = thunhapthang4.ToString();
                }
                if (thang.Equals(thang5))
                {
                    thunhapthang5 = thunhapthang5 + Int32.Parse(cv.TongTien);
                    tongtn5 = thunhapthang5.ToString();
                }
                if (thang.Equals(thang6))
                {
                    thunhapthang6 = thunhapthang6 + Int32.Parse(cv.TongTien);
                    tongtn6 = thunhapthang6.ToString();
                }
                if (thang.Equals(thang7))
                {
                    thunhapthang7 = thunhapthang7 + Int32.Parse(cv.TongTien);
                    tongtn7 = thunhapthang7.ToString();
                }
                if (thang.Equals(thang8))
                {
                    thunhapthang8 = thunhapthang8 + Int32.Parse(cv.TongTien);
                    tongtn8  = thunhapthang8.ToString();
                }
                if (thang.Equals(thang9))
                {
                    thunhapthang9 = thunhapthang9 + Int32.Parse(cv.TongTien);
                    tongtn9 = thunhapthang9.ToString();
                }
                if (thang.Equals(thang10))
                {
                    thunhapthang10 = thunhapthang10 + Int32.Parse(cv.TongTien);
                    tongtn10 = thunhapthang10.ToString();
                }
                if (thang.Equals(thang11))
                {
                    thunhapthang11 = thunhapthang11 + Int32.Parse(cv.TongTien);
                    tongtn11 = thunhapthang11.ToString();
                }
                if (thang.Equals(thang12))
                {
                    thunhapthang12 = thunhapthang12 + Int32.Parse(cv.TongTien);
                    tongtn12 = thunhapthang12.ToString();
                }
            }
        }

        
    }
}
