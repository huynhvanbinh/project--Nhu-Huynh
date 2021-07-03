using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SizeDAO
    {
        demoEntities demos = new demoEntities();
        public void themKT()
        {
            Size size = new Size();
            size.MaSize = "";
            size.TenSize = "";
            size.CanNang = "";
            size.TrangThai = "1";
            demos.Sizes.Add(size);
            demos.SaveChanges();
        }

        public List<SizeDTO> layDSKT()
        {
            List<SizeDTO> Dskt = new List<SizeDTO>();
            Dskt = demos.Sizes.Where(u => u.TrangThai == "1").Select(u => new SizeDTO
            {
                MaSize = u.MaSize,
                TenSize = u.TenSize,
                CanNang=u.CanNang,
                trangThai=u.TrangThai,
            }).ToList();
            return Dskt;
        }

        public SizeDTO layKT(string makt)
        {
            SizeDTO kt = new SizeDTO();
            kt = demos.Sizes.Where(u => u.TrangThai == "1").Select(u => new SizeDTO
            {
                MaSize = u.MaSize,
                TenSize = u.TenSize,
                CanNang = u.CanNang,
            }).SingleOrDefault();
            return kt;
        }

        public bool DKKT(SizeDTO kt)
        {
            Size customer = new Size();

            try
            {
                customer.MaSize = kt.MaSize;
                customer.TenSize = kt.TenSize;
                customer.CanNang = kt.CanNang;
                demos.Sizes.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(SizeDTO kt)
        {
            try
            {
                Size customer = demos.Sizes.Where(u => u.MaSize == kt.MaSize).SingleOrDefault();
                customer.TenSize = kt.TenSize;
                customer.CanNang = kt.CanNang;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(SizeDTO kt)
        {
            try
            {
                Size customer = demos.Sizes.Where(u => u.MaSize == kt.MaSize).SingleOrDefault();
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

