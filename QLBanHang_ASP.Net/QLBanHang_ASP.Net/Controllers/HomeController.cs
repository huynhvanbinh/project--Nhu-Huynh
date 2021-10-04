using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBanHang_ASP.Net.Models;

namespace QLBanHang_ASP.Net.Controllers
{
    public class HomeController : Controller
    {
        QLBanHangEntities db = new QLBanHangEntities();

        public ActionResult Index()
        {
            return View();
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