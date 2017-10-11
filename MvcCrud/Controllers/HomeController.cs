using MvcCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static MvcCrud.Models.DataContextWrapper;

namespace MvcCrud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Persons = GetPersons();
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(string name, string lastName, string age)
        {
            //       return View("Index");
            // return View("~/Views/Add/AddPerson.cshtml");
            Person person = new Person()
            {
                Name = name,
                LastName = lastName,
                Age = Int32.Parse(age),
                Time = DateTime.Now,
            };

            DataContextWrapper.AddPerson(person);
            return RedirectToAction("Index");
        }

        public ActionResult DeletePerson(int id)
        {
            DataContextWrapper.DeletePerson(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditPerson(int id)
        {
            ViewBag.Id = id;
            return View("~/Views/Edit/Edit.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}