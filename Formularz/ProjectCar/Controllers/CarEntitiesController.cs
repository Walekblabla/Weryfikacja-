using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectCar.Models;
using ProjectCar.Repository.Interfaces;
using ProjectCar.Interfaces;

namespace ProjectCar.Controllers
{
    public class CarEntitiesController : Controller

    {

        
        private ICarRepository _carRepository;
        private ICarBusinessLogic _businessLogic;

        public CarEntitiesController(ICarRepository carRepository, ICarBusinessLogic businessLogic)

        {

            _carRepository = carRepository;
            _businessLogic = businessLogic;

        }

        // GET: CarEntities

        public ActionResult Index()

        {
            var cars = new List<CarEntity>();
            if (_businessLogic.CheckIfUser())
                cars = _carRepository.GetWhere(x => x.Id > 0);
            else 
                cars = _carRepository.GetWhere(x => x.Id > 0 && x.IsActive);

            return View(cars);

        }



        // GET: CarEntities/Details/5

        public ActionResult Details(int? id)

        {

            if (id == null)

            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            CarEntity carEntity = _carRepository.GetWhere(x => x.Id == id.Value).FirstOrDefault();

            if (carEntity == null)

            {

                return HttpNotFound();

            }

            return View(carEntity);

        }



        // GET: CarEntities/Create

        public ActionResult Create()

        {

            return View();

        }



        // POST: CarEntities/Create

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Create(CarEntity carEntity)

        {

            if (ModelState.IsValid)

            {
                carEntity.ModPerson = _businessLogic.CheckIf();
                _carRepository.Create(carEntity);

                return RedirectToAction("Index");

            }



            return View(carEntity);

        }



        // GET: CarEntities/Edit/5

        public ActionResult Edit(int? id)

        {

            if (id == null)

            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            CarEntity carEntity = _carRepository.GetWhere(x => x.Id == id.Value).FirstOrDefault();

            if (carEntity == null)

            {

                return HttpNotFound();

            }

            return View(carEntity);

        }



        // POST: CarEntities/Edit/5

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Edit(CarEntity carEntity)

        {

            if (ModelState.IsValid)

            {

                _carRepository.Update(carEntity);

                return RedirectToAction("Index");

            }

            return View(carEntity);

        }



        // GET: CarEntities/Delete/5

        public ActionResult Delete(int? id)

        {

            if (id == null)

            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            CarEntity carEntity = _carRepository.GetWhere(x => x.Id == id.Value).FirstOrDefault();

            if (carEntity == null)

            {

                return HttpNotFound();

            }

            return View(carEntity);

        }



        // POST: CarEntities/Delete/5

        [HttpPost, ActionName("Delete")]

        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)

        {

            CarEntity carEntity = _carRepository.GetWhere(x => x.Id == id).FirstOrDefault();

            _carRepository.Delete(carEntity);

            return RedirectToAction("Index");

        }



        

    }
}
