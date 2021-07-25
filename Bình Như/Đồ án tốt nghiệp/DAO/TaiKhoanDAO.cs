using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        //ma hoa md5
        demoEntities demos = new demoEntities();
        public void themKH()
        {
            TaiKhoan kh = new TaiKhoan();
            kh.TaiKhoan1 = "";
            kh.MatKhau = "";
            kh.MaNV = "";
            kh.TrangThai = "1";
            demos.TaiKhoans.Add(kh);
            demos.SaveChanges();
        }

        public List<TaiKhoanDTO> layDSKH()
        {
            List<TaiKhoanDTO> Dskh = new List<TaiKhoanDTO>();
            Dskh = demos.TaiKhoans.Where(u => u.TrangThai == "1").Select(u => new TaiKhoanDTO
            {
                TaiKhoan = u.TaiKhoan1,
                MatKhau = u.MatKhau,
                MaNV=u.MaNV,      
                TrangThai=u.TrangThai,
            }).ToList();
            return Dskh;
        }

        public TaiKhoanDTO layKH(string makh)
        {
            TaiKhoanDTO kh = new TaiKhoanDTO();
            kh = demos.TaiKhoans.Where(u => u.TrangThai == "1").Select(u => new TaiKhoanDTO
            {
                TaiKhoan = u.TaiKhoan1,
                MatKhau = u.MatKhau,
                MaNV=u.MaNV,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return kh;
        }

        public bool DKKH(TaiKhoanDTO kh)
        {
            TaiKhoan customer = new TaiKhoan();

            try
            {
                customer.TaiKhoan1 = kh.TaiKhoan;
                customer.MatKhau = kh.MatKhau;
                customer.MaNV = kh.MaNV;
                customer.TrangThai = kh.TrangThai;
                demos.TaiKhoans.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(TaiKhoanDTO hd)
        {
            try
            {
                TaiKhoan customer = demos.TaiKhoans.Where(u => u.MaNV == hd.MaNV).SingleOrDefault();
                customer.MatKhau = hd.MatKhau;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(TaiKhoanDTO hd)
        {
            try
            {
                TaiKhoan customer = demos.TaiKhoans.Where(u => u.MaNV == hd.MaNV).SingleOrDefault();
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
