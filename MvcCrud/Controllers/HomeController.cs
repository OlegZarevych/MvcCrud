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

        [HttpGet]
        public ActionResult AddPerson()
        {
            //       return View("Index");
            return View("~/Views/Add/AddPerson.cshtml");
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