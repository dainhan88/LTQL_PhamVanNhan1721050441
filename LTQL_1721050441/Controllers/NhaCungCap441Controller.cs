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
    public class NhaCungCap441Controller : Controller
    {
        private PVN1721050441DbContext db = new PVN1721050441DbContext();

        // GET: NhaCungCap441
        public ActionResult Index()
        {
            return View(db.NhaCungCap441s.ToList());
        }

        // GET: NhaCungCap441/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap441 nhaCungCap441 = db.NhaCungCap441s.Find(id);
            if (nhaCungCap441 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap441);
        }

        // GET: NhaCungCap441/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap441/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap441 nhaCungCap441)
        {
            if (ModelState.IsValid)
            {
                db.NhaCungCap441s.Add(nhaCungCap441);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhaCungCap441);
        }

        // GET: NhaCungCap441/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap441 nhaCungCap441 = db.NhaCungCap441s.Find(id);
            if (nhaCungCap441 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap441);
        }

        // POST: NhaCungCap441/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap441 nhaCungCap441)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaCungCap441).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhaCungCap441);
        }

        // GET: NhaCungCap441/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap441 nhaCungCap441 = db.NhaCungCap441s.Find(id);
            if (nhaCungCap441 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap441);
        }

        // POST: NhaCungCap441/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhaCungCap441 nhaCungCap441 = db.NhaCungCap441s.Find(id);
            db.NhaCungCap441s.Remove(nhaCungCap441);
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
