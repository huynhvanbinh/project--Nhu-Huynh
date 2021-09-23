using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LuongNhanVienDAO
    {
        demoEntities demos = new demoEntities();
        public void themKH()
        {
            LuongNhanVien chucvu = new LuongNhanVien();
            chucvu.MaLuong = "";
            chucvu.MaNV = "";
            chucvu.Ngay = "";
            chucvu.LuongCoBan = "";
            chucvu.SoNgayLam = "";
            chucvu.TangCa = "";
            chucvu.ThamNien = "";
            chucvu.PhuCap = "";
            chucvu.Thuong = "";
            chucvu.TienLanh = "";
            chucvu.LuongPartTime = "";
            chucvu.SoGiolam = "";
            chucvu.TrangThai = "1";
            demos.LuongNhanViens.Add(chucvu);
            demos.SaveChanges();
        }

        public List<LuongNhanVienDTO> layDSKH()
        {
            List<LuongNhanVienDTO> Dskh = new List<LuongNhanVienDTO>();
            Dskh = demos.LuongNhanViens.Where(u => u.TrangThai == "1").Select(u => new LuongNhanVienDTO
            {
                MaLuong = u.MaLuong,
                MaNV = u.MaNV,
                Ngay = u.Ngay,
                LuongCoBan = u.LuongCoBan,
                SoNgayLam = u.SoNgayLam,
                TangCa = u.TangCa,
                ThamNien = u.ThamNien,
                PhuCap = u.PhuCap,
                Thuong = u.Thuong,
                TienLanh = u.TienLanh,
                LuongPartTime = u.LuongPartTime,
                SoGioLam = u.SoGiolam,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dskh;
        }
        public List<LuongNhanVienDTO> layDSLT(string ngay, string nam)
        {
            List<LuongNhanVienDTO> Dskh = new List<LuongNhanVienDTO>();
            Dskh = demos.LuongNhanViens.Where(u => u.TrangThai == "1").Select(u => new LuongNhanVienDTO
            {
                MaLuong = u.MaLuong,
                MaNV = u.MaNV,
                Ngay=u.Ngay,
                LuongCoBan = u.LuongCoBan,
                SoNgayLam = u.SoNgayLam,
                TangCa = u.TangCa,
                ThamNien = u.ThamNien,
                PhuCap = u.PhuCap,
                Thuong = u.Thuong,
                TienLanh = u.TienLanh,
                LuongPartTime = u.LuongPartTime,
                SoGioLam = u.SoGiolam,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dskh;
        }
        public List<LuongNhanVienDTO> layDSCV(string ngay, string nam, string manv)
        {
            List<LuongNhanVienDTO> Dskh = new List<LuongNhanVienDTO>();
            Dskh = demos.LuongNhanViens.Where(u => u.TrangThai == "1"&& u.MaNV != manv).Select(u => new LuongNhanVienDTO
            {
                MaLuong = u.MaLuong,
                MaNV = u.MaNV,
                Ngay = u.Ngay,
                LuongCoBan = u.LuongCoBan,
                SoNgayLam = u.SoNgayLam,
                TangCa = u.TangCa,
                ThamNien = u.ThamNien,
                PhuCap = u.PhuCap,
                Thuong = u.Thuong,
                TienLanh = u.TienLanh,
                LuongPartTime = u.LuongPartTime,
                SoGioLam = u.SoGiolam,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dskh;
        }
        public List<LuongNhanVienDTO> layDSTK(string ngay, string nam, string noidung)
        {
            List<LuongNhanVienDTO> Dskh = new List<LuongNhanVienDTO>();
            Dskh = demos.LuongNhanViens.Where(u => u.TrangThai == "1" && u.MaNV == noidung).Select(u => new LuongNhanVienDTO
            {
                MaLuong = u.MaLuong,
                MaNV = u.MaNV,
                Ngay = u.Ngay,
                LuongCoBan = u.LuongCoBan,
                SoNgayLam = u.SoNgayLam,
                TangCa = u.TangCa,
                ThamNien = u.ThamNien,
                PhuCap = u.PhuCap,
                Thuong = u.Thuong,
                TienLanh = u.TienLanh,
                LuongPartTime = u.LuongPartTime,
                SoGioLam = u.SoGiolam,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dskh;
        }
        public LuongNhanVienDTO layKH(string makh)
        {
            LuongNhanVienDTO kh = new LuongNhanVienDTO();
            kh = demos.LuongNhanViens.Where(u => u.TrangThai == "1").Select(u => new LuongNhanVienDTO
            {
                MaLuong = u.MaLuong,
                MaNV = u.MaNV,
                Ngay = u.Ngay,
                LuongCoBan = u.LuongCoBan,
                SoNgayLam = u.SoNgayLam,
                TangCa = u.TangCa,
                ThamNien = u.ThamNien,
                PhuCap = u.PhuCap,
                Thuong = u.Thuong,
                TienLanh = u.TienLanh,
                LuongPartTime = u.LuongPartTime,
                SoGioLam = u.SoGiolam,
                TrangThai = u.TrangThai,
            }).SingleOrDefault();
            return kh;
        }

        public bool DKKH(LuongNhanVienDTO kh)
        {
            LuongNhanVien customer = new LuongNhanVien();
            try
            {
                customer.MaLuong = kh.MaLuong;
                customer.MaNV = kh.MaNV;
                customer.Ngay = kh.Ngay;
                customer.LuongCoBan = kh.LuongCoBan;
                customer.SoNgayLam = kh.SoNgayLam;
                customer.TangCa = kh.TangCa;
                customer.ThamNien = kh.ThamNien;
                customer.PhuCap = kh.PhuCap;
                customer.Thuong = kh.Thuong;
                customer.TienLanh = kh.TienLanh;
                customer.LuongPartTime = kh.LuongPartTime;
                customer.SoGiolam = kh.SoGioLam;
                customer.TrangThai = kh.TrangThai;
                demos.LuongNhanViens.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(LuongNhanVienDTO kh)
        {
            try
            {
                LuongNhanVien customer = demos.LuongNhanViens.Where(u => u.MaLuong == kh.MaLuong).SingleOrDefault();
                customer.LuongCoBan = kh.LuongCoBan;
                customer.SoNgayLam = kh.SoNgayLam;
                customer.TangCa = kh.TangCa;
                customer.ThamNien = kh.ThamNien;
                customer.PhuCap = kh.PhuCap;
                customer.Thuong = kh.Thuong;
                customer.TienLanh = kh.TienLanh;
                customer.LuongPartTime = kh.LuongPartTime;
                customer.SoGiolam = kh.SoGioLam;
                customer.MaNV = kh.MaNV;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(LuongNhanVienDTO hd)
        {
            try
            {
                LuongNhanVien customer = demos.LuongNhanViens.Where(u => u.MaLuong == hd.MaLuong).SingleOrDefault();
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
