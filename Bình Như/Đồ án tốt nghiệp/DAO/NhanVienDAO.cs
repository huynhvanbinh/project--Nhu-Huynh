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
                TrangThai=u.TrangThai,
            }).ToList();
            return Dskh;
        }
        public List<NhanVienDTO> layDSKHNgay(string manhanvien, string manhanvien1, string manhanvien2, string manhanvien3, string manhanvien4
            , string manhanvien5, string manhanvien6, string manhanvien7, string manhanvien8, string manhanvien9, string manhanvien10,
            string manhanvien11, string manhanvien12, string manhanvien13, string manhanvien14, string manhanvien15, string manhanvien16,
            string manhanvien17, string manhanvien18, string manhanvien19, string manhanvien20)
        {
            List<NhanVienDTO> Dskh = new List<NhanVienDTO>();
            Dskh = demos.NhanViens.Select(u => new NhanVienDTO
            {
                MaNV = u.MaNV,
                TenNV = u.TenNV,
                SDT = u.SDT,
                MaCH=u.MaCH,
                MaCV = u.MaCV,
                TrangThai = u.TrangThai,
            }).Where(u => u.TrangThai == "1" && u.MaNV != manhanvien && u.MaNV != manhanvien1 && u.MaNV != manhanvien2 && u.MaNV != manhanvien3
            && u.MaNV != manhanvien4 && u.MaNV != manhanvien5 && u.MaNV != manhanvien6 && u.MaNV != manhanvien7 && u.MaNV != manhanvien8
            && u.MaNV != manhanvien9 && u.MaNV != manhanvien10 && u.MaNV != manhanvien11 && u.MaNV != manhanvien12 && u.MaNV != manhanvien13 && u.MaNV != manhanvien14
            && u.MaNV != manhanvien15 && u.MaNV != manhanvien16 && u.MaNV != manhanvien17 && u.MaNV != manhanvien18 && u.MaNV != manhanvien19 && u.MaNV != manhanvien20)
            .ToList();
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
