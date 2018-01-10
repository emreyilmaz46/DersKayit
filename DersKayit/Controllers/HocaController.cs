using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DersKayit.Models;

namespace DersKayit.Controllers
{
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

        // GET: Hoca/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hoca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hoca/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hoca/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hoca/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hoca/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hoca/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
