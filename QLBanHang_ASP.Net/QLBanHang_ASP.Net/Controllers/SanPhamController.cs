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
            var lstSanPhamLMT = db.SanPhams.Where(n=>n.GioTinh==Ma);
            int PageSize = 15;
            int PageNumber = (page ?? 1);
            ViewBag.ListSP = lstSanPhamLMT;
            ViewBag.Ma = Ma;
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
            return View(lstSanPhamLMT.OrderBy(n => n.MaSP).ToPagedList(PageNumber, PageSize));

        }

        public ActionResult MenuSanPham(int? page, string Ma)
        {
            var lstSanPhamLMT = db.SanPhams.Where(n => n.GioTinh == Ma);
            return PartialView(lstSanPhamLMT);
        }
    }
}