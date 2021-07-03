using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CTHoaDonDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            CTHoaDon ct = new CTHoaDon();
            ct.MaHD = "";
            ct.MaSP = "";
            ct.MaSize = "";
            ct.MaMau = "";
            ct.MaCH = "";
            ct.GiaBan = "";
            ct.SoLuong = "";
            ct.MaKM = "";
            ct.MaCTHD = "";
            ct.TrangThai = "1";
            demos.CTHoaDons.Add(ct);
            demos.SaveChanges();
        }

        
        //lay san pham khong tham so
        public List<CTHoaDonDTO> layDSSP(string ma)
        {
            List<CTHoaDonDTO> Dssp = new List<CTHoaDonDTO>();
            Dssp = demos.CTHoaDons.Where(u => u.MaHD == ma && u.TrangThai == "1").Select(u => new CTHoaDonDTO
            {
                MaHD = u.MaHD,
                MaSP = u.MaSP,
                MaSize = u.MaSize,
                MaMau = u.MaMau,
                MaCH = u.MaCH,
                GiaBan = u.GiaBan,
                SoLuong = u.SoLuong,
                MaKM = u.MaKM,
                MaCTHD = u.MaCTHD,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public CTHoaDonDTO laySP(string makh)
        {
            CTHoaDonDTO sp = new CTHoaDonDTO();
            sp = demos.CTHoaDons.Where(u=>u.TrangThai=="1").Select(u => new CTHoaDonDTO
            {
                MaHD = u.MaHD,
                MaSP = u.MaSP,
                MaSize = u.MaSize,
                MaMau = u.MaMau,
                MaCH = u.MaCH,
                GiaBan = u.GiaBan,
                SoLuong = u.SoLuong,
                MaKM = u.MaKM,
                MaCTHD = u.MaCTHD,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(CTHoaDonDTO ctpn)
        {
            CTHoaDon customer = new CTHoaDon();

            try
            {
                customer.MaHD = ctpn.MaHD;
                customer.MaSP = ctpn.MaSP;
                customer.MaMau = ctpn.MaMau;
                customer.MaSize = ctpn.MaSize;
                customer.MaCH = ctpn.MaCH;
                customer.SoLuong = ctpn.SoLuong;
                customer.GiaBan = ctpn.GiaBan;
                customer.MaKM = ctpn.MaKM;
                customer.MaCTHD = ctpn.MaCTHD;
                customer.TrangThai = ctpn.TrangThai;
                demos.CTHoaDons.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(CTHoaDonDTO hd)
        {
            try
            {
                CTHoaDon customer = demos.CTHoaDons.Where(u => u.MaSP == hd.MaSP).SingleOrDefault();

                customer.SoLuong = hd.SoLuong;

                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(CTHoaDonDTO hd)
        {
            try
            {
                CTHoaDon customer = demos.CTHoaDons.Where(u => u.MaCTHD == hd.MaCTHD).SingleOrDefault();
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
