using demo1.dataAccesslayer;
using demo1.Reportings;
using Microsoft.Reporting.WinForms;
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
    public partial class InLuongNhanVien : Form
    {
        public InLuongNhanVien()
        {
            InitializeComponent();
        }

        private void InLuongNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet.LuongNhanVien' table. You can move, or remove it, as needed.
            this.LuongNhanVienTableAdapter.Fill(this.demoDataSet.LuongNhanVien);
            // TODO: This line of code loads data into the 'demoDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.demoDataSet.NhanVien);
            
            HienThi();
            this.reportViewer1.RefreshReport();
        }
        private void HienThi()
        {
            using (var _dbContext = new Model1())
            {
                string truyvan = "select n.MaNV, n.TenNV from NhanVien n, LuongNhanVien l where n.MaNV = l.MaNV";
                //chi tiet hoa don
               string truyvans = "select * from LuongNhanVien";
                List<danhsachnhanvien> danhsachnv = _dbContext.Database.SqlQuery<danhsachnhanvien>(truyvan).ToList();
                List<luongnhanvien> danhsachluong = _dbContext.Database.SqlQuery<luongnhanvien>(truyvans).ToList();
                this.reportViewer1.LocalReport.ReportPath = "InLuongNhanVien.rdlc";
                var reportDataSource = new ReportDataSource("DataSet2", danhsachnv);
                var reportDataSource1 = new ReportDataSource("DataSet1", danhsachluong);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
