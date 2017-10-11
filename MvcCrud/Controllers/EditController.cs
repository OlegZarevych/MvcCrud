using MvcCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrud.Controllers
{
    public class EditController : Controller
    {
        [HttpPost]
        public ActionResult EditPerson(int id, string name, string lastName, string age)
        {
            Person tmp = DataContextWrapper.FindId(id);

            Person person = new Person()
            {
                Id = id,
                Name = name != string.Empty ? name : tmp.Name,
                LastName = lastName != string.Empty ? lastName : tmp.LastName,
                Age = age != string.Empty ? Int32.Parse(age) : tmp.Age,
                Time = DateTime.Now,
            };

            DataContextWrapper.EditPerson(id, person);
            return RedirectToAction("Index", "Home");
        }
    }
}