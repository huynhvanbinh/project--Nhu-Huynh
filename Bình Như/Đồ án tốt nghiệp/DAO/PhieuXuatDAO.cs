using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhieuXuatDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            PhieuXuat pn = new PhieuXuat();
            pn.MaPX = "";
            pn.NgayLap = "";
            pn.ThanhToan = "";
            pn.MaNV = "";
            pn.MaCH = "";
            pn.TringTrang = "";
            pn.TrangThai = "1";
            demos.PhieuXuats.Add(pn);
            demos.SaveChanges();
        }

        public List<PhieuXuatDTO> layDSSP()
        {
            List<PhieuXuatDTO> Dssp = new List<PhieuXuatDTO>();
            Dssp = demos.PhieuXuats.Where(u => u.TrangThai == "1").Select(u => new PhieuXuatDTO
            {
                MaPX = u.MaPX,
                NgayLap = u.NgayLap,
                ThanhToan = u.ThanhToan,
                MaNV = u.MaNV,
                MaCH = u.MaCH,
                TringTrang=u.TringTrang,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public List<PhieuXuatDTO> layDSSPNgay(string ngay)
        {
            List<PhieuXuatDTO> Dssp = new List<PhieuXuatDTO>();
            Dssp = demos.PhieuXuats.Where(u => u.TrangThai == "1" && u.NgayLap==ngay).Select(u => new PhieuXuatDTO
            {
                MaPX = u.MaPX,
                NgayLap = u.NgayLap,
                ThanhToan = u.ThanhToan,
                MaNV = u.MaNV,
                MaCH = u.MaCH,
                TringTrang=u.TringTrang,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public List<PhieuXuatDTO> layDSSPkhongtrangthai()
        {
            List<PhieuXuatDTO> Dssp = new List<PhieuXuatDTO>();
            Dssp = demos.PhieuXuats.Select(u => new PhieuXuatDTO
            {
                MaPX = u.MaPX,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public PhieuXuatDTO laySP(string makh)
        {
            PhieuXuatDTO sp = new PhieuXuatDTO();
            sp = demos.PhieuXuats.Where(u => u.TrangThai == "1").Select(u => new PhieuXuatDTO
            {
                MaPX = u.MaPX,
                NgayLap = u.NgayLap,
                ThanhToan = u.ThanhToan,
                MaNV = u.MaNV,
                MaCH = u.MaCH,
                TringTrang=u.TringTrang,
                TrangThai = u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(PhieuXuatDTO sp)
        {
            PhieuXuat customer = new PhieuXuat();

            try
            {
                customer.MaPX = sp.MaPX;
                customer.NgayLap = sp.NgayLap;
                customer.ThanhToan = sp.ThanhToan;
                customer.MaNV = sp.MaNV;
                customer.MaCH = sp.MaCH;
                customer.TringTrang = sp.TringTrang;
                customer.TrangThai = "1";
                demos.PhieuXuats.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(PhieuXuatDTO hd)
        {
            try
            {
                PhieuXuat customer = demos.PhieuXuats.Where(u => u.MaPX == hd.MaPX).SingleOrDefault();
                customer.MaPX = hd.MaPX;
                customer.TringTrang = hd.TringTrang;
              
              
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateSL(PhieuXuatDTO sp)
        {
            try
            {
                PhieuXuat customer = demos.PhieuXuats.Where(u => u.MaPX == sp.MaPX ).SingleOrDefault();
                customer.ThanhToan = sp.ThanhToan;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(PhieuXuatDTO hd)
        {
            try
            {
                PhieuXuat customer = demos.PhieuXuats.Where(u => u.MaPX == hd.MaPX).SingleOrDefault();
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
