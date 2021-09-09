using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhanVienDAO
    {
        demoEntities demos = new demoEntities();
        public void themKH()
        {
            NhanVien kh = new NhanVien();
            kh.MaNV = "";
            kh.TenNV = "";
            kh.SDT = "";
            kh.MaCV = "";
            kh.NgayVaoLam = "";
            kh.MaCH = "";
            kh.TrangThai = "1";
            demos.NhanViens.Add(kh);
            demos.SaveChanges();
        }

        public List<NhanVienDTO> layDSKH()
        {
            List<NhanVienDTO> Dskh = new List<NhanVienDTO>();
            Dskh = demos.NhanViens.Where(u => u.TrangThai == "1").Select(u => new NhanVienDTO
            {
                MaNV = u.MaNV,
                TenNV = u.TenNV,    
                SDT = u.SDT,
                MaCH=u.MaCH,
                MaCV=u.MaCV,
                NgayVaoLam=u.NgayVaoLam,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dskh;
        }
        public List<NhanVienDTO> layDSNVCH(string mach)
        {
            List<NhanVienDTO> Dskh = new List<NhanVienDTO>();
            Dskh = demos.NhanViens.Where(u => u.TrangThai == "1" && u.MaCH==mach).Select(u => new NhanVienDTO
            {
                MaNV = u.MaNV,
                TenNV = u.TenNV,
                SDT = u.SDT,
                MaCH = u.MaCH,
                MaCV = u.MaCV,
                NgayVaoLam = u.NgayVaoLam,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dskh;
        }

        public NhanVienDTO layKH(string makh)
        {
            NhanVienDTO kh = new NhanVienDTO();
            kh = demos.NhanViens.Where(u => u.TrangThai == "1").Select(u => new NhanVienDTO
            {
                MaNV = u.MaNV,
                TenNV = u.TenNV,
                SDT = u.SDT,
                MaCV=u.MaCV,
               MaCH=u.MaCH,
               NgayVaoLam=u.NgayVaoLam,
                TrangThai =u.TrangThai,
            }).SingleOrDefault();
            return kh;
        }

        public bool DKKH(NhanVienDTO kh)
        {
            NhanVien customer = new NhanVien();
         
            try
            {
                customer.MaNV = kh.MaNV;
                customer.TenNV = kh.TenNV;
                customer.SDT = kh.SDT;
                customer.MaCV = kh.MaCV;
                customer.MaCH = kh.MaCH;
                customer.NgayVaoLam = kh.NgayVaoLam;
                customer.TrangThai = kh.TrangThai;
                demos.NhanViens.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(NhanVienDTO hd)
        {
            try
            {
                NhanVien customer = demos.NhanViens.Where(u => u.MaNV == hd.MaNV).SingleOrDefault();
                customer.TenNV = hd.TenNV;
                customer.SDT = hd.SDT;
                customer.MaCV = hd.MaCV;
                customer.NgayVaoLam = hd.NgayVaoLam;
                customer.MaCH = hd.MaCH;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(NhanVienDTO hd)
        {
            try
            {
                NhanVien customer = demos.NhanViens.Where(u => u.MaNV == hd.MaNV).SingleOrDefault();
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
