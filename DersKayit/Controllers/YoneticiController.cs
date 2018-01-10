using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DersKayit.Models;

namespace DersKayit.Controllers
{
    public class YoneticiController : Controller
    {
        DersKayitContext Db = new DersKayitContext();
        // GET: Yonetici
        public ActionResult Index(int YoneticiNo)
        {
            Yonetici tempYonetici = new Yonetici();
            tempYonetici = Db.Yoneticiler.SingleOrDefault(I => I.YoneticiNo == YoneticiNo);
            
            return View();
        }
    }
}
