using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarLookupCodeFirst.Data.Models;
using CarLookupCodeFirst.Data.DAL;
using System.Collections.Generic;
using CarLookupCodeFirst.Services;
using CarLookupCodeFirst.Services.Interfaces;

namespace CarLookupCodeFirst.Web.Controllers
{
    public class CarController : Controller
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Maker,Model,Year")] Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.AddCar(car);
                return RedirectToAction("Index");
            }

            return View(car);
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = _carService.GetCar(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Car/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _carService.DeleteCar(id);
            return RedirectToAction("index");
        }

        // GET: Car/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = _carService.GetCar(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = _carService.GetCar(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID, Maker,Model,Year")] Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.EditCar(car);
                return RedirectToAction("Index");
            }

            return View(car);
        }

        // GET: Car
        public ActionResult Index()
        {
            return View(_carService.GetCars());
        }
    }
}
