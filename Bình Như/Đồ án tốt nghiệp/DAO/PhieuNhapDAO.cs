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
            pn.MaPhieuNhap = "";
            pn.NgayLap = null;
            pn.ThanhToan = "";
            pn.MaNN = "";
            pn.MaNCC = "";
            pn.TrangThai = "1";
            demos.PhieuNhaps.Add(pn);
            demos.SaveChanges();
        }

        public List<PhieuNhapDTO> layDSSP()
        {
            List<PhieuNhapDTO> Dssp = new List<PhieuNhapDTO>();
            Dssp = demos.PhieuNhaps.Where(u => u.TrangThai == "1").Select(u => new PhieuNhapDTO
            {
                MaPhieuNhap = u.MaPhieuNhap,
               NgayLap = (DateTime)u.NgayLap,
                ThanhToan = u.ThanhToan,
                MaNN=u.MaNN,
                MaNCC = u.MaNCC,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public PhieuNhapDTO laySP(string makh)
        {
            PhieuNhapDTO sp = new PhieuNhapDTO();
            sp = demos.PhieuNhaps.Where(u => u.TrangThai == "1").Select(u => new PhieuNhapDTO
            {
                MaPhieuNhap = u.MaPhieuNhap,
                NgayLap = (DateTime)u.NgayLap,
                ThanhToan = u.ThanhToan,
                MaNN = u.MaNN,
                MaNCC = u.MaNCC,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(PhieuNhapDTO sp)
        {
            PhieuNhap customer = new PhieuNhap();

            try
            {
                customer.MaPhieuNhap = sp.MaPhieuNhap;
                customer.NgayLap = sp.NgayLap;
                customer.ThanhToan = sp.ThanhToan;
                customer.MaNN = sp.MaNN;
                customer.MaNCC = sp.MaNCC;
               
                demos.PhieuNhaps.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(PhieuNhapDTO sp)
        {
            try
            {
                PhieuNhap customer = demos.PhieuNhaps.Where(u => u.MaPhieuNhap == sp.MaPhieuNhap).SingleOrDefault();
                customer.NgayLap = sp.NgayLap;
                customer.ThanhToan = sp.ThanhToan;
                customer.MaNN = sp.MaNN;
                customer.MaNCC = sp.MaNCC;
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
                PhieuNhap customer = demos.PhieuNhaps.Where(u => u.MaPhieuNhap== hd.MaPhieuNhap).SingleOrDefault();
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
