using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webbanhang_nhom10.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: TrangChu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Shop()
        {
            if (Session["User"] == null)
                return RedirectToAction("Login");
            return View();
        }
        public ActionResult Bestseller()
        {
            return View();
        }
        public ActionResult Collections()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Login tạm thời (sau có DB thì thay)
            if (username == "admin" && password == "123")
            {
                Session["User"] = username; //      Lưu user đang đăng nhập
                ViewBag.Message = "Đăng nhập thành công!";
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Sai tài khoản hoặc mật khẩu!";
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string username, string email, string password)
        {
            // Chỗ này bạn có thể lưu DB sau, còn giờ chỉ chuyển hướng tạm
            TempData["Message"] = "Đăng ký thành công, hãy đăng nhập!";
            return RedirectToAction("Login");
        }

        // LOGOUT
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Login");
        }
    }
}