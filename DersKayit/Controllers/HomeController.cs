using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DersKayit.Models;

namespace DersKayit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Giris(FormCollection bilgiler)
        {
            string ogrno = bilgiler["OgrenciNo"];
            int ogrnoINT = Convert.ToInt32(ogrno);
            string sifre = bilgiler["Sifre"];
            //
            Session["UserId"] = bilgiler["OgrenciNo"];
            Session["UserPass"] = bilgiler["Sifre"];
            //
            DersKayitContext Db = new DersKayitContext();
            Ogrenci tempOgrenci = new Ogrenci();
            tempOgrenci = Db.Ogrenciler.Where(I => (I.OgrenciNo == ogrnoINT) && (I.Sifre == sifre)).SingleOrDefault();

            if (tempOgrenci == null)
            {
                Session["UserId"] = null;
                Session["UserPass"] = null;
                return View("HataliGiris");
            }
            else
            {
                return View("Goster", tempOgrenci);
            }
            
        }

        public ActionResult Logout()
        {
            Session["UserId"] = null;
            Session["UserPass"] = null;
            return RedirectToAction("Giris");
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