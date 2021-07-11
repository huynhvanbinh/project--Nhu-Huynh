using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CTPhieuXuatDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            CTPhieuXuat pn = new CTPhieuXuat();
            pn.MaCTPX = "";
            pn.MaPX = "";
            pn.MaSP = "";
            pn.MaSize = "";
            pn.MaMau = "";
            pn.SoLuong = "";
            pn.GiaNhap = "";
            pn.ChiecKhau = "";
            pn.TrangThai = "1";
            demos.CTPhieuXuats.Add(pn);
            demos.SaveChanges();
        }

        public List<CTPhieuXuatDTO> layDSSPDK(string ma)
        {
            List<CTPhieuXuatDTO> Dssp = new List<CTPhieuXuatDTO>();
            Dssp = demos.CTPhieuXuats.Where(u => u.TrangThai == "1" && u.MaPX == ma).Select(u => new CTPhieuXuatDTO
            {
                MaCTPX = u.MaCTPX,
                MaPX = u.MaPX,
                MaSP = u.MaSP,
                MaMau = u.MaMau,
                MaSize = u.MaSize,
                SoLuong = u.SoLuong,
                GiaNhap = u.GiaNhap,
                ChiecKhau = u.ChiecKhau,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public List<CTPhieuXuatDTO> layDSSP()
        {
            List<CTPhieuXuatDTO> Dssp = new List<CTPhieuXuatDTO>();
            Dssp = demos.CTPhieuXuats.Where(u => u.TrangThai == "1").Select(u => new CTPhieuXuatDTO
            {
                MaCTPX = u.MaCTPX,
                MaPX = u.MaPX,
                MaSP = u.MaSP,
                MaMau = u.MaMau,
                MaSize = u.MaSize,
                SoLuong = u.SoLuong,
                GiaNhap = u.GiaNhap,
                ChiecKhau = u.ChiecKhau,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public CTPhieuXuatDTO laySP(string makh)
        {
            CTPhieuXuatDTO sp = new CTPhieuXuatDTO();
            sp = demos.CTPhieuXuats.Where(u => u.TrangThai == "1").Select(u => new CTPhieuXuatDTO
            {
                MaCTPX = u.MaCTPX,
                MaPX = u.MaPX,
                MaSP = u.MaSP,
                MaMau = u.MaMau,
                MaSize = u.MaSize,
                SoLuong = u.SoLuong,
                GiaNhap = u.GiaNhap,
                ChiecKhau = u.ChiecKhau,
                TrangThai = u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(CTPhieuXuatDTO sp)
        {
            CTPhieuXuat customer = new CTPhieuXuat();

            try
            {
                customer.MaCTPX = sp.MaCTPX;
                customer.MaPX = sp.MaPX;
                customer.MaSP = sp.MaSP;
                customer.MaMau = sp.MaMau;
                customer.MaSize = sp.MaSize;
                customer.SoLuong = sp.SoLuong;
                customer.GiaNhap = sp.GiaNhap;
                customer.ChiecKhau = sp.ChiecKhau;
                customer.TrangThai = sp.TrangThai;
                demos.CTPhieuXuats.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(CTPhieuXuatDTO hd)
        {
            try
            {
                CTPhieuXuat customer = demos.CTPhieuXuats.Where(u => u.MaCTPX == hd.MaCTPX).SingleOrDefault();
                customer.MaCTPX = hd.MaCTPX;
                customer.MaPX = hd.MaPX;
                customer.MaSP = hd.MaSP;
                customer.MaMau = hd.MaMau;
                customer.MaSize = hd.MaSize;
                customer.SoLuong = hd.SoLuong;
                customer.GiaNhap = hd.GiaNhap;
                customer.ChiecKhau = hd.ChiecKhau;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(CTPhieuXuatDTO hd)
        {
            try
            {
                CTPhieuXuat customer = demos.CTPhieuXuats.Where(u => u.MaCTPX == hd.MaCTPX).SingleOrDefault();
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
