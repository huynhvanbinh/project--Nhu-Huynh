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
    public partial class KhuyenMai : Form
    {
        public KhuyenMai()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        KhuyenMaiBUS customerBUS = new KhuyenMaiBUS();
        BindingSource bs = new BindingSource();
        List<KhuyenMaiDTO> dskhs = new List<KhuyenMaiDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskhs = customerBUS.LayDssp();
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;
            dtpngay.Text= DateTime.Now.ToString("dd/MM/yyyy");
            dtpngayketthuc.Text= DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtMaChucVu.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtTenChucVu.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                dtpngay.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                dtpngayketthuc.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
            }
        }
        private KhuyenMaiDTO layTTKH_moi()
        {
            KhuyenMaiDTO NewKH = new KhuyenMaiDTO();
            NewKH.MaKM = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenKM = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.NgayBatDau = dtpngay.Value.ToString("dd/MM/yyyy");
            NewKH.NgayKetThuc = dtpngayketthuc.Value.ToString("dd/MM/yyyy"); 
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private void reset()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }
        
        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            reset();
        }
        private KhuyenMaiDTO layTTSP_sua()
        {
            KhuyenMaiDTO NewKH = new KhuyenMaiDTO();
            NewKH.MaKM = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenKM = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;
            NewKH.NgayBatDau = dtpngay.Value.ToString("dd/MM/yyyy");
            NewKH.NgayKetThuc = dtpngayketthuc.Value.ToString("dd/MM/yyyy");
            NewKH.TrangThai = "0";
            return NewKH;
        }
      
        // khởi tạo truyền mã mã
        public string MaKhuyenMai="";

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            txtMaChucVu.Text = MaKhuyenMai;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(CheckControl())
            {
                KhuyenMaiDTO khAdd = layTTKH_moi();
                bool kq = customerBUS.DKSP(khAdd);
                MessageBox.Show("Thêm sản phẩm khuyến mãi");
                CTKhuyenMai ctkm = new CTKhuyenMai();
                ctkm.MaMai = txtMaChucVu.Text;
                reset();
                Load_Form();
                ctkm.Show();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhuyenMaiDTO khAdd = layTTKH_moi();
            if (khAdd.MaKM == "" || khAdd.TenKM == "")
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi xóa!!");
                return;
            }
            else
            {
                KhuyenMaiDTO nv = layTTSP_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa " + txtTenChucVu.Text);
                reset();
                Load_Form();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KhuyenMaiDTO khAdd = layTTKH_moi();
            if (khAdd.MaKM == "" || khAdd.TenKM == "")
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi!!");
                return;
            }
            else
            {
                KhuyenMaiDTO nv = layTTKH_moi();
                bool kq = customerBUS.UpdateNV(nv);
                MessageBox.Show("Sửa thành công");
                Load_Form();
            }
        }
        public bool CheckControl()
        { 
            if (string.IsNullOrWhiteSpace(txtMaChucVu.Text))
            {
                MessageBox.Show("Vui long nhap ma khuyen mai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaChucVu.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenChucVu.Text))
            {
                MessageBox.Show("Vui long nhap tên khuyến mãi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenChucVu.Focus();
                return false;
            }
            int ngayhople = 16062000;
            DateTime daes1 = Convert.ToDateTime(dtpngay.Text);
            DateTime daes3 = Convert.ToDateTime(dtpngayketthuc.Text);
            TimeSpan times = daes3.Subtract(daes1);
            int dayss = times.Days;  
            foreach (KhuyenMaiDTO cv in dskhs)
            {
                DateTime daes2 = Convert.ToDateTime(cv.NgayKetThuc);
                TimeSpan time = daes1.Subtract(daes2);
                int days = time.Days;
                if(days<=0)
                {
                    ngayhople = 14071999;
                }    
            }
            if(ngayhople== 14071999)
            {
                MessageBox.Show("đang trong thời gian diễn ra chương trình khuyến mãi khác", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpngay.Focus();
                return false;
            }
            if (dayss < 0)
            {
                MessageBox.Show("ngày kết thúc không hợp lệ ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpngayketthuc.Focus();
                return false;
            }
            return true;
        }
    }
}
