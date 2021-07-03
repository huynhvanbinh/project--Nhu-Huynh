using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChamCongDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            ChamCong hd = new ChamCong();
            hd.MaCC = "";
            hd.Ngay = null;
            hd.MaNV = "";
            hd.SoGioLam = "";
            hd.TrangThaiChamCong = "";
            hd.TangCa = "";
            hd.TrangThai = "1";
            demos.ChamCongs.Add(hd);
            demos.SaveChanges();
        }

        public List<ChamCongDTO> layDSSP( string ngay)
        {
            List<ChamCongDTO> Dssp = new List<ChamCongDTO>();
            Dssp = demos.ChamCongs.Where(u => u.TrangThai == "1" && u.Ngay == ngay).Select(u => new ChamCongDTO
            {
                MaCC = u.MaCC,
                Ngay = u.Ngay,
                MaNV = u.MaNV,
                TangCa = u.TangCa,
                SoGioLam = u.SoGioLam,
                TrangThaiChamCong = u.TrangThaiChamCong,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public List<ChamCongDTO> layDSSPdk()
        {
            List<ChamCongDTO> Dssp = new List<ChamCongDTO>();
            Dssp = demos.ChamCongs.Where(u => u.TrangThai == "1").Select(u => new ChamCongDTO
            {
                MaCC = u.MaCC,
                Ngay = u.Ngay,
                MaNV = u.MaNV,
                SoGioLam = u.SoGioLam,
                TangCa = u.TangCa,
                TrangThaiChamCong = u.TrangThaiChamCong,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dssp;
        }
        public ChamCongDTO laySP(string masp)
        {
            ChamCongDTO sp = new ChamCongDTO();
            sp = demos.ChamCongs.Where(u => u.TrangThai == "1").Select(u => new ChamCongDTO
            {
                MaCC = u.MaCC,
                Ngay = u.Ngay,
                MaNV = u.MaNV,
                SoGioLam = u.SoGioLam,
                TrangThaiChamCong = u.TrangThaiChamCong,
                TangCa = u.TangCa,
                TrangThai = u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(ChamCongDTO sp)
        {
            ChamCong customer = new ChamCong();
            try
            {
                customer.MaCC = sp.MaCC;
                customer.Ngay = sp.Ngay;
                customer.MaNV = sp.MaNV;
                customer.SoGioLam = sp.SoGioLam;
                customer.TrangThaiChamCong = sp.TrangThaiChamCong;
                customer.TrangThai = sp.TrangThai;
                customer.TangCa = sp.TangCa;
                demos.ChamCongs.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(ChamCongDTO hd)
        {
            try
            {
                ChamCong customer = demos.ChamCongs.Where(u => u.MaCC == hd.MaCC).SingleOrDefault();
                customer.TrangThaiChamCong = hd.TrangThaiChamCong;
                customer.SoGioLam = hd.SoGioLam;
                customer.TangCa = hd.TangCa;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(ChamCongDTO hd)
        {
            try
            {
                ChamCong customer = demos.ChamCongs.Where(u => u.MaCC == hd.MaCC).SingleOrDefault();
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
