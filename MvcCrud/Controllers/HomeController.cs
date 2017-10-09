using MvcCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrud.Controllers
{
    public class HomeController : Controller
    {
        public DataContext db = new DataContext();
        IEnumerable<Person> persons;

        public ActionResult Index()
        {
            persons = db.Persons;

            ViewBag.Persons = persons;
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

            db.Persons.Add(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeletePerson(int id)
        {
            var idToDelete = db.Persons.Find(id);
            db.Persons.Remove(idToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditPerson(int id, string name, string lastName, string age)
        {
            Person person = new Person()
            {
                Name = name,
                LastName = lastName,
                Age = Int32.Parse(age),
                Time = DateTime.Now,
            };

            
            db.SaveChanges();
            return RedirectToAction("Index");
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