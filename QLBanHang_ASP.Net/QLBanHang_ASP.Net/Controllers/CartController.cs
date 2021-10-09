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
        public List<ItemGioHang> LayGioHang()
        {
            List<ItemGioHang> lstGioHang = Session["GioHang"] as List<ItemGioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<ItemGioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }
        //them gio hang
        public ActionResult ThemGioHang(string MaSP, string strURL, int MaCTSP)
        {
            //kiem tra sp co ton tai hay k
            SanPham sp = db.SanPhams.SingleOrDefault(n => n.MaSP == MaSP);
            CTSanPham ctsp = db.CTSanPhams.SingleOrDefault(n => n.MaCTSP == MaCTSP);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //tao list gio hang
            List<ItemGioHang> lstGioHang = LayGioHang();
            ItemGioHang spCheck = lstGioHang.SingleOrDefault(n => n.MaSP == MaSP);
            if (spCheck != null)
            {
                if (ctsp.SoLuong < spCheck.SoLuong)
                {
                    return View("ThongBao");
                }
                spCheck.SoLuong++;
                spCheck.ThanhTien = spCheck.SoLuong * spCheck.DonGia;
                return Redirect(strURL);
            }
            ItemGioHang itemGH = new ItemGioHang(MaSP, MaCTSP);
            if (ctsp.SoLuong < itemGH.SoLuong)
            {
                return View("ThongBao");
            }
            lstGioHang.Add(itemGH);
            return Redirect(strURL);
        }






     
        public ActionResult CreateCart(string MaSP, string mau, string kt, string strURL)
        {
           
            return View();
        }

    }
}