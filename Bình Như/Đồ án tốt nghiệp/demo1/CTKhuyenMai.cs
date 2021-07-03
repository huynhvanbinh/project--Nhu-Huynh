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
            this.FormBorderStyle = FormBorderStyle.None;
            Load_Form();
        }
        CTKhuyenMaiBUS customerBUS = new CTKhuyenMaiBUS();
        BindingSource bs = new BindingSource();
        List<CTKhuyenMaiDTO> dskhs = new List<CTKhuyenMaiDTO>();

        SanPhamBUS customerSPBUS = new SanPhamBUS();
        BindingSource bssp = new BindingSource();
        List<SanPhamDTO> dssp = new List<SanPhamDTO>();

        CuaHangBUS customerCHBUS = new CuaHangBUS();
        BindingSource bsch = new BindingSource();
        List<CuaHangDTO> dsch = new List<CuaHangDTO>();

        KhuyenMaiBUS customerKMBUS = new KhuyenMaiBUS();
        BindingSource bskm = new BindingSource();
        List<KhuyenMaiDTO> dskm = new List<KhuyenMaiDTO>();
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
            int kt = 0;
            foreach (CTKhuyenMaiDTO cv in dskhs)
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
            dssp = customerSPBUS.LayDsspkm(masp, masp1, masp2, masp3, masp4, masp5, masp6, masp7, masp8, masp9, masp10, masp11, masp12, masp13
                , masp14, masp15, masp16, masp17, masp18, masp19, masp20);
            bssp.DataSource = dssp.ToList();
            dataGridView1.DataSource = bssp;
            //load dữ liệu bảng cửa hàng
            dsch = customerCHBUS.LayDsch();
            bsch.DataSource = dsch.ToList();
            //load dữ liệu bảng khuyến mãi
            dskm = customerKMBUS.LayDssp();
            bskm.DataSource = dskm.ToList();
        }
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                int i;
                i = dtgv_ttkh.CurrentRow.Index;
                txtkhuyenmai.Text = dtgv_ttkh.Rows[i].Cells[0].Value.ToString();
                txtmasp.Text = dtgv_ttkh.Rows[i].Cells[2].Value.ToString();
                txtmakm.Text = dtgv_ttkh.Rows[i].Cells[1].Value.ToString();
                txtgiamgia.Text = dtgv_ttkh.Rows[i].Cells[4].Value.ToString();
                txtmach.Text = dtgv_ttkh.Rows[i].Cells[3].Value.ToString();
                dssp = customerSPBUS.LayDssp();
                foreach (SanPhamDTO cv in dssp)
                {
                    if (cv.MaSP == txtmasp.Text)
                    {
                        txttensp.Text = cv.TenSP;
                        txtdongia.Text = cv.DonGia;
                        txtsoluong.Text = cv.SoLuongTon;
                    }
                }

            }
        }
        private CTKhuyenMaiDTO layTTKH_moi()
        {
            CTKhuyenMaiDTO NewKH = new CTKhuyenMaiDTO();
            NewKH.MaKM = string.IsNullOrEmpty(txtmakm.Text) ? "" : txtmakm.Text;
            NewKH.MaSP = string.IsNullOrEmpty(txtmasp.Text) ? "" : txtmasp.Text;
            NewKH.MaCH = string.IsNullOrEmpty(txtmach.Text) ? "" : txtmach.Text;
            NewKH.MaCTKM = string.IsNullOrEmpty(txtkhuyenmai.Text) ? "" : txtkhuyenmai.Text;
            NewKH.MaKH = string.IsNullOrEmpty(txtkhachhang.Text) ? "" : txtkhachhang.Text;
            NewKH.GiamGia = string.IsNullOrEmpty(txtkhuyenmai.Text) ? "" : txtgiamgia.Text;
            NewKH.TrangThai = "1";
            return NewKH;
        }
        private CTKhuyenMaiDTO layTTKH_sua()
        {
            CTKhuyenMaiDTO NewKH = new CTKhuyenMaiDTO();
            NewKH.MaKM = string.IsNullOrEmpty(txtmakm.Text) ? "" : txtmakm.Text;
            NewKH.MaSP = string.IsNullOrEmpty(txtmasp.Text) ? "" : txtmasp.Text;
            NewKH.MaCH = string.IsNullOrEmpty(txtmach.Text) ? "" : txtmach.Text;
            NewKH.MaCTKM = string.IsNullOrEmpty(txtkhuyenmai.Text) ? "" : txtkhuyenmai.Text;
            NewKH.MaKH = string.IsNullOrEmpty(txtkhachhang.Text) ? "" : txtkhachhang.Text;
            NewKH.GiamGia = string.IsNullOrEmpty(txtkhuyenmai.Text) ? "" : txtgiamgia.Text;
            NewKH.TrangThai = "0";
            return NewKH;
        }
        private void reset()
        {
            txtkhuyenmai.Text = "";
            txtmasp.Text = "";
            txtmach.Text = "";
            txtkhuyenmai.Text = "";
            txtkhachhang.Text = "";
            txtgiamgia.Text = "";
            txtdongia.Text = "";
            txttensp.Text = "";
            txtsoluong.Text = "";
        }
        private void Them_Click_1()
        {
            CTKhuyenMaiDTO khAdd = layTTKH_moi();
            if (khAdd.GiamGia == ""||khAdd.MaKH=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }else if(khAdd.MaKM==""||khAdd.MaSP==""||khAdd.MaCH=="")
            {
                MessageBox.Show("Vui lòng CHON  đầy đủ thông tin!");
                return;
            }

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
                    sua();
                    //reset;
                }
            }
            else
            {
                bool kq = customerBUS.DKSP(khAdd);
                MessageBox.Show("Thêm thành công");
            }
            reset();
            Load_Form();
        }
        private void bunifuButton3_Click_1()
        {
            reset();
        }
        //load du lieu len combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (SanPhamDTO sps in dssp)
            //{
            //    cmbsanpham.Items.Add(sps.TenSP.ToString());
            //}
            foreach (CuaHangDTO chs in dsch)
            {
                cmbcuahang.Items.Add(chs.TenCH.ToString());
            }
            //foreach (KhuyenMaiDTO kms in dskm)
            //{
            //    cmbkhuyenmai.Items.Add(kms.TenKM.ToString());
            //}
            txtmakm.Text = MaMai;
            string ma = MaMai;
            dskhs = customerBUS.LayDsspdk(ma);
            bs.DataSource = dskhs.ToList();
            dtgv_ttkh.DataSource = bs;

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
            int kt = 0;
            foreach (CTKhuyenMaiDTO cv in dskhs)
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
            dssp = customerSPBUS.LayDsspkm(masp, masp1, masp2, masp3, masp4, masp5, masp6, masp7, masp8, masp9, masp10, masp11, masp12, masp13
                , masp14, masp15, masp16, masp17, masp18, masp19, masp20);
            bssp.DataSource = dssp.ToList();
            dataGridView1.DataSource = bssp;
        }

        private void changmach(object sender, EventArgs e)
        {
            foreach (CuaHangDTO chs in dsch)
            {
                if (cmbcuahang.selectedValue == chs.TenCH.ToString())
                {
                    txtmach.Text = chs.MaCH.ToString();
                }
                Load_DSKH();
                int i = dtgv_ttkh.Rows.Count;
                   txtkhuyenmai.Text =txtmakm.Text +" _ "+"SP-"+ i.ToString();
            }
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
                txtsoluong.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            }
        }
        public void sua()
        {
            CTKhuyenMaiDTO nv = layTTKH_moi();

            bool kq = customerBUS.UpdateNV(nv);

            MessageBox.Show("bạn đã thay đổi thành công");
            Load_Form();
        }

       

        private void bunifuButton1_Click()
        {
            DialogResult h = MessageBox.Show
                 ("Bạn có muốn thoát chi tiết khuyến mãi",
                 "Thông báo !!!",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them_Click_1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuButton1_Click();
        }
        private void xoa()
        {
            CTKhuyenMaiDTO khAdd = layTTKH_sua();
            if (khAdd.MaKM == "" || khAdd.MaCTKM == ""|| khAdd.GiamGia == "")
            {
                MessageBox.Show("Vui lòng chọn sanr phamar khuyeens maix xoa!!");
                return;
            }
            else
            {
                CTKhuyenMaiDTO nv = layTTKH_sua();
                bool kq = customerBUS.DELETENV(nv);
                MessageBox.Show("Đã xóa ");
                reset();
                Load_Form();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xoa();
        }
    }
}
