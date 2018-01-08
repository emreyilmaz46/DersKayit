using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DersKayit;
using DersKayit.Models;

namespace DersKayit.Controllers
{
    public class DenemeController : Controller
    {
        private DersKayitContext db = new DersKayitContext();

        // GET: Deneme
        public ActionResult Index()
        {
            return View(db.Dersler.ToList());
        }

        // GET: Deneme/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ders ders = db.Dersler.Find(id);
            if (ders == null)
            {
                return HttpNotFound();
            }
            return View(ders);
        }

        // GET: Deneme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deneme/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DersId,DersAdi,DersKodu,Kontenjan,OnSartVarMi,BolumId,HocaId")] Ders ders)
        {
            if (ModelState.IsValid)
            {
                db.Dersler.Add(ders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ders);
        }

        // GET: Deneme/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ders ders = db.Dersler.Find(id);
            if (ders == null)
            {
                return HttpNotFound();
            }
            return View(ders);
        }

        // POST: Deneme/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DersId,DersAdi,DersKodu,Kontenjan,OnSartVarMi,BolumId,HocaId")] Ders ders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ders).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ders);
        }

        // GET: Deneme/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ders ders = db.Dersler.Find(id);
            if (ders == null)
            {
                return HttpNotFound();
            }
            return View(ders);
        }

        // POST: Deneme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ders ders = db.Dersler.Find(id);
            db.Dersler.Remove(ders);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
