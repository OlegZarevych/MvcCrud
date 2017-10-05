using MvcCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrud.Controllers
{
    public class AddController : HomeController
    {
        [HttpPost]
        public string Add(string name, string lastName, string age)
        {
            Person person = new Person()
            {
                Name = name,
                LastName = lastName,
                Age = Int32.Parse(age),
                Time = DateTime.Now,
            };

            db.Persons.Add(person);
            db.SaveChanges();

            return "Thanks";
        }
    }
}