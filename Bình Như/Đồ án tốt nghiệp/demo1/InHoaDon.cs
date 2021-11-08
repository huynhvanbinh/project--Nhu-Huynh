using demo1.dataAccesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo1.Reportings;
using Microsoft.Reporting.WinForms;
using BUS;
using DTO;
namespace demo1
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        //CTHoaDonBUS customerCTHDBUS = new CTHoaDonBUS();
        //BindingSource bscthd = new BindingSource();
        //List<CTHoaDonDTO> dscthd = new List<CTHoaDonDTO>();

        //HoaDonBUS customerHDBUS = new HoaDonBUS();
        //BindingSource bshd = new BindingSource();
        //List<CTHoaDonDTO> dshd = new List<CTHoaDonDTO>();

        //SanPhamBUS customerBUS = new SanPhamBUS();
        //BindingSource bs = new BindingSource();
        //List<SanPhamDTO> dssp = new List<SanPhamDTO>();
        public string mahd;
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.demoDataSet.SanPham);
            // TODO: This line of code loads data into the 'demoDataSet.CTHoaDon' table. You can move, or remove it, as needed.
            this.CTHoaDonTableAdapter.Fill(this.demoDataSet.CTHoaDon);
            // TODO: This line of code loads data into the 'demoDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.demoDataSet.NhanVien);
            // TODO: This line of code loads data into the 'demoDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.demoDataSet.HoaDon);
            txtMaChucVu.Text = mahd;
            HienThi();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void HienThi()
        {
            using (var _dbContext= new Model1())
            {
                string truyvan = "select * from HoaDon";
                //chi tiet hoa don
                string truyvans = "select * from CTHoaDon";
                //ten san pham
                string sanphams = "select s.TenSP from SanPham s, HoaDon hd, CTHoaDon ct where s.MaSP = ct.MaSP and  ct.MaHD=hd.MaHD and ct.MaHD = 'HD2262021230257'";

                List<dshd> danhsach = _dbContext.Database.SqlQuery<dshd>(truyvan).ToList();
                List<dscthd> danhsachs = _dbContext.Database.SqlQuery<dscthd>(truyvans).ToList();
                
                List<dssanpham> danhsachsp = _dbContext.Database.SqlQuery<dssanpham>(sanphams).ToList();

                //tim kiem
                if (txtMaChucVu.Text!="")
                {
                    danhsach = danhsach.Where(u => u.MaHD.ToLower() == mahd.ToLower()).ToList();
                    //dieu kien hoa don
                    danhsachs = danhsachs.Where(u => u.MaHD.ToLower() == mahd.ToLower()).ToList();
                    //ten san pham
                }    
                this.reportViewer1.LocalReport.ReportPath = "InHoaDon.rdlc";
                var reportDataSource = new ReportDataSource("DataSet2", danhsach);
               // khai bao hpa don
                var reportDataSourcea = new ReportDataSource("DataSet1", danhsachs);

                var reportDataSource1 = new ReportDataSource("DataSet3", danhsachsp);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSourcea);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.RefreshReport();
            }    
        }       
        private void Them_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
