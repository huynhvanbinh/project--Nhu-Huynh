using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CTKhuyenMaiDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            CTKhuyenMai pn = new CTKhuyenMai();
            pn.MaKM = "";
            pn.MaSP = "";
            pn.MaCH = "";
            pn.GiamGia = "";
            pn.MaKH = "";
            pn.MaCTKM = "";
            pn.TrangThai = "1";
            demos.CTKhuyenMais.Add(pn);
            demos.SaveChanges();
        }

        public List<CTKhuyenMaiDTO> layDSSPDK(string ma)
        {
            List<CTKhuyenMaiDTO> Dssp = new List<CTKhuyenMaiDTO>();
            Dssp = demos.CTKhuyenMais.Where(u=>u.TrangThai=="1" && u.MaKM == ma).Select(u => new CTKhuyenMaiDTO
            {
                MaKM = u.MaKM,
                MaSP=u.MaSP,
                MaCH=u.MaCH,
                GiamGia=u.GiamGia,
                MaKH=u.MaKH,
                MaCTKM=u.MaCTKM,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public List<CTKhuyenMaiDTO> layDSSP()
        {
            List<CTKhuyenMaiDTO> Dssp = new List<CTKhuyenMaiDTO>();
            Dssp = demos.CTKhuyenMais.Where(u => u.TrangThai == "1").Select(u => new CTKhuyenMaiDTO
            {
                MaKM = u.MaKM,
                MaSP = u.MaSP,
                MaCH = u.MaCH,
                GiamGia = u.GiamGia,
                MaKH = u.MaKH,
                MaCTKM = u.MaCTKM,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public CTKhuyenMaiDTO laySP(string makh)
        {
            CTKhuyenMaiDTO sp = new CTKhuyenMaiDTO();
            sp = demos.CTKhuyenMais.Where(u => u.TrangThai == "1").Select(u => new CTKhuyenMaiDTO
            {
                MaKM = u.MaKM,
                MaSP = u.MaSP,
                MaCH = u.MaCH,
                GiamGia = u.GiamGia,
                MaKH = u.MaKH,
                MaCTKM = u.MaCTKM,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(CTKhuyenMaiDTO sp)
        {
            CTKhuyenMai customer = new CTKhuyenMai();

            try
            {
                customer.MaKM = sp.MaKM;
                customer.MaSP = sp.MaSP;
                customer.MaCH = sp.MaCH;
                customer.GiamGia = sp.GiamGia;
                customer.MaKH = sp.MaKH;
                customer.MaCTKM = sp.MaCTKM;
                customer.TrangThai = sp.TrangThai;
                demos.CTKhuyenMais.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(CTKhuyenMaiDTO hd)
        {
            try
            {
                CTKhuyenMai customer = demos.CTKhuyenMais.Where(u => u.MaCTKM == hd.MaCTKM).SingleOrDefault();
                customer.MaSP = hd.MaSP;
                customer.MaCH = hd.MaCH;
                customer.GiamGia = hd.GiamGia;
                customer.MaKH = hd.MaKH;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(CTKhuyenMaiDTO hd)
        {
            try
            {
                CTKhuyenMai customer = demos.CTKhuyenMais.Where(u => u.MaCTKM == hd.MaCTKM).SingleOrDefault();
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
