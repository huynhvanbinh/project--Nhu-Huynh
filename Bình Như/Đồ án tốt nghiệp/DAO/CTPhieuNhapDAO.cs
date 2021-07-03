using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CTPhieuNhapDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            CTPhieuNhap ct = new CTPhieuNhap();
            ct.MaCTPN = "";
            ct.MaPhieuNhap = "";
            ct.MaSP = "";
            ct.SoLuong = "";
            ct.GiaNhap = "";
            ct.TongTien = "";
            ct.MaMau = "";
            ct.MaSize = "";
            ct.TrangThai = "1";
            demos.CTPhieuNhaps.Add(ct);
            demos.SaveChanges();
        }

        public List<CTPhieuNhapDTO> layDSSP()
        {
            List<CTPhieuNhapDTO> Dssp = new List<CTPhieuNhapDTO>();
            Dssp = demos.CTPhieuNhaps.Where(u=>u.TrangThai=="1").Select(u => new CTPhieuNhapDTO
            {
                MaCTPN=u.MaCTPN,
                MaPhieuNhap=u.MaPhieuNhap,
                MaSP=u.MaSP,
                MaCH=u.MaCH,
                GiaNhap=u.GiaNhap,
                SoLuong=u.SoLuong,
                TongTien=u.TongTien,
                MaMau=u.MaMau,
                MaSize=u.MaSize,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public CTPhieuNhapDTO laySP(string makh)
        {
            CTPhieuNhapDTO sp = new CTPhieuNhapDTO();
            sp = demos.CTPhieuNhaps.Where(u => u.TrangThai == "1").Select(u => new CTPhieuNhapDTO
            {
                MaCTPN = u.MaCTPN,
                MaPhieuNhap = u.MaPhieuNhap,
                MaSP = u.MaSP,
                MaCH = u.MaCH,
                GiaNhap = u.GiaNhap,
                SoLuong = u.SoLuong,
                TongTien = u.TongTien,
                MaMau = u.MaMau,
                MaSize = u.MaSize,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(CTPhieuNhapDTO ctpn)
        {
            CTPhieuNhap customer = new CTPhieuNhap();

            try
            {
                customer.MaCTPN = ctpn.MaCTPN;
                customer.MaPhieuNhap = ctpn.MaPhieuNhap;
                customer.MaSP = ctpn.MaSP;
                customer.SoLuong = ctpn.SoLuong;
                customer.GiaNhap = ctpn.GiaNhap;
                customer.TongTien = ctpn.TongTien;
                customer.MaMau = ctpn.MaMau;
                customer.MaSize = ctpn.MaSize;
                demos.CTPhieuNhaps.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(CTPhieuNhapDTO hd)
        {
            try
            {
                CTPhieuNhap customer = demos.CTPhieuNhaps.Where(u => u.MaCTPN == hd.MaCTPN).SingleOrDefault();
                customer.MaSP = hd.MaSP;
                customer.SoLuong = hd.SoLuong;
                customer.GiaNhap = hd.GiaNhap;
                customer.TongTien = hd.TongTien;
                customer.MaMau = hd.MaMau;
                customer.MaSize = hd.MaSize;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(CTPhieuNhapDTO hd)
        {
            try
            {
                CTPhieuNhap customer = demos.CTPhieuNhaps.Where(u => u.MaCTPN == hd.MaCTPN).SingleOrDefault();
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
