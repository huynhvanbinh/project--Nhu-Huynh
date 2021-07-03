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
        private void Them_Click_1()
        {
            KhuyenMaiDTO khAdd = layTTKH_moi();
            if (khAdd.MaKM == "" || khAdd.TenKM=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                int kt = 0;
                foreach (KhuyenMaiDTO km in dskhs)
                {
                    if (km.NgayKetThuc == dtpngayketthuc.Value.ToString("dd/MM/yyyy"))
                    {
                        kt = 1;
                    }
                    if(km.MaKM==txtMaChucVu.Text)
                    {
                        kt = 0;
                    }    
                }
                if(kt==0)
                {
                    bool kq = customerBUS.DKSP(khAdd);
                    MessageBox.Show("Thêm sản phẩm khuyến mãi");
                    CTKhuyenMai ctkm = new CTKhuyenMai();
                    ctkm.MaMai = txtMaChucVu.Text;
                    reset();
                    Load_Form();
                    ctkm.Show();
                }
                else
                {
                    MessageBox.Show("Thời gian đang diễn ra chương trình khuyến mãi khác!");
                }    
            }  
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

        private void bunifuButton2_Click()
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

        private void Xóa_Click()
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
                MessageBox.Show("Đã xóa " +txtTenChucVu.Text);
                reset();
                Load_Form();
            }
        }
        // khởi tạo truyền mã mã
        public string MaKhuyenMai="";

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            txtMaChucVu.Text = MaKhuyenMai;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them_Click_1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xóa_Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuButton2_Click();
        }
    }
}
