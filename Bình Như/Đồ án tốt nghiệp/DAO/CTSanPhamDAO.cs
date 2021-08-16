using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CTSanPhamDAO
    {
        demoEntities demos = new demoEntities();
        public void themMau()
        {
            CTSanPham mausac = new CTSanPham();
            mausac.MaCTSP = "";
            mausac.MaMau = "";
            mausac.KichThuoc = "";
            mausac.SoLuong = "";
            mausac.MaSP = "";
            mausac.MaCH = "";
            mausac.TrangThai = "1";
            demos.CTSanPhams.Add(mausac);
            demos.SaveChanges();
        }

        public List<CTSanPhamDTO> layDSMau(string ma)
        {
            List<CTSanPhamDTO> Dsmau = new List<CTSanPhamDTO>();
            Dsmau = demos.CTSanPhams.Where(u => u.TrangThai == "1" && u.MaSP==ma).Select(u => new CTSanPhamDTO
            {
               MaCTSP=u.MaCTSP,
               MaMau=u.MaMau,
               KichThuoc=u.KichThuoc,
               SoLuong=u.SoLuong,
               MaSP=u.MaSP,
               MaCH=u.MaCH,
               TrangThai = u.TrangThai,
            }).ToList();
            return Dsmau;
        }
        public List<CTSanPhamDTO> layDSctspch(string ma, string cuahang)
        {
            List<CTSanPhamDTO> Dsmau = new List<CTSanPhamDTO>();
            Dsmau = demos.CTSanPhams.Where(u => u.TrangThai == "1" && u.MaSP == ma && u.MaCH==cuahang).Select(u => new CTSanPhamDTO
            {
                MaCTSP = u.MaCTSP,
                MaMau = u.MaMau,
                KichThuoc = u.KichThuoc,
                SoLuong = u.SoLuong,
                MaSP = u.MaSP,
                MaCH=u.MaCH,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dsmau;
        }
        public List<CTSanPhamDTO> layDSCTSP()
        {
            List<CTSanPhamDTO> Dsmau = new List<CTSanPhamDTO>();
            Dsmau = demos.CTSanPhams.Where(u => u.TrangThai == "1").Select(u => new CTSanPhamDTO
            {
                MaCTSP = u.MaCTSP,
                MaMau = u.MaMau,
                KichThuoc = u.KichThuoc,
                SoLuong = u.SoLuong,
                MaSP = u.MaSP,
                MaCH=u.MaCH,
                TrangThai = u.TrangThai,
            }).ToList();
            return Dsmau;
        }

        public CTSanPhamDTO layMau(string mamau)
        {
            CTSanPhamDTO mau = new CTSanPhamDTO();
            mau = demos.CTSanPhams.Where(u => u.TrangThai == "1").Select(u => new CTSanPhamDTO
            {
                MaCTSP = u.MaCTSP,
                MaMau = u.MaMau,
                KichThuoc = u.KichThuoc,
                MaSP=u.MaSP,
                SoLuong = u.SoLuong,
                MaCH=u.MaCH,
                TrangThai = u.TrangThai,
            }).SingleOrDefault();
            return mau;
        }

        public bool DKMau(CTSanPhamDTO mau)
        {
            CTSanPham customer = new CTSanPham();

            try
            {
                customer.MaCTSP = mau.MaCTSP;
                customer.MaMau = mau.MaMau;
                customer.MaSP = mau.MaSP;
                customer.KichThuoc = mau.KichThuoc;
                customer.SoLuong = mau.SoLuong;
                customer.TrangThai = mau.TrangThai;
                customer.MaCH = mau.MaCH;
                demos.CTSanPhams.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateSL(CTSanPhamDTO sp)
        {
            try
            {
                CTSanPham customer = demos.CTSanPhams.Where(u => u.MaSP == sp.MaSP && u.MaMau==sp.MaMau && u.KichThuoc==sp.KichThuoc).SingleOrDefault();
                customer.SoLuong = sp.SoLuong;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(CTSanPhamDTO hd)
        {
            try
            {
                CTSanPham customer = demos.CTSanPhams.Where(u => u.MaCTSP == hd.MaCTSP).SingleOrDefault();
                customer.SoLuong = hd.SoLuong;
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
