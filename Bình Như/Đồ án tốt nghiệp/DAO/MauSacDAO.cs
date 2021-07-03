using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class MauSacDAO
    {
        demoEntities demos = new demoEntities();
        public void themMau()
        {
            MauSac mausac = new MauSac();
            mausac.MaMau = "";
            mausac.TenMau = "";
            mausac.TrangThai = "1";
            demos.MauSacs.Add(mausac);
            demos.SaveChanges();
        }

        public List<MauSacDTO> layDSMau()
        {
            List<MauSacDTO> Dsmau = new List<MauSacDTO>();
            Dsmau = demos.MauSacs.Where(u => u.TrangThai == "1").Select(u => new MauSacDTO
            {
                MaMau = u.MaMau,
                TenMau = u.TenMau,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dsmau;
        }

        public MauSacDTO layMau(string mamau)
        {
            MauSacDTO mau = new MauSacDTO();
            mau = demos.MauSacs.Where(u => u.TrangThai == "1").Select(u => new MauSacDTO
            {
                MaMau = u.MaMau,
                TenMau = u.TenMau,
                TrangThai = u.TrangThai,
            }).SingleOrDefault();
            return mau;
        }

        public bool DKMau(MauSacDTO mau)
        {
            MauSac customer = new MauSac();

            try
            {
                customer.MaMau = mau.MaMau;
                customer.TenMau = mau.TenMau;
                customer.TrangThai = mau.TrangThai;
                demos.MauSacs.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(MauSacDTO hd)
        {
            try
            {
                MauSac customer = demos.MauSacs.Where(u => u.MaMau == hd.MaMau).SingleOrDefault();
                customer.TenMau = hd.TenMau;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(MauSacDTO hd)
        {
            try
            {
                MauSac customer = demos.MauSacs.Where(u => u.MaMau == hd.MaMau).SingleOrDefault();
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
