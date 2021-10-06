using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using QLBanHang_ASP.Net.Models;

namespace QLBanHang_ASP.Net.Controllers
{
    public class HomeController : Controller
    {
        ShopQuanAoEntities db = new ShopQuanAoEntities();

        public ActionResult Index(int? page)
        {
            var lstSP = db.SanPhams;
            return View(lstSP);
        }
        [HttpGet]
        public ActionResult MenuPartial()
        {
            var lstSP = db.SanPhams;
            return PartialView(lstSP);
        }
        [HttpPost]
        public ActionResult MenuPartial(SanPham sp)
        {
            var lstSP = db.SanPhams;
            return PartialView(lstSP);
        }

    }
}