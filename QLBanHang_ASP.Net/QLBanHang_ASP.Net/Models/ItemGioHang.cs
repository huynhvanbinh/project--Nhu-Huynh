using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBanHang_ASP.Net.Models
{
    public class ItemGioHang
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public string Mau { get; set; }
        public string KichThuoc { get; set; }
        public Decimal DonGia { get; set; }
        public Decimal ThanhTien { get; set; }
        public String HinhAnh { get; set; }
        public ItemGioHang(string sMaSP,int MaCTSP)
        {
            using (ShopQuanAoEntities db = new ShopQuanAoEntities())
            {
                this.MaSP = sMaSP;
                SanPham sp = db.SanPhams.Single(n => n.MaSP == sMaSP);
                CTSanPham ctsp= db.CTSanPhams.Single(u => u.MaCTSP == MaCTSP);
                this.TenSP = sp.TenSP;
                this.HinhAnh = sp.HinhAnh;
                this.DonGia = sp.DonGia.Value;
                this.Mau = ctsp.MaMau;
                this.KichThuoc = ctsp.MaSize;
                this.SoLuong = 1;
                this.ThanhTien = DonGia * SoLuong;
            }
        }
        public ItemGioHang(string sMaSP, int sl, int MaCTSP)
        {
            using (ShopQuanAoEntities db = new ShopQuanAoEntities())
            {
                this.MaSP = sMaSP;
                SanPham sp = db.SanPhams.Single(n => n.MaSP == sMaSP);
                this.TenSP = sp.TenSP;
                this.HinhAnh = sp.HinhAnh;
                this.DonGia = sp.DonGia.Value;
                this.SoLuong = sl;
                this.ThanhTien = DonGia * SoLuong;
            }
        }
    }

  
}