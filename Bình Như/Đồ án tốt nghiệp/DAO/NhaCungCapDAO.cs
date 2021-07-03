using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhaCungCapDAO
    {
        demoEntities demos = new demoEntities();
        public void themCH()
        {
            NhaCungCap nhacc = new NhaCungCap();
            nhacc.MaNCC = "";
            nhacc.TenNCC = "";
            nhacc.SDT = "";
            nhacc.Email = "";
            nhacc.DiaChi = "";
            nhacc.TrangThai = "1";
            demos.NhaCungCaps.Add(nhacc);
            demos.SaveChanges();
        }

        public List<NhaCungCapDTO> layDSCH()
        {
            List<NhaCungCapDTO> Dsch = new List<NhaCungCapDTO>();
            Dsch = demos.NhaCungCaps.Where(u => u.TrangThai == "1").Select(u => new NhaCungCapDTO
            {
                MaNCC = u.MaNCC,
                TenNCC = u.TenNCC,
                SDT=u.SDT,
                Email=u.Email,
                DiaChi = u.DiaChi,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dsch;
        }

        public NhaCungCapDTO layCH(string mach)
        {
            NhaCungCapDTO ch = new NhaCungCapDTO();
            ch = demos.NhaCungCaps.Where(u => u.TrangThai == "1").Select(u => new NhaCungCapDTO
            {
                MaNCC = u.MaNCC,
                TenNCC = u.TenNCC,
                SDT = u.SDT,
                Email = u.Email,
                DiaChi = u.DiaChi,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return ch;
        }

        public bool DKCH(NhaCungCapDTO ch)
        {
            NhaCungCap customer = new NhaCungCap();

            try
            {
                customer.MaNCC = ch.MaNCC;
                customer.TenNCC = ch.TenNCC;
                customer.SDT = ch.SDT;
                customer.Email = ch.Email;
                customer.DiaChi = ch.DiaChi;
                customer.TrangThai = ch.TrangThai;
                demos.NhaCungCaps.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(NhaCungCapDTO hd)
        {
            try
            {
                NhaCungCap customer = demos.NhaCungCaps.Where(u => u.MaNCC == hd.MaNCC).SingleOrDefault();
                customer.TenNCC = hd.TenNCC;
                customer.SDT = hd.SDT;
                customer.DiaChi = hd.DiaChi;
                customer.Email = hd.Email;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(NhaCungCapDTO hd)
        {
            try
            {
                NhaCungCap customer = demos.NhaCungCaps.Where(u => u.MaNCC == hd.MaNCC).SingleOrDefault();
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
