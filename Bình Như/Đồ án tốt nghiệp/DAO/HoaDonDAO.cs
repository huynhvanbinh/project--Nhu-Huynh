using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
   public class HoaDonDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            HoaDon hd = new HoaDon();
            hd.MaHD = "";
            hd.NgayLap = null;
            hd.MaNV = "";
            hd.MaKH = "";
            hd.TongTien = "";
            hd.TrangThai = "1";
            demos.HoaDons.Add(hd);
            demos.SaveChanges();
        }

        public List<HoaDonDTO> layDSSP(string ngay)
        {
            List<HoaDonDTO> Dssp = new List<HoaDonDTO>();
            Dssp = demos.HoaDons.Where(u => u.TrangThai == "1" && u.NgayLap==ngay).Select(u => new HoaDonDTO
            {
                MaHD=u.MaHD,
                NgayLap= u.NgayLap,
                MaNV=u.MaNV,
                MaKH=u.MaKH,
                TongTien=u.TongTien,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public HoaDonDTO laySP(string masp)
        {
            HoaDonDTO sp = new HoaDonDTO();
            sp = demos.HoaDons.Where(u => u.TrangThai == "1").Select(u => new HoaDonDTO
            {
                MaHD = u.MaHD,
                NgayLap = u.NgayLap,
                MaNV = u.MaNV,
                MaKH = u.MaKH,
                TongTien = u.TongTien,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(HoaDonDTO sp)
        {
            HoaDon customer = new HoaDon();
            try
            {
                customer.MaHD = sp.MaHD;
                customer.NgayLap = sp.NgayLap;
                customer.MaNV = sp.MaNV;
                customer.MaKH = sp.MaKH;
                customer.TongTien = sp.TongTien;
                customer.TrangThai = sp.TrangThai;
                demos.HoaDons.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(HoaDonDTO hd)
        {
            try
            {
                HoaDon customer = demos.HoaDons.Where(u => u.MaHD == hd.MaHD).SingleOrDefault();
                customer.TongTien = hd.TongTien;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(HoaDonDTO hd)
        {
            try
            {
                HoaDon customer = demos.HoaDons.Where(u => u.MaHD == hd.MaHD).SingleOrDefault();
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
