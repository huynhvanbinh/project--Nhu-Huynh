using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using QLBanHang_ASP.Net.Models;
namespace QLBanHang_ASP.Net.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        QLBanHangEntities db = new QLBanHangEntities();
        [HttpGet]
        public ActionResult SanPham(int? page, string Ma)
        {
            var lstSanPhamLMT = db.SanPhams.Where(n => n.GioTinh == Ma);
            int PageSize = 15;
            int PageNumber = (page ?? 1);
            ViewBag.ListSP = lstSanPhamLMT;
            ViewBag.Ma = Ma;
            Session["SanPhamLoai"] = Ma;
            return View(lstSanPhamLMT.OrderBy(n => n.MaSP).ToPagedList(PageNumber, PageSize));
        }
        [HttpPost]
        public ActionResult SanPham(int? page, string Ma, FormCollection f)
        {
            var lstSanPhamLMT = db.SanPhams.Where(n => n.GioTinh == Ma);
            int PageSize = 15;
            int PageNumber = (page ?? 1);
            ViewBag.ListSP = lstSanPhamLMT;
            ViewBag.Ma = Ma;
            Session["SanPhamLoai"] = Ma;
            return View(lstSanPhamLMT.OrderBy(n => n.MaSP).ToPagedList(PageNumber, PageSize));
        }

        public ActionResult MenuSanPham(int? page, string Ma)
        {
            var lstSanPhamLMT = db.SanPhams.Where(n => n.GioTinh == Ma);
            return PartialView(lstSanPhamLMT);
        }


        [HttpGet]
        public ActionResult SPLoai(int? page, string Ma, int MaLoai)
        {
            var lstSanPhamLMT = db.SanPhams.Where(n => n.GioTinh == Ma && n.MaLoai==MaLoai);
            int PageSize = 15;
            int PageNumber = (page ?? 1);
            ViewBag.ListSP = lstSanPhamLMT;
            
            ViewBag.Ma = Ma;
            ViewBag.MaLoai = MaLoai;
            return View(lstSanPhamLMT.OrderBy(n => n.MaSP).ToPagedList(PageNumber, PageSize));
        }

        [HttpPost]
        public ActionResult SPLoai(int? page, string Ma, int MaLoai, FormCollection f)
        {
            var lstSanPhamLMT = db.SanPhams.Where(n => n.GioTinh == Ma && n.MaLoai==MaLoai);
            int PageSize = 15;
            int PageNumber = (page ?? 1);
            ViewBag.ListSP = lstSanPhamLMT;
            ViewBag.Ma = Ma;
            ViewBag.MaLoai = MaLoai;
            return View(lstSanPhamLMT.OrderBy(n => n.MaSP).ToPagedList(PageNumber, PageSize));
        }
    }
}