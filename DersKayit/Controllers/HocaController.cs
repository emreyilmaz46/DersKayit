using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DersKayit.Models;

namespace DersKayit.Controllers
{
    [KimlikKontrol]
    public class HocaController : Controller
    {
        DersKayitContext Db = new DersKayitContext();
        // GET: Hoca
        public ActionResult Index(int HocaNo)
        {
            Hoca tempHoca = new Hoca();
            tempHoca = Db.Hocalar.SingleOrDefault(I => I.HocaNo == HocaNo);
            List<Ders> HocaninDersleri = new List<Ders>();
            HocaninDersleri = tempHoca.Dersler.ToList();

            return View(HocaninDersleri);
        }
    }
}