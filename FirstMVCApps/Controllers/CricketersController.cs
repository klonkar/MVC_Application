using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstMVCApps.Models;

namespace FirstMVCApps.Controllers
{
    public class CricketersController : Controller
    {
        private FirstMVCApps2Context db = new FirstMVCApps2Context();

        // GET: Cricketers
        public ActionResult Index()
        {
            return View(db.Cricketers.ToList());
        }

        // GET: Cricketers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketers cricketers = db.Cricketers.Find(id);
            if (cricketers == null)
            {
                return HttpNotFound();
            }
            return View(cricketers);
        }

        // GET: Cricketers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cricketers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,ODI,Test")] Cricketers cricketers)
        {
            if (ModelState.IsValid)
            {
                db.Cricketers.Add(cricketers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cricketers);
        }

        // GET: Cricketers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketers cricketers = db.Cricketers.Find(id);
            if (cricketers == null)
            {
                return HttpNotFound();
            }
            return View(cricketers);
        }

        // POST: Cricketers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,ODI,Test")] Cricketers cricketers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cricketers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cricketers);
        }

        // GET: Cricketers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketers cricketers = db.Cricketers.Find(id);
            if (cricketers == null)
            {
                return HttpNotFound();
            }
            return View(cricketers);
        }

        // POST: Cricketers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cricketers cricketers = db.Cricketers.Find(id);
            db.Cricketers.Remove(cricketers);
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
