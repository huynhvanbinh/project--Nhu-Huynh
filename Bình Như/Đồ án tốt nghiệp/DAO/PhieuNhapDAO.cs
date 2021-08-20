using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhieuNhapDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            PhieuNhap pn = new PhieuNhap();
            pn.MaPN = "";
            pn.NgayLap = "";
            pn.ThanhToan = "";
            pn.MaNV = "";
            pn.MaCH = "";
            pn.TrangThai = "1";
            demos.PhieuNhaps.Add(pn);
            demos.SaveChanges();
        }
        public bool UpdateSL(PhieuNhapDTO sp)
        {
            try
            {
                PhieuNhap customer = demos.PhieuNhaps.Where(u => u.MaPN == sp.MaPN).SingleOrDefault();
                customer.ThanhToan = sp.ThanhToan;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<PhieuNhapDTO> layDSSP()
        {
            List<PhieuNhapDTO> Dssp = new List<PhieuNhapDTO>();
            Dssp = demos.PhieuNhaps.Where(u => u.TrangThai == "1").Select(u => new PhieuNhapDTO
            {
                MaPN=u.MaPN,
                NgayLap=u.NgayLap,
                ThanhToan=u.ThanhToan,
                MaNV=u.MaNV,
                MaCH=u.MaCH,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public List<PhieuNhapDTO> layDSSPNgay(string ngay)
        {
            List<PhieuNhapDTO> Dssp = new List<PhieuNhapDTO>();
            Dssp = demos.PhieuNhaps.Where(u => u.TrangThai == "1" && u.NgayLap == ngay).Select(u => new PhieuNhapDTO
            {
                MaPN = u.MaPN,
                NgayLap = u.NgayLap,
                ThanhToan = u.ThanhToan,
                MaNV = u.MaNV,
                MaCH = u.MaCH,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public PhieuNhapDTO laySP(string makh)
        {
            PhieuNhapDTO sp = new PhieuNhapDTO();
            sp = demos.PhieuNhaps.Where(u => u.TrangThai == "1").Select(u => new PhieuNhapDTO
            {
                MaPN=u.MaPN,
                NgayLap=u.NgayLap,
                ThanhToan=u.ThanhToan,
                MaNV=u.MaNV,
                MaCH=u.MaCH,
                TrangThai = u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(PhieuNhapDTO sp)
        {
            PhieuNhap customer = new PhieuNhap();

            try
            {
                customer.MaPN = sp.MaPN;
                customer.NgayLap = sp.NgayLap;
                customer.ThanhToan = sp.ThanhToan;
                customer.MaNV = sp.MaNV;
                customer.MaCH = sp.MaCH;
                customer.TrangThai = "1";
                demos.PhieuNhaps.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(PhieuNhapDTO hd)
        {
            try
            {
                PhieuNhap customer = demos.PhieuNhaps.Where(u => u.MaPN == hd.MaPN).SingleOrDefault();
                customer.MaPN = hd.MaPN;
                customer.NgayLap = hd.NgayLap;
                customer.ThanhToan = hd.ThanhToan;
                customer.MaNV = hd.MaNV;
                customer.MaCH = hd.MaCH;
                customer.TrangThai = "1";
                demos.PhieuNhaps.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(PhieuNhapDTO hd)
        {
            try
            {
                PhieuNhap customer = demos.PhieuNhaps.Where(u => u.MaPN == hd.MaPN).SingleOrDefault();
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
