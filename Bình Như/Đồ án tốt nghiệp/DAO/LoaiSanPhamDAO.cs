using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LoaiSanPhamDAO
    {
        demoEntities demos = new demoEntities();
        public void themSP()
        {
            LoaiSanPham loaisanpham = new LoaiSanPham();
            loaisanpham.MaLoai = "";
            loaisanpham.TenLoai = "";
            loaisanpham.TrangThai = "1";
            demos.LoaiSanPhams.Add(loaisanpham);
            demos.SaveChanges();
        }

        public List<LoaiSanPhamDTO> layDSSP()
        {
            List<LoaiSanPhamDTO> Dssp = new List<LoaiSanPhamDTO>();
            Dssp = demos.LoaiSanPhams.Where(u => u.TrangThai == "1").Select(u => new LoaiSanPhamDTO
            {
                MaLoai = u.MaLoai,
                TenLoai = u.TenLoai,
                TrangThai=u.TrangThai,
            }).ToList();
            return Dssp;
        }

        public LoaiSanPhamDTO laySP(string masp)
        {
            LoaiSanPhamDTO sp = new LoaiSanPhamDTO();
            sp = demos.LoaiSanPhams.Where(u => u.TrangThai == "1").Select(u => new LoaiSanPhamDTO
            {
                MaLoai = u.MaLoai,
                TenLoai = u.TenLoai,
                TrangThai=u.TrangThai,
            }).SingleOrDefault();
            return sp;
        }

        public bool DKSP(LoaiSanPhamDTO sp)
        {
            LoaiSanPham customer = new LoaiSanPham();

            try
            {
                customer.MaLoai = sp.MaLoai;
                customer.TenLoai = sp.TenLoai;
                customer.TrangThai = sp.TrangThai;
                demos.LoaiSanPhams.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHD(LoaiSanPhamDTO hd)
        {
            try
            {
                LoaiSanPham customer = demos.LoaiSanPhams.Where(u => u.MaLoai == hd.MaLoai).SingleOrDefault();
                customer.TenLoai = hd.TenLoai;
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DELETEHD(LoaiSanPhamDTO hd)
        {
            try
            {
                LoaiSanPham customer = demos.LoaiSanPhams.Where(u => u.MaLoai == hd.MaLoai).SingleOrDefault();
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
