using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhuyenMaiDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            KhuyenMai pn = new KhuyenMai();
            pn.MaKM = "";
            pn.TenKM = "";
            pn.NgayBatDau = "";
            pn.NgayKetThuc = "";
            pn.TrangThai = "1";
            demos.KhuyenMais.Add(pn);
            demos.SaveChanges();
        }

        public List<KhuyenMaiDTO> layDSSP()
        {
            List<KhuyenMaiDTO> Dssp = new List<KhuyenMaiDTO>();
            Dssp = demos.KhuyenMais.Where(u => u.TrangThai == "1").Select(u => new KhuyenMaiDTO
            {
                MaKM = u.MaKM,
                TenKM = u.TenKM,
                NgayBatDau = u.NgayBatDau,
                NgayKetThuc=u.NgayKetThuc,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public KhuyenMaiDTO laySP(string makh)
        {
            KhuyenMaiDTO sp = new KhuyenMaiDTO();
            sp = demos.KhuyenMais.Where(u => u.TrangThai == "1").Select(u => new KhuyenMaiDTO
            {
                MaKM = u.MaKM,
                TenKM = u.TenKM,
                NgayBatDau = u.NgayBatDau,
                NgayKetThuc =u.NgayKetThuc,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(KhuyenMaiDTO sp)
        {
            KhuyenMai customer = new KhuyenMai();

            try
            {
                customer.MaKM = sp.MaKM;
                customer.TenKM = sp.TenKM;
                customer.NgayBatDau = sp.NgayBatDau;
                customer.NgayKetThuc = sp.NgayKetThuc;
                customer.TrangThai = "1";
                demos.KhuyenMais.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(KhuyenMaiDTO hd)
        {
            try
            {
                KhuyenMai customer = demos.KhuyenMais.Where(u => u.MaKM == hd.MaKM).SingleOrDefault();
                customer.TenKM = hd.TenKM;
                customer.NgayBatDau = hd.NgayBatDau;
                customer.NgayKetThuc = hd.NgayKetThuc;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(KhuyenMaiDTO hd)
        {
            try
            {
                KhuyenMai customer = demos.KhuyenMais.Where(u => u.MaKM == hd.MaKM).SingleOrDefault();
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
