using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DersKayit.Models;

namespace DersKayit.Controllers
{
    public class DersController : Controller
    {
        DersKayitContext Db = new DersKayitContext();

        // GET: Ders
        public ActionResult Index()
        {
            return View(Db.Dersler.ToList());
        }
        [HttpPost]
        public JsonResult TumDersler()
        {
            
            List<Ders> TumDersler = new List<Ders>();
            TumDersler = Db.Dersler.ToList();
            return Json(TumDersler, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Liste(int OgrenciNo)
        {
            string gelen = OgrenciNo.ToString();
            return View();
        }


        // GET: Ders/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ders/Create
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

        // GET: Ders/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ders/Edit/5
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

        // GET: Ders/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ders/Delete/5
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
