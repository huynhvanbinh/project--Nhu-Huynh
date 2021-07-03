using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChucVuDAO
    {
        demoEntities demos = new demoEntities();
        public void themKH()
        {
            ChucVu chucvu = new ChucVu();
            chucvu.MaCV = "";
            chucvu.TenChucVu = "";
            chucvu.TrangThai = "1";
            demos.ChucVus.Add(chucvu);
            demos.SaveChanges();
        }

        public List<ChucVuDTO> layDSKH()
        {
            List<ChucVuDTO> Dskh = new List<ChucVuDTO>();
            Dskh = demos.ChucVus.Where(u => u.TrangThai == "1").Select(u => new ChucVuDTO
            {
                MaCV = u.MaCV,
                TenChucVu = u.TenChucVu, 
                TrangThai=u.TrangThai,
            }).ToList();
            return Dskh;
        }

        public ChucVuDTO layKH(string makh)
        {
            ChucVuDTO kh = new ChucVuDTO();
            kh = demos.ChucVus.Where(u => u.TrangThai == "1").Select(u => new ChucVuDTO
            {
                MaCV = u.MaCV,
                TenChucVu = u.TenChucVu, 
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return kh;
        }

        public bool DKKH(ChucVuDTO kh)
        {
            ChucVu customer = new ChucVu();
            try
            {
                customer.MaCV = kh.MaCV;
                customer.TenChucVu = kh.TenChucVu;
                customer.TrangThai = kh.TrangThai;
                demos.ChucVus.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(ChucVuDTO hd)
        {
            try
            {
                ChucVu customer = demos.ChucVus.Where(u => u.MaCV==hd.MaCV).SingleOrDefault();
                customer.TenChucVu = hd.TenChucVu;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(ChucVuDTO hd)
        {
            try
            {
                ChucVu customer = demos.ChucVus.Where(u => u.MaCV == hd.MaCV).SingleOrDefault();
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
