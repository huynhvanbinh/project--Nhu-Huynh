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
            CTPhieuNhap pn = new CTPhieuNhap();
            pn.MaCTPN = "";
            pn.MaPN = "";
            pn.MaSP = "";
            pn.MaSize = "";
            pn.MaMau = "";
            pn.SoLuong = "";
            pn.GiaNhap = "";
            pn.ChiecKhau = "";
            pn.TrangThai = "1";
            demos.CTPhieuNhaps.Add(pn);
            demos.SaveChanges();
        }

        public List<CTPhieuNhapDTO> layDSSPDK(string ma)
        {
            List<CTPhieuNhapDTO> Dssp = new List<CTPhieuNhapDTO>();
            Dssp = demos.CTPhieuNhaps.Where(u => u.TrangThai == "1" && u.MaPN == ma).Select(u => new CTPhieuNhapDTO
            {
              MaCTPN=u.MaCTPN,
              MaPN=u.MaPN,
              MaSP=u.MaSP,
              MaMau=u.MaMau,
              MaSize=u.MaSize,
              SoLuong=u.SoLuong,
              GiaNhap=u.GiaNhap,
              ChiecKhau=u.ChiecKhau,
              TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public List<CTPhieuNhapDTO> layDSSP()
        {
            List<CTPhieuNhapDTO> Dssp = new List<CTPhieuNhapDTO>();
            Dssp = demos.CTPhieuNhaps.Where(u => u.TrangThai == "1").Select(u => new CTPhieuNhapDTO
            {
                MaCTPN = u.MaCTPN,
                MaPN = u.MaPN,
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
        public CTPhieuNhapDTO laySP(string makh)
        {
            CTPhieuNhapDTO sp = new CTPhieuNhapDTO();
            sp = demos.CTPhieuNhaps.Where(u => u.TrangThai == "1").Select(u => new CTPhieuNhapDTO
            {
                MaCTPN = u.MaCTPN,
                MaPN = u.MaPN,
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

        public bool DKSP(CTPhieuNhapDTO sp)
        {
            CTPhieuNhap customer = new CTPhieuNhap();

            try
            {
                customer.MaCTPN = sp.MaCTPN;
                customer.MaPN = sp.MaPN;
                customer.MaSP = sp.MaSP;
                customer.MaMau = sp.MaMau;
                customer.MaSize = sp.MaSize;
                customer.SoLuong = sp.SoLuong;
                customer.GiaNhap = sp.GiaNhap;
                customer.ChiecKhau = sp.ChiecKhau;
                customer.TrangThai = sp.TrangThai;
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
                customer.MaCTPN = hd.MaCTPN;
                customer.MaPN = hd.MaPN;
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
