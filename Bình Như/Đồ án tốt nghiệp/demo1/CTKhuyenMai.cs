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
    public partial class CTKhuyenMai : Form
    {
        public CTKhuyenMai()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;
            Load_Form();
        }
        CTKhuyenMaiBUS customerBUS = new CTKhuyenMaiBUS();
        BindingSource bs = new BindingSource();
        List<CTKhuyenMaiDTO> dskhs = new List<CTKhuyenMaiDTO>();

        SanPhamBUS customerSPBUS = new SanPhamBUS();
        BindingSource bssp = new BindingSource();
        List<SanPhamDTO> dssp = new List<SanPhamDTO>();

        KhuyenMaiBUS customerKMBUS = new KhuyenMaiBUS();
        BindingSource bskm = new BindingSource();
        List<KhuyenMaiDTO> dskm = new List<KhuyenMaiDTO>();

        CTSanPhamBUS customerCTSPBUS = new CTSanPhamBUS();
        BindingSource bsctsp = new BindingSource();
        List<CTSanPhamDTO> dsctsp = new List<CTSanPhamDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            //load theo ma khuyen mai
            string ma = MaMai;
            dskhs = customerBUS.LayDsspdk(ma);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;

            //load du lieu bang san pham
            dssp = customerSPBUS.LayDsspcuahang("admin");
            bssp.DataSource = dssp.ToList();
            dataGridView1.DataSource = bssp;

            //load dữ liệu bảng khuyến mãi
            dskm = customerKMBUS.LayDssp();
            bskm.DataSource = dskm.ToList();

            //chi tiết khuyến mãi
            dsctsp = customerCTSPBUS.LayDsCTSP();
            bsctsp.DataSource = dsctsp.ToList();
        }
        public string makhuyenmaiupdate;
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtmasp.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                txtmakm.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtgiamgia.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                dssp = customerSPBUS.LayDssp();
                foreach (SanPhamDTO cv in dssp)
                {
                    if (cv.MaSP == txtmasp.Text)
                    {
                        txttensp.Text = cv.TenSP;
                        txtdongia.Text = cv.DonGia;
                    }
                }
                foreach(CTKhuyenMaiDTO ctkm in dskhs)
                {
                    if(ctkm.MaKM==txtmakm.Text && ctkm.MaSP==txtmasp.Text)
                    {
                        makhuyenmaiupdate = ctkm.MaCTKM;
                    }    
                }
                int slsanpham = 0;
                foreach (CTSanPhamDTO cv in dsctsp)
                {
                    if (cv.MaSP == txtmasp.Text)
                    {
                        slsanpham = slsanpham + Int32.Parse(cv.SoLuong);
                    }
                }
                txtsoluong.Text = slsanpham.ToString();
            }
        }
        private CTKhuyenMaiDTO layTTKH_moi()
        {
            CTKhuyenMaiDTO NewKH = new CTKhuyenMaiDTO();
            NewKH.MaKM = string.IsNullOrEmpty(txtmakm.Text) ? "" : txtmakm.Text;
            NewKH.MaSP = string.IsNullOrEmpty(txtmasp.Text) ? "" : txtmasp.Text;
            NewKH.MaCTKM =MaMai+ DateTime.Now.ToString("ddMMyyyyHHmmss");
            NewKH.GiamGia = string.IsNullOrEmpty(txtgiamgia.Text) ? "" : txtgiamgia.Text;
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private CTKhuyenMaiDTO layTTKHupdate()
        {
            CTKhuyenMaiDTO NewKH = new CTKhuyenMaiDTO();
            NewKH.MaKM = string.IsNullOrEmpty(txtmakm.Text) ? "" : txtmakm.Text;
            NewKH.MaSP = string.IsNullOrEmpty(txtmasp.Text) ? "" : txtmasp.Text;
            NewKH.MaCTKM = makhuyenmaiupdate;
            NewKH.GiamGia = string.IsNullOrEmpty(txtgiamgia.Text) ? "" : txtgiamgia.Text;
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private CTKhuyenMaiDTO layTTKHdelete()
        {
            CTKhuyenMaiDTO NewKH = new CTKhuyenMaiDTO();
            NewKH.MaCTKM = makhuyenmaiupdate;
            NewKH.MaKM = string.IsNullOrEmpty(txtmakm.Text) ? "" : txtmakm.Text;
            NewKH.MaSP = string.IsNullOrEmpty(txtmasp.Text) ? "" : txtmasp.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }
        private void reset()
        {
            txtgiamgia.Text = "";
            txtdongia.Text = "";
            txttensp.Text = "";
            txtsoluong.Text = "";
        }
        private void bunifuButton3_Click_1()
        {
            reset();
        }
        //load du lieu len combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            txtmakm.Text = MaMai;
            string ma = MaMai;
            dskhs = customerBUS.LayDsspdk(ma);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
            // san pham
            dssp = customerSPBUS.LayDsspcuahang("admin");
            bssp.DataSource = dssp.ToList();
            dataGridView1.DataSource = bssp;
        }

       
        public string MaMai;        
        private void loadsanpham(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int i;
                i = dataGridView1.CurrentRow.Index;
                txtmasp.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txttensp.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtdongia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                int slsanpham=0;
                foreach (CTSanPhamDTO cv in dsctsp)
                {
                    if (cv.MaSP == txtmasp.Text)
                    {
                        slsanpham = slsanpham + Int32.Parse(cv.SoLuong);
                    }
                }
                txtsoluong.Text = slsanpham.ToString();
                txtgiamgia.Text = "";
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            CTKhuyenMaiDTO khAdd = layTTKH_moi();
            if (CheckControl())
            {
                int ktsp = 0;
                foreach (CTKhuyenMaiDTO cv in dskhs)
                {
                    if (txtmasp.Text.Equals(cv.MaSP))
                    {
                        ktsp = 1;
                    }
                }
                if (ktsp == 1)
                {
                    DialogResult h = MessageBox.Show
                     ("sản phẩm đã tồn tại trong hóa đơn. Bạn có muốn thay đổi khuyến mãi",
                     "Thông báo",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (h == DialogResult.Yes)
                    {
                        txtgiamgia.Focus();
                    }
                }
                else
                {
                    bool kq = customerBUS.DKSP(khAdd);
                    MessageBox.Show("Thêm thành công");
                }

                Load_Form();
            }           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                CTKhuyenMaiDTO nv = layTTKHupdate();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("bạn đã thay đổi thành công");
                Load_Form();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                CTKhuyenMaiDTO nv = layTTKHdelete();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa ");
                Load_Form();
            }
        }
        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtmasp.Text))
            {
                MessageBox.Show("Vui long chon san pham", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtgiamgia.Text))
            {
                MessageBox.Show("Vui long nhập giảm giá", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgiamgia.Focus();
                return false;
            }
            return true;
        }
    }
}
