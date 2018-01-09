﻿using System;
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

        public ActionResult DersEkle(int ogrenciId, int dersId)
        {
            Ders eklenecekDers = new Ders();
            eklenecekDers = Db.Dersler.Single(I => I.DersId == dersId);
            Ogrenci tempOgrenci = new Ogrenci();
            tempOgrenci = Db.Ogrenciler.Single(I => I.OgrenciId == ogrenciId);


            if (tempOgrenci.Dersler.Contains(eklenecekDers))
            {
                TempData["Message"] = "Bu ders zaten eklenmiş";
            }
            else
            {
                TempData["Message"] = "Ders başarıyla eklendi";
                tempOgrenci.Dersler.Add(eklenecekDers);
                Db.SaveChanges();
            }

            //eklenecekDers.KayitliOgrenciler.Add(tempOgrenci);
            
            return View(tempOgrenci);
        }

        public ActionResult DersDetay(int dersId)
        {
            Ders tempDers = new Ders();
            tempDers = Db.Dersler.Single(I => I.DersId == dersId);
            return View(tempDers);
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
