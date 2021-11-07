using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBanHang_ASP.Net.Models;
using CaptchaMvc.HtmlHelpers;
using CaptchaMvc;

namespace QLBanHang_ASP.Net.Controllers
{
    public class LoginController : Controller
    {
        //ma hoa md6
        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }
        ShopQuanAoEntities db = new ShopQuanAoEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateAccount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAccount(KhachHang kh)
        {
            kh.MaKH = DateTime.Now.ToString("MMddyyyyHHmmss");
            //capcha
            if (this.IsCaptchaValid("Capcha is not valid"))
            {
                if(kh.LoaiKH != kh.MatKhau)
                {
                    ViewBag.ThongBao = "2 mật khẩu k hợp lệ";
                }    
                else
                {
                    if (ModelState.IsValid)
                    {
                        kh.MatKhau = md5(kh.MatKhau);
                        kh.MaKH = DateTime.Now.ToString("MMddyyyyHHmmss");
                        kh.TrangThai = 1;
                        kh.LoaiKH = "10072021173353";
                        db.KhachHangs.Add(kh);
                        db.SaveChanges();
                        ViewBag.ThongBao = "Tạo tài khoản thành công";
                    }
                    else
                    {
                        ViewBag.ThongBao = "Thêm thất bại";
                    }
                }              
                return View();
            }
            ViewBag.ThongBao = "!!! Sai mã capcha";
            return View();
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            Session["ThongBao"] = 1;
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(KhachHang kh)
        {
            kh.MatKhau = md5(kh.MatKhau);
            KhachHang tvs = db.KhachHangs.SingleOrDefault(n => n.SDT == kh.SDT && n.MatKhau == kh.MatKhau);
            var ddh = db.DonDatHangs.Where(n => n.TrangThaiGiaoHang == "chờ shop check" && n.MaKH==tvs.MaKH);
            if (tvs != null)
            {
                Session["Dem"] = ddh.Count();
                Session["TaiKhoan"] = tvs;
                Session["DonHang"] = ddh;
                return RedirectToAction("Index", "Home");
            }
            Session["ThongBao"] = null;
            return View();
        }
        public ActionResult DangXuat()
        {
            Session["TaiKhoan"] = null;
            return RedirectToAction("Index", "Home");
        }

    }
}