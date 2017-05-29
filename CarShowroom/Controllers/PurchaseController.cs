using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarShowroom.DAL;
using CarShowroom.Models;

namespace CarShowroom.Controllers
{
    public class PurchaseController : Controller
    {
        private CarShowroomContext db = new CarShowroomContext();

        // GET: Purchase
        public ActionResult Index()
        {
            var purchases = db.Purchases.Include(p => p.Car).Include(p => p.Client).Include(p => p.Worker);
            return View(purchases.ToList());
        }

        // GET: Purchase/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            return View(purchase);
        }

        // GET: Purchase/Create
        public ActionResult Create()
        {
            ViewBag.CarId = new SelectList(db.Cars, "CarId", "BrandModel");
            ViewBag.ClientId = new SelectList(db.Clients, "ClientId", "FullName");
            ViewBag.WorkerId = new SelectList(db.Workers, "WorkerId", "FullName");
            return View();
        }

        // POST: Purchase/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PurchaseId,ClientId,WorkerId,CarId,TransactionDate")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarId = new SelectList(db.Cars, "CarId", "BrandModel", purchase.CarId);
            ViewBag.ClientId = new SelectList(db.Clients, "ClientId", "FullName", purchase.ClientId);
            ViewBag.WorkerId = new SelectList(db.Workers, "WorkerId", "FullName", purchase.WorkerId);
            return View(purchase);
        }

        // GET: Purchase/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarId = new SelectList(db.Cars, "CarId", "BrandModel", purchase.CarId);
            ViewBag.ClientId = new SelectList(db.Clients, "ClientId", "FullName", purchase.ClientId);
            ViewBag.WorkerId = new SelectList(db.Workers, "WorkerId", "FullName", purchase.WorkerId);
            return View(purchase);
        }

        // POST: Purchase/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PurchaseId,ClientId,WorkerId,CarId,TransactionDate")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purchase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarId = new SelectList(db.Cars, "CarId", "BrandModel", purchase.CarId);
            ViewBag.ClientId = new SelectList(db.Clients, "ClientId", "FullName", purchase.ClientId);
            ViewBag.WorkerId = new SelectList(db.Workers, "WorkerId", "FullName", purchase.WorkerId);
            return View(purchase);
        }

        // GET: Purchase/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            return View(purchase);
        }

        // POST: Purchase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Purchase purchase = db.Purchases.Find(id);
            db.Purchases.Remove(purchase);
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
