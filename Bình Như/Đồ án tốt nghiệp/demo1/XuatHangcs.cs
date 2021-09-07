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
    public partial class XuatHangcs : Form
    {
        List<dssanpham> listsanpham;
        public XuatHangcs()
        {
            InitializeComponent();
            dtgv_ttsp.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
            choncuahang();
            listsanpham = new List<dssanpham>();
        }
        public string manv = "";
        public string tenNV;
      
        PhieuXuatBUS customerBUS = new PhieuXuatBUS();
        BindingSource bs = new BindingSource();
        List<PhieuXuatDTO> dskhs = new List<PhieuXuatDTO>();

        NhanVienBUS customerNVBUS = new NhanVienBUS();
        BindingSource bsnv = new BindingSource();
        List<NhanVienDTO> dsnv = new List<NhanVienDTO>();

        SanPhamBUS customerSPBUS = new SanPhamBUS();
        BindingSource bssp = new BindingSource();
        List<SanPhamDTO> dssp = new List<SanPhamDTO>();
        List<SanPhamDTO> dssps = new List<SanPhamDTO>();

        CTPhieuXuatBUS customerCTPXBUS = new CTPhieuXuatBUS();
        BindingSource bsctpx = new BindingSource();
        List<CTPhieuXuatDTO> dsctpx = new List<CTPhieuXuatDTO>();

        CTSanPhamBUS customerCTSPBUS = new CTSanPhamBUS();
        BindingSource bsctsp = new BindingSource();
        List<CTSanPhamDTO> dsctsp = new List<CTSanPhamDTO>();
        List<CTSanPhamDTO> dsctsps = new List<CTSanPhamDTO>();

        CuaHangBUS customerCHBUS = new CuaHangBUS();
        BindingSource bsch = new BindingSource();
        List<CuaHangDTO> dsch = new List<CuaHangDTO>();
        private void Load_Form()
        {
            Load_DSKH();  
        }
        private void Load_DSKH()
        {
            //chi tiết phiếu xuất
            string ma = txtMaPX.Text;
            dsctpx = customerCTPXBUS.LayDsspdk(ma);
            bsctpx.DataSource = dsctpx.ToList();
            dtgv_ttkh.DataSource = bsctpx;

            dskhs = customerBUS.LayDssp();
            bs.DataSource = dskhs.ToList();

            dssp = customerSPBUS.LayDssp();
            bssp.DataSource = dssp.ToList();
            dtgv_ttsp.DataSource = bssp;
            //cua hang
            dsch = customerCHBUS.LayDsch();
            bsch.DataSource = dsch.ToList();
            dataGridView2.DataSource = bsch;
           
        }
        private void reset()
        {
            txtSP.Text = "";
            txttensp.Text = "";
            txtdongia.Text = "";
            txtmau.Text = "";
            txtkichthuoc.Text = "";
            txtsoluong.Text = "";
            txttongtien.Text = "";
        }
        private void choncuahang()
        {
            labtrangthai.Visible = false;
            btnquanlypx.Visible = false;
            groupBox2.Visible = false;
            dtgv_ttkh.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            txtMaPX.Visible = false;
            txtSP.Visible = false;
            txttensp.Visible = false;
            txtdongia.Visible = false;
            txtmau.Visible = false;
            txtkichthuoc.Visible = false;
            txtsoluong.Visible = false;
            txttongtien.Visible = false;
            btnthem.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            bunifuButton2.Visible = false;
            label9.Visible = false;
            labcuahang.Visible = false;
            bunifuButton3.Visible = false;
        }
        private void dachoncuahang()
        {
            bunifuButton3.Visible = true;
            groupBox2.Visible = true;
            dtgv_ttkh.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            txtMaPX.Visible = true;
            txtSP.Visible = true;
            txttensp.Visible = true;
            txtdongia.Visible = true;
            txtmau.Visible = true;
            txtkichthuoc.Visible = true;
            txtsoluong.Visible = true;
            txttongtien.Visible = true;
            btnthem.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            bunifuButton2.Visible = true;
            label9.Visible = true;
            labcuahang.Visible = true;
        }
        private void XuatHangcs_Load(object sender, EventArgs e)
        {
          txtMaPX.Text= "XH_" + "_" + DateTime.Now.ToString("ddMMyyyy-HHms");
        }
        private PhieuXuatDTO layTTKH_moi()
        {
            int thanhtoan = 0;
            foreach (dssanpham listsp in listsanpham)
            {
                int dongia = Int32.Parse(listsp.GiaNhap);
                int soluong = Int32.Parse(listsp.SoLuong);
                thanhtoan = thanhtoan + dongia * soluong;
            }
            PhieuXuatDTO NewKH = new PhieuXuatDTO();
            NewKH.MaPX = string.IsNullOrEmpty(txtMaPX.Text) ? "" : txtMaPX.Text;
            NewKH.ThanhToan = thanhtoan.ToString();
            NewKH.NgayLap = DateTime.Now.ToString("dd/MM/yyyy");
            NewKH.MaCH = manguoinhan;
            NewKH.MaNV = manv;
            NewKH.TringTrang = "Chờ nhận hàng";
            NewKH.TrangThai = "1";
            return NewKH;
        }       
        void taophieuxuat()
        {
            PhieuXuatDTO khAdd = layTTKH_moi();
            bool kq = customerBUS.DKSP(khAdd);
        }
        public string macuahang;
        private void dtgv_ttsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttsp.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttsp.CurrentRow.Index;
                txtSP.Text = dtgv_ttsp.Rows[i].Cells[0].Value.ToString();
                txttensp.Text = dtgv_ttsp.Rows[i].Cells[1].Value.ToString();
                txtdongia.Text = dtgv_ttsp.Rows[i].Cells[2].Value.ToString();

                string masanpham = txtSP.Text;
                string cuahang = macuahang;
                dsctsp = customerCTSPBUS.LayDsctspch(masanpham, cuahang);
                bsctsp.DataSource = dsctsp.ToList();
                dataGridView1.DataSource = bsctsp;
            }
            txtmau.Text = "";
            txtkichthuoc.Text = "";
            txtsoluong.Text = "";
            txttongtien.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int i;
                i = dataGridView1.CurrentRow.Index;
                txtmau.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtkichthuoc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }
            txtsoluong.Text = "";
            txttongtien.Text = "";
        }
        public string mactpx;        
        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtSP.Text) || string.IsNullOrWhiteSpace(txtmau.Text))
            {
                MessageBox.Show("Vui long chon san pham", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtsoluong.Text))
            {
                MessageBox.Show("Vui long nhap so luong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsoluong.Focus();
                return false;
            }
            return true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            //them san pham vao list
            if (CheckControl())
            {
                int ktthemlist = 16062000;
                dssanpham sanpham = new dssanpham();
                sanpham.MaSP = txtSP.Text;
                sanpham.GiaNhap = txtdongia.Text;
                sanpham.MaMau = txtmau.Text;
                sanpham.MaSize = txtkichthuoc.Text;
                sanpham.SoLuong = txtsoluong.Text;
                foreach (dssanpham listsp in listsanpham)
                {
                    if(listsp.MaSP==txtSP.Text && listsp.MaMau==txtmau.Text && listsp.MaSize==txtkichthuoc.Text)
                    {
                        MessageBox.Show("san pham da co trong danh sach xuat hang", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ktthemlist = 0;
                    }
                }
                if(ktthemlist==16062000)
                {
                    listsanpham.Add(sanpham);
                    dtgv_ttkh.DataSource = null;
                    dtgv_ttkh.DataSource = listsanpham;
                    dtgv_ttkh.Refresh();
                }
            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if(txtsoluong.Text!="" && txtdongia.Text!="")
            {
                float dongia = Int32.Parse(txtdongia.Text);
                float soluong = Int32.Parse(txtsoluong.Text);
                float thanhtien = dongia * soluong;
                txttongtien.Text = thanhtien.ToString();
            }              
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int i;
                i = dataGridView2.CurrentRow.Index;
                txtMaChucVu.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
                txtTenChucVu.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
                txtdiachi.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
                labcuahang.Text= dataGridView2.Rows[i].Cells[1].Value.ToString();
            }
        }
        public string manguoinhan;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            bunifuButton1.Visible = false;
            groupBox1.Visible = false;
            manguoinhan = txtMaChucVu.Text;
            btnthem.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            labtrangthai.Visible = false;
            btnquanlypx.Visible = false;
            dachoncuahang();
        }

        //xuất hàng nhưng chọn đc nhiều CTSP
        private void aotuthemsanphampx()
        {
            CTPhieuXuatDTO NewCT = new CTPhieuXuatDTO();
            foreach (dssanpham listsp in listsanpham)
            {
                CTPhieuXuatDTO layCTPX_List()
                {                   
                    CTPhieuXuatDTO NewKH = new CTPhieuXuatDTO();
                    NewKH.MaCTPX = txtMaPX.Text + "_SP-0" + listsp.MaSP+ listsp.MaMau+ listsp.MaSize; 
                    NewKH.MaPX = string.IsNullOrEmpty(txtMaPX.Text) ? "" : txtMaPX.Text;
                    NewKH.MaSP = listsp.MaSP;
                    NewKH.SoLuong = listsp.SoLuong;
                    NewKH.GiaNhap = listsp.GiaNhap;
                    NewKH.MaMau = listsp.MaMau;
                    NewKH.MaSize = listsp.MaSize;
                    NewKH.ChiecKhau = "No ";
                    NewKH.TrangThai = "1";
                    return NewKH;
                }
                CTPhieuXuatDTO khAdd = layCTPX_List();
                bool kq = customerCTPXBUS.DKSP(khAdd);
                //update so luong chi tiết sp
                string macuahang = "admin";
                dsctsps = customerCTSPBUS.Laydsctspmacuahang(macuahang);
                bsctsp.DataSource = dsctsps.ToList();
                CTSanPhamDTO layTTSP_sua()
                {
                    string soluongkho = null;
                    string mactsp = null;
                    foreach (CTSanPhamDTO ct in dsctsp)
                    {
                        if (ct.MaSP==listsp.MaSP && ct.MaMau==listsp.MaMau && ct.KichThuoc==listsp.MaSize && ct.MaCH==macuahang)
                        {
                            soluongkho = ct.SoLuong;
                            mactsp = ct.MaCTSP;
                        }
                    }
                    float slupdates = Int32.Parse(soluongkho);
                    float soluongss = Int32.Parse(listsp.SoLuong);
                    float slconlai = slupdates - soluongss;
                    CTSanPhamDTO NewSP = new CTSanPhamDTO();
                    NewSP.MaSP = listsp.MaSP;
                    NewSP.MaMau = listsp.MaMau;
                    NewSP.KichThuoc = listsp.MaSize;
                    NewSP.SoLuong = slconlai.ToString();
                    NewSP.MaCTSP = mactsp;
                    NewSP.TrangThai = "1";
                    return NewSP;
                }
                CTSanPhamDTO nv = layTTSP_sua();
                bool kqs = customerCTSPBUS.UpdateSL(nv);                
            }                      
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            int kt = 0;
            foreach (dssanpham listsp in listsanpham)
            {
                if (listsp.MaSP !="")
                {
                    kt = 1;
                }
            }
            if (kt==1)
            {
                MessageBox.Show("đã xuất sản phẩm đến cửa hàng: "+ txtTenChucVu.Text);
                taophieuxuat();
                aotuthemsanphampx();
                Load_Form();
                string masanpham = txtSP.Text;
                string cuahang = macuahang;
                dsctsp = customerCTSPBUS.LayDsctspch(masanpham, cuahang);
                bsctsp.DataSource = dsctsp.ToList();
                dataGridView1.DataSource = bsctsp;
                btnthem.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                labtrangthai.Visible = true;
                btnquanlypx.Visible = true;
            }    
           if(kt==0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm xuất đến cửa hàng: " + txtTenChucVu.Text);
            }      
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ban co muon xoa", "thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listsanpham.RemoveAt(index);
                dtgv_ttkh.DataSource = null;
                dtgv_ttkh.DataSource = listsanpham;
                dtgv_ttkh.Refresh();
            }
        }
        int index;
        private void dtgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtSP.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtmau.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                txtkichthuoc.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                txtsoluong.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
                txtdongia.Text = dtgv_ttkh.Rows[i].Cells[4].Value.ToString();
                foreach (SanPhamDTO sp in dssp)
                {
                    if (sp.MaSP == txtSP.Text)
                    {
                        txttensp.Text = sp.TenSP;
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listsanpham[index].MaSP = txtSP.Text;
            listsanpham[index].MaMau = txtmau.Text;
            listsanpham[index].MaSize = txtkichthuoc.Text;
            listsanpham[index].SoLuong = txtsoluong.Text;
            listsanpham[index].GiaNhap = txtdongia.Text;
            dtgv_ttkh.DataSource = null;
            dtgv_ttkh.DataSource = listsanpham;
            dtgv_ttkh.Refresh();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            txtMaPX.Text = "XH_" + "_" + DateTime.Now.ToString("ddMMyyyy-HHms");
            dataGridView2.Visible = true;
            bunifuButton1.Visible = true;
            groupBox1.Visible = true;
            choncuahang();
            Load_Form();
            listsanpham.Clear();
        }

        private void btnquanlypx_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            PhieuXuat phieuxuat = new PhieuXuat();
            phieuxuat.FormBorderStyle = FormBorderStyle.None;
            phieuxuat.Dock = DockStyle.Fill;
            phieuxuat.MdiParent = this;
            phieuxuat.Show();
        }
    }
}
