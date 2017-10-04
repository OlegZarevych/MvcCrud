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
        DataContext db = new DataContext();
        IEnumerable<Person> persons;

        public ActionResult Index()
        {
            persons = db.Persons;

            ViewBag.Persons = persons;
            return View();
        }

        [HttpPost]
        public string AddPerson(string name, string lastName, string age)
        {
            Person person = new Person();
            person.Name = name;
            person.LastName = lastName;
            person.Age = Int32.Parse(age);
            person.Time = DateTime.Now;
            db.Persons.Add(person);
            db.SaveChanges();

            //       return View("Index");
            return "Thanks !!!";
        }

        public ActionResult DeletePerson()
        {
            return View();
        }

        public ActionResult EditPerson()
        {
            return View();
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