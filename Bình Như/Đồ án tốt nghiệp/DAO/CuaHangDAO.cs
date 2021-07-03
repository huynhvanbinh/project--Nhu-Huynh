using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CuaHangDAO
    {
        demoEntities demos = new demoEntities();
        public void themCH()
        {
            CuaHang cuahang = new CuaHang();
            cuahang.MaCH = "";
            cuahang.TenCH = "";
            cuahang.DiaChi = "";
            cuahang.TrangThai = "1";
            demos.CuaHangs.Add(cuahang);
            demos.SaveChanges();
        }

        public List<CuaHangDTO> layDSCH()
        {
            List<CuaHangDTO> Dsch = new List<CuaHangDTO>();
            Dsch = demos.CuaHangs.Where(u => u.TrangThai == "1").Select(u => new CuaHangDTO
            {
                MaCH = u.MaCH,
                TenCH = u.TenCH,
                DiaChi=u.DiaChi,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dsch;
        }

        public CuaHangDTO layCH(string mach)
        {
            CuaHangDTO ch = new CuaHangDTO();
            ch = demos.CuaHangs.Where(u => u.TrangThai == "1").Select(u => new CuaHangDTO
            {
                MaCH = u.MaCH,
                TenCH = u.TenCH,
                DiaChi=u.DiaChi,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return ch;
        }

        public bool DKCH(CuaHangDTO ch)
        {
            CuaHang customer = new CuaHang();
            try
            {
                customer.MaCH = ch.MaCH;
                customer.TenCH = ch.TenCH;
                customer.DiaChi = ch.DiaChi;
                customer.TrangThai = ch.TrangThai;
                demos.CuaHangs.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(CuaHangDTO hd)
        {
            try
            {
                CuaHang customer = demos.CuaHangs.Where(u => u.MaCH == hd.MaCH).SingleOrDefault();
                customer.TenCH = hd.TenCH;
                customer.DiaChi = hd.DiaChi;
                customer.TenCH = hd.TenCH;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(CuaHangDTO hd)
        {
            try
            {
                CuaHang customer = demos.CuaHangs.Where(u => u.MaCH == hd.MaCH).SingleOrDefault();
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

