using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DersKayit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(FormCollection bilgiler)
        {
            var ogrno = bilgiler["OgrenciNo"];
            var sifre = bilgiler["Sifre"];
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tanıtım sayfamıza hoşgeldiniz!";

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}