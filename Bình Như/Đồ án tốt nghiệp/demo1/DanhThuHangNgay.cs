using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1
{
    public partial class DanhThuHangNgay : Form
    {
        public DanhThuHangNgay()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void DanhThuHangNgay_Load(object sender, EventArgs e)
        {
            chartcot.Series["thang"].Points.AddXY("tháng1", 20000);
            chartcot.Series["thang"].Points.AddXY("tháng 2", 30000);
            chartcot.Series["thang"].Points.AddXY("tháng 3", 40000);
            chartcot.Series["thang"].Points.AddXY("tháng 4", 50000);
            chartcot.Series["thang"].Points.AddXY("tháng 5", 60000);
        }
    }
}
