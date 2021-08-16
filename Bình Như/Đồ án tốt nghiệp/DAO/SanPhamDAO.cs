using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
   public class SanPhamDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            SanPham sp = new SanPham();
            sp.MaSP = "";
            sp.TenSP = "";
            sp.DonGia = "";
            sp.MaLoai = "";
            sp.GiaNhap = "";
            sp.SoLuongTon = "";
            sp.MoTa = "";
            sp.HinhAnh = "";
            sp.TrangThai = "1";
            demos.SanPhams.Add(sp);
            demos.SaveChanges();
        }

        public List<SanPhamDTO> layDSSP()
        {
            List<SanPhamDTO> Dssp = new List<SanPhamDTO>();
            Dssp = demos.SanPhams.Where(u => u.TrangThai == "1").Select(u => new SanPhamDTO
            {
                MaSP = u.MaSP,
                TenSP = u.TenSP,
                DonGia = u.DonGia,
                MaLoai = u.MaLoai,
                GiaNhap=u.GiaNhap,
                SoLuongTon=u.SoLuongTon,
                MoTa=u.MoTa,
                HinhAnh=u.HinhAnh,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public List<SanPhamDTO> layDSMaCH(string mach)
        {
            List<SanPhamDTO> Dssp = new List<SanPhamDTO>();
            Dssp = demos.SanPhams.Where(u => u.TrangThai == "1" ).Select(u => new SanPhamDTO
            {
                MaSP = u.MaSP,
                TenSP = u.TenSP,
                DonGia = u.DonGia,
                MaLoai = u.MaLoai,
                GiaNhap = u.GiaNhap,
                SoLuongTon = u.SoLuongTon,
                MoTa = u.MoTa,
                HinhAnh = u.HinhAnh,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public List<SanPhamDTO> layDSSPbancham()
        {
            List<SanPhamDTO> Dssp = new List<SanPhamDTO>();
            Dssp = demos.SanPhams.Where(u => u.TrangThai == "1").OrderByDescending(u=>u.SoLuongTon ).Select(u => new SanPhamDTO
            {
                MaSP = u.MaSP,
                TenSP = u.TenSP,
                DonGia = u.DonGia,
                MaLoai = u.MaLoai,
                GiaNhap = u.GiaNhap,
                SoLuongTon = u.SoLuongTon,
                MoTa = u.MoTa,
                HinhAnh = u.HinhAnh,
                TrangThai = u.TrangThai,
            }).Take(2).ToList();
            return Dssp;
        }
        public List<SanPhamDTO> layDSSPHD(string masp, string masp1, string masp2, string masp3, string masp4, string masp5, string masp6,
            string masp7, string masp8, string masp9, string masp10, string masp11, string masp12, string masp13, string masp14, string masp15,
            string masp16, string masp17, string masp18, string masp19, string masp20, string macuahang)
        {
            List<SanPhamDTO> Dssp = new List<SanPhamDTO>();
            Dssp = demos.SanPhams.Where(u => u.TrangThai == "1" &&u.MaSP != masp && u.MaSP != masp1 && u.MaSP != masp2 && u.MaSP != masp3
            && u.MaSP != masp4 && u.MaSP != masp5 && u.MaSP != masp6 && u.MaSP != masp7 && u.MaSP != masp8 && u.MaSP != masp9 && u.MaSP != masp10 && u.MaSP != masp11
            && u.MaSP != masp12 && u.MaSP != masp13 && u.MaSP != masp14 && u.MaSP != masp15 && u.MaSP != masp16 && u.MaSP != masp17 && u.MaSP != masp18
            && u.MaSP != masp19 && u.MaSP != masp20 ).Select(u => new SanPhamDTO
            {
                MaSP = u.MaSP,
                TenSP = u.TenSP,
                DonGia = u.DonGia,
                MaLoai = u.MaLoai,
                GiaNhap = u.GiaNhap,
                SoLuongTon = u.SoLuongTon,
                MoTa = u.MoTa,
                HinhAnh = u.HinhAnh,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public List<SanPhamDTO> layDSSPKM(string masp, string masp1, string masp2, string masp3, string masp4, string masp5, string masp6,
           string masp7, string masp8, string masp9, string masp10, string masp11, string masp12, string masp13, string masp14, string masp15,
           string masp16, string masp17, string masp18, string masp19, string masp20)
        {
            List<SanPhamDTO> Dssp = new List<SanPhamDTO>();
            Dssp = demos.SanPhams.Where(u => u.TrangThai == "1" && u.MaSP != masp && u.MaSP != masp1 && u.MaSP != masp2 && u.MaSP != masp3
            && u.MaSP != masp4 && u.MaSP != masp5 && u.MaSP != masp6 && u.MaSP != masp7 && u.MaSP != masp8 && u.MaSP != masp9 && u.MaSP != masp10 && u.MaSP != masp11
            && u.MaSP != masp12 && u.MaSP != masp13 && u.MaSP != masp14 && u.MaSP != masp15 && u.MaSP != masp16 && u.MaSP != masp17 && u.MaSP != masp18
            && u.MaSP != masp19 && u.MaSP != masp20).Select(u => new SanPhamDTO
            {
                MaSP = u.MaSP,
                TenSP = u.TenSP,
                DonGia = u.DonGia,
                MaLoai = u.MaLoai,
                GiaNhap = u.GiaNhap,
                SoLuongTon = u.SoLuongTon,
                MoTa = u.MoTa,
                HinhAnh = u.HinhAnh,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public SanPhamDTO laySP(string makh)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp = demos.SanPhams.Where(u => u.TrangThai == "1").Select(u => new SanPhamDTO
            {
                MaSP = u.MaSP,
                TenSP = u.TenSP,
                DonGia = u.DonGia,
                MaLoai = u.MaLoai,
                GiaNhap = u.GiaNhap,
                SoLuongTon = u.SoLuongTon,
                MoTa = u.MoTa,
                HinhAnh = u.HinhAnh,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(SanPhamDTO sp)
        {
            SanPham customer = new SanPham();

            try
            {
                customer.MaSP = sp.MaSP;
                customer.TenSP =sp.TenSP;
                customer.DonGia = sp.DonGia;
                customer.MaLoai = sp.MaLoai;
                customer.GiaNhap = sp.GiaNhap;
                customer.SoLuongTon = sp.SoLuongTon;
                customer.MoTa = sp.MoTa;
                customer.HinhAnh = sp.HinhAnh;
                customer.TrangThai = sp.TrangThai;
                demos.SanPhams.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(SanPhamDTO sp)
        {
            try
            {
                SanPham customer = demos.SanPhams.Where(u => u.MaSP == sp.MaSP).SingleOrDefault();
                customer.TenSP = sp.TenSP;
                customer.DonGia = sp.DonGia;
                customer.MaLoai = sp.MaLoai;
                customer.GiaNhap = sp.GiaNhap;
                customer.SoLuongTon = sp.SoLuongTon;
                customer.MoTa = sp.MoTa;
                customer.HinhAnh = sp.HinhAnh;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateSL(SanPhamDTO sp)
        {
            try
            {
                SanPham customer = demos.SanPhams.Where(u => u.MaSP == sp.MaSP).SingleOrDefault();  
                customer.SoLuongTon = sp.SoLuongTon;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(SanPhamDTO sp)
        {
            try
            {
                SanPham customer = demos.SanPhams.Where(u => u.MaSP == sp.MaSP).SingleOrDefault();
                customer.TrangThai = "0";
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}