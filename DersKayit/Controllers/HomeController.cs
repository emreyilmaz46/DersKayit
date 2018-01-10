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
        DersKayitContext Db = new DersKayitContext();

        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Giris(FormCollection bilgiler)
        {
            int key = 0;
            if (!string.IsNullOrEmpty(bilgiler["OgrenciNo"]))
            {
                string ogrno = bilgiler["OgrenciNo"];
                key = Convert.ToInt32(ogrno);
                string sifre = bilgiler["Sifre"];
                Session["UserId"] = bilgiler["OgrenciNo"];
                Session["UserPass"] = bilgiler["Sifre"];

                Ogrenci tempOgrenci = new Ogrenci();
                tempOgrenci = Db.Ogrenciler.SingleOrDefault(I => (I.OgrenciNo == key) && (I.Sifre == sifre));

                    if (tempOgrenci == null)
                    {
                        Session["UserId"] = null;
                        Session["UserPass"] = null;
                        return View("HataliGiris");
                    }
                    else
                    {
                        return View("OgrenciGirisi", tempOgrenci);
                    }
            }
            if (!string.IsNullOrEmpty(bilgiler["HocaNo"]))
            {
                string ogrno = bilgiler["HocaNo"];
                key = Convert.ToInt32(ogrno);
                string sifre = bilgiler["Sifre"];
                Session["UserId"] = bilgiler["HocaNo"];
                Session["UserPass"] = bilgiler["Sifre"];

                Hoca tempHoca = new Hoca();
                tempHoca = Db.Hocalar.SingleOrDefault(I => (I.HocaNo == key) && (I.Sifre == sifre));

                if (tempHoca == null)
                {
                    Session["UserId"] = null;
                    Session["UserPass"] = null;
                    return View("HataliGiris");
                }
                else
                {
                    return View("HocaGirisi", tempHoca);
                }
            }
            if (!string.IsNullOrEmpty(bilgiler["YoneticiNo"]))
            {
                string ogrno = bilgiler["YoneticiNo"];
                key = Convert.ToInt32(ogrno);
                string sifre = bilgiler["Sifre"];
                Session["UserId"] = bilgiler["YoneticiNo"];
                Session["UserPass"] = bilgiler["Sifre"];

                Yonetici tempYonetici = new Yonetici();
                tempYonetici = Db.Yoneticiler.SingleOrDefault(I => (I.YoneticiNo == key) && (I.Sifre == sifre));

                if (tempYonetici == null)
                {
                    Session["UserId"] = null;
                    Session["UserPass"] = null;
                    return View("HataliGiris");
                }
                else
                {
                    return View("YoneticiGirisi", tempYonetici);
                }
            }
            return View("Giris");
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