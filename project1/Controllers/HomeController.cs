using project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {

            EmployeeContext db = new EmployeeContext();


            ViewBag.StateList = db.StateList;
            var model = new Employee();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Employee model)
        {
            EmployeeContext db = new EmployeeContext();

            if (ModelState.IsValid)
            {

                db.EmpList.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewBag.StateList = db.StateList;
            return View(model);
        }
        public ActionResult GetData()
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                var EmoloyeeData = db.EmpList.OrderBy(a => a.Name).ToList();
                return Json(new { data = EmoloyeeData }, JsonRequestBehavior.AllowGet);
            }
        }


        public ActionResult FillCity(int state)
        {
            EmployeeContext db = new EmployeeContext();

            var cities = db.CityList.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }

    }
}