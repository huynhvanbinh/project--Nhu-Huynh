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
        public XuatHangcs()
        {
            InitializeComponent();
            dtgv_ttsp.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
           
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

        CuaHangBUS customerCHBUS = new CuaHangBUS();
        BindingSource bsch = new BindingSource();
        List<CuaHangDTO> dsch = new List<CuaHangDTO>();
        private void Load_Form()
        {
            Load_DSKH();
            labmach.Visible = false;
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
            //nhanvien
            dsnv = customerNVBUS.LayDskh();
            bsnv.DataSource = dsnv.ToList();
            string masp = "";
            string masp1 = "";
            string masp2 = "";
            string masp3 = "";
            string masp4 = "";
            string masp5 = "";
            string masp6 = "";
            string masp7 = "";
            string masp8 = "";
            string masp9 = "";
            string masp10 = "";
            string masp11 = "";
            string masp12 = "";
            string masp13 = "";
            string masp14 = "";
            string masp15 = "";
            string masp16 = "";
            string masp17 = "";
            string masp18 = "";
            string masp19 = "";
            string masp20 = "";
            string macuahang = "admin";
            int kt = 0;
            foreach (CTPhieuXuatDTO cv in dsctpx)
            {
                if (kt == 0)
                {
                    masp = cv.MaSP;
                    kt++;
                }
                if (kt == 1 && masp != cv.MaSP)
                {
                    masp1 = cv.MaSP;
                    kt++;
                }
                if (kt == 2 && masp != cv.MaSP && masp1 != cv.MaSP)
                {
                    masp2 = cv.MaSP;
                    kt++;
                }
                if (kt == 3 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP)
                {
                    masp3 = cv.MaSP;
                    kt++;
                }
                if (kt == 4 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP)
                {
                    masp4 = cv.MaSP;
                    kt++;
                }
                if (kt == 5 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                   masp4 != cv.MaSP)
                {
                    masp5 = cv.MaSP;
                    kt++;
                }
                if (kt == 6 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP)
                {
                    masp6 = cv.MaSP;
                    kt++;
                }
                if (kt == 7 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP)
                {
                    masp7 = cv.MaSP;
                    kt++;
                }
                if (kt == 8 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP)
                {
                    masp8 = cv.MaSP;
                    kt++;
                }
                if (kt == 9 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP)
                {
                    masp9 = cv.MaSP;
                    kt++;
                }
                if (kt == 10 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP &&
                    masp9 != cv.MaSP
            )
                {
                    masp10 = cv.MaSP;
                    kt++;
                }
                if (kt == 11 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP &&
                    masp9 != cv.MaSP && masp10 != cv.MaSP
            )
                {
                    masp11 = cv.MaSP;
                    kt++;
                }
                if (kt == 12 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP &&
                    masp4 != cv.MaSP && masp5 != cv.MaSP && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP &&
                    masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
            )
                {
                    masp12 = cv.MaSP;
                    kt++;
                }
                if (kt == 13 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
             && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
             && masp12 != cv.MaSP)
                {
                    masp13 = cv.MaSP;
                    kt++;
                }
                if (kt == 14 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
              && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
              && masp12 != cv.MaSP && masp13 != cv.MaSP)
                {
                    masp14 = cv.MaSP;
                    kt++;
                }
                if (kt == 15 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
               && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
               && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP)
                {
                    masp15 = cv.MaSP;
                    kt++;
                }
                if (kt == 16 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP)
                {
                    masp16 = cv.MaSP;
                    kt++;
                }
                if (kt == 17 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                 && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                 && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP && masp16 != cv.MaSP)
                {
                    masp17 = cv.MaSP;
                    kt++;
                }
                if (kt == 18 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                   && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                   && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP && masp16 != cv.MaSP && masp17 != cv.MaSP)
                {
                    masp18 = cv.MaSP;
                    kt++;
                }
                if (kt == 19 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                    && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                    && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP && masp16 != cv.MaSP && masp17 != cv.MaSP && masp18 != cv.MaSP)
                {
                    masp19 = cv.MaSP;
                    kt++;
                }
                if (kt == 20 && masp != cv.MaSP && masp1 != cv.MaSP && masp2 != cv.MaSP && masp3 != cv.MaSP && masp4 != cv.MaSP && masp5 != cv.MaSP
                    && masp6 != cv.MaSP && masp7 != cv.MaSP && masp8 != cv.MaSP && masp9 != cv.MaSP && masp10 != cv.MaSP && masp11 != cv.MaSP
                    && masp12 != cv.MaSP && masp13 != cv.MaSP && masp14 != cv.MaSP && masp15 != cv.MaSP && masp16 != cv.MaSP && masp17 != cv.MaSP && masp18 != cv.MaSP && masp19 != cv.MaSP)
                {
                    masp20 = cv.MaSP;
                    kt++;
                }

            }
            dssp = customerSPBUS.LayDssphd(masp, masp1, masp2, masp3, masp4, masp5, masp6, masp7, masp8, masp9, masp10, masp11, masp12, masp13
                , masp14, masp15, masp16, masp17, masp18, masp19, masp20, macuahang);
            bssp.DataSource = dssp.ToList();
            dtgv_ttsp.DataSource = bssp;

            //cua hang
            dsch = customerCHBUS.LayDsch();
            bsch.DataSource = dsch.ToList();
        }

        private void XuatHangcs_Load(object sender, EventArgs e)
        {
          txtMaPX.Text= "XH_" + "_" + DateTime.Now.ToString("ddMMyyyy-HHms");
         
            //them PX
            //load cua hang
            foreach (CuaHangDTO ch in dsch)
            {
                cmbcuahang.Items.Add(ch.TenCH.ToString());
            }
        }
        private PhieuXuatDTO layTTKH_moi()
        {
            string tien="0";
            string thanhtoan = txttongtien.Text;
            foreach (PhieuXuatDTO px in dskhs)
            {
                
                if (px.MaPX == txtMaPX.Text)
                {
                     tien = px.ThanhToan;                   
                }
            }
              
            float thanhtien = Int32.Parse(tien);
            float thanhtoans= Int32.Parse(thanhtoan);
            thanhtoans = thanhtoans + thanhtien;
  
            PhieuXuatDTO NewKH = new PhieuXuatDTO();
            NewKH.MaPX = string.IsNullOrEmpty(txtMaPX.Text) ? "" : txtMaPX.Text;
            NewKH.ThanhToan = thanhtoans.ToString();
            NewKH.NgayLap = DateTime.Now.ToString("dd/MM/yyyy");
            NewKH.MaCH = string.IsNullOrEmpty(labmach.Text) ? "" : labmach.Text;
            NewKH.MaNV = manv;
            NewKH.TringTrang = "Chờ nhận hàng";
            NewKH.TrangThai = "1";
            return NewKH;
        }
       
        void them()
        {
            PhieuXuatDTO khAdd = layTTKH_moi();
            bool kq = customerBUS.DKSP(khAdd);
            Load_Form();
        }

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
                dsctsp = customerCTSPBUS.LayDsmau(masanpham);
                bsctsp.DataSource = dsctsp.ToList();
                dataGridView1.DataSource = bsctsp;
            }
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
        }
        private CTPhieuXuatDTO layCTPX_moi()
        {
            CTPhieuXuatDTO NewKH = new CTPhieuXuatDTO();
            NewKH.MaCTPX = mactpx;
            NewKH.MaPX = string.IsNullOrEmpty(txtMaPX.Text) ? "" : txtMaPX.Text;
            NewKH.MaSP = string.IsNullOrEmpty(txtSP.Text) ? "" : txtSP.Text;
            NewKH.SoLuong = string.IsNullOrEmpty(txtsoluong.Text) ? "" : txtsoluong.Text;
            NewKH.GiaNhap = string.IsNullOrEmpty(txtdongia.Text) ? "" : txtdongia.Text;
            NewKH.MaMau = string.IsNullOrEmpty(txtmau.Text) ? "" : txtmau.Text;
            NewKH.MaSize = string.IsNullOrEmpty(txtkichthuoc.Text) ? "" : txtkichthuoc.Text;
            NewKH.ChiecKhau = "No ";
            NewKH.TrangThai = "1";
            return NewKH;
        }
       
        void updatePX()
        {
            PhieuXuatDTO khAdd = layTTKH_moi();
            bool kq = customerBUS.UpdateNV(khAdd);
            Load_Form();
        }
        public string mactpx;
       

        void themsanphamPX()
        {
            int i = 1;
            foreach (CTPhieuXuatDTO sps in dsctpx)
            {
                i++;
            }
            mactpx = txtMaPX.Text + "_SP-0"+i;
            CTPhieuXuatDTO khAdd = layCTPX_moi();
            bool kq = customerCTPXBUS.DKSP(khAdd);
           

            //update so luong chi tiết sp
            CTSanPhamDTO nv = layTTSP_sua();
            bool kqs = customerCTSPBUS.UpdateSL(nv);
           

            //update tien phieu xuat
            PhieuXuatDTO px = layTTKH_moi();
            bool kqpx = customerBUS.UpdateSL(px);

            
            MessageBox.Show("Thêm thành công");
            //thong báo thành công

            Load_Form();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them();
            themsanphamPX();
            //updatePX();
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            float dongia = Int32.Parse(txtdongia.Text);
            float soluong = Int32.Parse(txtsoluong.Text);
            float thanhtien = dongia * soluong;
            txttongtien.Text = thanhtien.ToString();
        }
        private CTSanPhamDTO layTTSP_sua()
        {
            //tinh so luong con lai
            string soluongkho = null;
            foreach (CTSanPhamDTO cv in dsctsp)
            {
                if (cv.MaSP == txtSP.Text && cv.MaMau==txtmau.Text && cv.KichThuoc==txtkichthuoc.Text)
                {
                    soluongkho = cv.SoLuong;
                }
            }
            float slupdates = Int32.Parse(soluongkho);
            float soluongss = Int32.Parse(txtsoluong.Text);
            float slconlai = slupdates - soluongss;
            //end
            if (slconlai <= 0)
            {
                slconlai = 0;
            }
            CTSanPhamDTO NewSP = new CTSanPhamDTO();
            NewSP.MaSP = string.IsNullOrEmpty(txtSP.Text) ? "" : txtSP.Text;
            NewSP.MaMau= string.IsNullOrEmpty(txtmau.Text) ? "" : txtmau.Text;
            NewSP.KichThuoc = string.IsNullOrEmpty(txtkichthuoc.Text) ? "" : txtkichthuoc.Text;
            NewSP.SoLuong = slconlai.ToString();
            NewSP.TrangThai = "1";
            return NewSP;
        }

        private void cmbcuahang_onItemSelected(object sender, EventArgs e)
        {
            labmach.Visible = true;
            foreach (CuaHangDTO ch in dsch)
            {
                if (cmbcuahang.selectedValue == ch.TenCH.ToString())
                {
                    labmach.Text = ch.MaCH.ToString();
                }
            }
        }
    }
}
