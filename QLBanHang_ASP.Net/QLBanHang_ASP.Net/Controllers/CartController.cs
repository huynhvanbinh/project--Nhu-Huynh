using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBanHang_ASP.Net.Models;

namespace QLBanHang_ASP.Net.Controllers
{
    public class CartController : Controller
    {
        ShopQuanAoEntities db = new ShopQuanAoEntities();
        // GET: Cart
        
        public ActionResult CreateCart(string MaSP, string mau, string kt, string strURL)
        {
            GioHang gh = new GioHang();
            gh.MaGH= DateTime.Now.ToString("MMddyyyyHHmmss");
            gh.MaSP = MaSP;
            gh.MaMau = mau;
            gh.MaSize = kt;
            KhachHang tv = (KhachHang)Session["TaiKhoan"];
            string makh = tv.MaKH;
            gh.MaKH = makh;
            gh.TrangThai = 1;
            gh.TrinhTrangDonHang = "chờ xác nhận";
            gh.SoLuong = 1;
            db.GioHangs.Add(gh);
            db.SaveChanges();
            return Redirect(strURL);
        }

        public int? TinhTongSoLuong()
        {
            KhachHang tv = (KhachHang)Session["TaiKhoan"];
            string makh = null;
            if (Session["TaiKhoan"]!=null)
            {
                makh = tv.MaKH;
            }               
            var lstSL = db.GioHangs.Where(n => n.MaKH == makh && n.TrinhTrangDonHang == "chờ xác nhận");
            if(lstSL==null)
            {
                return 0;
            }
            return lstSL.Sum(n => n.SoLuong);
        }
        public ActionResult GioHangPartial()
        {
            if (TinhTongSoLuong() == 0)
            {
                ViewBag.TongSoLuong = 0;
                ViewBag.TongTien = 0;
                return PartialView();
            }
            ViewBag.TongSoLuong = TinhTongSoLuong();
           
            return PartialView();
        }

        public ActionResult XemGioHang()
        {
            KhachHang tv = (KhachHang)Session["TaiKhoan"];
            string makh = null;
            if (Session["TaiKhoan"] != null)
            {
                makh = tv.MaKH;
            }
            var lstgh= db.GioHangs.Where(n => n.MaKH == makh );
            ViewBag.SP = db.SanPhams;
            return View(lstgh);
        }

        string madh;
        public ActionResult DatHang()
        {
            DonDatHang ddh = new DonDatHang();
           
            KhachHang tv = (KhachHang)Session["TaiKhoan"];
            if (Session["TaiKhoan"] != null)
            {
                ddh.MaKH = tv.MaKH;
            }
            ddh.NgayDat = DateTime.Now.ToString("dd/MM/yyyy");
            ddh.TrangThaiGiaoHang = "chờ xử lý";
            ddh.DaHuy = 1;
            ddh.DaThanhToan = "No";
     
            ddh.TrangThai = 1;
            madh=DateTime.Now.ToString("MMddyyyyHHmmss");
            ddh.MaDDH = madh; 
            db.DonDatHangs.Add(ddh);
            db.SaveChanges();

            var lstgh = db.GioHangs.Where(n => n.MaKH == ddh.MaKH && n.TrinhTrangDonHang == "chờ xác nhận");
            var lstsp = db.SanPhams;
            foreach (var item in lstgh)
            {
                CTDonDatHang cthd = new CTDonDatHang();
                cthd.MaSP = item.MaSP;
                cthd.MaSize = item.MaSize;
                cthd.MaMau = item.MaMau;
                cthd.MaDDH = madh;
                cthd.MaCTDDH= DateTime.Now.ToString("MMddyyyyHHmmss");
                foreach (var itemsp in lstsp)
                {
                    if(item.MaSP==itemsp.MaSP)
                    {
                        cthd.GiaBan = itemsp.DonGia;
                    }
                }
                item.TrinhTrangDonHang = "Đã mua";
                cthd.SoLuong = item.SoLuong;
                cthd.TrangThai = 1;
                db.CTDonDatHangs.Add(cthd);
                db.SaveChanges();
                Session["GioHang"] = cthd;
            }
            db.SaveChanges();  
            return RedirectToAction("XemGioHang", "Cart");
        }

        public ActionResult DonDatHang()
        {
            KhachHang tv = (KhachHang)Session["TaiKhoan"];
            string makh = null;
            if (Session["TaiKhoan"] != null)
            {
                makh = tv.MaKH;
            }
            var lstddh = db.DonDatHangs.Where(n => n.MaKH == makh);
            ViewBag.CTDDH = db.CTDonDatHangs;
            return View(lstddh);
        }


        
    }
}