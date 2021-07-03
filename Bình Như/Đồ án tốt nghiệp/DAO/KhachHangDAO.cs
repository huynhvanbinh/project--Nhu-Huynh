using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhachHangDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            KhachHang khachhang = new KhachHang();
            khachhang.SDT = "";
            khachhang.TenKH = "";
            khachhang.GioiTinh = "";
            khachhang.Diem = "";
            khachhang.TrangThai = "1";
            demos.KhachHangs.Add(khachhang);
            demos.SaveChanges();
        }

        public List<KhachHangDTO> layDSSP()
        {
            List<KhachHangDTO> Dssp = new List<KhachHangDTO>();
            Dssp = demos.KhachHangs.Where(u => u.TrangThai == "1").Select(u => new KhachHangDTO
            {
               SDT=u.SDT,
               TenKH=u.TenKH,
               GioiTinh=u.GioiTinh,
               Diem=u.Diem,
               TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public KhachHangDTO laySP(string masp)
        {
            KhachHangDTO sp = new KhachHangDTO();
            sp = demos.KhachHangs.Where(u => u.TrangThai == "1").Select(u => new KhachHangDTO
            {
                SDT = u.SDT,
                TenKH = u.TenKH,
                GioiTinh = u.GioiTinh,
                Diem = u.Diem,
                TrangThai = u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(KhachHangDTO sp)
        {
            KhachHang customer = new KhachHang();

            try
            {
                customer.SDT = sp.SDT;
                customer.TenKH = sp.TenKH;
                customer.GioiTinh = sp.GioiTinh;
                customer.Diem = sp.Diem;
                customer.TrangThai = sp.TrangThai;
                demos.KhachHangs.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(KhachHangDTO hd)
        {
            try
            {
                KhachHang customer = demos.KhachHangs.Where(u => u.SDT == hd.SDT).SingleOrDefault();
                customer.TenKH = hd.TenKH;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(KhachHangDTO hd)
        {
            try
            {
                KhachHang customer = demos.KhachHangs.Where(u => u.SDT == hd.SDT).SingleOrDefault();
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
