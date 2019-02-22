using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarLookupCodeFirst.Core.Models;
using CarLookupCodeFirst.Data.DAL;

namespace CarLookupCodeFirst.Web.Controllers
{
    public class BodyTypeController : Controller
    {
        private CarLookupContext db = new CarLookupContext();

        // GET: BodyType
        public ActionResult Index()
        {
            return View(db.BodyTypes.ToList());
        }

        // GET: BodyType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyType bodyType = db.BodyTypes.Find(id);
            if (bodyType == null)
            {
                return HttpNotFound();
            }
            return View(bodyType);
        }

        // GET: BodyType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BodyType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] BodyType bodyType)
        {
            if (ModelState.IsValid)
            {
                db.BodyTypes.Add(bodyType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bodyType);
        }

        // GET: BodyType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyType bodyType = db.BodyTypes.Find(id);
            if (bodyType == null)
            {
                return HttpNotFound();
            }
            return View(bodyType);
        }

        // POST: BodyType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] BodyType bodyType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bodyType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bodyType);
        }

        // GET: BodyType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyType bodyType = db.BodyTypes.Find(id);
            if (bodyType == null)
            {
                return HttpNotFound();
            }
            return View(bodyType);
        }

        // POST: BodyType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BodyType bodyType = db.BodyTypes.Find(id);
            db.BodyTypes.Remove(bodyType);
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
