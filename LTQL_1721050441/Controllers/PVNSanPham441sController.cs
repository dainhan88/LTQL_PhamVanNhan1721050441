using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050441.Models;

namespace LTQL_1721050441.Controllers
{
    public class PVNSanPham441sController : Controller
    {
        private PVN1721050441DbContext db = new PVN1721050441DbContext();

        // GET: PVNSanPham441s
        public ActionResult Index()
        {
            var pVNSanPham441s = db.PVNSanPham441s.Include(p => p.NhaCungCap441s);
            return View(pVNSanPham441s.ToList());
        }

        // GET: PVNSanPham441s/Details/5
        [Authorize]
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PVNSanPham441 pVNSanPham441 = db.PVNSanPham441s.Find(id);
            if (pVNSanPham441 == null)
            {
                return HttpNotFound();
            }
            return View(pVNSanPham441);
        }

        // GET: PVNSanPham441s/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap441s, "MaNhaCungCap", "TenNhaCungCap");
            return View();
        }

        // POST: PVNSanPham441s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] PVNSanPham441 pVNSanPham441)
        {
            if (ModelState.IsValid)
            {
                db.PVNSanPham441s.Add(pVNSanPham441);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap441s, "MaNhaCungCap", "TenNhaCungCap", pVNSanPham441.MaNhaCungCap);
            return View(pVNSanPham441);
        }

        // GET: PVNSanPham441s/Edit/5
        [Authorize]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PVNSanPham441 pVNSanPham441 = db.PVNSanPham441s.Find(id);
            if (pVNSanPham441 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap441s, "MaNhaCungCap", "TenNhaCungCap", pVNSanPham441.MaNhaCungCap);
            return View(pVNSanPham441);
        }

        // POST: PVNSanPham441s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] PVNSanPham441 pVNSanPham441)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pVNSanPham441).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap441s, "MaNhaCungCap", "TenNhaCungCap", pVNSanPham441.MaNhaCungCap);
            return View(pVNSanPham441);
        }

        // GET: PVNSanPham441s/Delete/5
        [Authorize]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PVNSanPham441 pVNSanPham441 = db.PVNSanPham441s.Find(id);
            if (pVNSanPham441 == null)
            {
                return HttpNotFound();
            }
            return View(pVNSanPham441);
        }

        // POST: PVNSanPham441s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PVNSanPham441 pVNSanPham441 = db.PVNSanPham441s.Find(id);
            db.PVNSanPham441s.Remove(pVNSanPham441);
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
